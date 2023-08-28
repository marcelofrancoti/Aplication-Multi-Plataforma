using System;
using System.Web.UI;

public partial class DetalhesCliente : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Carregar os dados...
        }
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        // Redirecionar para a página anterior...
    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        // Redirecionar para a página de edição...
    }
}
