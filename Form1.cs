using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Sort_By_Filename
{
    public partial class Main : Form
    {
        public List<string[]> Filelist = new List<string[]>(); // [0] 이름, [1] 확장자.
        public List<string[]> Filelist_Temp = new List<string[]>(); // [0] 이름, [1] 확장자.

        int total;
        int count = 0;
        public string FolderName = "";

        FolderBrowserDialog dlg = new FolderBrowserDialog();
        OpenFileDialog OFD = new OpenFileDialog();

        string filedirPath = ""; // 불러올 폴더
        string filedirPath_Target = ""; // 저장할 폴더
        int WhichOne = 0;

        Boolean isClickedSaveFolderButton = false;


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dlg.ShowNewFolderButton = false;
            dlg.RootFolder = Environment.SpecialFolder.MyComputer;

            OFD.Filter = "모든 파일|*.*";
            OFD.Multiselect = true;
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) //변경시작 버튼
        {
            DialogResult dialogResult = MessageBox.Show("정말 이름을 변경하시겠습니까?", "확실합니까?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ChangeName();
            }
            else
            {
                MessageBox.Show("취소하셨습니다.");
            }

        }

        private void ChangeName()
        {
            string filename_tmp = tb_filename.Text;
            string newFileName = "";
            string oldFileName = "";
            int i = 0;

            string tmp1, tmp2; // tmp1은 바꾸기 전 이름, tmp2는 바꾼 후 이름.

            int stringlength = filename_tmp.Length;

            int SpecificNumber = 1;
            bool IsNumber = false;

            if (textBox_SpecificNumber.Text != "") // 특정 숫자를 입력받고 그게 숫자면 SpecificNumber에 대입. 아니면 그냥 둠.
            {
                IsNumber = int.TryParse(textBox_SpecificNumber.Text, out SpecificNumber);
            }

            if (WhichOne == 0) // 아무 것도 안하고 선택했을때 나오는 창.
            {
                MessageBox.Show("파일이나 폴더를 먼저 선택해야합니다.");
                return;
            }
            try
            {
                if (radiobtn_simple.Checked == true)
                {
                    if (WhichOne == 1) //폴더 선택했을 때
                    {
                        switch (stringlength)
                        {
                            case 0: // 문자에 입력된 값이 없을 때.
                                DialogResult NoString = MessageBox.Show("입력된 값이 없습니다. 파일이름 없이 순서만 메기게 됩니다. \n 진행하시겠습니까?", "", MessageBoxButtons.YesNo);

                                if (NoString == DialogResult.Yes) //이름 바꾸기
                                    if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                    {
                                        if (rdb_10.Checked == true || rdb_No.Checked == true) //자릿수 10개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D2") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_100.Checked == true) //자릿수 100개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D3") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_1000.Checked == true) //자릿수 1000개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D4") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 100) //파일 갯수가 100개보다 많으면
                                    {
                                        if (rdb_10.Checked == true) //자릿수 10개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D2") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_100.Checked == true || rdb_No.Checked == true) //자릿수 100개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D3") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_1000.Checked == true) //자릿수 1000개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D4") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                    {
                                        if (rdb_10.Checked == true)
                                        {
                                            MessageBox.Show("말이 안되는거 알지...?");
                                            return;
                                        }
                                        else if (rdb_100.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                newFileName = SpecificNumber.ToString("D3") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_1000.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                newFileName = SpecificNumber.ToString("D4") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }


                                if (checkBox_Open.Checked) // 변환후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }

                                break;
                            default:
                                if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                {
                                    if (rdb_10.Checked == true || rdb_No.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_100.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_1000.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 100 && listBox_Files.Items.Count < 1000) //파일 갯수가 100개 이상 1000개 미만이면
                                {
                                    if (rdb_10.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_100.Checked == true || rdb_No.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_1000.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                {
                                    if (rdb_10.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++)
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_100.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++)
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_1000.Checked == true || rdb_No.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++)
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                if (checkBox_Open.Checked) // 끝난후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }
                                break;
                        }
                    }
                    else if (WhichOne == 2) //파일 한개 혹은 여러개 선택했을때
                    {
                        switch (stringlength)
                        {
                            case 0: // 문자에 입력된 값이 없을 때.
                                DialogResult NoString = MessageBox.Show("입력된 값이 없습니다. 파일이름 없이 순서만 메기게 됩니다. \n 진행하시겠습니까?", "", MessageBoxButtons.YesNo);

                                if (NoString == DialogResult.Yes) //이름 바꾸기
                                    if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                    {
                                        if (rdb_10.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1]; //바꿀 파일의 이름을 찾음
                                                newFileName = SpecificNumber.ToString("D2") + "." + Filelist[i][1]; // 특정한 번호로 순서를 메김
                                                tmp1 = Path.Combine(filedirPath, oldFileName); // 바꿀 파일의 이전 경로,이름
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName); // 바꿀 파일의 이후 경로,이름
                                                File.Move(tmp1, tmp2); //이동
                                                SpecificNumber++;
                                            }
                                        }
                                        else if (rdb_100.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D3") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        else if (rdb_1000.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 100 && listBox_Files.Items.Count < 1000) //파일 갯수가 100개 이상 1000개 미만이면
                                    {
                                        if (rdb_10.Checked == true)
                                        {
                                            MessageBox.Show("너도 말이 안되는거 알지?");
                                            return;
                                        }
                                        else if (rdb_100.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D3") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        else if (rdb_1000.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                    {
                                        if (rdb_10.Checked == true || rdb_100.Checked == true)
                                        {
                                            MessageBox.Show("말이 안되는거 알지...?");
                                            return;
                                        }
                                        else if (rdb_1000.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }


                                if (checkBox_Open.Checked) // 끝난후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }
                                break;

                            default: // 텍스트박스에 이름 입력했을때 이리로 옴.
                                if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                {
                                    for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                    {
                                        oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                        newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + "." + Filelist[i][1];
                                        tmp1 = Path.Combine(filedirPath, oldFileName);
                                        tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                        File.Move(tmp1, tmp2);
                                        SpecificNumber++;
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 100 && listBox_Files.Items.Count < 1000) //파일 갯수가 100개 이상 1000개 미만이면
                                {
                                    for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                    {
                                        oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                        newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + "." + Filelist[i][1];
                                        tmp1 = Path.Combine(filedirPath, oldFileName);
                                        tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                        File.Move(tmp1, tmp2);
                                        SpecificNumber++;
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                {
                                    for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                    {
                                        oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                        newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                        tmp1 = Path.Combine(filedirPath, oldFileName);
                                        tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                        File.Move(tmp1, tmp2);
                                        SpecificNumber++;
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                if (checkBox_Open.Checked) // 끝난후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }
                                break;
                        }
                    }

                }
            }
            catch
            {
                String CurrentTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_"); //현재시간에 해당하는 문자열 생성
                Filelist_Temp = Filelist;

                for (int j = 0; j < Filelist_Temp.Count; j++)
                {
                    newFileName = Filelist_Temp[i][1] = CurrentTime + j;

                    tmp1 = Path.Combine(filedirPath, Filelist_Temp[i][0]);
                    tmp2 = Path.Combine(filedirPath_Target, newFileName);
                    File.Move(tmp1, tmp2);

                }
                if (radiobtn_simple.Checked == true)
                {
                    if (WhichOne == 1) //폴더 선택했을 때
                    {
                        switch (stringlength)
                        {
                            case 0: // 문자에 입력된 값이 없을 때.
                                DialogResult NoString = MessageBox.Show("입력된 값이 없습니다. 파일이름 없이 순서만 메기게 됩니다. \n 진행하시겠습니까?", "", MessageBoxButtons.YesNo);

                                if (NoString == DialogResult.Yes) //이름 바꾸기
                                    if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                    {
                                        if (rdb_10.Checked == true || rdb_No.Checked == true) //자릿수 10개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D2") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_100.Checked == true) //자릿수 100개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D3") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_1000.Checked == true) //자릿수 1000개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D4") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 100) //파일 갯수가 100개보다 많으면
                                    {
                                        if (rdb_10.Checked == true) //자릿수 10개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D2") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_100.Checked == true || rdb_No.Checked == true) //자릿수 100개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D3") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_1000.Checked == true) //자릿수 1000개로 설정
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++)
                                            {
                                                newFileName = SpecificNumber.ToString("D4") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                    {
                                        if (rdb_10.Checked == true)
                                        {
                                            MessageBox.Show("말이 안되는거 알지...?");
                                            return;
                                        }
                                        else if (rdb_100.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                newFileName = SpecificNumber.ToString("D3") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        else if (rdb_1000.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                newFileName = SpecificNumber.ToString("D4") + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                            label_lastnumber.Text = SpecificNumber.ToString();
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }


                                if (checkBox_Open.Checked) // 끝난후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }

                                break;
                            default:
                                if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                {
                                    if (rdb_10.Checked == true || rdb_No.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_100.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_1000.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 100 && listBox_Files.Items.Count < 1000) //파일 갯수가 100개 이상 1000개 미만이면
                                {
                                    if (rdb_10.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_100.Checked == true || rdb_No.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_1000.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                {
                                    if (rdb_10.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++)
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_100.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++)
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    else if (rdb_1000.Checked == true || rdb_No.Checked == true)
                                    {
                                        for (i = 0; i < listBox_Files.Items.Count; i++)
                                        {
                                            newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + Filelist[i][1];
                                            tmp1 = Path.Combine(filedirPath, Filelist[i][0]);
                                            tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                            File.Move(tmp1, tmp2);
                                            SpecificNumber++;
                                        }
                                        label_lastnumber.Text = SpecificNumber.ToString();
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                if (checkBox_Open.Checked) // 끝난후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }
                                break;
                        }
                    }
                    else if (WhichOne == 2) //파일 한개 혹은 여러개 선택했을때
                    {
                        switch (stringlength)
                        {
                            case 0: // 문자에 입력된 값이 없을 때.
                                DialogResult NoString = MessageBox.Show("입력된 값이 없습니다. 파일이름 없이 순서만 메기게 됩니다. \n 진행하시겠습니까?", "", MessageBoxButtons.YesNo);

                                if (NoString == DialogResult.Yes) //이름 바꾸기
                                    if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                    {
                                        if (rdb_10.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1]; //바꿀 파일의 이름을 찾음
                                                newFileName = SpecificNumber.ToString("D2") + "." + Filelist[i][1]; // 특정한 번호로 순서를 메김
                                                tmp1 = Path.Combine(filedirPath, oldFileName); // 바꿀 파일의 이전 경로,이름
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName); // 바꿀 파일의 이후 경로,이름
                                                File.Move(tmp1, tmp2); //이동
                                                SpecificNumber++;
                                            }
                                        }
                                        else if (rdb_100.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D3") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        else if (rdb_1000.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 100 && listBox_Files.Items.Count < 1000) //파일 갯수가 100개 이상 1000개 미만이면
                                    {
                                        if (rdb_10.Checked == true)
                                        {
                                            MessageBox.Show("너도 말이 안되는거 알지?");
                                            return;
                                        }
                                        else if (rdb_100.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D3") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        else if (rdb_1000.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }
                                    else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                    {
                                        if (rdb_10.Checked == true || rdb_100.Checked == true)
                                        {
                                            MessageBox.Show("말이 안되는거 알지...?");
                                            return;
                                        }
                                        else if (rdb_1000.Checked == true || rdb_No.Checked == true)
                                        {
                                            for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                            {
                                                oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                                newFileName = SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                                tmp1 = Path.Combine(filedirPath, oldFileName);
                                                tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                                File.Move(tmp1, tmp2);
                                                SpecificNumber++;
                                            }
                                        }
                                        MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                    }


                                if (checkBox_Open.Checked) // 끝난후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }
                                break;

                            default: // 텍스트박스에 이름 입력했을때 이리로 옴.
                                if (listBox_Files.Items.Count < 100) //파일 갯수가 100개보다 적으면
                                {
                                    for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                    {
                                        oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                        newFileName = filename_tmp + " " + SpecificNumber.ToString("D2") + "." + Filelist[i][1];
                                        tmp1 = Path.Combine(filedirPath, oldFileName);
                                        tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                        File.Move(tmp1, tmp2);
                                        SpecificNumber++;
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 100 && listBox_Files.Items.Count < 1000) //파일 갯수가 100개 이상 1000개 미만이면
                                {
                                    for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                    {
                                        oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                        newFileName = filename_tmp + " " + SpecificNumber.ToString("D3") + "." + Filelist[i][1];
                                        tmp1 = Path.Combine(filedirPath, oldFileName);
                                        tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                        File.Move(tmp1, tmp2);
                                        SpecificNumber++;
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                else if (listBox_Files.Items.Count >= 1000) //파일 갯수가 1000개보다 많으면
                                {
                                    for (i = 0; i < listBox_Files.Items.Count; i++) //이름 바꾸기
                                    {
                                        oldFileName = Filelist[i][0] + "." + Filelist[i][1];
                                        newFileName = filename_tmp + " " + SpecificNumber.ToString("D4") + "." + Filelist[i][1];
                                        tmp1 = Path.Combine(filedirPath, oldFileName);
                                        tmp2 = Path.Combine(filedirPath_Target, newFileName);
                                        File.Move(tmp1, tmp2);
                                        SpecificNumber++;
                                    }
                                    MessageBox.Show(listBox_Files.Items.Count + "개의 항목들의 이름을 변경하였습니다.", "변경 완료");
                                }
                                if (checkBox_Open.Checked) // 끝난후 폴더 열기
                                {
                                    System.Diagnostics.ProcessStartInfo process =
                                    new System.Diagnostics.ProcessStartInfo(filedirPath_Target);
                                    process.UseShellExecute = true;
                                    process.Verb = "open";
                                    System.Diagnostics.Process.Start(process);
                                }
                                if (checkBox_Close.Checked) // 끝난후 프로그램 닫기
                                {
                                    Close();
                                }
                                break;
                        }
                    }

                }
                ChangeName();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ext_Form frm = new Ext_Form();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_MakeFolder frm = new Form_MakeFolder();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void button_Fileload_Click(object sender, EventArgs e) //파일 불러오기 버튼
        {
            if (checkBox_reset.Checked == true)
            {
                Filelist.Clear();
                listBox_Files.Items.Clear();
            }

            string[] TempArray = new string[3]; // 리스트에 저장할 임시 배열

            DialogResult DR = this.OFD.ShowDialog();
            try
            {
                if (DR == DialogResult.OK)
                {
                    foreach (String fileName in OFD.SafeFileNames)
                    {
                        filedirPath = Path.GetDirectoryName(OFD.FileName);
                        filedirPath_Target = Path.GetDirectoryName(OFD.FileName);
                        TempArray = new string[] { filedirPath, fileName.Split('.')[0], fileName.Split('.')[1] };
                        Filelist.Add(TempArray);
                        listBox_Files.Items.Add(Filelist[count][1] + "." + Filelist[count][2]);
                        count++;
                    }
                    total = count;
                    label_count.Text = total.ToString();
                    WhichOne = 2; // 파일 선택했다는 흔적
                }
            }
            catch
            {
                count = 0;
                if (DR == DialogResult.OK)
                {
                    foreach (String fileName in OFD.SafeFileNames)
                    {
                        filedirPath = Path.GetDirectoryName(OFD.FileName);
                        filedirPath_Target = Path.GetDirectoryName(OFD.FileName);
                        TempArray = new string[] { filedirPath, fileName.Split('.')[0], fileName.Split('.')[1] };
                        Filelist.Add(TempArray);
                        listBox_Files.Items.Add(Filelist[count][1] + "." + Filelist[count][2]);
                        count++;
                    }
                    total = count;
                    label_count.Text = total.ToString();
                    WhichOne = 2; // 파일 선택했다는 흔적
                }
            }
        }

        private void button_load_Click(object sender, EventArgs e) // 폴더 불러오기 버튼
        {
            if (checkBox_reset.Checked == true)
            {
                Filelist.Clear();
                listBox_Files.Items.Clear();

                dlg.SelectedPath = filedirPath;
                DialogResult result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    filedirPath = dlg.SelectedPath;

                    if (checkBox_reset.Checked == true)
                    {
                        listBox_Files.Items.Clear();
                        Filelist.Clear();

                        count = 0;
                    }

                    if (Directory.Exists(filedirPath))
                    {
                        DirectoryInfo di = new DirectoryInfo(filedirPath);

                        foreach (var item in di.GetFiles().OrderBy(f => f, new NaturalFileInfoNameComparer())) // 폴더 안에 파일 몇개 있는지 불러오기.
                        {
                            Filelist.Add(new string[] { item.Name, item.Extension });
                            listBox_Files.Items.Add(Filelist[count][0]);
                            count++;
                        }
                        total = count;
                        label_dirpath.Text = filedirPath;
                        if (isClickedSaveFolderButton == false)
                        {
                            label_SaveFolder.Text = filedirPath;
                            filedirPath_Target = filedirPath;
                        }
                        label_count.Text = total.ToString();

                        WhichOne = 1; // 폴더 선택했다는 흔적
                    }
                }
            }
        }

        private void btn_reloadFloder_Click(object sender, EventArgs e) // 폴더 다시 불러오기 버튼
        {
            if (checkBox_reset.Checked == true)
            {
                listBox_Files.Items.Clear();
                Filelist.Clear();
            }

            DirectoryInfo di = new DirectoryInfo(filedirPath);

            count = 0;
            foreach (var item in di.GetFiles()) // 폴더 안에 파일 몇개 있는지 불러오기.
            {
                Filelist.Add(new string[] { item.Name, item.Extension });
                listBox_Files.Items.Add(Filelist[count][0]);
                count++;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBox_Files.Items.Clear();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            listBox_Files.Items.Clear();
            Filelist.Clear();

            count = 0;
        }

        [SuppressUnmanagedCodeSecurity] // 숫자 정렬 비교 알고리즘, https://stackoverflow.com/questions/248603/natural-sort-order-in-c-sharp
        internal static class SafeNativeMethods
        {
            [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
            public static extern int StrCmpLogicalW(string psz1, string psz2);
        }

        public sealed class NaturalStringComparer : IComparer<string> // 숫자 정렬 비교 알고리즘
        {
            public int Compare(string a, string b)
            {
                return SafeNativeMethods.StrCmpLogicalW(a, b);
            }
        }

        public sealed class NaturalFileInfoNameComparer : IComparer<FileInfo> // 숫자 정렬 비교 알고리즘
        {
            public int Compare(FileInfo a, FileInfo b)
            {
                return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name);
            }
        }

        private void button_SaveTargetFolderSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                label_SaveFolder.Text = dlg.SelectedPath;

                isClickedSaveFolderButton = true;

                filedirPath_Target = dlg.SelectedPath;
            }
        }

        private void listBox_Files_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox_Files.SelectedItem.ToString());
        }
    }

    public static class FolderBrowserLauncher // 
    {
        /// <summary>
        /// Using title text to look for the top level dialog window is fragile.
        /// In particular, this will fail in non-English applications.
        /// </summary>
        const string _topLevelSearchString = "Browse For Folder";

        /// <summary>
        /// These should be more robust.  We find the correct child controls in the dialog
        /// by using the GetDlgItem method, rather than the FindWindow(Ex) method,
        /// because the dialog item IDs should be constant.
        /// </summary>
        const int _dlgItemBrowseControl = 0;
        const int _dlgItemTreeView = 100;

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Some of the messages that the Tree View control will respond to
        /// </summary>
        private const int TV_FIRST = 0x1100;
        private const int TVM_SELECTITEM = (TV_FIRST + 11);
        private const int TVM_GETNEXTITEM = (TV_FIRST + 10);
        private const int TVM_GETITEM = (TV_FIRST + 12);
        private const int TVM_ENSUREVISIBLE = (TV_FIRST + 20);

        /// <summary>
        /// Constants used to identity specific items in the Tree View control
        /// </summary>
        private const int TVGN_ROOT = 0x0;
        private const int TVGN_NEXT = 0x1;
        private const int TVGN_CHILD = 0x4;
        private const int TVGN_FIRSTVISIBLE = 0x5;
        private const int TVGN_NEXTVISIBLE = 0x6;
        private const int TVGN_CARET = 0x9;


        /// <summary>
        /// Calling this method is identical to calling the ShowDialog method of the provided
        /// FolderBrowserDialog, except that an attempt will be made to scroll the Tree View
        /// to make the currently selected folder visible in the dialog window.
        /// </summary>
        /// <param name="dlg"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static DialogResult ShowFolderBrowser(FolderBrowserDialog dlg, IWin32Window parent = null)
        {
            DialogResult result = DialogResult.Cancel;
            int retries = 10;

            using (Timer t = new Timer())
            {
                t.Tick += (s, a) =>
                {
                    if (retries > 0)
                    {
                        --retries;
                        IntPtr hwndDlg = FindWindow((string)null, _topLevelSearchString);
                        if (hwndDlg != IntPtr.Zero)
                        {
                            IntPtr hwndFolderCtrl = GetDlgItem(hwndDlg, _dlgItemBrowseControl);
                            if (hwndFolderCtrl != IntPtr.Zero)
                            {
                                IntPtr hwndTV = GetDlgItem(hwndFolderCtrl, _dlgItemTreeView);

                                if (hwndTV != IntPtr.Zero)
                                {
                                    IntPtr item = SendMessage(hwndTV, (uint)TVM_GETNEXTITEM, new IntPtr(TVGN_CARET), IntPtr.Zero);
                                    if (item != IntPtr.Zero)
                                    {
                                        SendMessage(hwndTV, TVM_ENSUREVISIBLE, IntPtr.Zero, item);
                                        retries = 0;
                                        t.Stop();
                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        t.Stop();
                        SendKeys.Send("{TAB}{TAB}{DOWN}{DOWN}{UP}{UP}");
                    }
                };

                t.Interval = 10;
                t.Start();

                result = dlg.ShowDialog(parent);
            }

            return result;
        }
    }
}