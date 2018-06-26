using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite1;

public partial class ControlesUsuario_grid : System.Web.UI.UserControl
{
    private bool _online;

    public Filtros<Paginacao> Filtros { get; set; }

    public Cliente Clientesss { get; set; }

    public string ClientFormat { get; set; }

    public bool Online
    {
        get { return _online; }
        set { _online = value; }
    }

    public ControlesUsuario_grid()
    {
        Clientesss = new Cliente();
    }

    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }
}