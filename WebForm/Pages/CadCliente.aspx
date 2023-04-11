<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadCliente.aspx.cs" Inherits="WebForm.CadCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset style="margin: 5% 0 0 0">
        <legend>Cliente</legend>

        <p>
            <asp:Label Text="Codigo Cliente" runat="server" />
            <asp:Label Text="0" runat="server" ID="hdIdSelecionado" />
        </p>
        <p>
            <asp:Label Text="CPF:" runat="server" />
            <asp:TextBox runat="server" ID="txtCPF" />



            <asp:Label Text="Nome:" runat="server" />
            <asp:TextBox Width="750px" runat="server" ID="txtNome" />
        </p>
        <p>
            <asp:Label Text="RG:" runat="server" />
            <asp:TextBox runat="server" ID="txtRG" />


            <asp:Label Text="Data Expedicao:" runat="server" />
            <asp:TextBox runat="server" ID="txtData_Expedicao" />


            <asp:Label Text="Orgão Expedicão:" runat="server" />
            <asp:DropDownList runat="server" ID="dllOrgao">
                <asp:ListItem Text="SP" />
                <asp:ListItem Text="RJ" />
            </asp:DropDownList>
        
            <asp:Label Text="UF:" runat="server" />
            <asp:DropDownList runat="server" ID="ddlUF">
                <asp:ListItem Text="SP" />
                <asp:ListItem Text="RJ" />
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label Text="Data Nascimento:" runat="server" />
            <asp:TextBox runat="server" ID="txtDataNascimento" AutoCompleteType="Cellular" />

            <asp:Label Text="Sexo:" runat="server" />
            <asp:DropDownList runat="server" ID="ddlSexo">
                <asp:ListItem Text="Feminino" />
                <asp:ListItem Text="Masculino" />
            </asp:DropDownList>
         
            <asp:Label Text="Estado Civil:" runat="server" />
            <asp:DropDownList runat="server" ID="ddlEstadoCivil">
                <asp:ListItem Text="Solteiro" />
                <asp:ListItem Text="Casado" />
                <asp:ListItem Text="Amasiado" />
            </asp:DropDownList>
        </p>
        <asp:GridView ID="gridCliente" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridCliente_SelectedIndexChanged"
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
            CellPadding="3" CellSpacing="2" AutoGenerateColumns="False">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
            <Columns>
                <asp:BoundField HeaderText="CPF" DataField="CPF" />
                <asp:BoundField HeaderText="ClienteId" DataField="ClienteId" />
                <asp:BoundField HeaderText="DT Expedicao" DataField="Data_Expedicao" />
                <asp:BoundField HeaderText="DT Nasc" DataField="Data_de_Nascimento" />
                <asp:BoundField HeaderText="Estado Civil" DataField="Estado_Civil" />
                <asp:BoundField HeaderText="Nome" DataField="Nome" />
                <asp:BoundField HeaderText="O Expedicao" DataField="Orgao_Expedicao" />
                <asp:BoundField HeaderText="RG" DataField="RG" />
                <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
                <asp:BoundField HeaderText="UF" DataField="UF" />
            </Columns>
        </asp:GridView>
    </fieldset>
    <p>
        <asp:Button Text="Atualizar" ID="btnAtualizar" OnClick="btnAtualizar_Click" runat="server" />
    </p>
    <p>
        <fieldset>
            <legend>Endereco</legend>
            <p>
                <asp:Label Text="Codigo Endereco" runat="server" />
                <asp:Label Text="0" runat="server" ID="lblIDEndereco" />
            </p>
            <p>
                <asp:Label Text="CEP:" runat="server" />
                <asp:TextBox runat="server" ID="txtCEP" />

                <asp:Button Text="PesquisarCEP" ID="btnPesquisarCEP" OnClick="btnPesquisarCEP_Click" runat="server" />

                <asp:Label Text="Rua:" runat="server" />
                <asp:TextBox runat="server" ID="txtRua" />


                <asp:Label Text="Numero:" runat="server" />
                <asp:TextBox runat="server" ID="txtNumero" />
            </p>
            <p>
                <asp:Label Text="Complemento:" runat="server" />
                <asp:TextBox runat="server" ID="txtCompleto" />

                <asp:Label Text="Bairro:" runat="server" />
                <asp:TextBox runat="server" ID="txtBairro" />

                <asp:Label Text="Cidade:" runat="server" />
                <asp:TextBox runat="server" ID="txtCidade" />

                <asp:DropDownList runat="server" ID="ddlUFEnd">
                    <asp:ListItem Text="SP" />
                    <asp:ListItem Text="RJ" />
                </asp:DropDownList>
            </p>
            <p>
                <asp:GridView ID="gridClienteEndereco" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridClienteEndereco_SelectedIndexChanged"
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                    CellPadding="3" CellSpacing="2" AutoGenerateColumns="False">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                    <Columns>
                        <asp:BoundField HeaderText="EnderecoId" DataField="EnderecoId" />
                        <asp:BoundField HeaderText="ClienteId" DataField="ClienteId" />
                        <asp:BoundField HeaderText="CEP" DataField="CEP" />
                        <asp:BoundField HeaderText="Logradouro" DataField="Logradouro" />
                        <asp:BoundField HeaderText="Numero" DataField="Numero" />
                        <asp:BoundField HeaderText="Complemento" DataField="Complemento" />
                        <asp:BoundField HeaderText="Bairro" DataField="Bairro" />
                        <asp:BoundField HeaderText="Cidade" DataField="Cidade" />
                        <asp:BoundField HeaderText="UF" DataField="UF" />
                    </Columns>
                </asp:GridView>
            </p>

        </fieldset>
    </p>
    <p>
        <asp:Button Text="Atualizar" ID="btnAtualizarEndereco" OnClick="btnAtualizarEndereco_Click" runat="server" />
    </p>
    <ajaxtoolkit:maskededitextender targetcontrolid="txtCPF" mask="999.999.999-99"
        messagevalidatortip="true" onfocuscssclass="MaskedEditFocus" oninvalidcssclass="MaskedEditError"
        masktype="Number" inputdirection="LeftToRight" acceptnegative="None" displaymoney="None"
        errortooltipenabled="True" runat="server" id="mskCPF" />
    <ajaxtoolkit:maskededitextender targetcontrolid="txtNumero" mask="9999"
        messagevalidatortip="true" onfocuscssclass="MaskedEditFocus" oninvalidcssclass="MaskedEditError"
        masktype="Number" inputdirection="LeftToRight" acceptnegative="None" displaymoney="None"
        errortooltipenabled="True" runat="server" id="MaskedEditExtender4" />
    <ajaxtoolkit:maskededitextender targetcontrolid="txtCEP" mask="99999-999"
        messagevalidatortip="true" onfocuscssclass="MaskedEditFocus" oninvalidcssclass="MaskedEditError"
        masktype="Number" inputdirection="LeftToRight" acceptnegative="None" displaymoney="None"
        errortooltipenabled="True" runat="server" id="MaskedEditExtender5" />
    <ajaxtoolkit:maskededitextender targetcontrolid="txtDataNascimento" mask="99/99/9999"
        messagevalidatortip="true" onfocuscssclass="MaskedEditFocus" oninvalidcssclass="MaskedEditError"
        masktype="Date" inputdirection="LeftToRight" acceptnegative="None" displaymoney="None"
        errortooltipenabled="True" runat="server" id="MaskedEditExtender3" />
    <ajaxtoolkit:maskededitextender targetcontrolid="txtData_Expedicao" mask="99/99/9999"
        messagevalidatortip="true" onfocuscssclass="MaskedEditFocus" oninvalidcssclass="MaskedEditError"
        masktype="Date" inputdirection="LeftToRight" acceptnegative="None" displaymoney="None"
        errortooltipenabled="True" runat="server" id="MaskedEditExtender2" />
    <ajaxtoolkit:maskededitextender targetcontrolid="txtRG" mask="99.999.999-9"
        messagevalidatortip="true" onfocuscssclass="MaskedEditFocus" oninvalidcssclass="MaskedEditError"
        masktype="Number" inputdirection="LeftToRight" acceptnegative="None" displaymoney="None"
        errortooltipenabled="True" runat="server" id="MaskedEditExtender1" />
</asp:Content>
