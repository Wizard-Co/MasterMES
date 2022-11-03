using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using WizMes_WooJung.PopUp;
using WizMes_WooJung.PopUP;
using System.Windows.Input;
using System.Threading;

namespace WizMes_WooJung
{
    /**************************************************************************************************
    '** System 명 : WizMES
    '** Author    : Wizard
    '** 작성자    : 최준호
    '** 내용      : 설비가동률 조회
    '** 생성일자  : 2018.10~2019.2 월 사이
    '** 변경일자  : 
    '**------------------------------------------------------------------------------------------------
    ''*************************************************************************************************
    ' 변경일자  , 변경자, 요청자    , 요구사항ID  , 요청 및 작업내용
    '**************************************************************************************************
    ' ex) 2015.11.09, 박진성, 오영      ,S_201510_AFT_03 , 월별집계(가로) 순서 변경 : 합계/10월/9월/8월 순으로
    ' 2019.06.25 , 최준호 , 최규환   , 일자선택에서 기간선택으로, 비가동시간 나오게(특정 동작시 나오도록)
    '**************************************************************************************************/

    /// <summary>
    /// Win_prd_sts_RunningRateDetail_Q.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Win_prd_sts_RunningRateDetail_Q : UserControl
    {
        string stDate = string.Empty;
        string stTime = string.Empty;

        Lib lib = new Lib();
        public DataGrid FilterGrid { get; set; }
        public DataTable FilterTable { get; set; }

        ObservableCollection<Win_prd_sts_RunningRateDetail_Q_CodeView> ovcCollection = new ObservableCollection<Win_prd_sts_RunningRateDetail_Q_CodeView>();

        public Win_prd_sts_RunningRateDetail_Q()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            stDate = DateTime.Now.ToString("yyyyMMdd");
            stTime = DateTime.Now.ToString("HHmm");

            DataStore.Instance.InsertLogByFormS(this.GetType().Name, stDate, stTime, "S");

            Lib.Instance.UiLoading(sender);

            dtpSDate.SelectedDate = DateTime.Today;
            dtpEDate.SelectedDate = DateTime.Today;
        }

        #region Header - 검색조건

        //전일
        private void btnYesterDay_Click(object sender, RoutedEventArgs e)
        {
            DateTime[] SearchDate = lib.BringLastDayDateTimeContinue(dtpEDate.SelectedDate.Value);

            dtpSDate.SelectedDate = SearchDate[0];
            dtpEDate.SelectedDate = SearchDate[1];
        }

        //금일
        private void btnToday_Click(object sender, RoutedEventArgs e)
        {
            dtpSDate.SelectedDate = DateTime.Today;
            dtpEDate.SelectedDate = DateTime.Today;
        }

        // 전월 버튼 클릭 이벤트
        private void btnLastMonth_Click(object sender, RoutedEventArgs e)
        {
            DateTime[] SearchDate = lib.BringLastMonthContinue(dtpSDate.SelectedDate.Value);

            dtpSDate.SelectedDate = SearchDate[0];
            dtpEDate.SelectedDate = SearchDate[1];
        }

        // 금월 버튼 클릭 이벤트
        private void btnThisMonth_Click(object sender, RoutedEventArgs e)
        {
            dtpSDate.SelectedDate = lib.BringThisMonthDatetimeList()[0];
            dtpEDate.SelectedDate = lib.BringThisMonthDatetimeList()[1];
        }

