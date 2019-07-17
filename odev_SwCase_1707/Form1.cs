using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_SwCase_1707
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Eger ilk textbox'a "Admin","Moderator","Yonetici","CEO","Baskan" degerleri girilirse "Yönetim Paneline Yönlendiriliyorsunuz..."
            //"Uye" girilirse "Ana Sayfaya Yonlendiriliyorsunuz...";
            //Harici bir durumda "Bu Sayfayı Görme Yetkiniz Yok!";

            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz.

            //KullaniciAdi = "bilgeadam";
            //Sifre = "1234";

            //iki soruyu birleştirmeyi denedim 

            string KA = textBox1.Text;
            string KS = textBox2.Text;
            switch (KA)
            {
                #region ceo
                case "ceo":
                    {
                        switch (KS)
                        {
                            case "123":
                                MessageBox.Show("hoşgeldiniz ceo bey");
                                this.Text = "yonetim paneline yonlendiriliyorsunuz";
                                break;
                            default:
                                MessageBox.Show("şifrenizi kontrol ediniz ceo bey");
                                break;
                        }
                        break;
                    }
                #endregion

                #region admin
                case "admin":
                    {
                        switch (KS)
                        {
                            case "145":
                                MessageBox.Show("hoşgeldiniz admin bey");
                                this.Text = "yonetim paneline yonlendiriliyorsunuz";
                                break;
                            default:
                                MessageBox.Show("şifrenizi kontrol ediniz admin bey");
                                break;
                        }
                        break;
                    }
                #endregion

                #region moderator
                case "moderator":
                    {
                        switch (KS)
                        {
                            case "417":
                                MessageBox.Show("hoşgeldiniz moderator bey");
                                this.Text = "yonetim paneline yonlendiriliyorsunuz";
                                break;
                            default:
                                MessageBox.Show("şifrenizi kontrol ediniz moderator bey");
                                break;
                        }
                        break;
                    }
                #endregion

                #region uye
                case "uye":
                    {
                        switch (KS)
                        {
                            case "917":
                                MessageBox.Show("hoşgeldiniz uye bey");
                                this.Text = "ana sayfaya yonlendiriliyorsunuz";
                                break;
                            default:
                                MessageBox.Show("şifrenizi kontrol ediniz uye bey");
                                break;
                        }
                        break;
                    }
                #endregion

                #region hata
                default:
                    MessageBox.Show("bu sayfayı gormeye yetkiniz yok");
                    break; 
                    #endregion

            }

















        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
