using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine_winform
{
    public partial class Form1 : Form
    {
        //Bảng ký tự
        private readonly string Alphabet = "aáàãạảăắằẵẳặâấầẫậẩbcdđeéèẽẹẻêếềễệểfghiíìĩịỉjklmnoóòõọỏôốồỗộổơớờỡợởpqrstuúùũụủưứừữựửvwxyýỳỹỵỷzAÁÀÃẠẢĂẮẰẴẶẲÂẤẦẪẬẨBCDĐEÉÈẼẸẺÊẾỀỄỆỂFGHIÍÌĨỊỈJKLMNOÓÒÕỌỎÔỐỒỖỘỔƠỚỜỠỢỞPQRSTUÚÙŨỤỦƯỨỪỮỰỬVWXYÝỲỸỴỶZ0123456789 \\\"'`~!@#$%^&*()_-+={[}]|:;,.<>?/";
        public Form1()
        {
            InitializeComponent();
            char[] mangkt = Alphabet.ToCharArray();
            QuickSort(mangkt, 0, mangkt.Length - 1);//Sắp xếp mangkt theo thứ tự tăng dần 
            Alphabet = new string(mangkt);
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            int number;
            bool isInt = int.TryParse(keya.Text, out number);
            if(!isInt)//kiểm tra giá trị có phaỉ số nguyên hay không
            {
                MessageBox.Show("Số bạn vừa nhập không phải là số nguyên!!","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                keya.Text = "";
                keya.Focus();
            }
            else
            {
                isInt = int.TryParse(keyb.Text, out number);
                if (!isInt)
                {
                    MessageBox.Show("Số bạn vừa nhập không phải là số nguyên!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    keyb.Text = "";
                    keyb.Focus();
                }
                else
                {
                    int a = int.Parse(keya.Text);
                    int b = int.Parse(keyb.Text);
                    if (a <= 0 || UCLN(a, Alphabet.Length) != 1)
                    {
                        MessageBox.Show("a và " + Alphabet.Length + " phải là nguyên tố cùng nhau!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        keya.Text = "";
                        keya.Focus();
                    }
                    else
                        ciphertext.Text = encrypt(plaintext.Text, chuan_hoa_a(a), chuan_hoa_b(b)); ;
                }
            }
          
            
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            int number;
            bool isInt = int.TryParse(keya.Text, out number);
            if (!isInt)
            {
                MessageBox.Show("Số bạn nhập không phải là số nguyên!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                keya.Text = "";
                keya.Focus();
            }
            else
            {
                isInt = int.TryParse(keyb.Text, out number);
                if (!isInt)
                {
                    MessageBox.Show("Số bạn nhập không phải là số nguyên!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    keyb.Text = "";
                    keyb.Focus();
                }
                else
                {
                    int a = int.Parse(keya.Text);
                    int b = int.Parse(keyb.Text);
                    if (a <= 0 || UCLN(a, Alphabet.Length) != 1)
                    {
                        MessageBox.Show("Bạn nhập a không thỏa mãn điều kiện để giải mã", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        keya.Text = "";
                        keya.Focus();
                    }
                    else
                        plaintext1.Text = decrypt(ciphertext1.Text, chuan_hoa_a(a), chuan_hoa_b(b));
                }
            }
            
        }
        //hàm mã hóa
        private string encrypt(string plaintext, int a, int b)
        {
            StringBuilder ciphertext = new StringBuilder();

            foreach (char c in plaintext)
            {
                int index = BinarySearch(Alphabet, c);
                if (index!=-1)
                {
                    int encryptedIndex = (a * index + b) % Alphabet.Length;
                    char encryptedChar = Alphabet[encryptedIndex];
                    ciphertext.Append(encryptedChar);
                }
                else
                {
                    ciphertext.Append(c);
                }
            }

            return ciphertext.ToString();
        }
        //hàm giải mã
        private string decrypt(string ciphertext, int a, int b)
        {
            int aInverse = ModuloMultiplicativeInverse(a, Alphabet.Length);
            StringBuilder plaintext = new StringBuilder();

            foreach (char c in ciphertext)
            {
                int index = BinarySearch(Alphabet, c);
                if (index!=-1)
                {
                    int decryptedIndex = aInverse *(index - b + Alphabet.Length) % Alphabet.Length;
                    char decryptedChar = Alphabet[decryptedIndex];
                    plaintext.Append(decryptedChar);
                }
                else
                {
                    plaintext.Append(c);
                }
            }

            return plaintext.ToString();
        }
        //Hàm tìm kiếm nhị phân
        private int BinarySearch(string sortedString, char c)//hàm tìm kiếm nhị phân
        {
            int left = 0;
            int right = sortedString.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Nếu ký tự ở vị trí mid là ký tự cần tìm, trả về vị trí mid
                if (sortedString[mid] == c)
                    return mid;

                // Nếu ký tự ở vị trí mid nhỏ hơn ký tự cần tìm, ta tìm ở bên phải của mid
                if (sortedString[mid] < c)
                    left = mid + 1;
                // Ngược lại, ta tìm ở bên trái của mid
                else
                    right = mid - 1;
            }

            // Trả về -1 nếu không tìm thấy ký tự trong chuỗi
            return -1;
        }
        //Hàm sắp xếp
        private void QuickSort(char[] array, int low, int high)
        {
            if (low < high)
            {
                //pivotIndex là phần tử chốt của mảng
                int pivotIndex = Partition(array, low, high);
                //sắp xếp riêng biệt các mảng con
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }
        //hàm phân đoạn mảng
        private int Partition(char[] array, int low, int high)
        {
            //chọn phần tử cuối cùng của mảng là pivot
            char pivot = array[high];
            //khởi tạo một phần tử nhỏ hơn
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                //so sánh phần tử hiện tại với pivot nếu nhỏ hơn thì đổi chỗ
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }
        //hàm đổi vị trí 2 phần tử trong mảng
        private void Swap(char[] array, int i, int j)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        //Hàm tính nghịch đảo
        private int ModuloMultiplicativeInverse(int a, int m) // a^-1 mod n
        {
            int m0 = m;
            int y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                // q là thương của a cho m
                int q = a / m;

                int t = m;

                // m là số dư của a cho m
                m = a % m;
                a = t;
                t = y;

                // Cập nhật x và y
                y = x - q * y;
                x = t;
            }

            // Đảm bảo x là số dương
            if (x < 0)
                x += m0;

            return x;
        }
        //Tìm ước chung lớn nhất áp dụng giải thuật Euclid
        private int UCLN(int a,int b)
        {
            if (b == 0)
                return a;

            // Chia a cho b, và tiếp tục đệ quy với b và phần dư của a/b
            return UCLN(b, a % b);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDecrypt.Enabled = false;
            btnEncrypt.Enabled = false;
            ciphertext.ReadOnly = true;
            plaintext1.ReadOnly = true;
            btnSave.Enabled = false;
            btnSave1.Enabled = false;
            btnCopy.Enabled = false;
            btnCopy1.Enabled = false;
            txtAlphabet.ReadOnly = true;
            txtm.ReadOnly = true;
            txtAlphabet.Text = Alphabet;
            txtm.Text = Alphabet.Length.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn nhập lại dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                plaintext.Focus();
                plaintext.Text = "";
                ciphertext.Text = "";
            }
            
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn nhập lại dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ciphertext1.Focus();
                plaintext1.Text = "";
                ciphertext1.Text = "";
                //keya.Text = "";
                //keyb.Text = "";
            }
            
        }

        private void plaintext_TextChanged(object sender, EventArgs e)
        {
            if (plaintext.Text != "" && keya.Text != "" && keyb.Text != "") btnEncrypt.Enabled = true;
            if (plaintext.Text == "") btnEncrypt.Enabled = false;
            if (keya.Text == "") btnEncrypt.Enabled = false;
            if (keyb.Text == "") btnEncrypt.Enabled = false;
        }

        private void keya_TextChanged(object sender, EventArgs e)
        {
            if (plaintext.Text != "" && keya.Text != "" && keyb.Text != "") btnEncrypt.Enabled = true;
            if (ciphertext1.Text != "" && keya.Text != "" && keyb.Text != "") btnDecrypt.Enabled = true;
            if (plaintext.Text == "") btnEncrypt.Enabled = false;
            if(ciphertext1.Text == "") btnDecrypt.Enabled = false;
            if (keya.Text == "")
            {
                btnEncrypt.Enabled = false;
                btnDecrypt.Enabled = false;
            }
            if (keyb.Text == "")
            {
                btnEncrypt.Enabled = false;
                btnDecrypt.Enabled = false;
            }
        }

        private void keyb_TextChanged(object sender, EventArgs e)
        {
            if (plaintext.Text != "" && keya.Text != "" && keyb.Text != "") btnEncrypt.Enabled = true;
            if (ciphertext1.Text != "" && keya.Text != "" && keyb.Text != "") btnDecrypt.Enabled = true;
            if (plaintext.Text == "") btnEncrypt.Enabled = false;
            if (ciphertext1.Text == "") btnDecrypt.Enabled = false;
            if (keya.Text == "")
            {
                btnEncrypt.Enabled = false;
                btnDecrypt.Enabled = false;
            }
            if (keyb.Text == "")
            {
                btnEncrypt.Enabled = false;
                btnDecrypt.Enabled = false;
            }
        }

        private void ciphertext1_TextChanged(object sender, EventArgs e)
        {
            if (ciphertext1.Text != "" && keya.Text != "" && keyb.Text != "") btnDecrypt.Enabled = true;
            if (ciphertext1.Text == "") btnDecrypt.Enabled = false;
            if (keya.Text == "") btnDecrypt.Enabled = false;
            if (keyb.Text == "") btnDecrypt.Enabled = false;
        }
        
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string content = ciphertext.Text;
            Clipboard.SetText(content);
        }

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            string content = plaintext1.Text;
            Clipboard.SetText(content);
        }

        private void ciphertext_TextChanged(object sender, EventArgs e)
        {
            if (ciphertext.Text != "")
            {
                btnCopy.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                btnCopy.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void plaintext1_TextChanged(object sender, EventArgs e)
        {
            if (plaintext1.Text != "")
            {
                btnCopy1.Enabled = true;
                btnSave1.Enabled = true;
            }
            else
            {
                btnCopy1.Enabled = false;
                btnSave1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa toàn bộ dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                plaintext.Focus();
                plaintext.Text = "";
                ciphertext.Text = "";
                plaintext1.Text = "";
                ciphertext1.Text = "";
                keya.Text = "";
                keyb.Text = "";
            }
        }

        private void btnUploadtxt_Click(object sender, EventArgs e)
        {
            plaintext.Text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text Files|*.txt";

            openFileDialog1.Title = "Select a Text File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(filePath);
                plaintext.Text += fileContent;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save to Text File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                string textToSave = ciphertext.Text;
                File.WriteAllText(filePath, textToSave);
            }
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
            ciphertext1.Text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Text File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(filePath);
                ciphertext1.Text += fileContent;
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save to Text File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                string textToSave = plaintext1.Text;
                File.WriteAllText(filePath, textToSave);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int mina = 1;
            Random random = new Random();
            int randomNumber = random.Next(mina,int.MaxValue);
            while(UCLN(randomNumber, Alphabet.Length) != 1)
            {
                randomNumber = random.Next(mina, int.MaxValue);
            }
            keya.Text = randomNumber.ToString();
            int randomNumber2 = random.Next(int.MinValue, int.MaxValue);
            keyb.Text = randomNumber2.ToString();
        }
        int demchay=10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //label.Left+= demchay;
            //if(label.Right<=0)
            //{
            //    label.Location = new Point(panel1.Right -30, label.Location.Y);
            //}
            label.Left += demchay;
            if(label.Left>=panel1.Width-label.Width||label.Left<=0)
            {
                demchay = -demchay;
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa toàn bộ dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                plaintext.Focus();
                plaintext.Text = "";
                ciphertext.Text = "";
                plaintext1.Text = "";
                ciphertext1.Text = "";
                keya.Text = "";
                keyb.Text = "";
            }
        }
        
        public int chuan_hoa_b(int b)
        {
            while (b < 0)
            {
                b = b + Alphabet.Length;
            }
            b = b % Alphabet.Length;
            return b;
        }
        public int chuan_hoa_a(int a)
        {
            a = a % Alphabet.Length;
            return a;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //keya.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private bool isWindowOpen = false; // Biến cờ kiểm tra trạng thái cửa sổ
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!isWindowOpen) // Kiểm tra cửa sổ đã mở chưa
            {
                // Mở cửa sổ
                ThongTin a = new ThongTin();
                a.FormClosed += (s, args) => isWindowOpen = false; // Đặt biến cờ thành false khi cửa sổ được đóng
                a.Show();
                isWindowOpen = true; // Đặt biến cờ thành true
            }
        }

        private void btnEncrypt_MouseEnter(object sender, EventArgs e)
        {
            btnEncrypt.BackColor = Color.Orange;
            btnEncrypt.FlatStyle = FlatStyle.Popup;
        }

        private void btnEncrypt_MouseLeave(object sender, EventArgs e)
        {
            btnEncrypt.BackColor = Color.White;
        }

        private void btnDecrypt_MouseEnter(object sender, EventArgs e)
        {
            btnDecrypt.BackColor = Color.Green;
            btnDecrypt.FlatStyle = FlatStyle.Popup;
        }

        private void btnDecrypt_MouseLeave(object sender, EventArgs e)
        {
            btnDecrypt.BackColor = Color.White;
        }

        private void btnClearData_MouseEnter(object sender, EventArgs e)
        {
            btnClearData.BackColor = Color.Red;
            btnClearData.FlatStyle = FlatStyle.Popup;
        }

        private void btnClearData_MouseLeave(object sender, EventArgs e)
        {
            btnClearData.BackColor = Color.White;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Popup;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Blue;
            btnReset.FlatStyle = FlatStyle.Popup;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
        }

        private void btnReset1_MouseEnter(object sender, EventArgs e)
        {
            btnReset1.BackColor = Color.Blue;
            btnReset1.FlatStyle = FlatStyle.Popup;
        }

        private void btnReset1_MouseLeave(object sender, EventArgs e)
        {
            btnReset1.BackColor = Color.White;
        }

        private void btnUploadtxt_MouseEnter(object sender, EventArgs e)
        {
            btnUploadtxt.BackColor = Color.LightCyan;
            btnUploadtxt.FlatStyle = FlatStyle.Popup;
        }

        private void btnUploadtxt_MouseLeave(object sender, EventArgs e)
        {
            btnUploadtxt.BackColor = Color.White;
        }

        private void btnUpload1_MouseEnter(object sender, EventArgs e)
        {
            btnUpload1.BackColor = Color.LightCyan;
            btnUpload1.FlatStyle = FlatStyle.Popup;
        }

        private void btnUpload1_MouseLeave(object sender, EventArgs e)
        {
            btnUpload1.BackColor = Color.White;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.White;
        }

        private void btnSave1_MouseEnter(object sender, EventArgs e)
        {
            btnSave1.BackColor = Color.LightBlue;
            btnSave1.FlatStyle = FlatStyle.Popup;
        }

        private void btnSave1_MouseLeave(object sender, EventArgs e)
        {
            btnSave1.BackColor = Color.White;
        }

        private void btnCopy_MouseEnter(object sender, EventArgs e)
        {
            btnCopy.BackColor = Color.YellowGreen;
            btnCopy.FlatStyle = FlatStyle.Popup;
        }

        private void btnCopy_MouseLeave(object sender, EventArgs e)
        {
            btnCopy.BackColor = Color.White;
        }

        private void btnCopy1_MouseEnter(object sender, EventArgs e)
        {
            btnCopy1.BackColor = Color.YellowGreen;
            btnCopy1.FlatStyle = FlatStyle.Popup;
        }

        private void btnCopy1_MouseLeave(object sender, EventArgs e)
        {
            btnCopy1.BackColor = Color.White;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void btnRandom_MouseEnter(object sender, EventArgs e)
        {
            btnRandom.BackColor = Color.Coral;
            btnRandom.FlatStyle = FlatStyle.Popup;
        }

        private void btnRandom_MouseLeave(object sender, EventArgs e)
        {
            btnRandom.BackColor = Color.White;
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn nhập lại dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                keya.Text = "";
                keyb.Text = "";
                keya.Focus();
            }
        }

        private void btnReset2_MouseEnter(object sender, EventArgs e)
        {
            btnReset2.BackColor = Color.Blue;
            btnReset2.FlatStyle = FlatStyle.Popup;
        }

        private void btnReset2_MouseLeave(object sender, EventArgs e)
        {
            btnReset2.BackColor = Color.White;
        }
    }
}
