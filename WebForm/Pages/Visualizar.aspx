<%@ Page Title="Visualizar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Visualizar.aspx.cs" Inherits="WebForm.Visualizar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <h3>Cliente</h3>



    <table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>Nome           </th>
                <th>CPF                 </th>
                <th>RG                  </th>
                <th>Data_Expedicao      </th>
                <th>Orgao_Expedicao     </th>
                <th>UF                  </th>
                <th>Data_de_Nascimento</th>
                <th>Sexo              </th>
                <th>Estado_Civil      </th>
                <th>Alterar      </th>
                <!-- ... outras colunas ... -->
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="ClientesRepeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapse<%# Container.ItemIndex %>" aria-expanded="true" aria-controls="collapse<%# Container.ItemIndex %>">
                                <%# Eval("Nome") %>
                            </button>
                        </td>
                        <td><%# Eval("CPF") %></td>
                        <td><%# Eval("RG") %></td>
                        <td><%# Eval("Data_Expedicao") %></td>
                        <td><%# Eval("Orgao_Expedicao") %></td>
                        <td><%# Eval("UF") %></td>
                        <td><%# Eval("Data_de_Nascimento") %></td>
                        <td><%# Eval("Sexo") %></td>
                        <td><%# Eval("Estado_Civil") %></td>
                        <td>
                            <asp:Button Text="Alterar" runat="server" id="alterar" CommandArgument='<%# Eval("ClienteId") %>' OnCommand="alterar_Command" />

                        </td>
                        <!-- ... outras colunas ... -->
                    </tr>
                    <tr>
                        <td colspan="100%">
                            <div id="collapse<%# Container.ItemIndex %>" class="collapse" aria-labelledby="heading<%# Container.ItemIndex %>" data-parent="#ClientesRepeater">
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>

                                            <th>CEP          </th>
                                            <th>Logradouro   </th>
                                            <th>Numero       </th>
                                            <th>Complemento  </th>
                                            <th>Bairro       </th>
                                            <th>Cidade       </th>
                                            <th>UF           </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Repeater ID="EnderecosRepeater" runat="server" DataSource='<%# Eval("ClienteEndereco") %>'>
                                            <ItemTemplate>
                                                <tr>

                                                    <td><%# Eval("CEP") %></td>
                                                    <td><%# Eval("Logradouro") %></td>
                                                    <td><%# Eval("Numero") %></td>
                                                    <td><%# Eval("Complemento") %></td>
                                                    <td><%# Eval("Bairro") %></td>
                                                    <td><%# Eval("Cidade") %></td>
                                                    <td><%# Eval("UF") %></td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>



</asp:Content>
