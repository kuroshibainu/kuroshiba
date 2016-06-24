using System;
using System.Windows.Forms;

namespace PramTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        struct ValWrap { public int value; }
        class RefWrap { public int value; }

        private void Form1_Load(object sender, EventArgs e) {
            {
                Console.WriteLine("値の値渡し");
                var left = new ValWrap();
                left.value = 1;
                var right = new ValWrap();
                right.value = 2;
                swapAndEdit(left, right);
                Console.WriteLine(left.value + ", " + right.value);
            }
            {
                Console.WriteLine("参照の値渡し");
                var left = new RefWrap();
                left.value = 1;
                var right = new RefWrap();
                right.value = 2;
                swapAndEdit(left, right);
                Console.WriteLine(left.value + ", " + right.value);
            }
            {
                Console.WriteLine("値の参照渡し");
                var left = new ValWrap();
                left.value = 1;
                var right = new ValWrap();
                right.value = 2;
                swapAndEdit(ref left, ref right);
                Console.WriteLine(left.value + ", " + right.value);
            }
            {
                Console.WriteLine("参照の参照渡し");
                var left = new RefWrap();
                left.value = 1;
                var right = new RefWrap();
                right.value = 2;
                swapAndEdit(ref left, ref right);
                Console.WriteLine(left.value + ", " + right.value);
            }
        }

        static void swapAndEdit(ValWrap left, ValWrap right) {
            var tmp = left;
            left = right;
            right = tmp;
            tmp.value *= 100;
        }
        static void swapAndEdit(RefWrap left, RefWrap right) {
            var tmp = left;
            left = right;
            right = tmp;
            tmp.value *= 100;
        }
        static void swapAndEdit(ref ValWrap left, ref ValWrap right) {
            var tmp = left;
            left = right;
            right = tmp;
            tmp.value *= 100;
        }
        static void swapAndEdit(ref RefWrap left, ref RefWrap right) {
            var tmp = left;
            left = right;
            right = tmp;
            tmp.value *= 100;
        }

    }
}
