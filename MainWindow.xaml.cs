using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Net;

namespace U3SummativeAssignmentTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string word = "";
        int counter = 0;
        int randnumber = 0;
        Random random = new Random();
        bool wordsolve = false;
        int IncorrectLttr = 0;
        int CorrectLttr = 0;

        public MainWindow()
        {
            InitializeComponent();
         
            

         
            try
            {
                randnumber = random.Next(1,11);
             
                StreamReader streamReader = new StreamReader("TextFile1.txt");
                while(counter != randnumber)
                {
                    string temp = streamReader.ReadLine();
                    counter++;
                    //MessageBox.Show(temp);
                    word = temp;
                 //   MessageBox.Show(randnumber.ToString());
                }
                MessageBox.Show(word);
                word = "c a t";
                lblword.Content = word;
                string dash = "";
                for(int i = 0; i  < word.Length; i = i+2)
                {
                    dash += "_ ";

                }

                dashes.Content = dash;
           
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(dashes.Content.ToString() + " Length: " + dashes.Content.ToString().Length.ToString());
        }

        public void lttrReplace(string x)
        {
            if (word.Contains(x))
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if(word[i] == x[0])
                    {
                        MessageBox.Show(dashes.Content.ToString() +" Length: " + dashes.Content.ToString().Length.ToString());
                        string temp2 = dashes.Content.ToString().Remove(i * 2, 2);
                        temp2 = temp2.Insert((i + 1) * 2 , x);
                        dashes.Content = temp2;
                        CorrectLttr++;
                        
                    }
                }
                MessageBox.Show(dashes.Content.ToString() + " Length: " + dashes.Content.ToString().Length.ToString());
            }
            else
            {
                IncorrectLttr++;
                MessageBox.Show(IncorrectLttr.ToString());
            }
        }



        // Letter Buttons
        bool AClick = false;
        bool BClick = false;
        bool CClick = false;
        bool DClick = false;
        bool EClick = false;
        bool FClick = false;
        bool GClick = false;
        bool HClick = false;
        bool IClick = false;
        bool JClick = false;
        bool KClick = false;
        bool LClick = false;
        bool MClick = false;
        bool NClick = false;
        bool OClick = false;
        bool PClick = false;
        bool QClick = false;
        bool RClick = false;
        bool SClick = false;
        bool TClick = false;
        bool UClick = false;
        bool VClick = false;
        bool WClick = false;
        bool XClick = false;
        bool YClick = false;
        bool ZClick = false;

        private void A_Click(object sender, RoutedEventArgs e)
        {
            AClick = true;          
            if (AClick)
            {
                A.Visibility = Visibility.Hidden;
            }
            lttrReplace("a");
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            BClick = true;
            if (BClick)
            {
                B.Visibility = Visibility.Hidden;
            }
            lttrReplace("b");
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            CClick = true;
            if (CClick)
            {
                C.Visibility = Visibility.Hidden;
            }
            lttrReplace("c");
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            DClick = true;
            if (DClick)
            {
                D.Visibility = Visibility.Hidden;
            }
            lttrReplace("d");
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {
            EClick = true;
            if (EClick)
            {
                E.Visibility = Visibility.Hidden;
            }
            lttrReplace("e");
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            FClick = true;
            if (FClick)
            {
                F.Visibility = Visibility.Hidden;
            }
            lttrReplace("f");
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            GClick = true;
            if (GClick)
            {
                G.Visibility = Visibility.Hidden;
            }
            lttrReplace("g");
        }

        private void H_Click(object sender, RoutedEventArgs e)
        {
            HClick = true;
            if (HClick)
            {
                H.Visibility = Visibility.Hidden;
            }
            lttrReplace("h");
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            IClick = true;
            if (IClick)
            {
                I.Visibility = Visibility.Hidden;
            }
            lttrReplace("i");
        }

        private void J_Click(object sender, RoutedEventArgs e)
        {
            JClick = true;
            if (JClick)
            {
                J.Visibility = Visibility.Hidden;
            }
            lttrReplace("j");
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            KClick = true;
            if (KClick)
            {
                K.Visibility = Visibility.Hidden;
            }
            lttrReplace("k");
        }

        private void L_Click(object sender, RoutedEventArgs e)
        {
            LClick = true;
            if (LClick)
            {
                L.Visibility = Visibility.Hidden;
            }
            lttrReplace("l");
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {
            MClick = true;
            if (MClick)
            {
                M.Visibility = Visibility.Hidden;
            }
            lttrReplace("m");
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            NClick = true;
            if (NClick)
            {
                N.Visibility = Visibility.Hidden;
            }
            lttrReplace("n");
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            OClick = true;
            if (OClick)
            {
                O.Visibility = Visibility.Hidden;
            }
            lttrReplace("o");
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            PClick = true;
            if (PClick)
            {
                P.Visibility = Visibility.Hidden;
            }
            lttrReplace("p");
        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {
            QClick = true;
            if (QClick)
            {
                Q.Visibility = Visibility.Hidden;
            }
            lttrReplace("q");
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            RClick = true;
            if (RClick)
            {
                R.Visibility = Visibility.Hidden;
            }
            lttrReplace("r");
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            SClick = true;
            if (SClick)
            {
                S.Visibility = Visibility.Hidden;
            }
            lttrReplace("s");
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {
            TClick = true;
            if (TClick)
            {
                T.Visibility = Visibility.Hidden;
            }
            lttrReplace("t");
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
            UClick = true;
            if (UClick)
            {
                U.Visibility = Visibility.Hidden;
            }
            lttrReplace("u");
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            VClick = true;
            if (VClick)
            {
                V.Visibility = Visibility.Hidden;
            }
            lttrReplace("v");
        }

        private void W_Click(object sender, RoutedEventArgs e)
        {
            WClick = true;
            if (WClick)
            {
                W.Visibility = Visibility.Hidden;
            }
            lttrReplace("w");
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            XClick = true;
            if (XClick)
            {
                X.Visibility = Visibility.Hidden;
            }
            lttrReplace("x");
        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            YClick = true;
            if (YClick)
            {
                Y.Visibility = Visibility.Hidden;
            }
            lttrReplace("y");
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            ZClick = true;
            if (ZClick)
            {
                Z.Visibility = Visibility.Hidden;
            }
            lttrReplace("z");
        }
    }
}



/*
 * Testing stuff
 * 
 * McT's example for assigning each word a number
                    string longText = "Word1\r\nWord2\r\nWord3";
                    string[] mywords = longText.Split(new char[] { '\n' });
                    MessageBox.Show(mywords.Length.ToString());
                    MessageBox.Show(mywords[0]);
       
             string AllWords = streamReader.ReadToEnd();
                    
                    string[] mywords = AllWords.Split(new char[] { '\n' });
              
                    MessageBox.Show(mywords.Length.ToString());
          
    */