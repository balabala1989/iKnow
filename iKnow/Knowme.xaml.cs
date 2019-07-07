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
    public partial class Knowme : PhoneApplicationPage
    {
        string textBlockContent = "-> Have you ever wondered whether your mobile can answer all your questions? Yes now it can do it.\n\n -> \"iKnowe\" will answer all your questions about your past, present, future, friends, likes etc.\n\n -> In order to use the great wisdom of \"iKnowe\" you must first request it to answer and then ask your question. Type the request \"please answer me\" or \"please answer me this question\" in the \"Request\" field. \n\n -> Type your question in the \"Question\" field. \n\n -> After typing the request and the question \"iKnowe\" will give your answer right away. \n\n P.S: You must first respect \"iKnowe\" to use its wisdom. Without a proper request \"iKnowe\" will refuse to answer your question. Expect some unexpected answers from \"iKnowe\". Have fun!!!!!";
        public Knowme()
        {
            InitializeComponent();
            aboutMeTextBlock.Text = textBlockContent;           
        }

        private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            
            if ((e.Orientation & PageOrientation.Portrait) == (PageOrientation.Portrait))
            {
                scrollViewer1.Width = 394.0;
                aboutMeTextBlock.Text = textBlockContent;
            }
            else
            {
                scrollViewer1.Width = 634.0;
                aboutMeTextBlock.Text = textBlockContent + "\n\n\n\n\n\n\n\n";
            }
        }
    }
}