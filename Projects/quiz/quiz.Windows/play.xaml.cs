using quiz.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237
public struct que
{
    public string q;
    public Dictionary<string, int> a;
    public int cor;
    public void start()
    {
        a = new Dictionary<string, int>();
    }
    public void set(string f, int ff)
    {
        a.Add(f, ff);
    }
}
namespace quiz
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class play : Page
    {
        public static int c = 0,ans=0,score=0,ans1=0,ans2=0;
        public static bool ayman;

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        public static que demo(int i)
        {
            que[] arr = new que[30];
            arr[0].start(); arr[0].q = "Complete: _____ x=0.512;"; arr[0].set("int", 1); arr[0].set("float", 2); arr[0].cor = 2;
            arr[1].start(); arr[1].q = "Is this right?\nint x;\nx++;\ncout<<x;"; arr[1].set("yes", 1); arr[1].set("no", 2); arr[1].cor = 2;
            arr[2].start(); arr[2].q = "Is this right?\nbool y;\ncout<<y+1;"; arr[2].set("yes", 1); arr[2].set("no", 2); arr[2].cor = 2;
            arr[3].start(); arr[3].q = "int x=10,c=0;\nwhile(x--){\nc++;\n}\ncout<<c\nWhat is the output?"; arr[3].set("10", 1); arr[3].set("9", 2); arr[3].cor = 1;
            arr[4].start(); arr[4].q = "int x=10;\nx*=10;\ncout<<x;\nWhat is the output?"; arr[4].set("100", 1); arr[4].set("11", 2); arr[4].cor = 1;
            arr[5].start(); arr[5].q = "int y=5;\nfor(int i=0;i<10;i++){\ny++;\n}\ncout<<y;\nWhat is the output?"; arr[5].set("15", 1); arr[5].set("20", 2); arr[5].cor = 1;
            arr[6].start(); arr[6].q = "Is this right?\nint x=5;\nwhile(true){\nif(x>10) break;\nx++;\n}"; arr[6].set("yes", 1); arr[6].set("no", 2); arr[6].cor = 1;
            arr[7].start(); arr[7].q = "Is this right?\nint arr[5];\ncin>>arr[5];"; arr[7].set("yes", 1); arr[7].set("no", 2); arr[7].cor = 2;
            arr[8].start(); arr[8].q = "int x=10;\nif(x>10) cout<<\"hello\";\nelse cout<<\"bye\";\n\nWhat is the output?"; arr[8].set("hello", 1); arr[8].set("bye", 2); arr[8].cor = 2;
            arr[9].start(); arr[9].q = "char c='a';\nc++;\ncout<<c;\nWhat is the output?"; arr[9].set("a", 1); arr[9].set("b", 2); arr[9].cor = 2;
            arr[10].start(); arr[10].q = "int x=20;\n int *y=&x;\n*y=10;\ncout<<x;\nWhat is the output?"; arr[10].set("10", 1); arr[10].set("11", 2); arr[10].cor = 1;
            arr[11].start(); arr[11].q = "int x=20;\n int *y=&x;\ncout<<y;\nWhat is the output?"; arr[11].set("20", 1); arr[11].set("random no.", 2); arr[11].cor = 2;
            arr[12].start(); arr[12].q = "int arr[]={1,2,3,4,5};\ncout<<*max_element(arr,arr+5);\nWhat is the output?"; arr[12].set("5", 1); arr[12].set("4", 2); arr[12].cor = 1;
            arr[13].start(); arr[13].q = "int arr[]={1,2,3,4,5};\ncout<<accumulate(arr,arr+5,0);\nWhat is the output?"; arr[13].set("15", 1); arr[13].set("10", 2); arr[13].cor = 1;
            arr[14].start(); arr[14].q = "double a=21.012;\ncout<<(int) a;\nWhat is the output?"; arr[14].set("21.0", 1); arr[14].set("21", 2); arr[14].cor = 2;
            arr[15].start(); arr[15].q = "Is this right?\nint x;\nint *y=&x;\ny=10;\ncout<<x;"; arr[15].set("yes", 1); arr[15].set("no", 2); arr[15].cor = 2;
            arr[16].start(); arr[16].q = "Is this right?\nvector<int> v;\nv[5]=4;\nv[0]=1;\ncout<<v[0]<<endl<<v[5];"; arr[16].set("yes", 1); arr[16].set("no", 2); arr[16].cor = 2;
            arr[17].start(); arr[17].q = "Is this right?\nmap<int> m;\nm.insert(5);\ncout<<m.begin();"; arr[17].set("yes", 1); arr[17].set("no", 2); arr[17].cor = 2;
            arr[18].start(); arr[18].q = "Is this right?\nint x;\ncin>>x;\nint y=new int [x];"; arr[18].set("yes", 1); arr[18].set("no", 2); arr[18].cor = 2;
            arr[19].start(); arr[19].q = "register int x;\nWhat's the benefit of using 'register' word?"; arr[19].set("Faster access", 1); arr[19].set("bigger size", 2); arr[19].cor = 1;
            arr[20].start(); arr[20].q = "To convert string to integar?"; arr[20].set("int =* string", 1); arr[20].set("stringstream", 2); arr[20].cor = 2;
            arr[21].start(); arr[21].q = "1+2+3+4+......+n"; arr[21].set("n(n+1)/2", 1); arr[21].set("1/(n-1)", 2); arr[21].cor = 1;
            arr[22].start(); arr[22].q = "Iterator is a/an ?"; arr[22].set("object", 1); arr[22].set("pointer", 2); arr[22].cor = 1;
            arr[23].start(); arr[23].q = "what 'end()' function in vector return?"; arr[23].set("Iterator to last element", 1); arr[23].set("Iterator to the position after the last element", 2); arr[23].cor = 2;
            arr[24].start(); arr[24].q = "vector<int> v={1,2,3,4,5};\nsort(v.begin(),v.end(),\n[] (int a,int b){return a>b;});"; arr[24].set("Descending", 1); arr[24].set("Ascending", 2); arr[24].cor = 1;
            arr[25].start(); arr[25].q = "x%2 is equal to :"; arr[25].set("x^1", 1); arr[25].set("x&1", 2); arr[25].cor = 2;
            arr[26].start(); arr[26].q = "Sparse graph has :"; arr[26].set("Few edges", 1); arr[26].set("Many edges", 2); arr[26].cor = 1;
            arr[27].start(); arr[27].q = "If least bit in binary number = zero then this number is :"; arr[27].set("Odd", 1); arr[27].set("Even", 2); arr[27].cor = 2;
            arr[28].start(); arr[28].q = "1<<5 is equal to :"; arr[28].set("2^5", 1); arr[28].set("5^2", 2); arr[28].cor = 1;
            arr[29].start(); arr[29].q = "vector<int> v={1,2,3};\nvector<int> c=move(v);\ncout<<v.size()\nWhat is the output?"; arr[29].set("0", 1); arr[29].set("3", 2); arr[29].cor = 1;
            return arr[i];
        }

        public play()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void pageTitle_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            c = 1;
            score = 0;
            ayman = true;
            Random i = new Random();
            string[] ss = new string[2];
            int[] sss = new int[2];
            int sha = 0;
            int rr = i.Next(level.delevel * 10, (level.delevel * 10) + 10);
            testqq.Text = demo(rr).q;

            foreach (KeyValuePair<string, int> kvp in demo(rr).a)
            {
                ss[sha] = kvp.Key;
                sss[sha++] = kvp.Value;

            }
            answer1.Content = ss[0];
            ans1 = sss[0];
            answer2.Content = ss[1];
            ans2 = sss[1];
            ans = demo(rr).cor;
        }

      
        private void testq(object sender, ContextMenuEventArgs e)
        {

        }

        private void tesstq(FrameworkElement sender, DataContextChangedEventArgs args)
        {

        }

        private void testqq_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void answer1_Click(object sender, RoutedEventArgs e)
        {
            if (c == 5 && ayman)
            {
                if (ans == 1) score++;
                ayman = false;
            }
            if (c == 5)
            {
                string f;
                if (score >= 3) f = "WOW, you answer most of them right";
                else f = "NOT good, go to learn page to improve your skills";
                testqq.Text = f;
                answer1.Content = "Play again";
                answer2.Content = "";
                c = -1;
            }

            else
            {
                if (c == -1)
                {
                    if (this.Frame != null)
                    {
                        this.Frame.Navigate(typeof(play));
                    }
                    Frame.BackStack.RemoveAt(Frame.BackStack.Count - 1);
                }
                if (ans == 1) score++;
                c++;
                Random i = new Random();
                string[] ss = new string[2];
                int[] sss = new int[2];
                int sha = 0;
                int rr = i.Next(level.delevel * 10, (level.delevel * 10) + 10);
                testqq.Text = demo(rr).q;

                foreach (KeyValuePair<string, int> kvp in demo(rr).a)
                {
                    ss[sha] = kvp.Key;
                    sss[sha++] = kvp.Value;

                }
                answer1.Content = ss[0];
                ans1 = sss[0];
                answer2.Content = ss[1];
                ans2 = sss[1];
                ans = demo(rr).cor;
            }
        }

        private void answer2_Click(object sender, RoutedEventArgs e)
        {

            if (c == 5 && ayman)
            {
                if (ans == 2) score++;
                ayman = false;
            }
            if (c != -1)
            {
                if (c == 5)
                {
                    string f;
                    if (score >= 3) f = "WOW, you answer most of them right";
                    else f = "NOT good, go to learn page to improve your skills";
                    testqq.Text = f;
                    answer1.Content = "Play again";
                    answer2.Content = "";
                    c = -1;
                }

                else
                {

                    if (ans == 2) score++;
                    c++;
                    Random i = new Random();
                    string[] ss = new string[2];
                    int[] sss = new int[2];
                    int sha = 0;
                    int rr = i.Next(level.delevel * 10, (level.delevel * 10) + 10);
                    testqq.Text = demo(rr).q;

                    foreach (KeyValuePair<string, int> kvp in demo(rr).a)
                    {
                        ss[sha] = kvp.Key;
                        sss[sha++] = kvp.Value;

                    }
                    answer1.Content = ss[0];
                    ans1 = sss[0];
                    answer2.Content = ss[1];
                    ans2 = sss[1];
                    ans = demo(rr).cor;
                }

            }
        }
    }
}
