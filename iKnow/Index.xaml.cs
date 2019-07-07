using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace iKnow
{
    public partial class Index : PhoneApplicationPage
    {
        Storyboard _timer = new Storyboard();
        public string textString = "";
        public string str = "";
        public static int countComma = 0;
        public char[] shortRequest = {'p','l','e','a','s','e',' ','a','n','s','w','e','r',' ','m','e'};
        public char[] longRequest = { 'p', 'l', 'e', 'a', 's', 'e', ' ', 'a', 'n', 's', 'w', 'e', 'r', ' ', 'm', 'e', ' ','t','h','i','s',' ','q','u','e','s','t','i','o','n'};
        public string answer = "";
        public string[] noAnswerReply = { "You are wasting my time, and I'll do the same to you !!!!",
                                          "I do not wish to answer now !!!!",
                                          "I will obey my master only.",
                                          "Shhhhhhhhhhhhhhhhhhhhhhh",
                                          "I can't answer now try after some time.",
                                          "It's a secret that I was ordered to protect.",
                                          "I refuse to answer.",
                                          "You can't force me to answer this question.",
                                          "I am not sure u want me to answer this question.",
                                          "You know the answer for this question.",
                                          "I can't answer this type of questions",
                                          "I don't think you really want to know the answer for this question.",
                                          "I need peace don't disturb me now.",
                                          "Sorry I am tired. I can't answer now.",
                                          "It's not good time to discuss this question now.",
                                          "Sorry don't disturb me now I am meditating.",
                                          "I have chosen to remain silent",
                                          "I am not supposed to answer this question.",
                                          "You are not supposed to know the answer.",
                                          "I'm sorry, but I can't help you with this question."
                                        };
        public string[] noRequestReply = { "The request you just made is not valid",
                                           "Are you trying to find how I react?",
                                           "You are little disorganised in giving request. Enter a proper request.",
                                           "Do the request again, you are wasting my great wisdom.",
                                           "Do the request again."
                                         };
        public string[] request = { "please answer me",
                                    "please answer me this question"
                                  };

        public Index()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            clearEverything();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            
            countComma = 0;

            requestTextBox.IsEnabled = false;
            questionTextBox.IsEnabled = false;

            MyProgress.Visibility = System.Windows.Visibility.Visible;
            MyProgress.Value = 0;
            _timer.Duration = TimeSpan.FromMilliseconds(1);

            _timer.Completed += new EventHandler(_timer_Completed);

            _timer.Begin();

            
        }

        private void tryAgainButton_Click(object sender, RoutedEventArgs e)
        {
            clearEverything();   
        }

        public void clearEverything()
        {
            requestTextBox.Text = "Tap here to make request";
            questionTextBox.Text = "Enter a question here";
            okButton.Visibility = Visibility.Visible;
            answerTexBlock.Visibility = Visibility.Collapsed;
            tryAgainButton.Visibility = Visibility.Collapsed;
            countComma = 0;
            answerTexBlock.Text = "";
            answer = "";
            requestTextBox.IsEnabled = true;
            questionTextBox.IsEnabled = true;
            textString = "";
        }

        private void requestTextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            requestTextBox.Text = "";
        }

        private void questionTextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            questionTextBox.Text = "";
        }

        
        private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            if ((e.Orientation & PageOrientation.Portrait) == (PageOrientation.Portrait))
            {
                requestTextBlock.Margin = new Thickness(12, 135, 285, 583);

                requestTextBox.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                requestTextBox.Margin = new Thickness(12, 204, 0, 492);
                requestTextBox.Width = 341.0;

                clearButton.Margin = new Thickness(0, 204, 12, 0);

                questionTextBlock.Margin = new Thickness(12, 325, 278, 389);

                questionTextBox.Margin = new Thickness(12, 385, 0, 0);
                questionTextBox.Width = 341.0;

                okButton.Margin = new Thickness(356, 385, 0, 0);

                MyProgress.Margin = new Thickness(137, 525, 143, 223);

                answerTexBlock.Margin = new Thickness(12, 492, 0, 0);
                answerTexBlock.Height = 95.0;
                answerTexBlock.Width = 456.0;

                tryAgainButton.Margin = new Thickness(137, 604, 0, 0);
            }
            else
            {
                requestTextBlock.Margin = new Thickness(21, 136, 524, 589);
                
                requestTextBox.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
                requestTextBox.Margin = new Thickness(0, 116, 152, 580);
                requestTextBox.Width = 366.0;

                clearButton.Margin = new Thickness(0, 116, 34, 0);

                questionTextBlock.Margin = new Thickness(21, 235, 524, 479);

                questionTextBox.Margin = new Thickness(210, 211, 0, 0);
                questionTextBox.Width = 366.0;

                okButton.Margin = new Thickness(582, 211, 0, 0);

                MyProgress.Margin = new Thickness(296, 308, 232, 430);

                answerTexBlock.Margin = new Thickness(21, 307, 0, 0);
                answerTexBlock.Height = 79.0;
                answerTexBlock.Width = 673.0;

                tryAgainButton.Margin = new Thickness(278, 392, 0, 0);

            }
        }

        private void requestTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.PlatformKeyCode.ToString() != "8")
            {
                if (e.PlatformKeyCode.ToString() != "188")
                    textString += (char)e.PlatformKeyCode;
                else
                    textString += ",";
                char[] strrr = requestTextBox.Text.ToCharArray();
                string sss = "";
                if (countComma >= 0 && countComma <= 2)
                {
                    if (e.PlatformKeyCode.ToString() == "188")
                        countComma++;


                    if (countComma == 1 || countComma == 2)
                    {
                        if (e.PlatformKeyCode.ToString() == "188")
                        { }
                        else
                        {
                            if (countComma != 2)
                                answer += (char)e.PlatformKeyCode;

                        }

                        for (int i = 0; i < strrr.Length - 1; i++)
                            sss += strrr[i];
                        if (strrr.Length < 17)
                            sss += shortRequest[strrr.Length - 1];

                        else
                            sss += longRequest[strrr.Length - 1];

                        requestTextBox.Text = sss;
                        requestTextBox.SelectionStart = requestTextBox.Text.Length;

                        if (countComma == 2)
                            countComma ++;
                    }
                }
            }
            else
            {
                if (textString.Length > 0)
                {
                    textString = textString.Substring(0, textString.Length - 1);
                    //questionTextBox.Text = textString;
                    countComma = textString.Split(',').Length - 1;

                    if (countComma != 0)
                    {
                        string[] temp = textString.Split(',');
                        answer = temp[1];
                    }

                    else
                        answer = "";
                }
                

            }
            
        }

        private void requestTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //questionTextBox.Text = requestTextBox.Text.Equals(request[0]).ToString();
        }

        public string answerDisplay()
        {
            Random rand = new Random();

            if (requestTextBox.Text.Length <= 0 || requestTextBox.Text == "Tap here to make request")
                return "You must enter a valid request";

            else if (!(requestTextBox.Text.Equals(request[0])) && !(requestTextBox.Text.Equals(request[1])))
                return noRequestReply[rand.Next(0, 4)];

            else if (questionTextBox.Text.Length <= 0 || questionTextBox.Text == "Enter a question here")
                return "Please enter a valid question";

            else if (answer.Length > 0)
            {
                char[] st = answer.ToCharArray();
                answer = "";
                for (int i = 0; i < st.Length; i++)
                    answer += st[i];

                return answer.ToLower();
            }

            else
                return noAnswerReply[rand.Next(0, 19)];
            
        }




        void _timer_Completed(object sender, EventArgs e)
        {

            if (MyProgress.Value < MyProgress.Maximum)
            {

                MyProgress.Value++;

                _timer.Begin();

            }

            if (MyProgress.Value == MyProgress.Maximum)
            {
                MyProgress.Visibility = System.Windows.Visibility.Collapsed;
                okButton.Visibility = Visibility.Collapsed;
                answerTexBlock.Visibility = Visibility.Visible;
                tryAgainButton.Visibility = Visibility.Visible;
                answerTexBlock.Text = answerDisplay();
            }

        }
               
    }
}