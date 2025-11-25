namespace GITStudentManager
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        public class Student
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Class { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();

            // --- KIỂM TRA LỖI HỌ TÊN ---
            // 1. Không được chứa số
            if (name.Any(char.IsDigit))
                if (name.Any(char.IsDigit))
                {
                    MessageBox.Show("Họ tên không được chứa số!", "Lỗi nhập liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

            // 2. Không được vượt quá 30 ký tự
            if (name.Length > 30)
            {
                MessageBox.Show("Họ tên không được dài quá 30 ký tự!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu hợp lệ → tạo đối tượng Student
            Student s = new Student()
            {
                Name = name,
                Gender = gender.Text,
                Class = txtlop.Text
            };

            students.Add(s);

            // Cập nhật bảng
            board.DataSource = null;
            board.DataSource = students;
        }

        private void update_Click(object sender, EventArgs e)
        {
            int index = board.CurrentRow.Index;
            students[index].Name = txtname.Text;
            students[index].Gender = gender.Text;
            students[index].Class = txtlop.Text;
            board.DataSource = null;
            board.DataSource = students;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string keyword = txtname.Text.ToLower();
            var result = students.FindAll(s => s.Name.ToLower().Contains(keyword));
            board.DataSource = null;
            board.DataSource = result;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string keyword = txtname.Text.ToLower();
            var result = students.FindAll(s => s.Name.ToLower().Contains(keyword));
            board.DataSource = null;
            board.DataSource = result;
        }
    }
}
