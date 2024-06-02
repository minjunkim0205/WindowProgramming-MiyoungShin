namespace Te03;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    //
    // PrintDateButton
    //
    private void PrintDateButton_Click(System.Object? sender, System.EventArgs e)
    {
        // 현재 날짜 및 시간 정보 가져오기
        string current_date_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Form 제목 표시줄 텍스트 가져오기
        string form_title = this.Text;

        // 메시지 박스로 날짜 정보와 Form 제목 표시줄 텍스트 출력
        MessageBox.Show($"{current_date_time}\n{e}\nDateDisplay", $"DateDisplay");
    }
}
