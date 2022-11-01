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
    /// <summary>
    /// RheoChoice.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Win_pop_PlanInput_CreateInst : Window
    {
        //int rowNum = 0;

        //public string ArticleID = "";
        //public string Article = "";
        //public string JaturiLotID = "";

        //public string BuyerArticleNo = "";
        //public string JaturiSpec = "";
        //public string InstID = "";

        



        //public Win_prd_PlanInput_U StockControl = new Win_prd_PlanInput_U();

        //public List<Win_prd_PlanInput_U_CodeView_pop> lstUseCloneInst = new List<Win_prd_PlanInput_U_CodeView_pop>();
        //List<Win_prd_PlanInput_U_CodeView_pop> winordorderusubcodeview = new List<Win_prd_PlanInput_U_CodeView_pop>();
        //PlusFinder pf = new PlusFinder();

        //public Win_pop_PlanInput_CreateInst()
        //{
        //    InitializeComponent();
        //}

        //public Win_pop_PlanInput_CreateInst(List<Win_prd_PlanInput_U_CodeView_pop> lstUseCloneInst)
        //{
        //    InitializeComponent();

        //    this.lstUseCloneInst = lstUseCloneInst;
        //}

        //public Win_pop_PlanInput_CreateInst(string ArticleID, string Article, string JaturiLotID, string BuyerArticleNo, string JaturiSpec, string InstID)
        //{
        //    InitializeComponent();

        //    this.ArticleID = ArticleID;
        //    this.Article = Article;
        //    this.JaturiLotID = JaturiSpec;

        //    this.BuyerArticleNo = BuyerArticleNo;
        //    this.JaturiSpec = JaturiSpec;
        //    this.InstID = InstID;
            
            
        //}

        //// 콤보박스셋팅
        //private void ComboBoxSetting()
        //{

        //}
         
        //private void MoveSub_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //MessageBox.Show(InstID);
        //    FillGrid();

        //    //dtpAdjustDate.SelectedDate = DateTime.Today;
        //}

        //#region 주요 버튼 이벤트 - 확인, 닫기, 검색

        //public List<Win_prd_PlanInput_U_CodeView_pop> lstLotStock = new List<Win_prd_PlanInput_U_CodeView_pop>();
         
        ////확인
        //private void btnConfirm_Click(object sender, RoutedEventArgs e)
        //{
        //    for (int i = 0; i < dgdMain.Items.Count; i++)
        //    {
        //        var main = dgdMain.Items[i] as Win_prd_PlanInput_U_CodeView_pop;

        //        if (main != null && main.Chk == true)
        //        {
        //            lstLotStock.Add(main);

        //        }

        //    }

        //    this.DialogResult = true;

        //}

        ////닫기
        //private void btnCancel_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}

        ////검색
        //private void btnSearch_Click(object sender, RoutedEventArgs e)
        //{
        //    re_Search(rowNum);
        //}

        //#endregion // 주요 버튼 이벤트


        //#region Header 부분 - 검색조건



        //#endregion // Header 부분 - 검색조건

        //#region Header 부분 - 검색조건 : 바코드 검색 → 바코드 비워주기 (다음 바코드를 바로 입력할 수 있도록)

        //#endregion

        //#region 주요 메서드 모음

        //private void re_Search(int rowNum)
        //{
        //    FillGrid();

        //    if (dgdMain.Items.Count > 0)
        //    {
        //        dgdMain.SelectedIndex = rowNum;
        //    }
        //    else
        //    {
        //        this.DataContext = null;
        //        MessageBox.Show("조회된 데이터가 없습니다.");
        //        return;
        //    }
        //}

        //#region 조회

        //private void FillGrid()
        //{
        //    if (dgdMain.Items.Count > 0)
        //    {
        //        dgdMain.Items.Clear();
        //    }

        //    try
        //    {
        //        Dictionary<string, object> sqlParameter = new Dictionary<string, object>();
        //        sqlParameter.Clear();
        //        sqlParameter.Add("CreateInstID", InstID);

        //        //sqlParameter.Add("sDate", date);

        //        //DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_mtr_StockLotID_WPF", sqlParameter, false);
        //        DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_Plinput_sJaturi_Create", sqlParameter, false);

        //        if (ds != null && ds.Tables.Count > 0)
        //        {
        //            DataTable dt = ds.Tables[0];

        //            if (dt.Rows.Count == 0)
        //            {
        //                MessageBox.Show("조회된 데이터가 없습니다.");
        //            }
        //            else
        //            {
        //                int index = 0;
        //                DataRowCollection drc = dt.Rows;

        //                foreach (DataRow dr in drc)
        //                {
        //                    index++;
        //                    var NowStockData = new Win_prd_PlanInput_U_CodeView_pop
        //                    {
        //                        Num = index,
        //                        ArticleID = dr["ArticleID"].ToString(),
        //                        Article = dr["Article"].ToString(),
        //                        BuyerArticleNo = dr["BuyerArticleNo"].ToString(),
        //                        JaturiLotID = dr["JaturiLotID"].ToString(),
        //                        JaturiSpec = dr["JaturiSpec"].ToString(),
                                

        //                        UDFlag = true,

        //                    };

                             

        //                    dgdMain.Items.Add(NowStockData);
        //                }
        //                tblCount.Text = "▶검색개수 : " + index + "건";

        //            }
        //        }

        //    }
        //    catch (Exception ee)
        //    {


        //        MessageBox.Show("조회 오류 : " + ee.Message);
        //    }
        //    finally
        //    {
        //        DataStore.Instance.CloseConnection();
        //    }
        //}

        //#endregion

        //#region 조회 - ArticleID 로!

        ////private void FillGrid_ArticleID(string ArticleID)
        ////{
        ////    if (dgdMain.Items.Count > 0)
        ////    {
        ////        dgdMain.Items.Clear();
        ////    }

        ////    try
        ////    {
        ////        Dictionary<string, object> sqlParameter = new Dictionary<string, object>();
        ////        sqlParameter.Clear();


        ////        sqlParameter.Add("ChkArticleID", 1);
        ////        sqlParameter.Add("ArticleID", ArticleID);

        ////        sqlParameter.Add("ChkArticle", 0);
        ////        sqlParameter.Add("Article", "");

        ////        sqlParameter.Add("ChkLotID", 0);
        ////        sqlParameter.Add("LotID", "");

        ////        DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_mtr_StockLotID_WPF", sqlParameter, false);

        ////        if (ds != null && ds.Tables.Count > 0)
        ////        {
        ////            DataTable dt = ds.Tables[0];

        ////            if (dt.Rows.Count > 0)
        ////            {
        ////                DataRowCollection drc = dt.Rows;

        ////                int i = 0;

        ////                foreach (DataRow dr in drc)
        ////                {
        ////                    i++;

        ////                    var Main = new Win_mtr_StockControl_U_Stuffin()
        ////                    {
        ////                        Num = i.ToString(),

        ////                        BuyerArticleNo = dr["BuyerArticleNo"].ToString(),

        ////                        Article = dr["Article"].ToString(),
        ////                        ArticleID = dr["ArticleID"].ToString(),
        ////                        LotID = dr["LotID"].ToString(),
        ////                        Qty = stringFormatN0(dr["Qty"]),

        ////                    };

        ////                    dgdMain.Items.Add(Main);

        ////                }

        ////                tblCount.Text = "▶검색개수 : " + i + "건";
        ////            }
        ////        }
        ////    }
        ////    catch (Exception ee)
        ////    {
        ////        MessageBox.Show("조회 오류 : " + ee.Message);
        ////    }
        ////    finally
        ////    {
        ////        DataStore.Instance.CloseConnection();
        ////    }
        ////}

        //#endregion

        //#endregion

        //#region 유효성 검사

        //private bool CheckData()
        //{
        //    bool flag = true;

        //    return flag;
        //}

        //#endregion

        //#region 데이터 그리드 체크박스 이벤트

        //// 팝업창 체크박스 이벤트
        //private void CHK_Click_Sub(object sender, RoutedEventArgs e)
        //{
        //    //CheckBox chkSender = sender as CheckBox;
        //    //var MoveSub = chkSender.DataContext as Win_mtr_Move_U_CodeViewSub;

        //    //if (MoveSub != null)
        //    //{
        //    //    if (chkSender.IsChecked == true)
        //    //    {
        //    //        MoveSub.Chk = true;
        //    //        MoveSub.FontColor = true;

        //    //        if (ovcMoveSub.Contains(MoveSub) == false)
        //    //        {
        //    //            ovcMoveSub.Add(MoveSub);
        //    //        }
        //    //    }
        //    //    else
        //    //    {
        //    //        MoveSub.Chk = false;
        //    //        MoveSub.FontColor = false;

        //    //        if (ovcMoveSub.Contains(MoveSub) == true)
        //    //        {
        //    //            ovcMoveSub.Remove(MoveSub);
        //    //        }
        //    //    }
        //    //}
        //}

        //#endregion // 데이터 그리드 체크박스 이벤트

        //#region 전체 선택 체크박스 이벤트

        //// 전체 선택 체크박스 체크 이벤트
        //private void AllCheck_Checked(object sender, RoutedEventArgs e)
        //{
        //    //ovcMoveSub.Clear();

        //    //if (dgdMain.Visibility == Visibility.Visible)
        //    //{
        //    //    for (int i = 0; i < dgdMain.Items.Count; i++)
        //    //    {
        //    //        var MoveSub = dgdMain.Items[i] as Win_mtr_Move_U_CodeViewSub;
        //    //        MoveSub.Chk = true;
        //    //        MoveSub.FontColor = true;

        //    //        ovcMoveSub.Add(MoveSub);
        //    //    }
        //    //}
        //}

        //// 전체 선택 체크박스 언체크 이벤트
        //private void AllCheck_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    //ovcMoveSub.Clear();

        //    //if (dgdMain.Visibility == Visibility.Visible)
        //    //{
        //    //    for (int i = 0; i < dgdMain.Items.Count; i++)
        //    //    {
        //    //        var MoveSub = dgdMain.Items[i] as Win_mtr_Move_U_CodeViewSub;
        //    //        MoveSub.Chk = false;
        //    //        MoveSub.FontColor = false;
        //    //    }
        //    //}
        //}

        //#endregion // 전체 선택 체크박스 이벤트

        //#region 기타 메서드

        //// 천마리 콤마, 소수점 버리기
        //private string stringFormatN0(object obj)
        //{
        //    return string.Format("{0:N0}", obj);
        //}


        //// 데이터피커 포맷으로 변경
        //private string DatePickerFormat(string str)
        //{
        //    string result = "";

        //    if (str.Length == 8)
        //    {
        //        if (!str.Trim().Equals(""))
        //        {
        //            result = str.Substring(0, 4) + "-" + str.Substring(4, 2) + "-" + str.Substring(6, 2);
        //        }
        //    }

        //    return result;
        //}

        //// Int로 변환
        //private int ConvertInt(string str)
        //{
        //    int result = 0;
        //    int chkInt = 0;

        //    if (!str.Trim().Equals(""))
        //    {
        //        str = str.Replace(",", "");

        //        if (Int32.TryParse(str, out chkInt) == true)
        //        {
        //            result = Int32.Parse(str);
        //        }
        //    }

        //    return result;
        //}

        //// 소수로 변환 가능한지 체크 이벤트
        //private bool CheckConvertDouble(string str)
        //{
        //    bool flag = false;
        //    double chkDouble = 0;

        //    if (!str.Trim().Equals(""))
        //    {
        //        if (Double.TryParse(str, out chkDouble) == true)
        //        {
        //            flag = true;
        //        }
        //    }

        //    return flag;
        //}

        //// 숫자로 변환 가능한지 체크 이벤트
        //private bool CheckConvertInt(string str)
        //{
        //    bool flag = false;
        //    int chkInt = 0;

        //    if (!str.Trim().Equals(""))
        //    {
        //        str = str.Trim().Replace(",", "");

        //        if (Int32.TryParse(str, out chkInt) == true)
        //        {
        //            flag = true;
        //        }
        //    }

        //    return flag;
        //}

        //// 소수로 변환
        //private double ConvertDouble(string str)
        //{
        //    double result = 0;
        //    double chkDouble = 0;

        //    if (!str.Trim().Equals(""))
        //    {
        //        str = str.Replace(",", "");

        //        if (Double.TryParse(str, out chkDouble) == true)
        //        {
        //            result = Double.Parse(str);
        //        }
        //    }

        //    return result;
        //}






        //#endregion // 기타 메서드

        //// 메인 그리드 더블클릭시 선택한걸로!!
        //private void dgdMain_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    //if (e.ClickCount == 2)
        //    //{
        //    //    btnConfirm_Click(null, null);
        //    //}
        //}

        ////선택
        //private void chkReq_Click(object sender, RoutedEventArgs e)
        //{
        //    CheckBox chkSender = sender as CheckBox;
        //    var LotStock = chkSender.DataContext as Win_prd_PlanInput_U_CodeView_pop;

        //    if (LotStock != null)
        //    {
                
        //        if (chkSender.IsChecked == true)
        //        {
        //            LotStock.Chk = true;
        //        }
        //        else
        //        {
        //            LotStock.Chk = false;
        //        }

        //    }



        //}

        //#region 서브 데이터그리드 방향키 이동 및 셀 포커스
        //private void DataGridSub_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        if (e.Key == Key.Down || e.Key == Key.Up || e.Key == Key.Left || e.Key == Key.Right)
        //        {
        //            DataGridSub_KeyDown(sender, e);
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - DataGridSub_PreviewKeyDown " + ee.ToString());
        //    }
        //}

        //private void DataGridSub_KeyDown(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        var SubItem = dgdMain.CurrentItem as Win_prd_PlanInput_U_CodeView_pop;
        //        int rowCount = dgdMain.Items.IndexOf(dgdMain.CurrentItem);
        //        int colCount = dgdMain.Columns.IndexOf(dgdMain.CurrentCell.Column);
        //        int StartColumnCount = 1; //DataGridSub.Columns.IndexOf(dgdtpeMCoperationRateScore);
        //        int EndColumnCount = 5; //DataGridSub.Columns.IndexOf(dgdtpeComments);

        //        if (e.Key == Key.Enter)
        //        {
        //            e.Handled = true;
        //            (sender as DataGridCell).IsEditing = false;

        //            if (EndColumnCount == colCount && dgdMain.Items.Count - 1 > rowCount)
        //            {
        //                dgdMain.SelectedIndex = rowCount + 1;
        //                dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount + 1], dgdMain.Columns[StartColumnCount]);
        //            }
        //            else if (EndColumnCount > colCount && dgdMain.Items.Count - 1 > rowCount)
        //            {
        //                dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount], dgdMain.Columns[colCount + 1]);
        //            }
        //            else if (EndColumnCount == colCount && dgdMain.Items.Count - 1 == rowCount)
        //            {
        //                btnConfirm.Focus();
        //            }
        //            else if (EndColumnCount > colCount && dgdMain.Items.Count - 1 == rowCount)
        //            {
        //                dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount], dgdMain.Columns[colCount + 1]);
        //            }
        //            else
        //            {
        //                MessageBox.Show("있으면 찾아보자...");
        //            }
        //        }
        //        else if (e.Key == Key.Down)
        //        {
        //            e.Handled = true;
        //            (sender as DataGridCell).IsEditing = false;

        //            if (dgdMain.Items.Count - 1 > rowCount)
        //            {
        //                dgdMain.SelectedIndex = rowCount + 1;
        //                dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount + 1], dgdMain.Columns[colCount]);
        //            }
        //            else if (dgdMain.Items.Count - 1 == rowCount)
        //            {
        //                if (EndColumnCount > colCount)
        //                {
        //                    dgdMain.SelectedIndex = 0;
        //                    dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[0], dgdMain.Columns[colCount + 1]);
        //                }
        //                else
        //                {
        //                    btnConfirm.Focus();
        //                }
        //            }
        //        }
        //        else if (e.Key == Key.Up)
        //        {
        //            e.Handled = true;
        //            (sender as DataGridCell).IsEditing = false;

        //            if (rowCount > 0)
        //            {
        //                dgdMain.SelectedIndex = rowCount - 1;
        //                dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount - 1], dgdMain.Columns[colCount]);
        //            }
        //        }
        //        else if (e.Key == Key.Left)
        //        {
        //            e.Handled = true;
        //            (sender as DataGridCell).IsEditing = false;

        //            if (colCount > 0)
        //            {
        //                dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount], dgdMain.Columns[colCount - 1]);
        //            }
        //        }
        //        else if (e.Key == Key.Right)
        //        {
        //            e.Handled = true;
        //            (sender as DataGridCell).IsEditing = false;

        //            if (EndColumnCount > colCount)
        //            {
        //                dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount], dgdMain.Columns[colCount + 1]);
        //            }
        //            else if (EndColumnCount == colCount)
        //            {
        //                if (dgdMain.Items.Count - 1 > rowCount)
        //                {
        //                    dgdMain.SelectedIndex = rowCount + 1;
        //                    dgdMain.CurrentCell = new DataGridCellInfo(dgdMain.Items[rowCount + 1], dgdMain.Columns[StartColumnCount]);
        //                }
        //                else
        //                {
        //                    btnConfirm.Focus();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - dgdMain_KeyDown " + ee.ToString());
        //    }
        //}

        //private void DataGridSub_TextFocus(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        Lib.Instance.DataGridINControlFocus(sender, e);
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - DataGridSub_TextFocus " + ee.ToString());
        //    }
        //}

        //private void DataGridSub_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (dgdMain.Items.Count > 0 )
        //        {
        //            DataGridCell cell = sender as DataGridCell;
        //            cell.IsEditing = true;
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - DataGridSub_GotFocus " + ee.ToString());
        //    }
        //}

        //private void DataGridSub_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    try
        //    {
        //        Lib.Instance.DataGridINBothByMouseUP(sender, e);
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - DataGridSub_MouseUp " + ee.ToString());
        //    }
        //}
        //#endregion

        //#region 서브 그리드 행 추가, 삭제
        ////데이터 그리드 서브 행 추가 버튼
        //private void ButtonDataGridSubRowAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        SubRowAdd();

        //        //int colCount = DataGridSub.Columns.IndexOf(d)
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - ButtonDataGridSubRowAdd_Click : " + ee.ToString());
        //    }
        //}

        ////데이터 그리드 서브 행 삭제 버튼
        //private void ButtonDataGridSubRowDel_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        SubRowDel();
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - ButtonDataGridSubRowDel_Click : " + ee.ToString());
        //    }
        //}

        ////서브 그리드 추가
        //private void SubRowAdd()
        //{
        //    try
        //    {
        //        int index = dgdMain.Items.Count;

        //        var WOOUSC = new Win_prd_PlanInput_U_CodeView_pop()
        //        {
        //            Num = index + 1,
        //            InstID = InstID,
                     
        //            CreateInstDetSeq = "",

        //            ArticleID = "",
        //            Article = "",
        //            BuyerArticleNo = "",
        //            JaturiLotID = "",
        //            JaturiSpec = ""

        //    };
        //        dgdMain.Items.Add(WOOUSC);
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - SubRowAdd : " + ee.ToString());
        //    }
        //}

        ////서브 그리드 삭제
        //private void SubRowDel()
        //{
        //    try
        //    {
        //        if (dgdMain.Items.Count > 0)
        //        {
        //            if (dgdMain.SelectedItem != null)
        //            {
        //                if (dgdMain.CurrentItem != null)
        //                {
        //                    dgdMain.Items.Remove(dgdMain.CurrentItem as Win_prd_PlanInput_U_CodeView_pop);
        //                }
        //                else
        //                {
        //                    winordorderusubcodeview.Add(dgdMain.SelectedItem as Win_prd_PlanInput_U_CodeView_pop);
        //                    dgdMain.Items.Remove((dgdMain.Items[dgdMain.SelectedIndex]) as Win_prd_PlanInput_U_CodeView_pop);

        //                    //dgdMain.Items.Remove((dgdMain.Items[dgdMain.Items.Count - 1]) as Win_ord_Order_U_Sub_CodeView);  //마지막 행만 삭제
        //                }

        //                dgdMain.Refresh();
        //            }
        //            else
        //            {
        //                MessageBox.Show("삭제할 데이터를 먼저 선택하세요.");
        //            }
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("오류지점 - SubRowDel : " + ee.ToString());
        //    }
        //}

        //#endregion
        ////품번 검색
        //private void dgdBuyerArticleNo_KeyDown(object sender, KeyEventArgs e)
        //{
        //    var SubItem = dgdMain.CurrentItem as Win_prd_PlanInput_U_CodeView_pop;

        //    if (e.Key == Key.Enter)
        //    {
        //        TextBox tb1 = sender as TextBox;
        //        pf.ReturnCode(tb1, 5001, SubItem.BuyerArticleNo);

        //        if (tb1.Tag != null)
        //        {
        //            SubItem.ArticleID = tb1.Tag.ToString();
        //            SubItem.BuyerArticleNo = tb1.Text;
        //        }

        //        string FindText = tb1.Text;
        //        string FindTag = tb1.Tag.ToString();
        //        Dictionary<string, object> sqlParameter = new Dictionary<string, object>();
        //        sqlParameter.Clear();
        //        sqlParameter.Add("ArticleID", FindTag);
        //        DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_Plinput_Article", sqlParameter, false);

        //        DataTable dt = null;
        //        dt = ds.Tables[0];
        //        if (dt.Rows.Count != 0)
        //        {
        //            SubItem.Article = dt.Rows[0]["Article"].ToString();
        //            SubItem.BuyerArticleNo = dt.Rows[0]["BuyerArticleNo"].ToString();
        //            //SubItem.Spec = dt.Rows[0]["Spec"].ToString();
        //            //SubItem.Weight = dt.Rows[0]["Weight"].ToString();
        //        }
        //    }
        //}

        ////품명검색
        //private void dgdArticle_KeyDown(object sender, KeyEventArgs e)
        //{
        //    var SubItem = dgdMain.CurrentItem as Win_prd_PlanInput_U_CodeView_pop;

        //    if (e.Key == Key.Enter)
        //    {
        //        TextBox tb1 = sender as TextBox;
        //        pf.ReturnCode(tb1, 5000, SubItem.Article);
                
        //        if (tb1.Tag != null)
        //        {
        //            SubItem.ArticleID = tb1.Tag.ToString();
        //            SubItem.Article = tb1.Text;
        //        }

        //        string FindText = tb1.Text;
        //        string FindTag = tb1.Tag.ToString();
        //        Dictionary<string, object> sqlParameter = new Dictionary<string, object>();
        //        sqlParameter.Clear();
        //        sqlParameter.Add("ArticleID", FindTag);
        //        DataSet ds = DataStore.Instance.ProcedureToDataSet("xp_Plinput_Article", sqlParameter, false);

        //        DataTable dt = null;
        //        dt = ds.Tables[0];
        //        if (dt.Rows.Count != 0)
        //        {
        //            SubItem.Article = dt.Rows[0]["Article"].ToString();
        //            SubItem.BuyerArticleNo = dt.Rows[0]["BuyerArticleNo"].ToString();
        //            //SubItem.Spec = dt.Rows[0]["Spec"].ToString();
        //            //SubItem.Weight = dt.Rows[0]["Weight"].ToString();
        //        }
        //    }
        //}

        //private void CheckBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    if(e.ClickCount == 1)
        //    {
        //        chkReq_Click(null, null);
        //    }
        //}
    }


}

