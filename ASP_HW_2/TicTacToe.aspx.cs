using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Helpers;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class TicTacToe : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        {
          
            if ((Session["SessionID"] == null) || !Crypto.VerifyHashedPassword((Request.Cookies["user"]["SessionID"]).ToString(), Session["SessionID"].ToString()))
            {
                Label1.Text = "You are not authorized";
                container.Visible = false;
            }

            else
            {

                string turn = null;
                string whosetocheck;

                if (ViewState["turn"] != null)
                {
                    turn = ViewState["turn"].ToString();

                    whosetocheck = turn + "s";

                    if (ViewState[whosetocheck] == null)
                    {

                        ViewState[whosetocheck] = new List<int>();
                    }
                }

                else
                {
                    ViewState["turn"] = "X";
                }

                if (ViewState["BoardCellCounts"] == null)
                {
                    ViewState["BoardCellCounts"] = 0;
                }
            }
           
            
        }

 
    }

    
 

    protected void UpdateInstruction(object sender, EventArgs e)
    {

        if ((Session["SessionID"] == null) || !Crypto.VerifyHashedPassword((Request.Cookies["user"]["SessionID"]).ToString(), Session["SessionID"].ToString()))
        {
            Label1.Text = "You are not authorized";
            container.Visible = false;
        }


        else
        {
            
            Button buttonClicked = sender as Button;
            buttonClicked.Visible = false;
            string XorO = ViewState["turn"].ToString() + "s";

            

            if (buttonClicked.ID == "Button1")
            {
                Img1.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";
               
            }

            if (buttonClicked.ID == "Button2")
            {
                Img2.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            if (buttonClicked.ID == "Button3")
            {
                Img3.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            if (buttonClicked.ID == "Button4")
            {
                Img4.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            if (buttonClicked.ID == "Button5")
            {
                Img5.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            if (buttonClicked.ID == "Button6")
            {
                Img6.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            if (buttonClicked.ID == "Button7")
            {
                Img7.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            if (buttonClicked.ID == "Button8")
            {
                Img8.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            if (buttonClicked.ID == "Button9")
            {
                Img9.Src = "~/Content/" + ViewState["turn"].ToString() + ".PNG";

            }

            ViewState["BoardCellCounts"] = (int)ViewState["BoardCellCounts"] + 1;


            List<int> pattern = (List<int>)ViewState[XorO];
            pattern.Add(Convert.ToInt32(buttonClicked.ID.Substring(6)));
            ViewState[XorO] = pattern;

            

                if ((pattern.Contains(9) && pattern.Contains(8) && pattern.Contains(7)) || (pattern.Contains(6) && pattern.Contains(5) && pattern.Contains(4)) || (pattern.Contains(1) && pattern.Contains(2) && pattern.Contains(3)) || (pattern.Contains(7) && pattern.Contains(4) && pattern.Contains(1)) || (pattern.Contains(5) && pattern.Contains(2) && pattern.Contains(8)) || (pattern.Contains(9) && pattern.Contains(6) && pattern.Contains(3)) || (pattern.Contains(7) && pattern.Contains(5) && pattern.Contains(3)) || (pattern.Contains(1) && pattern.Contains(5) && pattern.Contains(9)))
                {
                    Label1.Text = "Player " + ViewState["turn"].ToString() + " wins.";
                    container.Style.Add("pointer-events","none");
                }

            else if ((int)ViewState["BoardCellCounts"] == 9)
            {
                Label1.Text = "The game is tied. Nobody wins.";
            }


            else
            {
                    if (ViewState["turn"].ToString() == "X")
                        ViewState["turn"] = "O";
                    else if (ViewState["turn"].ToString() == "O")
                        ViewState["turn"] = "X";

                    Label1.Text = "Current player is " + ViewState["turn"].ToString();
                }
                

        }

    }


}