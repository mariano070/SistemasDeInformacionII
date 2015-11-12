/*
               File: TTBUS007_p
        Description: Actualización de Permisos de Usuarios
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:38.55
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ttbus007_p : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A33TTBUS7_Pos) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A35TTBUS7_CodResp = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A35TTBUS7_CodResp) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A33TTBUS7_Pos) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A39TTBUS7_CodUsuario = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_10( A39TTBUS7_CodUsuario) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( ! entryPointCalled )
         {
            AV9TTBUS7_Pos = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9TTBUS7_Pos), 3, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV10TTBUS7_CodUsuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TTBUS7_CodUsuario", AV10TTBUS7_CodUsuario);
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV8USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
            }
         }
         chkTTBUS7_RespAux.Name = "TTBUS7_RESPAUX" ;
         chkTTBUS7_RespAux.WebTags = "" ;
         chkTTBUS7_RespAux.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Caption", chkTTBUS7_RespAux.Caption);
         chkTTBUS7_RespAux.CheckedValue = "0" ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Actualización de Permisos de Usuarios", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS7_Pos_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus007_p( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus007_p( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_TTBUS7_Pos ,
                           ref String aP1_TTBUS7_CodUsuario ,
                           ref String aP2_Gx_mode ,
                           ref String aP3_SISTEMA ,
                           ref String aP4_USUARIO )
      {
         this.AV9TTBUS7_Pos = aP0_TTBUS7_Pos;
         this.AV10TTBUS7_CodUsuario = aP1_TTBUS7_CodUsuario;
         this.Gx_mode = aP2_Gx_mode;
         this.AV7SISTEMA = aP3_SISTEMA;
         this.AV8USUARIO = aP4_USUARIO;
         executePrivate();
         aP0_TTBUS7_Pos=this.AV9TTBUS7_Pos;
         aP1_TTBUS7_CodUsuario=this.AV10TTBUS7_CodUsuario;
         aP2_Gx_mode=this.Gx_mode;
         aP3_SISTEMA=this.AV7SISTEMA;
         aP4_USUARIO=this.AV8USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkTTBUS7_RespAux = new GXCheckbox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_078( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_078e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_078( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_078( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_078e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Actualización de Permisos de Usuarios"+"</legend>") ;
            wb_table3_27_078( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_078e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_078e( true) ;
         }
         else
         {
            wb_table1_2_078e( false) ;
         }
      }

      protected void wb_table3_27_078( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_078( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_078e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS007_p.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS007_p.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_078e( true) ;
         }
         else
         {
            wb_table3_27_078e( false) ;
         }
      }

      protected void wb_table4_33_078( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_pos_Internalname, 1, 1, 0, "Id. de Posición", "", "", "", 0, lblTextblockttbus7_pos_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_Pos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtTTBUS7_Pos_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A33TTBUS7_Pos), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtTTBUS7_Pos_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS007_p.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_33_Internalname, "", "prompt.gif", "Modern", imgprompt_33_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_33_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_des_Internalname, 1, 1, 0, "Descripción posición", "", "", "", 0, lblTextblockttbus7_des_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_Des_Internalname, StringUtil.RTrim( A34TTBUS7_Des), "", 50, "chr", 1, "row", 50, 1, edtTTBUS7_Des_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A34TTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtTTBUS7_Des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_codresp_Internalname, 1, 1, 0, "Código Responsable", "", "", "", 0, lblTextblockttbus7_codresp_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_CodResp_Internalname, StringUtil.RTrim( A35TTBUS7_CodResp), "", 16, "chr", 1, "row", 16, 1, edtTTBUS7_CodResp_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A35TTBUS7_CodResp, "@!")), "", 0, edtTTBUS7_CodResp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_desresp_Internalname, 1, 1, 0, "Descripción Responsable", "", "", "", 0, lblTextblockttbus7_desresp_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_DesResp_Internalname, StringUtil.RTrim( A36TTBUS7_DesResp), "", 50, "chr", 1, "row", 50, 1, edtTTBUS7_DesResp_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A36TTBUS7_DesResp, "@!")), "", 0, edtTTBUS7_DesResp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_codusuario_Internalname, 1, 1, 0, "Cod. Usuario", "", "", "", 0, lblTextblockttbus7_codusuario_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_CodUsuario_Internalname, StringUtil.RTrim( A39TTBUS7_CodUsuario), "", 16, "chr", 1, "row", 16, 1, edtTTBUS7_CodUsuario_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A39TTBUS7_CodUsuario, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(58);\"", 0, edtTTBUS7_CodUsuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007_p.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_39_Internalname, "", "prompt.gif", "Modern", imgprompt_39_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_39_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_desusuario_Internalname, 1, 1, 0, "Desc. Usuario", "", "", "", 0, lblTextblockttbus7_desusuario_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_DesUsuario_Internalname, StringUtil.RTrim( A199TTBUS7_DesUsuario), "", 50, "chr", 1, "row", 50, 1, edtTTBUS7_DesUsuario_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A199TTBUS7_DesUsuario, "@!")), "", 0, edtTTBUS7_DesUsuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_respaux_Internalname, 1, 1, 0, "Responsable Auxiliar", "", "", "", 0, lblTextblockttbus7_respaux_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkTTBUS7_RespAux_Internalname, StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0), "", 1, chkTTBUS7_RespAux.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(68, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(68);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_078e( true) ;
         }
         else
         {
            wb_table4_33_078e( false) ;
         }
      }

      protected void wb_table2_5_078( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_POS"+"'), id:'"+"TTBUS7_POS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS7_CODUSUARIO"+"'), id:'"+"TTBUS7_CODUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_POS"+"'), id:'"+"TTBUS7_POS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS7_CODUSUARIO"+"'), id:'"+"TTBUS7_CODUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007_p.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_078e( true) ;
         }
         else
         {
            wb_table2_5_078e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS7_Pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS7_POS");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS7_Pos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A33TTBUS7_Pos = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               }
               else
               {
                  A33TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               }
               A34TTBUS7_Des = cgiGet( edtTTBUS7_Des_Internalname) ;
               n34TTBUS7_Des = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               A35TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtTTBUS7_CodResp_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtTTBUS7_DesResp_Internalname)) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               A39TTBUS7_CodUsuario = StringUtil.Upper( cgiGet( edtTTBUS7_CodUsuario_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               A199TTBUS7_DesUsuario = StringUtil.Upper( cgiGet( edtTTBUS7_DesUsuario_Internalname)) ;
               n199TTBUS7_DesUsuario = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
               if ( ! context.localUtil.VCNumber( cgiGet( chkTTBUS7_RespAux_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkTTBUS7_RespAux_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkTTBUS7_RespAux_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS7_RESPAUX");
                  AnyError = 1 ;
                  GX_FocusControl = chkTTBUS7_RespAux_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A51TTBUS7_RespAux = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
               }
               else
               {
                  A51TTBUS7_RespAux = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS7_RespAux_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
               }
               /* Read saved values. */
               Z33TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( "Z33TTBUS7_Pos"), ",", ".")) ;
               Z39TTBUS7_CodUsuario = cgiGet( "Z39TTBUS7_CodUsuario") ;
               Z51TTBUS7_RespAux = (short)(context.localUtil.CToN( cgiGet( "Z51TTBUS7_RespAux"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV8USUARIO = cgiGet( "vUSUARIO") ;
               AV9TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( "vTTBUS7_POS"), ",", ".")) ;
               AV10TTBUS7_CodUsuario = cgiGet( "vTTBUS7_CODUSUARIO") ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A39TTBUS7_CodUsuario = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode8 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode8 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound8 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_070( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "TTBUS7_POS");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll078( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            imgBtn_delete2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
            imgBtn_delete2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               imgBtn_enter2_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
               imgBtn_enter2_separator_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtTTBUS7_Pos_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
            edtTTBUS7_Des_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Des_Enabled), 5, 0)));
            edtTTBUS7_CodResp_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodResp_Enabled), 5, 0)));
            edtTTBUS7_DesResp_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_DesResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_DesResp_Enabled), 5, 0)));
            edtTTBUS7_CodUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0)));
            edtTTBUS7_DesUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_DesUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0)));
            chkTTBUS7_RespAux.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0)));
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_070( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls078( ) ;
            }
            else
            {
               CheckExtendedTable078( ) ;
               CloseExtendedTableCursors078( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption070( )
      {
      }

      protected void ZM078( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z51TTBUS7_RespAux = T00073_A51TTBUS7_RespAux[0] ;
            }
            else
            {
               Z51TTBUS7_RespAux = A51TTBUS7_RespAux ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z51TTBUS7_RespAux = A51TTBUS7_RespAux ;
            Z33TTBUS7_Pos = A33TTBUS7_Pos ;
            Z39TTBUS7_CodUsuario = A39TTBUS7_CodUsuario ;
            Z35TTBUS7_CodResp = A35TTBUS7_CodResp ;
            Z36TTBUS7_DesResp = A36TTBUS7_DesResp ;
            Z34TTBUS7_Des = A34TTBUS7_Des ;
            Z199TTBUS7_DesUsuario = A199TTBUS7_DesUsuario ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtTTBUS7_CodResp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodResp_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTTBUS7_Pos_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
         }
         else
         {
            edtTTBUS7_Pos_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
         }
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_POS"+"'), id:'"+"TTBUS7_POS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_39_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_CODUSUARIO"+"'), id:'"+"TTBUS7_CODUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         edtTTBUS7_CodResp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodResp_Enabled), 5, 0)));
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A33TTBUS7_Pos = AV9TTBUS7_Pos ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A39TTBUS7_CodUsuario = AV10TTBUS7_CodUsuario ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTTBUS7_Pos_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00074 */
            pr_default.execute(2, new Object[] {A33TTBUS7_Pos});
            A35TTBUS7_CodResp = T00074_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            pr_default.close(2);
            /* Using cursor T00075 */
            pr_default.execute(3, new Object[] {A35TTBUS7_CodResp});
            A36TTBUS7_DesResp = T00075_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T00075_n36TTBUS7_DesResp[0] ;
            pr_default.close(3);
            /* Using cursor T00076 */
            pr_default.execute(4, new Object[] {A33TTBUS7_Pos});
            A34TTBUS7_Des = T00076_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T00076_n34TTBUS7_Des[0] ;
            pr_default.close(4);
            /* Using cursor T00077 */
            pr_default.execute(5, new Object[] {A39TTBUS7_CodUsuario});
            A199TTBUS7_DesUsuario = T00077_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T00077_n199TTBUS7_DesUsuario[0] ;
            pr_default.close(5);
         }
      }

      protected void Load078( )
      {
         /* Using cursor T00078 */
         pr_default.execute(6, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound8 = 1 ;
            A34TTBUS7_Des = T00078_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T00078_n34TTBUS7_Des[0] ;
            A36TTBUS7_DesResp = T00078_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T00078_n36TTBUS7_DesResp[0] ;
            A199TTBUS7_DesUsuario = T00078_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T00078_n199TTBUS7_DesUsuario[0] ;
            A51TTBUS7_RespAux = T00078_A51TTBUS7_RespAux[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
            A35TTBUS7_CodResp = T00078_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            ZM078( -6) ;
         }
         pr_default.close(6);
         OnLoadActions078( ) ;
      }

      protected void OnLoadActions078( )
      {
      }

      protected void CheckExtendedTable078( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Maestro de Responsables de Posiciones'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A35TTBUS7_CodResp = T00074_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
         }
         pr_default.close(2);
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A35TTBUS7_CodResp});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Responsable de Posición'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A36TTBUS7_DesResp = T00075_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T00075_n36TTBUS7_DesResp[0] ;
         }
         pr_default.close(3);
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Maestro de Responsables de Posiciones'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A34TTBUS7_Des = T00076_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T00076_n34TTBUS7_Des[0] ;
         }
         pr_default.close(4);
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario con acceso a posicion trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A199TTBUS7_DesUsuario = T00077_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T00077_n199TTBUS7_DesUsuario[0] ;
         }
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors078( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_7( short A33TTBUS7_Pos )
      {
         /* Using cursor T00079 */
         pr_default.execute(7, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Maestro de Responsables de Posiciones'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A35TTBUS7_CodResp = T00079_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A35TTBUS7_CodResp))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_8( String A35TTBUS7_CodResp )
      {
         /* Using cursor T000710 */
         pr_default.execute(8, new Object[] {A35TTBUS7_CodResp});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Responsable de Posición'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A36TTBUS7_DesResp = T000710_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T000710_n36TTBUS7_DesResp[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A36TTBUS7_DesResp))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void gxLoad_9( short A33TTBUS7_Pos )
      {
         /* Using cursor T000711 */
         pr_default.execute(9, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Maestro de Responsables de Posiciones'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A34TTBUS7_Des = T000711_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T000711_n34TTBUS7_Des[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A34TTBUS7_Des))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(9);
      }

      protected void gxLoad_10( String A39TTBUS7_CodUsuario )
      {
         /* Using cursor T000712 */
         pr_default.execute(10, new Object[] {A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario con acceso a posicion trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A199TTBUS7_DesUsuario = T000712_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T000712_n199TTBUS7_DesUsuario[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A199TTBUS7_DesUsuario))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(10);
      }

      protected void GetKey078( )
      {
         /* Using cursor T000713 */
         pr_default.execute(11, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound8 = 1 ;
         }
         else
         {
            RcdFound8 = 0 ;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM078( 6) ;
            RcdFound8 = 1 ;
            A51TTBUS7_RespAux = T00073_A51TTBUS7_RespAux[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
            A33TTBUS7_Pos = T00073_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A39TTBUS7_CodUsuario = T00073_A39TTBUS7_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
            Z33TTBUS7_Pos = A33TTBUS7_Pos ;
            Z39TTBUS7_CodUsuario = A39TTBUS7_CodUsuario ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load078( ) ;
            Gx_mode = sMode8 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound8 = 0 ;
            InitializeNonKey078( ) ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode8 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey078( ) ;
         if ( RcdFound8 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound8 = 0 ;
         /* Using cursor T000714 */
         pr_default.execute(12, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000714_A33TTBUS7_Pos[0] < A33TTBUS7_Pos ) || ( T000714_A33TTBUS7_Pos[0] == A33TTBUS7_Pos ) && ( StringUtil.StrCmp(T000714_A39TTBUS7_CodUsuario[0], A39TTBUS7_CodUsuario) < 0 ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000714_A33TTBUS7_Pos[0] > A33TTBUS7_Pos ) || ( T000714_A33TTBUS7_Pos[0] == A33TTBUS7_Pos ) && ( StringUtil.StrCmp(T000714_A39TTBUS7_CodUsuario[0], A39TTBUS7_CodUsuario) > 0 ) ) )
            {
               A33TTBUS7_Pos = T000714_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A39TTBUS7_CodUsuario = T000714_A39TTBUS7_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               RcdFound8 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0 ;
         /* Using cursor T000715 */
         pr_default.execute(13, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( T000715_A33TTBUS7_Pos[0] > A33TTBUS7_Pos ) || ( T000715_A33TTBUS7_Pos[0] == A33TTBUS7_Pos ) && ( StringUtil.StrCmp(T000715_A39TTBUS7_CodUsuario[0], A39TTBUS7_CodUsuario) > 0 ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( T000715_A33TTBUS7_Pos[0] < A33TTBUS7_Pos ) || ( T000715_A33TTBUS7_Pos[0] == A33TTBUS7_Pos ) && ( StringUtil.StrCmp(T000715_A39TTBUS7_CodUsuario[0], A39TTBUS7_CodUsuario) < 0 ) ) )
            {
               A33TTBUS7_Pos = T000715_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A39TTBUS7_CodUsuario = T000715_A39TTBUS7_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               RcdFound8 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey078( ) ;
         if ( RcdFound8 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS7_POS");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( A33TTBUS7_Pos != Z33TTBUS7_Pos ) || ( StringUtil.StrCmp(A39TTBUS7_CodUsuario, Z39TTBUS7_CodUsuario) != 0 ) )
            {
               A33TTBUS7_Pos = Z33TTBUS7_Pos ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A39TTBUS7_CodUsuario = Z39TTBUS7_CodUsuario ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS7_POS");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update078( ) ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A33TTBUS7_Pos != Z33TTBUS7_Pos ) || ( StringUtil.StrCmp(A39TTBUS7_CodUsuario, Z39TTBUS7_CodUsuario) != 0 ) )
            {
               /* Insert record */
               Insert078( ) ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS7_POS");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS7_Pos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert078( ) ;
                  GX_FocusControl = edtTTBUS7_Pos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( ( A33TTBUS7_Pos != Z33TTBUS7_Pos ) || ( StringUtil.StrCmp(A39TTBUS7_CodUsuario, Z39TTBUS7_CodUsuario) != 0 ) )
         {
            A33TTBUS7_Pos = Z33TTBUS7_Pos ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A39TTBUS7_CodUsuario = Z39TTBUS7_CodUsuario ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency078( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000716 */
            pr_default.execute(14, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
            if ( (pr_default.getStatus(14) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS007Permisos"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(14) == 101) || ( Z51TTBUS7_RespAux != T000716_A51TTBUS7_RespAux[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS007Permisos"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert078( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable078( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM078( 0) ;
            CheckOptimisticConcurrency078( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm078( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000717 */
                     pr_default.execute(15, new Object[] {A51TTBUS7_RespAux, A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
                     pr_default.close(15);
                     if ( (pr_default.getStatus(15) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption070( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load078( ) ;
            }
            EndLevel078( ) ;
         }
         CloseExtendedTableCursors078( ) ;
      }

      protected void Update078( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable078( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency078( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm078( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000718 */
                     pr_default.execute(16, new Object[] {A51TTBUS7_RespAux, A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
                     pr_default.close(16);
                     if ( (pr_default.getStatus(16) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS007Permisos"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate078( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel078( ) ;
         }
         CloseExtendedTableCursors078( ) ;
      }

      protected void DeferredUpdate078( )
      {
      }

      protected void delete( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency078( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls078( ) ;
            AfterConfirm078( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete078( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000719 */
                  pr_default.execute(17, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
                  pr_default.close(17);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode8 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel078( ) ;
         Gx_mode = sMode8 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls078( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000720 */
            pr_default.execute(18, new Object[] {A33TTBUS7_Pos});
            A35TTBUS7_CodResp = T000720_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            pr_default.close(18);
            /* Using cursor T000721 */
            pr_default.execute(19, new Object[] {A35TTBUS7_CodResp});
            A36TTBUS7_DesResp = T000721_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T000721_n36TTBUS7_DesResp[0] ;
            pr_default.close(19);
            /* Using cursor T000722 */
            pr_default.execute(20, new Object[] {A33TTBUS7_Pos});
            A34TTBUS7_Des = T000722_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T000722_n34TTBUS7_Des[0] ;
            pr_default.close(20);
            /* Using cursor T000723 */
            pr_default.execute(21, new Object[] {A39TTBUS7_CodUsuario});
            A199TTBUS7_DesUsuario = T000723_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T000723_n199TTBUS7_DesUsuario[0] ;
            pr_default.close(21);
         }
      }

      protected void EndLevel078( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete078( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(18);
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(21);
            context.CommitDataStores("TTBUS007_p");
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(18);
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(21);
            context.RollbackDataStores("TTBUS007_p");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart078( )
      {
         /* Using cursor T000724 */
         pr_default.execute(22);
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound8 = 1 ;
            A33TTBUS7_Pos = T000724_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A39TTBUS7_CodUsuario = T000724_A39TTBUS7_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext078( )
      {
         pr_default.readNext(22);
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound8 = 1 ;
            A33TTBUS7_Pos = T000724_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A39TTBUS7_CodUsuario = T000724_A39TTBUS7_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         }
      }

      protected void ScanEnd078( )
      {
      }

      protected void AfterConfirm078( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert078( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate078( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete078( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete078( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate078( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues070( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus007_p.aspx") + "?" + UrlEncode("" +AV9TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(AV10TTBUS7_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z33TTBUS7_Pos", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z39TTBUS7_CodUsuario", StringUtil.RTrim( Z39TTBUS7_CodUsuario));
         GxWebStd.gx_hidden_field( context, "Z51TTBUS7_RespAux", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z51TTBUS7_RespAux), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "vTTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTTBUS7_CODUSUARIO", StringUtil.RTrim( AV10TTBUS7_CodUsuario));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "TTBUS007_p" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actualización de Permisos de Usuarios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus007_p.aspx") + "?" + UrlEncode("" +AV9TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(AV10TTBUS7_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void InitializeNonKey078( )
      {
         A34TTBUS7_Des = "" ;
         n34TTBUS7_Des = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
         A35TTBUS7_CodResp = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
         A36TTBUS7_DesResp = "" ;
         n36TTBUS7_DesResp = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
         A199TTBUS7_DesUsuario = "" ;
         n199TTBUS7_DesUsuario = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
         A51TTBUS7_RespAux = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
      }

      protected void InitAll078( )
      {
         A33TTBUS7_Pos = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
         A39TTBUS7_CodUsuario = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         InitializeNonKey078( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19293974");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus007_p.js", "?19293974");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockttbus7_pos_Internalname = "TEXTBLOCKTTBUS7_POS" ;
         edtTTBUS7_Pos_Internalname = "TTBUS7_POS" ;
         lblTextblockttbus7_des_Internalname = "TEXTBLOCKTTBUS7_DES" ;
         edtTTBUS7_Des_Internalname = "TTBUS7_DES" ;
         lblTextblockttbus7_codresp_Internalname = "TEXTBLOCKTTBUS7_CODRESP" ;
         edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP" ;
         lblTextblockttbus7_desresp_Internalname = "TEXTBLOCKTTBUS7_DESRESP" ;
         edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP" ;
         lblTextblockttbus7_codusuario_Internalname = "TEXTBLOCKTTBUS7_CODUSUARIO" ;
         edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO" ;
         lblTextblockttbus7_desusuario_Internalname = "TEXTBLOCKTTBUS7_DESUSUARIO" ;
         edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO" ;
         lblTextblockttbus7_respaux_Internalname = "TEXTBLOCKTTBUS7_RESPAUX" ;
         chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_33_Internalname = "PROMPT_33" ;
         imgprompt_39_Internalname = "PROMPT_39" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Actualización de Permisos de Usuarios" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         chkTTBUS7_RespAux.Enabled = 1 ;
         edtTTBUS7_DesUsuario_Jsonclick = "" ;
         edtTTBUS7_DesUsuario_Enabled = 0 ;
         imgprompt_39_Visible = 1 ;
         imgprompt_39_Link = "" ;
         edtTTBUS7_CodUsuario_Jsonclick = "" ;
         edtTTBUS7_CodUsuario_Enabled = 1 ;
         edtTTBUS7_DesResp_Jsonclick = "" ;
         edtTTBUS7_DesResp_Enabled = 0 ;
         edtTTBUS7_CodResp_Jsonclick = "" ;
         edtTTBUS7_CodResp_Enabled = 0 ;
         edtTTBUS7_Des_Jsonclick = "" ;
         edtTTBUS7_Des_Enabled = 0 ;
         imgprompt_33_Visible = 1 ;
         imgprompt_33_Link = "" ;
         edtTTBUS7_Pos_Jsonclick = "" ;
         edtTTBUS7_Pos_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         chkTTBUS7_RespAux.Caption = "" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Ttbus7_pos( short GX_Parm1 ,
                                    String GX_Parm2 ,
                                    String GX_Parm3 ,
                                    String GX_Parm4 )
      {
         A33TTBUS7_Pos = GX_Parm1 ;
         A35TTBUS7_CodResp = GX_Parm2 ;
         A36TTBUS7_DesResp = GX_Parm3 ;
         n36TTBUS7_DesResp = false ;
         A34TTBUS7_Des = GX_Parm4 ;
         n34TTBUS7_Des = false ;
         /* Using cursor T000720 */
         pr_default.execute(18, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Maestro de Responsables de Posiciones'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A35TTBUS7_CodResp = T000720_A35TTBUS7_CodResp[0] ;
         }
         pr_default.close(18);
         /* Using cursor T000721 */
         pr_default.execute(19, new Object[] {A35TTBUS7_CodResp});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No existe 'Responsable de Posición'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A36TTBUS7_DesResp = T000721_A36TTBUS7_DesResp[0] ;
            n36TTBUS7_DesResp = T000721_n36TTBUS7_DesResp[0] ;
         }
         pr_default.close(19);
         /* Using cursor T000722 */
         pr_default.execute(20, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GX_msglist.addItem("No existe 'Maestro de Responsables de Posiciones'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A34TTBUS7_Des = T000722_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = T000722_n34TTBUS7_Des[0] ;
         }
         pr_default.close(20);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A35TTBUS7_CodResp = "" ;
            A36TTBUS7_DesResp = "" ;
            n36TTBUS7_DesResp = false ;
            A34TTBUS7_Des = "" ;
            n34TTBUS7_Des = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A35TTBUS7_CodResp)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A36TTBUS7_DesResp)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A34TTBUS7_Des)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Ttbus7_codusuario( String GX_Parm1 ,
                                           String GX_Parm2 )
      {
         A39TTBUS7_CodUsuario = GX_Parm1 ;
         A199TTBUS7_DesUsuario = GX_Parm2 ;
         n199TTBUS7_DesUsuario = false ;
         /* Using cursor T000723 */
         pr_default.execute(21, new Object[] {A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario con acceso a posicion trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A199TTBUS7_DesUsuario = T000723_A199TTBUS7_DesUsuario[0] ;
            n199TTBUS7_DesUsuario = T000723_n199TTBUS7_DesUsuario[0] ;
         }
         pr_default.close(21);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A199TTBUS7_DesUsuario = "" ;
            n199TTBUS7_DesUsuario = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A199TTBUS7_DesUsuario)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(22);
         pr_default.close(13);
         pr_default.close(12);
         pr_default.close(18);
         pr_default.close(19);
         pr_default.close(20);
         pr_default.close(21);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOAV10TTBUS7_CodUsuario = "" ;
         wcpOGx_mode = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A35TTBUS7_CodResp = "" ;
         A39TTBUS7_CodUsuario = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockttbus7_pos_Jsonclick = "" ;
         lblTextblockttbus7_des_Jsonclick = "" ;
         A34TTBUS7_Des = "" ;
         lblTextblockttbus7_codresp_Jsonclick = "" ;
         lblTextblockttbus7_desresp_Jsonclick = "" ;
         A36TTBUS7_DesResp = "" ;
         lblTextblockttbus7_codusuario_Jsonclick = "" ;
         lblTextblockttbus7_desusuario_Jsonclick = "" ;
         A199TTBUS7_DesUsuario = "" ;
         lblTextblockttbus7_respaux_Jsonclick = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z39TTBUS7_CodUsuario = "" ;
         sMode8 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z35TTBUS7_CodResp = "" ;
         Z36TTBUS7_DesResp = "" ;
         Z34TTBUS7_Des = "" ;
         Z199TTBUS7_DesUsuario = "" ;
         T00074_A35TTBUS7_CodResp = new String[] {""} ;
         T00075_A36TTBUS7_DesResp = new String[] {""} ;
         T00075_n36TTBUS7_DesResp = new bool[] {false} ;
         T00076_A34TTBUS7_Des = new String[] {""} ;
         T00076_n34TTBUS7_Des = new bool[] {false} ;
         T00077_A199TTBUS7_DesUsuario = new String[] {""} ;
         T00077_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T00078_A34TTBUS7_Des = new String[] {""} ;
         T00078_n34TTBUS7_Des = new bool[] {false} ;
         T00078_A36TTBUS7_DesResp = new String[] {""} ;
         T00078_n36TTBUS7_DesResp = new bool[] {false} ;
         T00078_A199TTBUS7_DesUsuario = new String[] {""} ;
         T00078_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T00078_A51TTBUS7_RespAux = new short[1] ;
         T00078_A33TTBUS7_Pos = new short[1] ;
         T00078_A35TTBUS7_CodResp = new String[] {""} ;
         T00078_A39TTBUS7_CodUsuario = new String[] {""} ;
         T00079_A35TTBUS7_CodResp = new String[] {""} ;
         T000710_A36TTBUS7_DesResp = new String[] {""} ;
         T000710_n36TTBUS7_DesResp = new bool[] {false} ;
         T000711_A34TTBUS7_Des = new String[] {""} ;
         T000711_n34TTBUS7_Des = new bool[] {false} ;
         T000712_A199TTBUS7_DesUsuario = new String[] {""} ;
         T000712_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T000713_A33TTBUS7_Pos = new short[1] ;
         T000713_A39TTBUS7_CodUsuario = new String[] {""} ;
         T00073_A51TTBUS7_RespAux = new short[1] ;
         T00073_A33TTBUS7_Pos = new short[1] ;
         T00073_A39TTBUS7_CodUsuario = new String[] {""} ;
         T000714_A33TTBUS7_Pos = new short[1] ;
         T000714_A39TTBUS7_CodUsuario = new String[] {""} ;
         T000715_A33TTBUS7_Pos = new short[1] ;
         T000715_A39TTBUS7_CodUsuario = new String[] {""} ;
         T000716_A51TTBUS7_RespAux = new short[1] ;
         T000716_A33TTBUS7_Pos = new short[1] ;
         T000716_A39TTBUS7_CodUsuario = new String[] {""} ;
         T000720_A35TTBUS7_CodResp = new String[] {""} ;
         T000721_A36TTBUS7_DesResp = new String[] {""} ;
         T000721_n36TTBUS7_DesResp = new bool[] {false} ;
         T000722_A34TTBUS7_Des = new String[] {""} ;
         T000722_n34TTBUS7_Des = new bool[] {false} ;
         T000723_A199TTBUS7_DesUsuario = new String[] {""} ;
         T000723_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T000724_A33TTBUS7_Pos = new short[1] ;
         T000724_A39TTBUS7_CodUsuario = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus007_p__default(),
            new Object[][] {
                new Object[] {
               T00072_A51TTBUS7_RespAux, T00072_A33TTBUS7_Pos, T00072_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T00073_A51TTBUS7_RespAux, T00073_A33TTBUS7_Pos, T00073_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T00074_A35TTBUS7_CodResp
               }
               , new Object[] {
               T00075_A36TTBUS7_DesResp, T00075_n36TTBUS7_DesResp
               }
               , new Object[] {
               T00076_A34TTBUS7_Des, T00076_n34TTBUS7_Des
               }
               , new Object[] {
               T00077_A199TTBUS7_DesUsuario, T00077_n199TTBUS7_DesUsuario
               }
               , new Object[] {
               T00078_A34TTBUS7_Des, T00078_n34TTBUS7_Des, T00078_A36TTBUS7_DesResp, T00078_n36TTBUS7_DesResp, T00078_A199TTBUS7_DesUsuario, T00078_n199TTBUS7_DesUsuario, T00078_A51TTBUS7_RespAux, T00078_A33TTBUS7_Pos, T00078_A35TTBUS7_CodResp, T00078_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T00079_A35TTBUS7_CodResp
               }
               , new Object[] {
               T000710_A36TTBUS7_DesResp, T000710_n36TTBUS7_DesResp
               }
               , new Object[] {
               T000711_A34TTBUS7_Des, T000711_n34TTBUS7_Des
               }
               , new Object[] {
               T000712_A199TTBUS7_DesUsuario, T000712_n199TTBUS7_DesUsuario
               }
               , new Object[] {
               T000713_A33TTBUS7_Pos, T000713_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T000714_A33TTBUS7_Pos, T000714_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T000715_A33TTBUS7_Pos, T000715_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T000716_A51TTBUS7_RespAux, T000716_A33TTBUS7_Pos, T000716_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000720_A35TTBUS7_CodResp
               }
               , new Object[] {
               T000721_A36TTBUS7_DesResp, T000721_n36TTBUS7_DesResp
               }
               , new Object[] {
               T000722_A34TTBUS7_Des, T000722_n34TTBUS7_Des
               }
               , new Object[] {
               T000723_A199TTBUS7_DesUsuario, T000723_n199TTBUS7_DesUsuario
               }
               , new Object[] {
               T000724_A33TTBUS7_Pos, T000724_A39TTBUS7_CodUsuario
               }
            }
         );
      }

      private short wcpOAV9TTBUS7_Pos ;
      private short GxWebError ;
      private short A33TTBUS7_Pos ;
      private short AV9TTBUS7_Pos ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A51TTBUS7_RespAux ;
      private short Z33TTBUS7_Pos ;
      private short Z51TTBUS7_RespAux ;
      private short RcdFound8 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtTTBUS7_Pos_Enabled ;
      private int imgprompt_33_Visible ;
      private int edtTTBUS7_Des_Enabled ;
      private int edtTTBUS7_CodResp_Enabled ;
      private int edtTTBUS7_DesResp_Enabled ;
      private int edtTTBUS7_CodUsuario_Enabled ;
      private int imgprompt_39_Visible ;
      private int edtTTBUS7_DesUsuario_Enabled ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOAV10TTBUS7_CodUsuario ;
      private String wcpOGx_mode ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private String AV10TTBUS7_CodUsuario ;
      private String Gx_mode ;
      private String AV7SISTEMA ;
      private String AV8USUARIO ;
      private String chkTTBUS7_RespAux_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS7_Pos_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus7_pos_Internalname ;
      private String lblTextblockttbus7_pos_Jsonclick ;
      private String edtTTBUS7_Pos_Jsonclick ;
      private String imgprompt_33_Internalname ;
      private String imgprompt_33_Link ;
      private String lblTextblockttbus7_des_Internalname ;
      private String lblTextblockttbus7_des_Jsonclick ;
      private String edtTTBUS7_Des_Internalname ;
      private String A34TTBUS7_Des ;
      private String edtTTBUS7_Des_Jsonclick ;
      private String lblTextblockttbus7_codresp_Internalname ;
      private String lblTextblockttbus7_codresp_Jsonclick ;
      private String edtTTBUS7_CodResp_Internalname ;
      private String edtTTBUS7_CodResp_Jsonclick ;
      private String lblTextblockttbus7_desresp_Internalname ;
      private String lblTextblockttbus7_desresp_Jsonclick ;
      private String edtTTBUS7_DesResp_Internalname ;
      private String A36TTBUS7_DesResp ;
      private String edtTTBUS7_DesResp_Jsonclick ;
      private String lblTextblockttbus7_codusuario_Internalname ;
      private String lblTextblockttbus7_codusuario_Jsonclick ;
      private String edtTTBUS7_CodUsuario_Internalname ;
      private String edtTTBUS7_CodUsuario_Jsonclick ;
      private String imgprompt_39_Internalname ;
      private String imgprompt_39_Link ;
      private String lblTextblockttbus7_desusuario_Internalname ;
      private String lblTextblockttbus7_desusuario_Jsonclick ;
      private String edtTTBUS7_DesUsuario_Internalname ;
      private String A199TTBUS7_DesUsuario ;
      private String edtTTBUS7_DesUsuario_Jsonclick ;
      private String lblTextblockttbus7_respaux_Internalname ;
      private String lblTextblockttbus7_respaux_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String Z39TTBUS7_CodUsuario ;
      private String sMode8 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z35TTBUS7_CodResp ;
      private String Z36TTBUS7_DesResp ;
      private String Z34TTBUS7_Des ;
      private String Z199TTBUS7_DesUsuario ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n34TTBUS7_Des ;
      private bool n36TTBUS7_DesResp ;
      private bool n199TTBUS7_DesUsuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private short aP0_TTBUS7_Pos ;
      private String aP1_TTBUS7_CodUsuario ;
      private String aP2_Gx_mode ;
      private String aP3_SISTEMA ;
      private String aP4_USUARIO ;
      private GXCheckbox chkTTBUS7_RespAux ;
      private IDataStoreProvider pr_default ;
      private String[] T00074_A35TTBUS7_CodResp ;
      private String[] T00075_A36TTBUS7_DesResp ;
      private bool[] T00075_n36TTBUS7_DesResp ;
      private String[] T00076_A34TTBUS7_Des ;
      private bool[] T00076_n34TTBUS7_Des ;
      private String[] T00077_A199TTBUS7_DesUsuario ;
      private bool[] T00077_n199TTBUS7_DesUsuario ;
      private String[] T00078_A34TTBUS7_Des ;
      private bool[] T00078_n34TTBUS7_Des ;
      private String[] T00078_A36TTBUS7_DesResp ;
      private bool[] T00078_n36TTBUS7_DesResp ;
      private String[] T00078_A199TTBUS7_DesUsuario ;
      private bool[] T00078_n199TTBUS7_DesUsuario ;
      private short[] T00078_A51TTBUS7_RespAux ;
      private short[] T00078_A33TTBUS7_Pos ;
      private String[] T00078_A35TTBUS7_CodResp ;
      private String[] T00078_A39TTBUS7_CodUsuario ;
      private String[] T00079_A35TTBUS7_CodResp ;
      private String[] T000710_A36TTBUS7_DesResp ;
      private bool[] T000710_n36TTBUS7_DesResp ;
      private String[] T000711_A34TTBUS7_Des ;
      private bool[] T000711_n34TTBUS7_Des ;
      private String[] T000712_A199TTBUS7_DesUsuario ;
      private bool[] T000712_n199TTBUS7_DesUsuario ;
      private short[] T000713_A33TTBUS7_Pos ;
      private String[] T000713_A39TTBUS7_CodUsuario ;
      private short[] T00073_A51TTBUS7_RespAux ;
      private short[] T00073_A33TTBUS7_Pos ;
      private String[] T00073_A39TTBUS7_CodUsuario ;
      private short[] T000714_A33TTBUS7_Pos ;
      private String[] T000714_A39TTBUS7_CodUsuario ;
      private short[] T000715_A33TTBUS7_Pos ;
      private String[] T000715_A39TTBUS7_CodUsuario ;
      private short[] T000716_A51TTBUS7_RespAux ;
      private short[] T000716_A33TTBUS7_Pos ;
      private String[] T000716_A39TTBUS7_CodUsuario ;
      private String[] T000720_A35TTBUS7_CodResp ;
      private String[] T000721_A36TTBUS7_DesResp ;
      private bool[] T000721_n36TTBUS7_DesResp ;
      private String[] T000722_A34TTBUS7_Des ;
      private bool[] T000722_n34TTBUS7_Des ;
      private String[] T000723_A199TTBUS7_DesUsuario ;
      private bool[] T000723_n199TTBUS7_DesUsuario ;
      private short[] T000724_A33TTBUS7_Pos ;
      private String[] T000724_A39TTBUS7_CodUsuario ;
      private short[] T00072_A51TTBUS7_RespAux ;
      private short[] T00072_A33TTBUS7_Pos ;
      private String[] T00072_A39TTBUS7_CodUsuario ;
      private GXWebForm Form ;
   }

   public class ttbus007_p__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000712 ;
          prmT000712 = new Object[] {
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000713 ;
          prmT000713 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000714 ;
          prmT000714 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000715 ;
          prmT000715 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000716 ;
          prmT000716 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000717 ;
          prmT000717 = new Object[] {
          new Object[] {"@TTBUS7_RespAux",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000718 ;
          prmT000718 = new Object[] {
          new Object[] {"@TTBUS7_RespAux",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000719 ;
          prmT000719 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000724 ;
          prmT000724 = new Object[] {
          } ;
          Object[] prmT000720 ;
          prmT000720 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000721 ;
          prmT000721 = new Object[] {
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000722 ;
          prmT000722 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000723 ;
          prmT000723 = new Object[] {
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT [TTBUS7_RespAux], [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (UPDLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,false )
             ,new CursorDef("T00073", "SELECT [TTBUS7_RespAux], [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,false )
             ,new CursorDef("T00074", "SELECT [TTBUS7_CodResp] AS TTBUS7_CodResp FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,1,0,true,false )
             ,new CursorDef("T00075", "SELECT [USU_DES] AS TTBUS7_DesResp FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodResp ",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1,0,true,false )
             ,new CursorDef("T00076", "SELECT [W53DES] AS TTBUS7_Des FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,false )
             ,new CursorDef("T00077", "SELECT [USU_DES] AS TTBUS7_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1,0,true,false )
             ,new CursorDef("T00078", "SELECT T4.[W53DES] AS TTBUS7_Des, T3.[USU_DES] AS TTBUS7_DesResp, T5.[USU_DES] AS TTBUS7_DesUsuario, TM1.[TTBUS7_RespAux], TM1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[TTBUS7_CodResp] AS TTBUS7_CodResp, TM1.[TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM (((([TTBUS007Permisos] TM1 WITH (NOLOCK) INNER JOIN [TTBUS007] T2 WITH (NOLOCK) ON T2.[TTBUS7_Pos] = TM1.[TTBUS7_Pos]) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T2.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T4 WITH (NOLOCK) ON T4.[W53POS] = TM1.[TTBUS7_Pos]) INNER JOIN [SEG002] T5 WITH (NOLOCK) ON T5.[USU_COD] = TM1.[TTBUS7_CodUsuario]) WHERE TM1.[TTBUS7_Pos] = @TTBUS7_Pos and TM1.[TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ORDER BY TM1.[TTBUS7_Pos], TM1.[TTBUS7_CodUsuario]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00078,100,0,true,false )
             ,new CursorDef("T00079", "SELECT [TTBUS7_CodResp] AS TTBUS7_CodResp FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT00079,1,0,true,false )
             ,new CursorDef("T000710", "SELECT [USU_DES] AS TTBUS7_DesResp FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodResp ",true, GxErrorMask.GX_NOMASK, false, this,prmT000710,1,0,true,false )
             ,new CursorDef("T000711", "SELECT [W53DES] AS TTBUS7_Des FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT000711,1,0,true,false )
             ,new CursorDef("T000712", "SELECT [USU_DES] AS TTBUS7_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000712,1,0,true,false )
             ,new CursorDef("T000713", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000713,1,0,true,false )
             ,new CursorDef("T000714", "SELECT TOP 1 [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE ( [TTBUS7_Pos] > @TTBUS7_Pos or [TTBUS7_Pos] = @TTBUS7_Pos and [TTBUS7_CodUsuario] > @TTBUS7_CodUsuario) ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000714,1,0,true,true )
             ,new CursorDef("T000715", "SELECT TOP 1 [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE ( [TTBUS7_Pos] < @TTBUS7_Pos or [TTBUS7_Pos] = @TTBUS7_Pos and [TTBUS7_CodUsuario] < @TTBUS7_CodUsuario) ORDER BY [TTBUS7_Pos] DESC, [TTBUS7_CodUsuario] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000715,1,0,true,true )
             ,new CursorDef("T000716", "SELECT [TTBUS7_RespAux], [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (UPDLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000716,1,0,true,false )
             ,new CursorDef("T000717", "INSERT INTO [TTBUS007Permisos] ([TTBUS7_RespAux], [TTBUS7_Pos], [TTBUS7_CodUsuario]) VALUES (@TTBUS7_RespAux, @TTBUS7_Pos, @TTBUS7_CodUsuario)", GxErrorMask.GX_NOMASK,prmT000717)
             ,new CursorDef("T000718", "UPDATE [TTBUS007Permisos] SET [TTBUS7_RespAux]=@TTBUS7_RespAux  WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario", GxErrorMask.GX_NOMASK,prmT000718)
             ,new CursorDef("T000719", "DELETE FROM [TTBUS007Permisos]  WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario", GxErrorMask.GX_NOMASK,prmT000719)
             ,new CursorDef("T000720", "SELECT [TTBUS7_CodResp] AS TTBUS7_CodResp FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT000720,1,0,true,false )
             ,new CursorDef("T000721", "SELECT [USU_DES] AS TTBUS7_DesResp FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodResp ",true, GxErrorMask.GX_NOMASK, false, this,prmT000721,1,0,true,false )
             ,new CursorDef("T000722", "SELECT [W53DES] AS TTBUS7_Des FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT000722,1,0,true,false )
             ,new CursorDef("T000723", "SELECT [USU_DES] AS TTBUS7_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000723,1,0,true,false )
             ,new CursorDef("T000724", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000724,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((String[]) buf[8])[0] = rslt.getString(6, 16) ;
                ((String[]) buf[9])[0] = rslt.getString(7, 16) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
