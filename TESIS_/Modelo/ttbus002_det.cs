/*
               File: TTBUS002_Det
        Description: Detalle de movimientos de bienes de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:20.91
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
   public class ttbus002_det : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A52TTBUS2_IdMovimiento = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_2( A52TTBUS2_IdMovimiento) ;
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
         cmbTTBUS2_TipoResp.Name = "TTBUS2_TIPORESP" ;
         cmbTTBUS2_TipoResp.WebTags = "" ;
         cmbTTBUS2_TipoResp.addItem("E", "Envía", 0);
         cmbTTBUS2_TipoResp.addItem("R", "Recibe", 0);
         if ( ( cmbTTBUS2_TipoResp.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A102TTBUS2_TipoResp)) )
         {
            A102TTBUS2_TipoResp = cmbTTBUS2_TipoResp.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Detalle de movimientos de bienes de uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus002_det( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus002_det( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbTTBUS2_TipoResp = new GXCombobox();
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
            wb_table1_2_0A10( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0A10e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0A10( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0A10( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0A10e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Detalle de movimientos de bienes de uso"+"</legend>") ;
            wb_table3_27_0A10( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0A10e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0A10e( true) ;
         }
         else
         {
            wb_table1_2_0A10e( false) ;
         }
      }

      protected void wb_table3_27_0A10( bool wbgen )
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
            wb_table4_33_0A10( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0A10e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS002_Det.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS002_Det.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS002_Det.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0A10e( true) ;
         }
         else
         {
            wb_table3_27_0A10e( false) ;
         }
      }

      protected void wb_table4_33_0A10( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_idmovimiento_Internalname, 1, 1, 0, "Id Movimiento", "", "", "", 0, lblTextblockttbus2_idmovimiento_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002_Det.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_IdMovimiento_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")), "", 12, "chr", 1, "row", 12, 1, edtTTBUS2_IdMovimiento_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A52TTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtTTBUS2_IdMovimiento_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002_Det.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_52_Internalname, "", "prompt.gif", "Modern", imgprompt_52_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_52_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS002_Det.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_idusuario_Internalname, 1, 1, 0, "Usuario", "", "", "", 0, lblTextblockttbus2_idusuario_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002_Det.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_IdUsuario_Internalname, StringUtil.RTrim( A53TTBUS2_IdUsuario), "", 16, "chr", 1, "row", 16, 1, edtTTBUS2_IdUsuario_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A53TTBUS2_IdUsuario, "XXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", 0, edtTTBUS2_IdUsuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS002_Det.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_tiporesp_Internalname, 1, 1, 0, "Envía/ Recibe)", "", "", "", 0, lblTextblockttbus2_tiporesp_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002_Det.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTTBUS2_TipoResp, cmbTTBUS2_TipoResp_Internalname, A102TTBUS2_TipoResp, "", "char", 1, cmbTTBUS2_TipoResp.Enabled, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbTTBUS2_TipoResp_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", true, "HLP_TTBUS002_Det.htm");
            cmbTTBUS2_TipoResp.CurrentValue = A102TTBUS2_TipoResp ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS2_TipoResp_Internalname, "Values", (String)(cmbTTBUS2_TipoResp.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0A10e( true) ;
         }
         else
         {
            wb_table4_33_0A10e( false) ;
         }
      }

      protected void wb_table2_5_0A10( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS2_IDMOVIMIENTO"+"'), id:'"+"TTBUS2_IDMOVIMIENTO"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS2_IDUSUARIO"+"'), id:'"+"TTBUS2_IDUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS2_IDMOVIMIENTO"+"'), id:'"+"TTBUS2_IDMOVIMIENTO"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS2_IDUSUARIO"+"'), id:'"+"TTBUS2_IDUSUARIO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002_Det.htm");
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
            wb_table2_5_0A10e( true) ;
         }
         else
         {
            wb_table2_5_0A10e( false) ;
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
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS2_IdMovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS2_IdMovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS2_IdMovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS2_IDMOVIMIENTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A52TTBUS2_IdMovimiento = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               }
               else
               {
                  A52TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtTTBUS2_IdMovimiento_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               }
               A53TTBUS2_IdUsuario = cgiGet( edtTTBUS2_IdUsuario_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
               cmbTTBUS2_TipoResp.CurrentValue = cgiGet( cmbTTBUS2_TipoResp_Internalname) ;
               A102TTBUS2_TipoResp = cgiGet( cmbTTBUS2_TipoResp_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
               /* Read saved values. */
               Z52TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( "Z52TTBUS2_IdMovimiento"), ",", ".")) ;
               Z53TTBUS2_IdUsuario = cgiGet( "Z53TTBUS2_IdUsuario") ;
               Z102TTBUS2_TipoResp = cgiGet( "Z102TTBUS2_TipoResp") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
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
                  A52TTBUS2_IdMovimiento = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
                  A53TTBUS2_IdUsuario = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
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
               InitAll0A10( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
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
         edtTTBUS2_IdMovimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_IdMovimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_IdMovimiento_Enabled), 5, 0)));
         edtTTBUS2_IdUsuario_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_IdUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_IdUsuario_Enabled), 5, 0)));
         cmbTTBUS2_TipoResp.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS2_TipoResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTTBUS2_TipoResp.Enabled), 5, 0)));
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

      protected void ResetCaption0A0( )
      {
      }

      protected void ZM0A10( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z102TTBUS2_TipoResp = T000A3_A102TTBUS2_TipoResp[0] ;
            }
            else
            {
               Z102TTBUS2_TipoResp = A102TTBUS2_TipoResp ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z53TTBUS2_IdUsuario = A53TTBUS2_IdUsuario ;
            Z102TTBUS2_TipoResp = A102TTBUS2_TipoResp ;
            Z52TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_52_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS2_IDMOVIMIENTO"+"'), id:'"+"TTBUS2_IDMOVIMIENTO"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
      }

      protected void standaloneModal( )
      {
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
      }

      protected void Load0A10( )
      {
         /* Using cursor T000A5 */
         pr_default.execute(3, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound10 = 1 ;
            A102TTBUS2_TipoResp = T000A5_A102TTBUS2_TipoResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
            ZM0A10( -1) ;
         }
         pr_default.close(3);
         OnLoadActions0A10( ) ;
      }

      protected void OnLoadActions0A10( )
      {
      }

      protected void CheckExtendedTable0A10( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000A4 */
         pr_default.execute(2, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Movimientos de Bienes de Uso'.", "ForeignKeyNotFound", 1, "TTBUS2_IDMOVIMIENTO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0A10( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound10 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void gxLoad_2( long A52TTBUS2_IdMovimiento )
      {
         /* Using cursor T000A6 */
         pr_default.execute(4, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Movimientos de Bienes de Uso'.", "ForeignKeyNotFound", 1, "TTBUS2_IDMOVIMIENTO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0A10( )
      {
         /* Using cursor T000A7 */
         pr_default.execute(5, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound10 = 1 ;
         }
         else
         {
            RcdFound10 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000A3 */
         pr_default.execute(1, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A10( 1) ;
            RcdFound10 = 1 ;
            A53TTBUS2_IdUsuario = T000A3_A53TTBUS2_IdUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
            A102TTBUS2_TipoResp = T000A3_A102TTBUS2_TipoResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
            A52TTBUS2_IdMovimiento = T000A3_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            Z52TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            Z53TTBUS2_IdUsuario = A53TTBUS2_IdUsuario ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0A10( ) ;
            Gx_mode = sMode10 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0 ;
            InitializeNonKey0A10( ) ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode10 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound10 = 0 ;
         /* Using cursor T000A8 */
         pr_default.execute(6, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000A8_A52TTBUS2_IdMovimiento[0] < A52TTBUS2_IdMovimiento ) || ( T000A8_A52TTBUS2_IdMovimiento[0] == A52TTBUS2_IdMovimiento ) && ( StringUtil.StrCmp(T000A8_A53TTBUS2_IdUsuario[0], A53TTBUS2_IdUsuario) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000A8_A52TTBUS2_IdMovimiento[0] > A52TTBUS2_IdMovimiento ) || ( T000A8_A52TTBUS2_IdMovimiento[0] == A52TTBUS2_IdMovimiento ) && ( StringUtil.StrCmp(T000A8_A53TTBUS2_IdUsuario[0], A53TTBUS2_IdUsuario) > 0 ) ) )
            {
               A52TTBUS2_IdMovimiento = T000A8_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               A53TTBUS2_IdUsuario = T000A8_A53TTBUS2_IdUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0 ;
         /* Using cursor T000A9 */
         pr_default.execute(7, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000A9_A52TTBUS2_IdMovimiento[0] > A52TTBUS2_IdMovimiento ) || ( T000A9_A52TTBUS2_IdMovimiento[0] == A52TTBUS2_IdMovimiento ) && ( StringUtil.StrCmp(T000A9_A53TTBUS2_IdUsuario[0], A53TTBUS2_IdUsuario) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000A9_A52TTBUS2_IdMovimiento[0] < A52TTBUS2_IdMovimiento ) || ( T000A9_A52TTBUS2_IdMovimiento[0] == A52TTBUS2_IdMovimiento ) && ( StringUtil.StrCmp(T000A9_A53TTBUS2_IdUsuario[0], A53TTBUS2_IdUsuario) < 0 ) ) )
            {
               A52TTBUS2_IdMovimiento = T000A9_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               A53TTBUS2_IdUsuario = T000A9_A53TTBUS2_IdUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0A10( ) ;
         if ( RcdFound10 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS2_IDMOVIMIENTO");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento ) || ( StringUtil.StrCmp(A53TTBUS2_IdUsuario, Z53TTBUS2_IdUsuario) != 0 ) )
            {
               A52TTBUS2_IdMovimiento = Z52TTBUS2_IdMovimiento ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               A53TTBUS2_IdUsuario = Z53TTBUS2_IdUsuario ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS2_IDMOVIMIENTO");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0A10( ) ;
               GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento ) || ( StringUtil.StrCmp(A53TTBUS2_IdUsuario, Z53TTBUS2_IdUsuario) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert0A10( ) ;
               GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS2_IDMOVIMIENTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert0A10( ) ;
                  GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento ) || ( StringUtil.StrCmp(A53TTBUS2_IdUsuario, Z53TTBUS2_IdUsuario) != 0 ) )
         {
            A52TTBUS2_IdMovimiento = Z52TTBUS2_IdMovimiento ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A53TTBUS2_IdUsuario = Z53TTBUS2_IdUsuario ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS2_IDMOVIMIENTO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "TTBUS2_IDMOVIMIENTO");
            AnyError = 1 ;
         }
         GX_FocusControl = cmbTTBUS2_TipoResp_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbTTBUS2_TipoResp_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A10( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbTTBUS2_TipoResp_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbTTBUS2_TipoResp_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound10 != 0 )
            {
               ScanNext0A10( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbTTBUS2_TipoResp_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A10( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000A10 */
            pr_default.execute(8, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS002_Det"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z102TTBUS2_TipoResp, T000A10_A102TTBUS2_TipoResp[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS002_Det"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A10( 0) ;
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A11 */
                     pr_default.execute(9, new Object[] {A53TTBUS2_IdUsuario, A102TTBUS2_TipoResp, A52TTBUS2_IdMovimiento});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 1) )
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
                           ResetCaption0A0( ) ;
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
               Load0A10( ) ;
            }
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void Update0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A12 */
                     pr_default.execute(10, new Object[] {A102TTBUS2_TipoResp, A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS002_Det"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0A10( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption0A0( ) ;
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
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void DeferredUpdate0A10( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A10( ) ;
            AfterConfirm0A10( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A10( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A13 */
                  pr_default.execute(11, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound10 == 0 )
                        {
                           InitAll0A10( ) ;
                           Gx_mode = "INS" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                        ResetCaption0A0( ) ;
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
         sMode10 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0A10( ) ;
         Gx_mode = sMode10 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A10( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("TTBUS002_Det");
            if ( AnyError == 0 )
            {
               ConfirmValues0A0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("TTBUS002_Det");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0A10( )
      {
         /* Using cursor T000A14 */
         pr_default.execute(12);
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound10 = 1 ;
            A52TTBUS2_IdMovimiento = T000A14_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A53TTBUS2_IdUsuario = T000A14_A53TTBUS2_IdUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A10( )
      {
         pr_default.readNext(12);
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound10 = 1 ;
            A52TTBUS2_IdMovimiento = T000A14_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A53TTBUS2_IdUsuario = T000A14_A53TTBUS2_IdUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
         }
      }

      protected void ScanEnd0A10( )
      {
      }

      protected void AfterConfirm0A10( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A10( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A10( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A10( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A10( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A10( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0A0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus002_det.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52TTBUS2_IdMovimiento), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z53TTBUS2_IdUsuario", StringUtil.RTrim( Z53TTBUS2_IdUsuario));
         GxWebStd.gx_hidden_field( context, "Z102TTBUS2_TipoResp", StringUtil.RTrim( Z102TTBUS2_TipoResp));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
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
         return "TTBUS002_Det" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalle de movimientos de bienes de uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus002_det.aspx")  ;
      }

      protected void InitializeNonKey0A10( )
      {
         A102TTBUS2_TipoResp = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
      }

      protected void InitAll0A10( )
      {
         A52TTBUS2_IdMovimiento = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         A53TTBUS2_IdUsuario = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
         InitializeNonKey0A10( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11472162");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus002_det.js", "?11472162");
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
         lblTextblockttbus2_idmovimiento_Internalname = "TEXTBLOCKTTBUS2_IDMOVIMIENTO" ;
         edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO" ;
         lblTextblockttbus2_idusuario_Internalname = "TEXTBLOCKTTBUS2_IDUSUARIO" ;
         edtTTBUS2_IdUsuario_Internalname = "TTBUS2_IDUSUARIO" ;
         lblTextblockttbus2_tiporesp_Internalname = "TEXTBLOCKTTBUS2_TIPORESP" ;
         cmbTTBUS2_TipoResp_Internalname = "TTBUS2_TIPORESP" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_52_Internalname = "PROMPT_52" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Detalle de movimientos de bienes de uso" ;
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
         cmbTTBUS2_TipoResp_Jsonclick = "" ;
         cmbTTBUS2_TipoResp.Enabled = 1 ;
         edtTTBUS2_IdUsuario_Jsonclick = "" ;
         edtTTBUS2_IdUsuario_Enabled = 1 ;
         imgprompt_52_Visible = 1 ;
         imgprompt_52_Link = "" ;
         edtTTBUS2_IdMovimiento_Jsonclick = "" ;
         edtTTBUS2_IdMovimiento_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000A15 */
         pr_default.execute(13, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Movimientos de Bienes de Uso'.", "ForeignKeyNotFound", 1, "TTBUS2_IDMOVIMIENTO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(13);
         GX_FocusControl = cmbTTBUS2_TipoResp_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ttbus2_idmovimiento( long GX_Parm1 )
      {
         A52TTBUS2_IdMovimiento = GX_Parm1 ;
         /* Using cursor T000A15 */
         pr_default.execute(13, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Movimientos de Bienes de Uso'.", "ForeignKeyNotFound", 1, "TTBUS2_IDMOVIMIENTO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(13);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Ttbus2_idusuario( long GX_Parm1 ,
                                          String GX_Parm2 ,
                                          GXCombobox cmbGX_Parm3 )
      {
         A52TTBUS2_IdMovimiento = GX_Parm1 ;
         A53TTBUS2_IdUsuario = GX_Parm2 ;
         cmbTTBUS2_TipoResp = cmbGX_Parm3 ;
         A102TTBUS2_TipoResp = cmbTTBUS2_TipoResp.CurrentValue ;
         cmbTTBUS2_TipoResp.CurrentValue = A102TTBUS2_TipoResp ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         cmbTTBUS2_TipoResp.CurrentValue = A102TTBUS2_TipoResp ;
         isValidOutput.Add((Object)(cmbTTBUS2_TipoResp));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52TTBUS2_IdMovimiento), 12, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z53TTBUS2_IdUsuario)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z102TTBUS2_TipoResp)));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
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
         pr_default.close(12);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A102TTBUS2_TipoResp = "" ;
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
         lblTextblockttbus2_idmovimiento_Jsonclick = "" ;
         lblTextblockttbus2_idusuario_Jsonclick = "" ;
         A53TTBUS2_IdUsuario = "" ;
         lblTextblockttbus2_tiporesp_Jsonclick = "" ;
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
         Z53TTBUS2_IdUsuario = "" ;
         Z102TTBUS2_TipoResp = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000A5_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000A5_A102TTBUS2_TipoResp = new String[] {""} ;
         T000A5_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A4_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A6_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A7_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A7_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000A3_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000A3_A102TTBUS2_TipoResp = new String[] {""} ;
         T000A3_A52TTBUS2_IdMovimiento = new long[1] ;
         sMode10 = "" ;
         T000A8_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A8_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000A9_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A9_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000A10_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000A10_A102TTBUS2_TipoResp = new String[] {""} ;
         T000A10_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A14_A52TTBUS2_IdMovimiento = new long[1] ;
         T000A14_A53TTBUS2_IdUsuario = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T000A15_A52TTBUS2_IdMovimiento = new long[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus002_det__default(),
            new Object[][] {
                new Object[] {
               T000A2_A53TTBUS2_IdUsuario, T000A2_A102TTBUS2_TipoResp, T000A2_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T000A3_A53TTBUS2_IdUsuario, T000A3_A102TTBUS2_TipoResp, T000A3_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T000A4_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T000A5_A53TTBUS2_IdUsuario, T000A5_A102TTBUS2_TipoResp, T000A5_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T000A6_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T000A7_A52TTBUS2_IdMovimiento, T000A7_A53TTBUS2_IdUsuario
               }
               , new Object[] {
               T000A8_A52TTBUS2_IdMovimiento, T000A8_A53TTBUS2_IdUsuario
               }
               , new Object[] {
               T000A9_A52TTBUS2_IdMovimiento, T000A9_A53TTBUS2_IdUsuario
               }
               , new Object[] {
               T000A10_A53TTBUS2_IdUsuario, T000A10_A102TTBUS2_TipoResp, T000A10_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A14_A52TTBUS2_IdMovimiento, T000A14_A53TTBUS2_IdUsuario
               }
               , new Object[] {
               T000A15_A52TTBUS2_IdMovimiento
               }
            }
         );
      }

      private short RcdFound10 ;
      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtTTBUS2_IdMovimiento_Enabled ;
      private int imgprompt_52_Visible ;
      private int edtTTBUS2_IdUsuario_Enabled ;
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
      private long A52TTBUS2_IdMovimiento ;
      private long Z52TTBUS2_IdMovimiento ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A102TTBUS2_TipoResp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS2_IdMovimiento_Internalname ;
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
      private String lblTextblockttbus2_idmovimiento_Internalname ;
      private String lblTextblockttbus2_idmovimiento_Jsonclick ;
      private String edtTTBUS2_IdMovimiento_Jsonclick ;
      private String imgprompt_52_Internalname ;
      private String imgprompt_52_Link ;
      private String lblTextblockttbus2_idusuario_Internalname ;
      private String lblTextblockttbus2_idusuario_Jsonclick ;
      private String edtTTBUS2_IdUsuario_Internalname ;
      private String A53TTBUS2_IdUsuario ;
      private String edtTTBUS2_IdUsuario_Jsonclick ;
      private String lblTextblockttbus2_tiporesp_Internalname ;
      private String lblTextblockttbus2_tiporesp_Jsonclick ;
      private String cmbTTBUS2_TipoResp_Internalname ;
      private String cmbTTBUS2_TipoResp_Jsonclick ;
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
      private String Z53TTBUS2_IdUsuario ;
      private String Z102TTBUS2_TipoResp ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode10 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTTBUS2_TipoResp ;
      private IDataStoreProvider pr_default ;
      private String[] T000A5_A53TTBUS2_IdUsuario ;
      private String[] T000A5_A102TTBUS2_TipoResp ;
      private long[] T000A5_A52TTBUS2_IdMovimiento ;
      private long[] T000A4_A52TTBUS2_IdMovimiento ;
      private long[] T000A6_A52TTBUS2_IdMovimiento ;
      private long[] T000A7_A52TTBUS2_IdMovimiento ;
      private String[] T000A7_A53TTBUS2_IdUsuario ;
      private String[] T000A3_A53TTBUS2_IdUsuario ;
      private String[] T000A3_A102TTBUS2_TipoResp ;
      private long[] T000A3_A52TTBUS2_IdMovimiento ;
      private long[] T000A8_A52TTBUS2_IdMovimiento ;
      private String[] T000A8_A53TTBUS2_IdUsuario ;
      private long[] T000A9_A52TTBUS2_IdMovimiento ;
      private String[] T000A9_A53TTBUS2_IdUsuario ;
      private String[] T000A10_A53TTBUS2_IdUsuario ;
      private String[] T000A10_A102TTBUS2_TipoResp ;
      private long[] T000A10_A52TTBUS2_IdMovimiento ;
      private long[] T000A14_A52TTBUS2_IdMovimiento ;
      private String[] T000A14_A53TTBUS2_IdUsuario ;
      private long[] T000A15_A52TTBUS2_IdMovimiento ;
      private String[] T000A2_A53TTBUS2_IdUsuario ;
      private String[] T000A2_A102TTBUS2_TipoResp ;
      private long[] T000A2_A52TTBUS2_IdMovimiento ;
      private GXWebForm Form ;
   }

   public class ttbus002_det__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000A2 ;
          prmT000A2 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A5 ;
          prmT000A5 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A4 ;
          prmT000A4 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000A6 ;
          prmT000A6 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000A7 ;
          prmT000A7 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A3 ;
          prmT000A3 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A8 ;
          prmT000A8 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A9 ;
          prmT000A9 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A10 ;
          prmT000A10 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A11 ;
          prmT000A11 = new Object[] {
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS2_TipoResp",SqlDbType.Char,1,0} ,
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000A12 ;
          prmT000A12 = new Object[] {
          new Object[] {"@TTBUS2_TipoResp",SqlDbType.Char,1,0} ,
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A13 ;
          prmT000A13 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000A14 ;
          prmT000A14 = new Object[] {
          } ;
          Object[] prmT000A15 ;
          prmT000A15 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000A2", "SELECT [TTBUS2_IdUsuario], [TTBUS2_TipoResp], [TTBUS2_IdMovimiento] FROM [TTBUS002_Det] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento AND [TTBUS2_IdUsuario] = @TTBUS2_IdUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A2,1,0,true,false )
             ,new CursorDef("T000A3", "SELECT [TTBUS2_IdUsuario], [TTBUS2_TipoResp], [TTBUS2_IdMovimiento] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento AND [TTBUS2_IdUsuario] = @TTBUS2_IdUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A3,1,0,true,false )
             ,new CursorDef("T000A4", "SELECT [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A4,1,0,true,false )
             ,new CursorDef("T000A5", "SELECT TM1.[TTBUS2_IdUsuario], TM1.[TTBUS2_TipoResp], TM1.[TTBUS2_IdMovimiento] FROM [TTBUS002_Det] TM1 WITH (NOLOCK) WHERE TM1.[TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento and TM1.[TTBUS2_IdUsuario] = @TTBUS2_IdUsuario ORDER BY TM1.[TTBUS2_IdMovimiento], TM1.[TTBUS2_IdUsuario]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A5,100,0,true,false )
             ,new CursorDef("T000A6", "SELECT [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A6,1,0,true,false )
             ,new CursorDef("T000A7", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento AND [TTBUS2_IdUsuario] = @TTBUS2_IdUsuario  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A7,1,0,true,false )
             ,new CursorDef("T000A8", "SELECT TOP 1 [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE ( [TTBUS2_IdMovimiento] > @TTBUS2_IdMovimiento or [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento and [TTBUS2_IdUsuario] > @TTBUS2_IdUsuario) ORDER BY [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A8,1,0,true,true )
             ,new CursorDef("T000A9", "SELECT TOP 1 [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE ( [TTBUS2_IdMovimiento] < @TTBUS2_IdMovimiento or [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento and [TTBUS2_IdUsuario] < @TTBUS2_IdUsuario) ORDER BY [TTBUS2_IdMovimiento] DESC, [TTBUS2_IdUsuario] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A9,1,0,true,true )
             ,new CursorDef("T000A10", "SELECT [TTBUS2_IdUsuario], [TTBUS2_TipoResp], [TTBUS2_IdMovimiento] FROM [TTBUS002_Det] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento AND [TTBUS2_IdUsuario] = @TTBUS2_IdUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A10,1,0,true,false )
             ,new CursorDef("T000A11", "INSERT INTO [TTBUS002_Det] ([TTBUS2_IdUsuario], [TTBUS2_TipoResp], [TTBUS2_IdMovimiento]) VALUES (@TTBUS2_IdUsuario, @TTBUS2_TipoResp, @TTBUS2_IdMovimiento)", GxErrorMask.GX_NOMASK,prmT000A11)
             ,new CursorDef("T000A12", "UPDATE [TTBUS002_Det] SET [TTBUS2_TipoResp]=@TTBUS2_TipoResp  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento AND [TTBUS2_IdUsuario] = @TTBUS2_IdUsuario", GxErrorMask.GX_NOMASK,prmT000A12)
             ,new CursorDef("T000A13", "DELETE FROM [TTBUS002_Det]  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento AND [TTBUS2_IdUsuario] = @TTBUS2_IdUsuario", GxErrorMask.GX_NOMASK,prmT000A13)
             ,new CursorDef("T000A14", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] FROM [TTBUS002_Det] WITH (NOLOCK) ORDER BY [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A14,100,0,true,false )
             ,new CursorDef("T000A15", "SELECT [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A15,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                break;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                break;
             case 12 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 13 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (long)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
       }
    }

 }

}