        //호기
        private void lblMCIDSrh_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (chkMCIDSrh.IsChecked == true) { chkMCIDSrh.IsChecked = false; }
            else { chkMCIDSrh.IsChecked = true; }
        }

        //호기
        private void chkMCIDSrh_Checked(object sender, RoutedEventArgs e)
        {
            cboMCID.IsEnabled = true;
        }

        //호기
        private void chkMCIDSrh_Unchecked(object sender, RoutedEventArgs e)
        {
            cboMCID.IsEnabled = false;
        }

        //공정
        private void lblProcessSrh_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (chkProcessSrh.IsChecked == true) { chkProcessSrh.IsChecked = false; }
            else { chkProcessSrh.IsChecked = true; }
        }

        //공정
        private void chkProcessSrh_Checked(object sender, RoutedEventArgs e)
        {
            cboProcess.IsEnabled = true;
        }

        //공정
        private void chkProcessSrh_Unchecked(object sender, RoutedEventArgs e)
        {
            cboProcess.IsEnabled = false;
        }

        #endregion

        #region Header - 오른쪽 상단 버튼

        //검색
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //검색버튼 비활성화
            btnSearch.IsEnabled = false;

            Dispatcher.BeginInvoke(new Action(() =>

            {
                Thread.Sleep(2000);

                //로직
                using (Loading lw = new Loading(beSearch))
                {
                    lw.ShowDialog();
                }

            }), System.Windows.Threading.DispatcherPriority.Background);



            Dispatcher.BeginInvoke(new Action(() =>

            {
                btnSearch.IsEnabled = true;

            }), System.Windows.Threading.DispatcherPriority.Background);
            
        }

        private void beSearch()
        {
            if (dtpSDate.SelectedDate == null
                || dtpSDate.SelectedDate.ToString() == ""
                || dtpEDate.SelectedDate == null
                || dtpEDate.SelectedDate.ToString() == null)
            {
                MessageBox.Show("날짜를 정확히 입력해주세요.");
                //검색 다 되면 활성화
                btnSearch.IsEnabled = true;
                return;
            }

            FillGrid();

            if (dgdMain.Items.Count > 0)
            {
                dgdMain.SelectedIndex = 0;
            } else
            {
                MessageBox.Show("조회된 내용이 없습니다.");
            }
           

           
        }

        //닫기
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            DataStore.Instance.InsertLogByFormS(this.GetType().Name, stDate, stTime, "E");
            Lib.Instance.ChildMenuClose(this.ToString());
        }

        //엑셀
        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = null;
                string Name = string.Empty;

                string[] lst = new string[2];
                lst[0] = "설비 가동률";
                lst[1] = dgdMain.Name;

                ExportExcelxaml ExpExc = new ExportExcelxaml(lst);

                ExpExc.ShowDialog();

                if (ExpExc.DialogResult.HasValue)
                {
                    if (ExpExc.choice.Equals(dgdMain.Name))
                    {
                        DataStore.Instance.InsertLogByForm(this.GetType().Name, "E");
                        if (ExpExc.Check.Equals("Y"))
                            dt = Lib.Instance.DataGridToDTinHidden(dgdMain);
                        else
                            dt = Lib.Instance.DataGirdToDataTable(dgdMain);

                        Name = dgdMain.Name;

                        if (Lib.Instance.GenerateExcel(dt, Name))
                            Lib.Instance.excel.Visible = true;
                        else
                            return;
                    }
                    else
                    {
                        if (dt != null)
                        {
                            dt.Clear();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 주요 메서드 - FillGrid

        //조회
        private void FillGrid()
        {
            try
            {
                dgdMain.ItemsSource = null;
                ovcCollection.Clear();

                Dictionary<string, object> sqlParameter = new Dictionary<string, object>();
                sqlParameter.Add("sFromDate", dtpSDate.SelectedDate != null ? dtpSDate.SelectedDate.Value.ToString("yyyyMMdd") : "");
                sqlParameter.Add("sToDate", dtpSDate.SelectedDate != null ? dtpEDate.SelectedDate.Value.ToString("yyyyMMdd") : "");

             
                //DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_prd_sMCRunningRate_WPF_20201012", sqlParameter, false);
                DataSet ds = DataStore.Instance.ProcedureToDataSet_LogWrite("xp_prd_sMCRunningRate_WPF_20210517", sqlParameter, true, "R");
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];

                    //dgdPNMSubul.ItemsSource = dt.DefaultView;
                    if (dt.Rows.Count > 0)
                    {
                        int i = 0;
                        //var DataTemplateHeader = new ProdNMtrSubulHeaderItem("원재료", "이월량", "생산량", "입고량", "사용량", "재고량");
                        //dgdPNMSubul.ItemsSource = dt.DefaultView;
                        DataRowCollection drc = dt.Rows;

                        foreach (DataRow dr in drc)
                        {
                            i++;
                            var dgdWorkRate = new Win_prd_sts_RunningRateDetail_Q_CodeView()
                            {
                                Num = i,
                                MCID = dr["MCID"].ToString(),
                                MCName = dr["MCName"].ToString(),

                            
                            };

                            ovcCollection.Add(dgdWorkRate);
                        }

                        dgdMain.ItemsSource = ovcCollection;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생, 오류 내용 : " + ex.ToString());
            }
            finally
            {
                DataStore.Instance.CloseConnection();
            }
        }

        #endregion

        private void BtnNoWorking_Click(object sender, RoutedEventArgs e)
        {
            var NoWorkingCode = dgdMain.SelectedItem as Win_prd_sts_RunningRateDetail_Q_CodeView;

            string sDate = dtpSDate.SelectedDate.Value.ToString("yyyyMMdd");
            string eDate = dtpEDate.SelectedDate.Value.ToString("yyyyMMdd");

            NoWorkInfo NoWorking = null;

            if (NoWorkingCode != null)
            {
                if (NoWorkingCode.NoWorkDate == null
                    || ConvertDouble(NoWorkingCode.NoWorkDate) == 0)
                    MessageBox.Show("선택된 자료의 비가동 시간을 확인해보세요.");
                else
                    NoWorking = new NoWorkInfo(sDate, eDate, NoWorkingCode.MCID);
            }
            else
            {
                NoWorking = new NoWorkInfo(sDate, eDate, "");
            }

            if (NoWorking != null)
                NoWorking.ShowDialog();
        }

        private void DgdMain_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                var NoWorkingCode = dgdMain.SelectedItem as Win_prd_sts_RunningRateDetail_Q_CodeView;

                string sDate = dtpSDate.SelectedDate.Value.ToString("yyyyMMdd");
                string eDate = dtpEDate.SelectedDate.Value.ToString("yyyyMMdd");

                NoWorkInfo NoWorking = null;

                if (NoWorkingCode != null)
                {
                    if (NoWorkingCode.NoWorkDate == null
                        || ConvertDouble(NoWorkingCode.NoWorkDate) == 0)
                        MessageBox.Show("선택된 자료의 비가동 시간을 확인해보세요.");
                    else
                        NoWorking = new NoWorkInfo(sDate, eDate, NoWorkingCode.MCID);
                }
                else
                {
                    NoWorking = new NoWorkInfo(sDate, eDate, "");
                }

                if (NoWorking != null)
                    NoWorking.ShowDialog();
            }
        }

        #region 기타 메서드 모음

        // 천마리 콤마, 소수점 버리기
        private string stringFormatN0(object obj)
        {
            return string.Format("{0:N0}", obj);
        }

        private string stringFormatN1(object obj)
        {
            return string.Format("{0:N1}", obj);
        }

        // 천마리 콤마, 소수점 두자리
        private string stringFormatN2(object obj)
        {
            return string.Format("{0:N2}", obj);
        }

        // 데이터피커 포맷으로 변경
        private string DatePickerFormat(string str)
        {
            string result = "";

            if (str.Length == 8)
            {
                if (!str.Trim().Equals(""))
                {
                    result = str.Substring(0, 4) + "-" + str.Substring(4, 2) + "-" + str.Substring(6, 2);
                }
            }

            return result;
        }

        // Int로 변환
        private int ConvertInt(string str)
        {
            int result = 0;
            int chkInt = 0;

            if (!str.Trim().Equals(""))
            {
                str = str.Replace(",", "");

                if (Int32.TryParse(str, out chkInt) == true)
                {
                    result = Int32.Parse(str);
                }
            }

            return result;
        }

        // 소수로 변환 가능한지 체크 이벤트
        private bool CheckConvertDouble(string str)
        {
            bool flag = false;
            double chkDouble = 0;

            if (!str.Trim().Equals(""))
            {
                if (Double.TryParse(str, out chkDouble) == true)
                {
                    flag = true;
                }
            }

            return flag;
        }

        // 숫자로 변환 가능한지 체크 이벤트
        private bool CheckConvertInt(string str)
        {
            bool flag = false;
            int chkInt = 0;

            if (!str.Trim().Equals(""))
            {
                str = str.Trim().Replace(",", "");

                if (Int32.TryParse(str, out chkInt) == true)
                {
                    flag = true;
                }
            }

            return flag;
        }

        // 소수로 변환
        private double ConvertDouble(string str)
        {
            double result = 0;
            double chkDouble = 0;

            if (!str.Trim().Equals(""))
            {
                str = str.Replace(",", "");

                if (Double.TryParse(str, out chkDouble) == true)
                {
                    result = Double.Parse(str);
                }
            }

            return result;
        }

        #endregion

    }

    public class Win_prd_sts_RunningRateDetail_Q_CodeView : BaseView
    {
        public override string ToString()
        {
            return (this.ReportAllProperties());
        }

        public int Num { get; set; }
        public string WorkDate { get; set; }
        public string ArticleID { get; set; }
        public string Article { get; set; }
        public string Worker { get; set; }

        public string LearningCount { get; set; }
        public string WorkStartDate { get; set; }
        public string MCID { get; set; }
        public string MCName { get; set; }
        public string MCNum { get; set; }

        public string LastMCInspectDate { get; set; }
        public string MCErrorCount { get; set; }
        public string MCErrorContent { get; set; }
        public string NoWorkDate { get; set; }
        public string NoWorkReason { get; set; }

    }


}
