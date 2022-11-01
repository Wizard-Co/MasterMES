using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WizMes_WooJung.PopUp
{
    ///// <summary>
    ///// RheoChoice.xaml에 대한 상호 작용 논리
    ///// </summary>
    //public partial class Win_pop_PlanInput_UseInst : Window
    //{
    //    int rowNum = 0;

    //    public string ArticleID = "";
    //    public string Article = "";
    //    public string JaturiLotID = "";

    //    public string BuyerArticleNo = "";
    //    public string JaturiSpec = "";
    //    public string JaturiCDate = "";
    //    public string InstID = "";
    //    public string date = "";



    //    public Win_prd_PlanInput_U StockControl = new Win_prd_PlanInput_U();

    //    public List<Win_prd_PlanInput_U_CodeView_pop> lstUseCloneInst = new List<Win_prd_PlanInput_U_CodeView_pop>();
    //    List<Win_prd_PlanInput_U_CodeView> lstSelect = new List<Win_prd_PlanInput_U_CodeView>();
    //    List<Win_prd_PlanInput_U_CodeView> lstAll = new List<Win_prd_PlanInput_U_CodeView>();

    //    int indexAllItem = 0; // 전체품목 검색을 위한 인덱스
    //    int indexSelItem = 0; // 선택된 품목 검색을 위한 인덱스
         
    //    public Win_pop_PlanInput_UseInst()
    //    {
    //        InitializeComponent();
    //    }

    //    public Win_pop_PlanInput_UseInst(List<Win_prd_PlanInput_U_CodeView_pop> lstUseCloneInst)
    //    {
    //        InitializeComponent();

    //        this.lstUseCloneInst = lstUseCloneInst;
    //    }

    //    public Win_pop_PlanInput_UseInst(string ArticleID, string Article, string JaturiLotID, string BuyerArticleNo, string JaturiSpec, string JaturiCDate, string InstID)
    //    {
    //        InitializeComponent();

    //        this.ArticleID = ArticleID;
    //        this.Article = Article;
    //        this.JaturiLotID = JaturiLotID;

    //        this.BuyerArticleNo = BuyerArticleNo;
    //        this.JaturiSpec = JaturiSpec;
    //        this.JaturiCDate = JaturiCDate;
    //        this.InstID = InstID;
    //    }

    //    // 콤보박스셋팅
    //    private void ComboBoxSetting()
    //    {

    //    }

    //    private void MoveSub_Loaded(object sender, RoutedEventArgs e)
    //    {

    //        FillGrid();

    //        dtpInstUseDate.SelectedDate = DateTime.Today;
    //        //dtpAdjustDate.SelectedDate = DateTime.Today;
    //    }

    //    #region 주요 버튼 이벤트 - 확인, 닫기, 검색

    //    public List<Win_prd_PlanInput_U_CodeView_pop> lstLotStock = new List<Win_prd_PlanInput_U_CodeView_pop>();

    //    //확인
    //    private void btnConfirm_Click(object sender, RoutedEventArgs e)
    //    {
            
    //        if(MessageBox.Show("선택한 항목들을 사용처리 하시겠습니까?", "사용처리 전 확인", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
    //        {
    //            SaveData();
    //        }
    //        //for (int i = 0; i < dgdMain.Items.Count; i++)
    //        //{
    //        //    var main = dgdMain.Items[i] as Win_prd_PlanInput_U_CodeView_pop;

    //        //    if (main != null && main.Chk == true)
    //        //    {
    //        //        lstLotStock.Add(main);

    //        //    }

    //        //}




    //    }

    //    //닫기
    //    private void btnCancel_Click(object sender, RoutedEventArgs e)
    //    {
    //        this.Close();
    //    }

    //    //검색
    //    private void btnSearch_Click(object sender, RoutedEventArgs e)
    //    {
    //        re_Search(rowNum);
    //    }

    //    #endregion // 주요 버튼 이벤트


    //    #region Header 부분 - 검색조건



    //    #endregion // Header 부분 - 검색조건

    //    #region Header 부분 - 검색조건 : 바코드 검색 → 바코드 비워주기 (다음 바코드를 바로 입력할 수 있도록)

    //    #endregion

    //    #region 주요 메서드 모음

    //    private void re_Search(int rowNum)
    //    {
    //        FillGrid();

    //        if (dgdMain.Items.Count > 0)
    //        {
    //            dgdMain.SelectedIndex = rowNum;
    //        }
    //        else
    //        {
    //            this.DataContext = null;
    //            MessageBox.Show("조회된 데이터가 없습니다.");
    //            return;
    //        }
    //    }

    //    #region 조회

    //    private void FillGrid()
    //    {
    //        lstAll.Clear();

    //        if (dgdMain.Items.Count > 0)
    //        {
    //            dgdMain.Items.Clear();
    //        }

    //        try
    //        {
    //            Dictionary<string, object> sqlParameter = new Dictionary<string, object>();
    //            sqlParameter.Clear();

    //            sqlParameter.Add("sInstid", InstID);

    //            //DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_mtr_StockLotID_WPF", sqlParameter, false);
    //            DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_Plinput_sJaturi", sqlParameter, false);

    //            if (ds != null && ds.Tables.Count > 0)
    //            {
    //                DataTable dt = ds.Tables[0];

    //                if (dt.Rows.Count == 0)
    //                {
    //                    MessageBox.Show("조회된 데이터가 없습니다.");
    //                }
    //                else
    //                {
    //                    int index = 0;
    //                    DataRowCollection drc = dt.Rows;

    //                    foreach (DataRow dr in drc)
    //                    {
    //                        index++;
    //                        var NowStockData = new Win_prd_PlanInput_U_CodeView
    //                        {

    //                            Num = index,
    //                            ArticleID = dr["ArticleID"].ToString(),
    //                            Article = dr["Article"].ToString(),
    //                            BuyerArticleNo = dr["BuyerArticleNo"].ToString(),
    //                            JaturiLotID = dr["JaturiLotID"].ToString(),
    //                            JaturiSpec = dr["JaturiSpec"].ToString(),
    //                            JaturiCDate = dr["JaturiCDate"].ToString(),

    //                            UDFlag = true,

    //                        };

    //                        dgdMain.Items.Add(NowStockData);
    //                        lstAll.Add(NowStockData);
    //                    }
    //                    tblCount.Text = "▶검색개수 : " + index + "건";

    //                }
    //            }

    //        }
    //        catch (Exception ee)
    //        {


    //            MessageBox.Show("조회 오류 : " + ee.Message);
    //        }
    //        finally
    //        {
    //            DataStore.Instance.CloseConnection();
    //        }
    //    }

    //    #endregion

    //    #region 조회 - ArticleID 로!

    //    //private void FillGrid_ArticleID(string ArticleID)
    //    //{
    //    //    if (dgdMain.Items.Count > 0)
    //    //    {
    //    //        dgdMain.Items.Clear();
    //    //    }

    //    //    try
    //    //    {
    //    //        Dictionary<string, object> sqlParameter = new Dictionary<string, object>();
    //    //        sqlParameter.Clear();


    //    //        sqlParameter.Add("ChkArticleID", 1);
    //    //        sqlParameter.Add("ArticleID", ArticleID);

    //    //        sqlParameter.Add("ChkArticle", 0);
    //    //        sqlParameter.Add("Article", "");

    //    //        sqlParameter.Add("ChkLotID", 0);
    //    //        sqlParameter.Add("LotID", "");

    //    //        DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_mtr_StockLotID_WPF", sqlParameter, false);

    //    //        if (ds != null && ds.Tables.Count > 0)
    //    //        {
    //    //            DataTable dt = ds.Tables[0];

    //    //            if (dt.Rows.Count > 0)
    //    //            {
    //    //                DataRowCollection drc = dt.Rows;

    //    //                int i = 0;

    //    //                foreach (DataRow dr in drc)
    //    //                {
    //    //                    i++;

    //    //                    var Main = new Win_mtr_StockControl_U_Stuffin()
    //    //                    {
    //    //                        Num = i.ToString(),

    //    //                        BuyerArticleNo = dr["BuyerArticleNo"].ToString(),

    //    //                        Article = dr["Article"].ToString(),
    //    //                        ArticleID = dr["ArticleID"].ToString(),
    //    //                        LotID = dr["LotID"].ToString(),
    //    //                        Qty = stringFormatN0(dr["Qty"]),

    //    //                    };

    //    //                    dgdMain.Items.Add(Main);

    //    //                }

    //    //                tblCount.Text = "▶검색개수 : " + i + "건";
    //    //            }
    //    //        }
    //    //    }
    //    //    catch (Exception ee)
    //    //    {
    //    //        MessageBox.Show("조회 오류 : " + ee.Message);
    //    //    }
    //    //    finally
    //    //    {
    //    //        DataStore.Instance.CloseConnection();
    //    //    }
    //    //}

    //    #endregion

    //    #endregion


    //    #region 저장
    //    private bool SaveData()
    //    {
    //        bool flag = false;
    //        List<Procedure> Prolist = new List<Procedure>();
    //        List<Dictionary<string, object>> ListParameter = new List<Dictionary<string, object>>();

    //        try
    //        {
    //            if (dgdMainRigt.Items.Count > 0)
    //            {
    //                Dictionary<string, object> sqlParameter = null;

    //                for (int i = 0; i < lstSelect.Count; i++)
    //                {
    //                    var SelectItem = lstSelect[i] as Win_prd_PlanInput_U_CodeView;

    //                    sqlParameter = new Dictionary<string, object>(); //테스트로 봉인
                        
    //                    sqlParameter.Clear();
    //                    sqlParameter.Add("JaturiLotID", SelectItem.JaturiLotID);
    //                    sqlParameter.Add("JaturiUDate", dtpInstUseDate.SelectedDate != null ? dtpInstUseDate.SelectedDate.Value.ToString("yyyyMMdd") : "");
    //                    sqlParameter.Add("UseInstID", InstID);
    //                    sqlParameter.Add("LastUpdateUserID", MainWindow.CurrentUser);

    //                    Procedure pro1 = new Procedure();
    //                    pro1.Name = "xp_Plinput_uJaturi";
    //                    pro1.OutputUseYN = "N";
    //                    pro1.OutputName = "JaturiLotID";
    //                    pro1.OutputLength = "10";
                        
    //                    Prolist.Add(pro1);
    //                    ListParameter.Add(sqlParameter);
    //                }

    //                string[] Confirm = new string[2];
    //                Confirm = DataStore.Instance.ExecuteAllProcedureOutputNew_NewLog(Prolist, ListParameter, "C");
    //                if (Confirm[0] != "success")
    //                {
    //                    MessageBox.Show("[저장실패]\r\n" + Confirm[1].ToString());
    //                    flag = false;
    //                    //return false;
    //                }
    //                else
    //                {
                        
    //                    flag = true;

    //                    this.DialogResult = true;

    //                    MessageBox.Show("잔재 사용처리가 저장되었습니다.");
    //                }

    //            }

    //        }
    //        catch(Exception ex)
    //        {
    //            MessageBox.Show(ex.ToString());
    //        }
    //        finally
    //        {
    //            DataStore.Instance.CloseConnection();
    //        }

    //        return flag;

    //    }
    //    #endregion

    //    #region 유효성 검사

    //    private bool CheckData()
    //    {
    //        bool flag = true;

    //        return flag;
    //    }

    //    #endregion

    //    #region 데이터 그리드 체크박스 이벤트

    //    // 팝업창 체크박스 이벤트
    //    private void CHK_Click_Sub(object sender, RoutedEventArgs e)
    //    {
    //        //CheckBox chkSender = sender as CheckBox;
    //        //var MoveSub = chkSender.DataContext as Win_mtr_Move_U_CodeViewSub;

    //        //if (MoveSub != null)
    //        //{
    //        //    if (chkSender.IsChecked == true)
    //        //    {
    //        //        MoveSub.Chk = true;
    //        //        MoveSub.FontColor = true;

    //        //        if (ovcMoveSub.Contains(MoveSub) == false)
    //        //        {
    //        //            ovcMoveSub.Add(MoveSub);
    //        //        }
    //        //    }
    //        //    else
    //        //    {
    //        //        MoveSub.Chk = false;
    //        //        MoveSub.FontColor = false;

    //        //        if (ovcMoveSub.Contains(MoveSub) == true)
    //        //        {
    //        //            ovcMoveSub.Remove(MoveSub);
    //        //        }
    //        //    }
    //        //}
    //    }

    //    #endregion // 데이터 그리드 체크박스 이벤트

    //    #region 전체 선택 체크박스 이벤트

    //    // 전체 선택 체크박스 체크 이벤트
    //    private void AllCheck_Checked(object sender, RoutedEventArgs e)
    //    {
    //        //ovcMoveSub.Clear();

    //        //if (dgdMain.Visibility == Visibility.Visible)
    //        //{
    //        //    for (int i = 0; i < dgdMain.Items.Count; i++)
    //        //    {
    //        //        var MoveSub = dgdMain.Items[i] as Win_mtr_Move_U_CodeViewSub;
    //        //        MoveSub.Chk = true;
    //        //        MoveSub.FontColor = true;

    //        //        ovcMoveSub.Add(MoveSub);
    //        //    }
    //        //}
    //    }

    //    // 전체 선택 체크박스 언체크 이벤트
    //    private void AllCheck_Unchecked(object sender, RoutedEventArgs e)
    //    {
    //        //ovcMoveSub.Clear();

    //        //if (dgdMain.Visibility == Visibility.Visible)
    //        //{
    //        //    for (int i = 0; i < dgdMain.Items.Count; i++)
    //        //    {
    //        //        var MoveSub = dgdMain.Items[i] as Win_mtr_Move_U_CodeViewSub;
    //        //        MoveSub.Chk = false;
    //        //        MoveSub.FontColor = false;
    //        //    }
    //        //}
    //    }

    //    #endregion // 전체 선택 체크박스 이벤트

    //    #region 기타 메서드

    //    // 천마리 콤마, 소수점 버리기
    //    private string stringFormatN0(object obj)
    //    {
    //        return string.Format("{0:N0}", obj);
    //    }


    //    // 데이터피커 포맷으로 변경
    //    private string DatePickerFormat(string str)
    //    {
    //        string result = "";

    //        if (str.Length == 8)
    //        {
    //            if (!str.Trim().Equals(""))
    //            {
    //                result = str.Substring(0, 4) + "-" + str.Substring(4, 2) + "-" + str.Substring(6, 2);
    //            }
    //        }

    //        return result;
    //    }

    //    // Int로 변환
    //    private int ConvertInt(string str)
    //    {
    //        int result = 0;
    //        int chkInt = 0;

    //        if (!str.Trim().Equals(""))
    //        {
    //            str = str.Replace(",", "");

    //            if (Int32.TryParse(str, out chkInt) == true)
    //            {
    //                result = Int32.Parse(str);
    //            }
    //        }

    //        return result;
    //    }

    //    // 소수로 변환 가능한지 체크 이벤트
    //    private bool CheckConvertDouble(string str)
    //    {
    //        bool flag = false;
    //        double chkDouble = 0;

    //        if (!str.Trim().Equals(""))
    //        {
    //            if (Double.TryParse(str, out chkDouble) == true)
    //            {
    //                flag = true;
    //            }
    //        }

    //        return flag;
    //    }

    //    // 숫자로 변환 가능한지 체크 이벤트
    //    private bool CheckConvertInt(string str)
    //    {
    //        bool flag = false;
    //        int chkInt = 0;

    //        if (!str.Trim().Equals(""))
    //        {
    //            str = str.Trim().Replace(",", "");

    //            if (Int32.TryParse(str, out chkInt) == true)
    //            {
    //                flag = true;
    //            }
    //        }

    //        return flag;
    //    }

    //    // 소수로 변환
    //    private double ConvertDouble(string str)
    //    {
    //        double result = 0;
    //        double chkDouble = 0;

    //        if (!str.Trim().Equals(""))
    //        {
    //            str = str.Replace(",", "");

    //            if (Double.TryParse(str, out chkDouble) == true)
    //            {
    //                result = Double.Parse(str);
    //            }
    //        }

    //        return result;
    //    }






    //    #endregion // 기타 메서드

    //    // 메인 그리드 더블클릭시 선택한걸로!!
    //    private void dgdMain_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    //    {
    //        //if (e.ClickCount == 2)
    //        //{
    //        //    btnConfirm_Click(null, null);
    //        //}
    //    }

    //    //선택
    //    private void chkReq_Click(object sender, RoutedEventArgs e)
    //    {
    //        CheckBox chkSender = sender as CheckBox;
    //        var LotStock = chkSender.DataContext as Win_prd_PlanInput_U_CodeView;

    //        if (LotStock != null)
    //        {
    //            if (chkSender.IsChecked == true)
    //            {
    //                LotStock.chkFlag = true;
    //            }
    //            else
    //            {
    //                LotStock.chkFlag = false;
    //            }
    //        }
    //    }


    //    //선택된거 
    //    private void chkSelect_Click(object sender, RoutedEventArgs e)
    //    {
    //        CheckBox chkSender = sender as CheckBox;
    //        var dgdSlect = chkSender.DataContext as Win_prd_PlanInput_U_CodeView;

    //        if (dgdSlect != null)
    //        {
    //            if (chkSender.IsChecked == true)
    //            {
    //                dgdSlect.chkFlag = true;
    //            }
    //            else
    //            {
    //                dgdSlect.chkFlag = false;
    //            }

    //        }
    //    }
    //    //추가 오른쪽이동 
    //    private void btnAddSelectItem_Click(object sender, RoutedEventArgs e)
    //    {
    //        Win_prd_PlanInput_U_CodeView allItem = null;

    //        // 에러메시지용 변수
    //        int MsgCnt = 0;
    //        string Msg = "";

    //        // 딱 넘겨주는것만 dgdSel 에 추가해주기
    //        List<Win_prd_PlanInput_U_CodeView> lstTemp = new List<Win_prd_PlanInput_U_CodeView>();
            
    //        for (int i = 0; i < dgdMain.Items.Count; i++)
    //        {
    //            allItem = null;
    //            allItem = dgdMain.Items[i] as Win_prd_PlanInput_U_CodeView;
    //            if (allItem.chkFlag == true)
    //            {
    //                //lstSelect.Add(allItem);
    //                // 2020.03.18 수정
    //                // lstSelect 에 이미 있는 품명이라면, 메시지 띄우기.
    //                if (lstSelect.Count > 0)
    //                {
    //                    bool good = true;
    //                    for (int k = 0; k < lstSelect.Count; k++)
    //                    {
    //                        //JaturiLotID
    //                        var JaturiLot = lstSelect[k] as Win_prd_PlanInput_U_CodeView;
    //                        if (JaturiLot != null)
    //                        {
    //                            if (JaturiLot.JaturiLotID.Trim().Equals(allItem.JaturiLotID.Trim()))
    //                            { 
    //                                MsgCnt++;
    //                                Msg += JaturiLot.JaturiLotID + "\r";

    //                                good = false;
    //                                break;
    //                            }
    //                        }
    //                    }
    //                    if (good == true)
    //                    {
    //                        lstTemp.Add(allItem);
    //                        lstSelect.Add(allItem);
    //                    }
    //                }
    //                else
    //                {
    //                    lstTemp.Add(allItem);
    //                    lstSelect.Add(allItem);
    //                }
    //            }
    //        }

    //        //if (dgdSelectItem.Items.Count > 0)
    //        //{
    //        //    dgdSelectItem.Items.Clear();
    //        //}

    //        for (int j = 0; lstTemp.Count > j; j++)
    //        {
    //            var selectionItem = lstTemp[j] as Win_prd_PlanInput_U_CodeView;
    //            selectionItem.chkFlag = false;
    //            selectionItem.SelectNum = (j + 1).ToString();
    //            dgdMainRigt.Items.Add(selectionItem);
    //        }

    //        FillGridAllItem();

    //        // 에러 메시지 띄우기
    //        if (MsgCnt > 0)
    //        {
    //            MessageBox.Show(Msg + "위의 잔재로트는 이미 등록되어 있습니다.");
    //        }
    //    }

    //    //모든품목 표 
    //    private void FillGridAllItem()
    //    {
    //        if (dgdMain.Items.Count > 0) { dgdMain.Items.Clear(); }

    //        try
    //        {
    //            for (int j = 0; j < lstAll.Count; j++)
    //            {
    //                bool flag = true;
    //                var ItemAll = lstAll[j] as Win_prd_PlanInput_U_CodeView;

    //                for (int k = 0; k < lstSelect.Count; k++)
    //                {
    //                    var ItemSelect = lstSelect[k] as Win_prd_PlanInput_U_CodeView;
    //                    if (ItemAll.JaturiLotID.Equals(ItemSelect.JaturiLotID))
    //                    {
    //                        flag = false;
    //                        break;
    //                    }
    //                }

    //                if (flag)
    //                {
    //                    dgdMain.Items.Add(ItemAll);
    //                }
    //            }

    //            tblCount.Text = "전체 품목 : " + dgdMain.Items.Count.ToString() + "개";
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("오류 발생, 오류 내용 : " + ex.ToString());
    //        }
    //        finally
    //        {
    //            DataStore.Instance.CloseConnection();
    //        }
    //    }



    //    //제거 왼쪽이동
    //    private void btnDelSelectItem_Click(object sender, RoutedEventArgs e)
    //    {
    //        Win_prd_PlanInput_U_CodeView selectItem = null;

    //        // 딱 넘겨주는것만 dgdSel 에 삭제해주기
    //        List<Win_prd_PlanInput_U_CodeView> lstTemp = new List<Win_prd_PlanInput_U_CodeView>();

    //        for (int i = 0; i < dgdMainRigt.Items.Count; i++)
    //        {
    //            selectItem = null;
    //            selectItem = dgdMainRigt.Items[i] as Win_prd_PlanInput_U_CodeView;
    //            if (selectItem.chkFlag == true)
    //            {
    //                lstSelect.Remove(selectItem);
    //                lstTemp.Add(selectItem);
    //            }
    //        }
              
    //        //if (dgdSelectItem.Items.Count > 0)
    //        //{
    //        //    dgdSelectItem.Items.Clear();
    //        //}

    //        for (int j = 0; lstTemp.Count > j; j++)
    //        {
    //            //var selectionItem = lstSelect[j] as Win_com_CustomArticle_U_CodeView_SorD;
    //            //selectionItem.chkFlag = false;
    //            //selectionItem.SelectNum = (j + 1).ToString();
    //            dgdMainRigt.Items.Remove(lstTemp[j]);
    //        }
    //        //tbkSelectCount.Text = "선택품목 : " + dgdSelectItem.Items.Count.ToString() + "개";

    //        FillGridAllItem();
    //    }
        
    //    private void dgdAllItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //    {
    //        indexAllItem = dgdMain.SelectedIndex;
    //    }
    //}

}

