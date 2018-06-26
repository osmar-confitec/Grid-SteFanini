using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite1;

public partial class _Default : Page
{
    public Cliente Cliente { get; set; }

    public string clientFormat { get; set; }

    public _Default()
    {
        clientFormat = "1s0";
        Cliente = new Cliente() { nome = "Osmar" };
    }

    public Cliente Getcliente() {
        return Cliente;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            MyLogisssn.ClientFormat = "opppppppppppppp";
            clientFormat = "tampinha";
        }
    }
}