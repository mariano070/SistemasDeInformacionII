/*
               File: TTBUS002
        Description: Historial de Ubicaciones de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:19.14
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
   public class ttbus002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS2_MOTIVOENVIO") == 0 )
         {
            A47TTBUS2_MotivoEnvio = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXSGATTBUS2_MOTIVOENVIO090( A47TTBUS2_MotivoEnvio) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS2_OBSERVACIONES") == 0 )
         {
            A87TTBUS2_Observaciones = GetNextPar( ) ;
            n87TTBUS2_Observaciones = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXSGATTBUS2_OBSERVACIONES090( A87TTBUS2_Observaciones) ;
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
         cmbTTBUS2_EstadoEnvio.Name = "TTBUS2_ESTADOENVIO" ;
         cmbTTBUS2_EstadoEnvio.WebTags = "" ;
         cmbTTBUS2_EstadoEnvio.addItem("1", "No Finalizado", 0);
         cmbTTBUS2_EstadoEnvio.addItem("2", "Finalizado", 0);
         cmbTTBUS2_EstadoEnvio.addItem("3", "Cancelado", 0);
         if ( ( cmbTTBUS2_EstadoEnvio.ItemCount > 0 ) && (0==A26TTBUS2_EstadoEnvio) )
         {
            A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbTTBUS2_EstadoEnvio.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Historial de Ubicaciones de Bienes de Uso", 0) ;
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

      public ttbus002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus002( IGxContext context )
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
         cmbTTBUS2_EstadoEnvio = new GXCombobox();
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
            wb_table1_2_095( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_095e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_095( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_095( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_095e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Historial de Ubicaciones de Bienes de Uso"+"</legend>") ;
            wb_table3_27_095( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_095e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_095e( true) ;
         }
         else
         {
            wb_table1_2_095e( false) ;
         }
      }

      protected void wb_table3_27_095( bool wbgen )
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
            wb_table4_33_095( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_095e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS002.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS002.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_095e( true) ;
         }
         else
         {
            wb_table3_27_095e( false) ;
         }
      }

      protected void wb_table4_33_095( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_idmovimiento_Internalname, 1, 1, 0, "Movimiento", "", "", "", 0, lblTextblockttbus2_idmovimiento_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_IdMovimiento_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")), "", 12, "chr", 1, "row", 12, 1, edtTTBUS2_IdMovimiento_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A52TTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtTTBUS2_IdMovimiento_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_idbien_Internalname, 1, 1, 0, "Bien", "", "", "", 0, lblTextblockttbus2_idbien_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_IdBien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtTTBUS2_IdBien_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A22TTBUS2_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(43);\"", 0, edtTTBUS2_IdBien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_codposdesde_Internalname, 1, 1, 0, "Posición Desde", "", "", "", 0, lblTextblockttbus2_codposdesde_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_CodPosDesde_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48TTBUS2_CodPosDesde), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtTTBUS2_CodPosDesde_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A48TTBUS2_CodPosDesde), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtTTBUS2_CodPosDesde_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_respdesde_Internalname, 1, 1, 0, "de envío", "", "", "", 0, lblTextblockttbus2_respdesde_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_RespDesde_Internalname, StringUtil.RTrim( A24TTBUS2_RespDesde), "", 15, "chr", 1, "row", 15, 1, edtTTBUS2_RespDesde_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A24TTBUS2_RespDesde, "XXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", 0, edtTTBUS2_RespDesde_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_fechaenvio_Internalname, 1, 1, 0, "de envío", "", "", "", 0, lblTextblockttbus2_fechaenvio_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS2_FechaEnvio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_FechaEnvio_Internalname, context.localUtil.Format(A45TTBUS2_FechaEnvio, "99/99/9999 99:99"), "", 16, "chr", 1, "row", 16, 1, edtTTBUS2_FechaEnvio_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A45TTBUS2_FechaEnvio, "99/99/9999 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(58);\"", 0, edtTTBUS2_FechaEnvio_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS2_FechaEnvio_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS2_FechaEnvio_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS002.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_codposhacia_Internalname, 1, 1, 0, "Posición Hacia", "", "", "", 0, lblTextblockttbus2_codposhacia_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_CodPosHacia_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A49TTBUS2_CodPosHacia), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtTTBUS2_CodPosHacia_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A49TTBUS2_CodPosHacia), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(63);\"", 0, edtTTBUS2_CodPosHacia_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_resphacia_Internalname, 1, 1, 0, "de recepción", "", "", "", 0, lblTextblockttbus2_resphacia_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_RespHacia_Internalname, StringUtil.RTrim( A25TTBUS2_RespHacia), "", 15, "chr", 1, "row", 15, 1, edtTTBUS2_RespHacia_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A25TTBUS2_RespHacia, "XXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, edtTTBUS2_RespHacia_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_fecharecepcion_Internalname, 1, 1, 0, "de recepción", "", "", "", 0, lblTextblockttbus2_fecharecepcion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS2_FechaRecepcion_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_FechaRecepcion_Internalname, context.localUtil.Format(A46TTBUS2_FechaRecepcion, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtTTBUS2_FechaRecepcion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A46TTBUS2_FechaRecepcion, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(73);\"", 0, edtTTBUS2_FechaRecepcion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS2_FechaRecepcion_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS2_FechaRecepcion_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS002.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_estadoenvio_Internalname, 1, 1, 0, "de envío", "", "", "", 0, lblTextblockttbus2_estadoenvio_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTTBUS2_EstadoEnvio, cmbTTBUS2_EstadoEnvio_Internalname, StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0), "", "int", 1, cmbTTBUS2_EstadoEnvio.Enabled, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbTTBUS2_EstadoEnvio_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", true, "HLP_TTBUS002.htm");
            cmbTTBUS2_EstadoEnvio.CurrentValue = StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS2_EstadoEnvio_Internalname, "Values", (String)(cmbTTBUS2_EstadoEnvio.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_motivoenvio_Internalname, 1, 1, 0, "de envío", "", "", "", 0, lblTextblockttbus2_motivoenvio_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_MotivoEnvio_Internalname, StringUtil.RTrim( A47TTBUS2_MotivoEnvio), "", 80, "chr", 1, "row", 100, 1, edtTTBUS2_MotivoEnvio_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A47TTBUS2_MotivoEnvio, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(83);\"", 0, edtTTBUS2_MotivoEnvio_Jsonclick, "", 0, 1, 0, true, "left", "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_observaciones_Internalname, 1, 1, 0, "Observaciones", "", "", "", 0, lblTextblockttbus2_observaciones_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtTTBUS2_Observaciones_Internalname, StringUtil.RTrim( A87TTBUS2_Observaciones), 1, edtTTBUS2_Observaciones_Enabled, 0, 80, "chr", 5, "row", StyleString, ClassString, "400", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(88);\"", -1, 0, "", "", true, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_plazorecepcion_Internalname, 1, 1, 0, "del bien", "", "", "", 0, lblTextblockttbus2_plazorecepcion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS2_PlazoRecepcion_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS2_PlazoRecepcion_Internalname, context.localUtil.Format(A77TTBUS2_PlazoRecepcion, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtTTBUS2_PlazoRecepcion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A77TTBUS2_PlazoRecepcion, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(93);\"", 0, edtTTBUS2_PlazoRecepcion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS002.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS2_PlazoRecepcion_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS2_PlazoRecepcion_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS002.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_095e( true) ;
         }
         else
         {
            wb_table4_33_095e( false) ;
         }
      }

      protected void wb_table2_5_095( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS2_IDMOVIMIENTO"+"'), id:'"+"TTBUS2_IDMOVIMIENTO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS2_IDMOVIMIENTO"+"'), id:'"+"TTBUS2_IDMOVIMIENTO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS002.htm");
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
            wb_table2_5_095e( true) ;
         }
         else
         {
            wb_table2_5_095e( false) ;
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
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS2_IdBien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS2_IdBien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS2_IdBien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS2_IDBIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A22TTBUS2_IdBien = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               }
               else
               {
                  A22TTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS2_IdBien_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS2_CodPosDesde_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosDesde_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosDesde_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS2_CODPOSDESDE");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_CodPosDesde_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A48TTBUS2_CodPosDesde = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
               }
               else
               {
                  A48TTBUS2_CodPosDesde = (short)(context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosDesde_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
               }
               A24TTBUS2_RespDesde = cgiGet( edtTTBUS2_RespDesde_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               if ( context.localUtil.VCDateTime( cgiGet( edtTTBUS2_FechaEnvio_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Fecha de envío"}), 1, "TTBUS2_FECHAENVIO");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_FechaEnvio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A45TTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtTTBUS2_FechaEnvio_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS2_CodPosHacia_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosHacia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosHacia_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS2_CODPOSHACIA");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_CodPosHacia_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A49TTBUS2_CodPosHacia = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
               }
               else
               {
                  A49TTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosHacia_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
               }
               A25TTBUS2_RespHacia = cgiGet( edtTTBUS2_RespHacia_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               if ( context.localUtil.VCDateTime( cgiGet( edtTTBUS2_FechaRecepcion_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Fecha de recepción"}), 1, "TTBUS2_FECHARECEPCION");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_FechaRecepcion_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
                  n46TTBUS2_FechaRecepcion = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A46TTBUS2_FechaRecepcion = context.localUtil.CToT( cgiGet( edtTTBUS2_FechaRecepcion_Internalname)) ;
                  n46TTBUS2_FechaRecepcion = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
               }
               n46TTBUS2_FechaRecepcion = ((DateTime.MinValue==A46TTBUS2_FechaRecepcion) ? true : false) ;
               cmbTTBUS2_EstadoEnvio.CurrentValue = cgiGet( cmbTTBUS2_EstadoEnvio_Internalname) ;
               A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbTTBUS2_EstadoEnvio_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               A47TTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtTTBUS2_MotivoEnvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
               A87TTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtTTBUS2_Observaciones_Internalname)) ;
               n87TTBUS2_Observaciones = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
               n87TTBUS2_Observaciones = (String.IsNullOrEmpty(StringUtil.RTrim( A87TTBUS2_Observaciones)) ? true : false) ;
               if ( context.localUtil.VCDate( cgiGet( edtTTBUS2_PlazoRecepcion_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Plazo para recepción del bien"}), 1, "TTBUS2_PLAZORECEPCION");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS2_PlazoRecepcion_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
                  n77TTBUS2_PlazoRecepcion = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77TTBUS2_PlazoRecepcion", context.localUtil.Format(A77TTBUS2_PlazoRecepcion, "99/99/9999"));
               }
               else
               {
                  A77TTBUS2_PlazoRecepcion = context.localUtil.CToD( cgiGet( edtTTBUS2_PlazoRecepcion_Internalname), 4) ;
                  n77TTBUS2_PlazoRecepcion = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77TTBUS2_PlazoRecepcion", context.localUtil.Format(A77TTBUS2_PlazoRecepcion, "99/99/9999"));
               }
               n77TTBUS2_PlazoRecepcion = ((DateTime.MinValue==A77TTBUS2_PlazoRecepcion) ? true : false) ;
               /* Read saved values. */
               Z52TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( "Z52TTBUS2_IdMovimiento"), ",", ".")) ;
               Z22TTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( "Z22TTBUS2_IdBien"), ",", ".")) ;
               Z48TTBUS2_CodPosDesde = (short)(context.localUtil.CToN( cgiGet( "Z48TTBUS2_CodPosDesde"), ",", ".")) ;
               Z24TTBUS2_RespDesde = cgiGet( "Z24TTBUS2_RespDesde") ;
               Z45TTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( "Z45TTBUS2_FechaEnvio")) ;
               Z49TTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( "Z49TTBUS2_CodPosHacia"), ",", ".")) ;
               Z25TTBUS2_RespHacia = cgiGet( "Z25TTBUS2_RespHacia") ;
               Z46TTBUS2_FechaRecepcion = context.localUtil.CToT( cgiGet( "Z46TTBUS2_FechaRecepcion")) ;
               Z26TTBUS2_EstadoEnvio = (short)(context.localUtil.CToN( cgiGet( "Z26TTBUS2_EstadoEnvio"), ",", ".")) ;
               Z47TTBUS2_MotivoEnvio = cgiGet( "Z47TTBUS2_MotivoEnvio") ;
               Z87TTBUS2_Observaciones = cgiGet( "Z87TTBUS2_Observaciones") ;
               Z77TTBUS2_PlazoRecepcion = context.localUtil.CToD( cgiGet( "Z77TTBUS2_PlazoRecepcion"), 0) ;
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
               InitAll095( ) ;
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
         edtTTBUS2_IdBien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_IdBien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_IdBien_Enabled), 5, 0)));
         edtTTBUS2_CodPosDesde_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_CodPosDesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_CodPosDesde_Enabled), 5, 0)));
         edtTTBUS2_RespDesde_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_RespDesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_RespDesde_Enabled), 5, 0)));
         edtTTBUS2_FechaEnvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_FechaEnvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_FechaEnvio_Enabled), 5, 0)));
         edtTTBUS2_CodPosHacia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_CodPosHacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_CodPosHacia_Enabled), 5, 0)));
         edtTTBUS2_RespHacia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_RespHacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_RespHacia_Enabled), 5, 0)));
         edtTTBUS2_FechaRecepcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_FechaRecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_FechaRecepcion_Enabled), 5, 0)));
         cmbTTBUS2_EstadoEnvio.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS2_EstadoEnvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTTBUS2_EstadoEnvio.Enabled), 5, 0)));
         edtTTBUS2_MotivoEnvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_MotivoEnvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_MotivoEnvio_Enabled), 5, 0)));
         edtTTBUS2_Observaciones_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_Observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_Observaciones_Enabled), 5, 0)));
         edtTTBUS2_PlazoRecepcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_PlazoRecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS2_PlazoRecepcion_Enabled), 5, 0)));
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

      protected void ResetCaption090( )
      {
      }

      protected void ZM095( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z22TTBUS2_IdBien = T00093_A22TTBUS2_IdBien[0] ;
               Z48TTBUS2_CodPosDesde = T00093_A48TTBUS2_CodPosDesde[0] ;
               Z24TTBUS2_RespDesde = T00093_A24TTBUS2_RespDesde[0] ;
               Z45TTBUS2_FechaEnvio = T00093_A45TTBUS2_FechaEnvio[0] ;
               Z49TTBUS2_CodPosHacia = T00093_A49TTBUS2_CodPosHacia[0] ;
               Z25TTBUS2_RespHacia = T00093_A25TTBUS2_RespHacia[0] ;
               Z46TTBUS2_FechaRecepcion = T00093_A46TTBUS2_FechaRecepcion[0] ;
               Z26TTBUS2_EstadoEnvio = T00093_A26TTBUS2_EstadoEnvio[0] ;
               Z47TTBUS2_MotivoEnvio = T00093_A47TTBUS2_MotivoEnvio[0] ;
               Z87TTBUS2_Observaciones = T00093_A87TTBUS2_Observaciones[0] ;
               Z77TTBUS2_PlazoRecepcion = T00093_A77TTBUS2_PlazoRecepcion[0] ;
            }
            else
            {
               Z22TTBUS2_IdBien = A22TTBUS2_IdBien ;
               Z48TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
               Z24TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
               Z45TTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
               Z49TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
               Z25TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
               Z46TTBUS2_FechaRecepcion = A46TTBUS2_FechaRecepcion ;
               Z26TTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
               Z47TTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
               Z87TTBUS2_Observaciones = A87TTBUS2_Observaciones ;
               Z77TTBUS2_PlazoRecepcion = A77TTBUS2_PlazoRecepcion ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z52TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            Z22TTBUS2_IdBien = A22TTBUS2_IdBien ;
            Z48TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
            Z24TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
            Z45TTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
            Z49TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
            Z25TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
            Z46TTBUS2_FechaRecepcion = A46TTBUS2_FechaRecepcion ;
            Z26TTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
            Z47TTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
            Z87TTBUS2_Observaciones = A87TTBUS2_Observaciones ;
            Z77TTBUS2_PlazoRecepcion = A77TTBUS2_PlazoRecepcion ;
         }
      }

      protected void standaloneNotModal( )
      {
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

      protected void Load095( )
      {
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound5 = 1 ;
            A22TTBUS2_IdBien = T00094_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A48TTBUS2_CodPosDesde = T00094_A48TTBUS2_CodPosDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
            A24TTBUS2_RespDesde = T00094_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A45TTBUS2_FechaEnvio = T00094_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A49TTBUS2_CodPosHacia = T00094_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A25TTBUS2_RespHacia = T00094_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A46TTBUS2_FechaRecepcion = T00094_A46TTBUS2_FechaRecepcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
            n46TTBUS2_FechaRecepcion = T00094_n46TTBUS2_FechaRecepcion[0] ;
            A26TTBUS2_EstadoEnvio = T00094_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A47TTBUS2_MotivoEnvio = T00094_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = T00094_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = T00094_n87TTBUS2_Observaciones[0] ;
            A77TTBUS2_PlazoRecepcion = T00094_A77TTBUS2_PlazoRecepcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77TTBUS2_PlazoRecepcion", context.localUtil.Format(A77TTBUS2_PlazoRecepcion, "99/99/9999"));
            n77TTBUS2_PlazoRecepcion = T00094_n77TTBUS2_PlazoRecepcion[0] ;
            ZM095( -4) ;
         }
         pr_default.close(2);
         OnLoadActions095( ) ;
      }

      protected void OnLoadActions095( )
      {
      }

      protected void CheckExtendedTable095( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A45TTBUS2_FechaEnvio) || ( A45TTBUS2_FechaEnvio >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Fecha de envío fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A46TTBUS2_FechaRecepcion) || ( A46TTBUS2_FechaRecepcion >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Fecha de recepción fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A77TTBUS2_PlazoRecepcion) || ( A77TTBUS2_PlazoRecepcion >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Plazo para recepción del bien fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors095( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound5 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey095( )
      {
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM095( 4) ;
            RcdFound5 = 1 ;
            A52TTBUS2_IdMovimiento = T00093_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A22TTBUS2_IdBien = T00093_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A48TTBUS2_CodPosDesde = T00093_A48TTBUS2_CodPosDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
            A24TTBUS2_RespDesde = T00093_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A45TTBUS2_FechaEnvio = T00093_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A49TTBUS2_CodPosHacia = T00093_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A25TTBUS2_RespHacia = T00093_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A46TTBUS2_FechaRecepcion = T00093_A46TTBUS2_FechaRecepcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
            n46TTBUS2_FechaRecepcion = T00093_n46TTBUS2_FechaRecepcion[0] ;
            A26TTBUS2_EstadoEnvio = T00093_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A47TTBUS2_MotivoEnvio = T00093_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = T00093_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = T00093_n87TTBUS2_Observaciones[0] ;
            A77TTBUS2_PlazoRecepcion = T00093_A77TTBUS2_PlazoRecepcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77TTBUS2_PlazoRecepcion", context.localUtil.Format(A77TTBUS2_PlazoRecepcion, "99/99/9999"));
            n77TTBUS2_PlazoRecepcion = T00093_n77TTBUS2_PlazoRecepcion[0] ;
            Z52TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load095( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0 ;
            InitializeNonKey095( ) ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey095( ) ;
         if ( RcdFound5 == 0 )
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
         RcdFound5 = 0 ;
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00096_A52TTBUS2_IdMovimiento[0] < A52TTBUS2_IdMovimiento ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00096_A52TTBUS2_IdMovimiento[0] > A52TTBUS2_IdMovimiento ) ) )
            {
               A52TTBUS2_IdMovimiento = T00096_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0 ;
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A52TTBUS2_IdMovimiento});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00097_A52TTBUS2_IdMovimiento[0] > A52TTBUS2_IdMovimiento ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00097_A52TTBUS2_IdMovimiento[0] < A52TTBUS2_IdMovimiento ) ) )
            {
               A52TTBUS2_IdMovimiento = T00097_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey095( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS2_IDMOVIMIENTO");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento )
            {
               A52TTBUS2_IdMovimiento = Z52TTBUS2_IdMovimiento ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
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
               Update095( ) ;
               GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert095( ) ;
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
                  Insert095( ) ;
                  GX_FocusControl = edtTTBUS2_IdMovimiento_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A52TTBUS2_IdMovimiento != Z52TTBUS2_IdMovimiento )
         {
            A52TTBUS2_IdMovimiento = Z52TTBUS2_IdMovimiento ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "TTBUS2_IDMOVIMIENTO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtTTBUS2_IdBien_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart095( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS2_IdBien_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd095( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS2_IdBien_Internalname ;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS2_IdBien_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart095( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound5 != 0 )
            {
               ScanNext095( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS2_IdBien_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd095( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency095( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00098 */
            pr_default.execute(6, new Object[] {A52TTBUS2_IdMovimiento});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS002"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( Z22TTBUS2_IdBien != T00098_A22TTBUS2_IdBien[0] ) || ( Z48TTBUS2_CodPosDesde != T00098_A48TTBUS2_CodPosDesde[0] ) || ( StringUtil.StrCmp(Z24TTBUS2_RespDesde, T00098_A24TTBUS2_RespDesde[0]) != 0 ) || ( Z45TTBUS2_FechaEnvio != T00098_A45TTBUS2_FechaEnvio[0] ) || ( Z49TTBUS2_CodPosHacia != T00098_A49TTBUS2_CodPosHacia[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z25TTBUS2_RespHacia, T00098_A25TTBUS2_RespHacia[0]) != 0 ) || ( Z46TTBUS2_FechaRecepcion != T00098_A46TTBUS2_FechaRecepcion[0] ) || ( Z26TTBUS2_EstadoEnvio != T00098_A26TTBUS2_EstadoEnvio[0] ) || ( StringUtil.StrCmp(Z47TTBUS2_MotivoEnvio, T00098_A47TTBUS2_MotivoEnvio[0]) != 0 ) || ( StringUtil.StrCmp(Z87TTBUS2_Observaciones, T00098_A87TTBUS2_Observaciones[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z77TTBUS2_PlazoRecepcion != T00098_A77TTBUS2_PlazoRecepcion[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS002"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert095( )
      {
         BeforeValidate095( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable095( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM095( 0) ;
            CheckOptimisticConcurrency095( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm095( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert095( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00099 */
                     pr_default.execute(7, new Object[] {A22TTBUS2_IdBien, A48TTBUS2_CodPosDesde, A24TTBUS2_RespDesde, A45TTBUS2_FechaEnvio, A49TTBUS2_CodPosHacia, A25TTBUS2_RespHacia, n46TTBUS2_FechaRecepcion, A46TTBUS2_FechaRecepcion, A26TTBUS2_EstadoEnvio, A47TTBUS2_MotivoEnvio, n87TTBUS2_Observaciones, A87TTBUS2_Observaciones, n77TTBUS2_PlazoRecepcion, A77TTBUS2_PlazoRecepcion});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000910 */
                     pr_default.execute(8);
                     A52TTBUS2_IdMovimiento = T000910_A52TTBUS2_IdMovimiento[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption090( ) ;
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
               Load095( ) ;
            }
            EndLevel095( ) ;
         }
         CloseExtendedTableCursors095( ) ;
      }

      protected void Update095( )
      {
         BeforeValidate095( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable095( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency095( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm095( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate095( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000911 */
                     pr_default.execute(9, new Object[] {A22TTBUS2_IdBien, A48TTBUS2_CodPosDesde, A24TTBUS2_RespDesde, A45TTBUS2_FechaEnvio, A49TTBUS2_CodPosHacia, A25TTBUS2_RespHacia, n46TTBUS2_FechaRecepcion, A46TTBUS2_FechaRecepcion, A26TTBUS2_EstadoEnvio, A47TTBUS2_MotivoEnvio, n87TTBUS2_Observaciones, A87TTBUS2_Observaciones, n77TTBUS2_PlazoRecepcion, A77TTBUS2_PlazoRecepcion, A52TTBUS2_IdMovimiento});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS002"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate095( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption090( ) ;
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
            EndLevel095( ) ;
         }
         CloseExtendedTableCursors095( ) ;
      }

      protected void DeferredUpdate095( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate095( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency095( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls095( ) ;
            AfterConfirm095( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete095( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000912 */
                  pr_default.execute(10, new Object[] {A52TTBUS2_IdMovimiento});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound5 == 0 )
                        {
                           InitAll095( ) ;
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
                        ResetCaption090( ) ;
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
         sMode5 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel095( ) ;
         Gx_mode = sMode5 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls095( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000913 */
            pr_default.execute(11, new Object[] {A52TTBUS2_IdMovimiento});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Detalle de Movimientos de Bienes de Uso"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel095( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete095( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TTBUS002");
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TTBUS002");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart095( )
      {
         /* Using cursor T000914 */
         pr_default.execute(12);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1 ;
            A52TTBUS2_IdMovimiento = T000914_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext095( )
      {
         pr_default.readNext(12);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1 ;
            A52TTBUS2_IdMovimiento = T000914_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         }
      }

      protected void ScanEnd095( )
      {
      }

      protected void AfterConfirm095( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert095( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate095( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete095( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete095( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate095( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues090( )
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
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus002.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52TTBUS2_IdMovimiento), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22TTBUS2_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48TTBUS2_CodPosDesde), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z24TTBUS2_RespDesde", StringUtil.RTrim( Z24TTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "Z45TTBUS2_FechaEnvio", context.localUtil.TToC( Z45TTBUS2_FechaEnvio, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z49TTBUS2_CodPosHacia), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z25TTBUS2_RespHacia", StringUtil.RTrim( Z25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, "Z46TTBUS2_FechaRecepcion", context.localUtil.TToC( Z46TTBUS2_FechaRecepcion, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z26TTBUS2_EstadoEnvio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26TTBUS2_EstadoEnvio), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z47TTBUS2_MotivoEnvio", StringUtil.RTrim( Z47TTBUS2_MotivoEnvio));
         GxWebStd.gx_hidden_field( context, "Z87TTBUS2_Observaciones", StringUtil.RTrim( Z87TTBUS2_Observaciones));
         GxWebStd.gx_hidden_field( context, "Z77TTBUS2_PlazoRecepcion", context.localUtil.DToC( Z77TTBUS2_PlazoRecepcion, 0, "/"));
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
         return "TTBUS002" ;
      }

      public override String GetPgmdesc( )
      {
         return "Historial de Ubicaciones de Bienes de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus002.aspx")  ;
      }

      protected void InitializeNonKey095( )
      {
         A22TTBUS2_IdBien = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
         A48TTBUS2_CodPosDesde = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
         A24TTBUS2_RespDesde = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
         A49TTBUS2_CodPosHacia = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
         A25TTBUS2_RespHacia = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         n46TTBUS2_FechaRecepcion = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
         n46TTBUS2_FechaRecepcion = ((DateTime.MinValue==A46TTBUS2_FechaRecepcion) ? true : false) ;
         A26TTBUS2_EstadoEnvio = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
         A47TTBUS2_MotivoEnvio = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
         A87TTBUS2_Observaciones = "" ;
         n87TTBUS2_Observaciones = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
         n87TTBUS2_Observaciones = (String.IsNullOrEmpty(StringUtil.RTrim( A87TTBUS2_Observaciones)) ? true : false) ;
         A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         n77TTBUS2_PlazoRecepcion = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77TTBUS2_PlazoRecepcion", context.localUtil.Format(A77TTBUS2_PlazoRecepcion, "99/99/9999"));
         n77TTBUS2_PlazoRecepcion = ((DateTime.MinValue==A77TTBUS2_PlazoRecepcion) ? true : false) ;
      }

      protected void InitAll095( )
      {
         A52TTBUS2_IdMovimiento = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
         InitializeNonKey095( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11472028");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus002.js", "?11472028");
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
         lblTextblockttbus2_idbien_Internalname = "TEXTBLOCKTTBUS2_IDBIEN" ;
         edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN" ;
         lblTextblockttbus2_codposdesde_Internalname = "TEXTBLOCKTTBUS2_CODPOSDESDE" ;
         edtTTBUS2_CodPosDesde_Internalname = "TTBUS2_CODPOSDESDE" ;
         lblTextblockttbus2_respdesde_Internalname = "TEXTBLOCKTTBUS2_RESPDESDE" ;
         edtTTBUS2_RespDesde_Internalname = "TTBUS2_RESPDESDE" ;
         lblTextblockttbus2_fechaenvio_Internalname = "TEXTBLOCKTTBUS2_FECHAENVIO" ;
         edtTTBUS2_FechaEnvio_Internalname = "TTBUS2_FECHAENVIO" ;
         lblTextblockttbus2_codposhacia_Internalname = "TEXTBLOCKTTBUS2_CODPOSHACIA" ;
         edtTTBUS2_CodPosHacia_Internalname = "TTBUS2_CODPOSHACIA" ;
         lblTextblockttbus2_resphacia_Internalname = "TEXTBLOCKTTBUS2_RESPHACIA" ;
         edtTTBUS2_RespHacia_Internalname = "TTBUS2_RESPHACIA" ;
         lblTextblockttbus2_fecharecepcion_Internalname = "TEXTBLOCKTTBUS2_FECHARECEPCION" ;
         edtTTBUS2_FechaRecepcion_Internalname = "TTBUS2_FECHARECEPCION" ;
         lblTextblockttbus2_estadoenvio_Internalname = "TEXTBLOCKTTBUS2_ESTADOENVIO" ;
         cmbTTBUS2_EstadoEnvio_Internalname = "TTBUS2_ESTADOENVIO" ;
         lblTextblockttbus2_motivoenvio_Internalname = "TEXTBLOCKTTBUS2_MOTIVOENVIO" ;
         edtTTBUS2_MotivoEnvio_Internalname = "TTBUS2_MOTIVOENVIO" ;
         lblTextblockttbus2_observaciones_Internalname = "TEXTBLOCKTTBUS2_OBSERVACIONES" ;
         edtTTBUS2_Observaciones_Internalname = "TTBUS2_OBSERVACIONES" ;
         lblTextblockttbus2_plazorecepcion_Internalname = "TEXTBLOCKTTBUS2_PLAZORECEPCION" ;
         edtTTBUS2_PlazoRecepcion_Internalname = "TTBUS2_PLAZORECEPCION" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Historial de Ubicaciones de Bienes de Uso" ;
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
         edtTTBUS2_PlazoRecepcion_Jsonclick = "" ;
         edtTTBUS2_PlazoRecepcion_Enabled = 1 ;
         edtTTBUS2_Observaciones_Enabled = 1 ;
         edtTTBUS2_MotivoEnvio_Jsonclick = "" ;
         edtTTBUS2_MotivoEnvio_Enabled = 1 ;
         cmbTTBUS2_EstadoEnvio_Jsonclick = "" ;
         cmbTTBUS2_EstadoEnvio.Enabled = 1 ;
         edtTTBUS2_FechaRecepcion_Jsonclick = "" ;
         edtTTBUS2_FechaRecepcion_Enabled = 1 ;
         edtTTBUS2_RespHacia_Jsonclick = "" ;
         edtTTBUS2_RespHacia_Enabled = 1 ;
         edtTTBUS2_CodPosHacia_Jsonclick = "" ;
         edtTTBUS2_CodPosHacia_Enabled = 1 ;
         edtTTBUS2_FechaEnvio_Jsonclick = "" ;
         edtTTBUS2_FechaEnvio_Enabled = 1 ;
         edtTTBUS2_RespDesde_Jsonclick = "" ;
         edtTTBUS2_RespDesde_Enabled = 1 ;
         edtTTBUS2_CodPosDesde_Jsonclick = "" ;
         edtTTBUS2_CodPosDesde_Enabled = 1 ;
         edtTTBUS2_IdBien_Jsonclick = "" ;
         edtTTBUS2_IdBien_Enabled = 1 ;
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

      protected void GXSGATTBUS2_MOTIVOENVIO090( String A47TTBUS2_MotivoEnvio )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS2_MOTIVOENVIO_data090( A47TTBUS2_MotivoEnvio) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXSGATTBUS2_MOTIVOENVIO_data090( String A47TTBUS2_MotivoEnvio )
      {
         l47TTBUS2_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( A47TTBUS2_MotivoEnvio), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
         /* Using cursor T000915 */
         pr_default.execute(13, new Object[] {l47TTBUS2_MotivoEnvio});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(13) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000915_A47TTBUS2_MotivoEnvio[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000915_A47TTBUS2_MotivoEnvio[0]));
            pr_default.readNext(13);
         }
         pr_default.close(13);
      }

      protected void GXSGATTBUS2_OBSERVACIONES090( String A87TTBUS2_Observaciones )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS2_OBSERVACIONES_data090( A87TTBUS2_Observaciones) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXSGATTBUS2_OBSERVACIONES_data090( String A87TTBUS2_Observaciones )
      {
         l87TTBUS2_Observaciones = StringUtil.PadR( StringUtil.RTrim( A87TTBUS2_Observaciones), 400, "%") ;
         n87TTBUS2_Observaciones = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
         /* Using cursor T000916 */
         pr_default.execute(14, new Object[] {n87TTBUS2_Observaciones, l87TTBUS2_Observaciones});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(14) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000916_A87TTBUS2_Observaciones[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000916_A87TTBUS2_Observaciones[0]));
            pr_default.readNext(14);
         }
         pr_default.close(14);
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtTTBUS2_IdBien_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ttbus2_idmovimiento( long GX_Parm1 ,
                                             int GX_Parm2 ,
                                             short GX_Parm3 ,
                                             String GX_Parm4 ,
                                             DateTime GX_Parm5 ,
                                             short GX_Parm6 ,
                                             String GX_Parm7 ,
                                             DateTime GX_Parm8 ,
                                             GXCombobox cmbGX_Parm9 ,
                                             String GX_Parm10 ,
                                             String GX_Parm11 ,
                                             DateTime GX_Parm12 )
      {
         A52TTBUS2_IdMovimiento = GX_Parm1 ;
         A22TTBUS2_IdBien = GX_Parm2 ;
         A48TTBUS2_CodPosDesde = GX_Parm3 ;
         A24TTBUS2_RespDesde = GX_Parm4 ;
         A45TTBUS2_FechaEnvio = GX_Parm5 ;
         A49TTBUS2_CodPosHacia = GX_Parm6 ;
         A25TTBUS2_RespHacia = GX_Parm7 ;
         A46TTBUS2_FechaRecepcion = GX_Parm8 ;
         n46TTBUS2_FechaRecepcion = false ;
         cmbTTBUS2_EstadoEnvio = cmbGX_Parm9 ;
         A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbTTBUS2_EstadoEnvio.CurrentValue, ".")) ;
         cmbTTBUS2_EstadoEnvio.CurrentValue = StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0) ;
         A47TTBUS2_MotivoEnvio = GX_Parm10 ;
         A87TTBUS2_Observaciones = GX_Parm11 ;
         n87TTBUS2_Observaciones = false ;
         A77TTBUS2_PlazoRecepcion = GX_Parm12 ;
         n77TTBUS2_PlazoRecepcion = false ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A48TTBUS2_CodPosDesde), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A24TTBUS2_RespDesde)));
         isValidOutput.Add((Object)(context.localUtil.Format(A45TTBUS2_FechaEnvio, "99/99/9999 99:99")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A49TTBUS2_CodPosHacia), 3, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A25TTBUS2_RespHacia)));
         isValidOutput.Add((Object)(context.localUtil.Format(A46TTBUS2_FechaRecepcion, "99/99/99 99:99")));
         cmbTTBUS2_EstadoEnvio.CurrentValue = StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0) ;
         isValidOutput.Add((Object)(cmbTTBUS2_EstadoEnvio));
         isValidOutput.Add((Object)(StringUtil.RTrim( A47TTBUS2_MotivoEnvio)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A87TTBUS2_Observaciones)));
         isValidOutput.Add((Object)(context.localUtil.Format(A77TTBUS2_PlazoRecepcion, "99/99/9999")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52TTBUS2_IdMovimiento), 12, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22TTBUS2_IdBien), 8, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48TTBUS2_CodPosDesde), 3, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z24TTBUS2_RespDesde)));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z45TTBUS2_FechaEnvio, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z49TTBUS2_CodPosHacia), 3, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z25TTBUS2_RespHacia)));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z46TTBUS2_FechaRecepcion, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26TTBUS2_EstadoEnvio), 1, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z47TTBUS2_MotivoEnvio)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z87TTBUS2_Observaciones)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z77TTBUS2_PlazoRecepcion, 0, "/")));
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
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A87TTBUS2_Observaciones = "" ;
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
         lblTextblockttbus2_idbien_Jsonclick = "" ;
         lblTextblockttbus2_codposdesde_Jsonclick = "" ;
         lblTextblockttbus2_respdesde_Jsonclick = "" ;
         A24TTBUS2_RespDesde = "" ;
         lblTextblockttbus2_fechaenvio_Jsonclick = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         lblTextblockttbus2_codposhacia_Jsonclick = "" ;
         lblTextblockttbus2_resphacia_Jsonclick = "" ;
         A25TTBUS2_RespHacia = "" ;
         lblTextblockttbus2_fecharecepcion_Jsonclick = "" ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         lblTextblockttbus2_estadoenvio_Jsonclick = "" ;
         lblTextblockttbus2_motivoenvio_Jsonclick = "" ;
         lblTextblockttbus2_observaciones_Jsonclick = "" ;
         lblTextblockttbus2_plazorecepcion_Jsonclick = "" ;
         A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
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
         Z24TTBUS2_RespDesde = "" ;
         Z45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         Z25TTBUS2_RespHacia = "" ;
         Z46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         Z47TTBUS2_MotivoEnvio = "" ;
         Z87TTBUS2_Observaciones = "" ;
         Z77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00094_A52TTBUS2_IdMovimiento = new long[1] ;
         T00094_A22TTBUS2_IdBien = new int[1] ;
         T00094_A48TTBUS2_CodPosDesde = new short[1] ;
         T00094_A24TTBUS2_RespDesde = new String[] {""} ;
         T00094_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         T00094_A49TTBUS2_CodPosHacia = new short[1] ;
         T00094_A25TTBUS2_RespHacia = new String[] {""} ;
         T00094_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         T00094_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         T00094_A26TTBUS2_EstadoEnvio = new short[1] ;
         T00094_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         T00094_A87TTBUS2_Observaciones = new String[] {""} ;
         T00094_n87TTBUS2_Observaciones = new bool[] {false} ;
         T00094_A77TTBUS2_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         T00094_n77TTBUS2_PlazoRecepcion = new bool[] {false} ;
         T00095_A52TTBUS2_IdMovimiento = new long[1] ;
         T00093_A52TTBUS2_IdMovimiento = new long[1] ;
         T00093_A22TTBUS2_IdBien = new int[1] ;
         T00093_A48TTBUS2_CodPosDesde = new short[1] ;
         T00093_A24TTBUS2_RespDesde = new String[] {""} ;
         T00093_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         T00093_A49TTBUS2_CodPosHacia = new short[1] ;
         T00093_A25TTBUS2_RespHacia = new String[] {""} ;
         T00093_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         T00093_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         T00093_A26TTBUS2_EstadoEnvio = new short[1] ;
         T00093_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         T00093_A87TTBUS2_Observaciones = new String[] {""} ;
         T00093_n87TTBUS2_Observaciones = new bool[] {false} ;
         T00093_A77TTBUS2_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         T00093_n77TTBUS2_PlazoRecepcion = new bool[] {false} ;
         sMode5 = "" ;
         T00096_A52TTBUS2_IdMovimiento = new long[1] ;
         T00097_A52TTBUS2_IdMovimiento = new long[1] ;
         T00098_A52TTBUS2_IdMovimiento = new long[1] ;
         T00098_A22TTBUS2_IdBien = new int[1] ;
         T00098_A48TTBUS2_CodPosDesde = new short[1] ;
         T00098_A24TTBUS2_RespDesde = new String[] {""} ;
         T00098_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         T00098_A49TTBUS2_CodPosHacia = new short[1] ;
         T00098_A25TTBUS2_RespHacia = new String[] {""} ;
         T00098_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         T00098_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         T00098_A26TTBUS2_EstadoEnvio = new short[1] ;
         T00098_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         T00098_A87TTBUS2_Observaciones = new String[] {""} ;
         T00098_n87TTBUS2_Observaciones = new bool[] {false} ;
         T00098_A77TTBUS2_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         T00098_n77TTBUS2_PlazoRecepcion = new bool[] {false} ;
         T000910_A52TTBUS2_IdMovimiento = new long[1] ;
         T000913_A52TTBUS2_IdMovimiento = new long[1] ;
         T000913_A53TTBUS2_IdUsuario = new String[] {""} ;
         T000914_A52TTBUS2_IdMovimiento = new long[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         l47TTBUS2_MotivoEnvio = "" ;
         T000915_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         GXt_char3 = "" ;
         l87TTBUS2_Observaciones = "" ;
         T000916_A87TTBUS2_Observaciones = new String[] {""} ;
         T000916_n87TTBUS2_Observaciones = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus002__default(),
            new Object[][] {
                new Object[] {
               T00092_A52TTBUS2_IdMovimiento, T00092_A22TTBUS2_IdBien, T00092_A48TTBUS2_CodPosDesde, T00092_A24TTBUS2_RespDesde, T00092_A45TTBUS2_FechaEnvio, T00092_A49TTBUS2_CodPosHacia, T00092_A25TTBUS2_RespHacia, T00092_A46TTBUS2_FechaRecepcion, T00092_n46TTBUS2_FechaRecepcion, T00092_A26TTBUS2_EstadoEnvio,
               T00092_A47TTBUS2_MotivoEnvio, T00092_A87TTBUS2_Observaciones, T00092_n87TTBUS2_Observaciones, T00092_A77TTBUS2_PlazoRecepcion, T00092_n77TTBUS2_PlazoRecepcion
               }
               , new Object[] {
               T00093_A52TTBUS2_IdMovimiento, T00093_A22TTBUS2_IdBien, T00093_A48TTBUS2_CodPosDesde, T00093_A24TTBUS2_RespDesde, T00093_A45TTBUS2_FechaEnvio, T00093_A49TTBUS2_CodPosHacia, T00093_A25TTBUS2_RespHacia, T00093_A46TTBUS2_FechaRecepcion, T00093_n46TTBUS2_FechaRecepcion, T00093_A26TTBUS2_EstadoEnvio,
               T00093_A47TTBUS2_MotivoEnvio, T00093_A87TTBUS2_Observaciones, T00093_n87TTBUS2_Observaciones, T00093_A77TTBUS2_PlazoRecepcion, T00093_n77TTBUS2_PlazoRecepcion
               }
               , new Object[] {
               T00094_A52TTBUS2_IdMovimiento, T00094_A22TTBUS2_IdBien, T00094_A48TTBUS2_CodPosDesde, T00094_A24TTBUS2_RespDesde, T00094_A45TTBUS2_FechaEnvio, T00094_A49TTBUS2_CodPosHacia, T00094_A25TTBUS2_RespHacia, T00094_A46TTBUS2_FechaRecepcion, T00094_n46TTBUS2_FechaRecepcion, T00094_A26TTBUS2_EstadoEnvio,
               T00094_A47TTBUS2_MotivoEnvio, T00094_A87TTBUS2_Observaciones, T00094_n87TTBUS2_Observaciones, T00094_A77TTBUS2_PlazoRecepcion, T00094_n77TTBUS2_PlazoRecepcion
               }
               , new Object[] {
               T00095_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T00096_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T00097_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T00098_A52TTBUS2_IdMovimiento, T00098_A22TTBUS2_IdBien, T00098_A48TTBUS2_CodPosDesde, T00098_A24TTBUS2_RespDesde, T00098_A45TTBUS2_FechaEnvio, T00098_A49TTBUS2_CodPosHacia, T00098_A25TTBUS2_RespHacia, T00098_A46TTBUS2_FechaRecepcion, T00098_n46TTBUS2_FechaRecepcion, T00098_A26TTBUS2_EstadoEnvio,
               T00098_A47TTBUS2_MotivoEnvio, T00098_A87TTBUS2_Observaciones, T00098_n87TTBUS2_Observaciones, T00098_A77TTBUS2_PlazoRecepcion, T00098_n77TTBUS2_PlazoRecepcion
               }
               , new Object[] {
               }
               , new Object[] {
               T000910_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000913_A52TTBUS2_IdMovimiento, T000913_A53TTBUS2_IdUsuario
               }
               , new Object[] {
               T000914_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               T000915_A47TTBUS2_MotivoEnvio
               }
               , new Object[] {
               T000916_A87TTBUS2_Observaciones, T000916_n87TTBUS2_Observaciones
               }
            }
         );
      }

      private short RcdFound5 ;
      private short GxWebError ;
      private short A26TTBUS2_EstadoEnvio ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short Z48TTBUS2_CodPosDesde ;
      private short Z49TTBUS2_CodPosHacia ;
      private short Z26TTBUS2_EstadoEnvio ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtTTBUS2_IdMovimiento_Enabled ;
      private int A22TTBUS2_IdBien ;
      private int edtTTBUS2_IdBien_Enabled ;
      private int edtTTBUS2_CodPosDesde_Enabled ;
      private int edtTTBUS2_RespDesde_Enabled ;
      private int edtTTBUS2_FechaEnvio_Enabled ;
      private int edtTTBUS2_CodPosHacia_Enabled ;
      private int edtTTBUS2_RespHacia_Enabled ;
      private int edtTTBUS2_FechaRecepcion_Enabled ;
      private int edtTTBUS2_MotivoEnvio_Enabled ;
      private int edtTTBUS2_Observaciones_Enabled ;
      private int edtTTBUS2_PlazoRecepcion_Enabled ;
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
      private int Z22TTBUS2_IdBien ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long A52TTBUS2_IdMovimiento ;
      private long Z52TTBUS2_IdMovimiento ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
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
      private String lblTextblockttbus2_idbien_Internalname ;
      private String lblTextblockttbus2_idbien_Jsonclick ;
      private String edtTTBUS2_IdBien_Internalname ;
      private String edtTTBUS2_IdBien_Jsonclick ;
      private String lblTextblockttbus2_codposdesde_Internalname ;
      private String lblTextblockttbus2_codposdesde_Jsonclick ;
      private String edtTTBUS2_CodPosDesde_Internalname ;
      private String edtTTBUS2_CodPosDesde_Jsonclick ;
      private String lblTextblockttbus2_respdesde_Internalname ;
      private String lblTextblockttbus2_respdesde_Jsonclick ;
      private String edtTTBUS2_RespDesde_Internalname ;
      private String A24TTBUS2_RespDesde ;
      private String edtTTBUS2_RespDesde_Jsonclick ;
      private String lblTextblockttbus2_fechaenvio_Internalname ;
      private String lblTextblockttbus2_fechaenvio_Jsonclick ;
      private String edtTTBUS2_FechaEnvio_Internalname ;
      private String edtTTBUS2_FechaEnvio_Jsonclick ;
      private String lblTextblockttbus2_codposhacia_Internalname ;
      private String lblTextblockttbus2_codposhacia_Jsonclick ;
      private String edtTTBUS2_CodPosHacia_Internalname ;
      private String edtTTBUS2_CodPosHacia_Jsonclick ;
      private String lblTextblockttbus2_resphacia_Internalname ;
      private String lblTextblockttbus2_resphacia_Jsonclick ;
      private String edtTTBUS2_RespHacia_Internalname ;
      private String A25TTBUS2_RespHacia ;
      private String edtTTBUS2_RespHacia_Jsonclick ;
      private String lblTextblockttbus2_fecharecepcion_Internalname ;
      private String lblTextblockttbus2_fecharecepcion_Jsonclick ;
      private String edtTTBUS2_FechaRecepcion_Internalname ;
      private String edtTTBUS2_FechaRecepcion_Jsonclick ;
      private String lblTextblockttbus2_estadoenvio_Internalname ;
      private String lblTextblockttbus2_estadoenvio_Jsonclick ;
      private String cmbTTBUS2_EstadoEnvio_Internalname ;
      private String cmbTTBUS2_EstadoEnvio_Jsonclick ;
      private String lblTextblockttbus2_motivoenvio_Internalname ;
      private String lblTextblockttbus2_motivoenvio_Jsonclick ;
      private String edtTTBUS2_MotivoEnvio_Internalname ;
      private String edtTTBUS2_MotivoEnvio_Jsonclick ;
      private String lblTextblockttbus2_observaciones_Internalname ;
      private String lblTextblockttbus2_observaciones_Jsonclick ;
      private String edtTTBUS2_Observaciones_Internalname ;
      private String lblTextblockttbus2_plazorecepcion_Internalname ;
      private String lblTextblockttbus2_plazorecepcion_Jsonclick ;
      private String edtTTBUS2_PlazoRecepcion_Internalname ;
      private String edtTTBUS2_PlazoRecepcion_Jsonclick ;
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
      private String Z24TTBUS2_RespDesde ;
      private String Z25TTBUS2_RespHacia ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode5 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String gxwrpcisep ;
      private String GXt_char3 ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime A46TTBUS2_FechaRecepcion ;
      private DateTime Z45TTBUS2_FechaEnvio ;
      private DateTime Z46TTBUS2_FechaRecepcion ;
      private DateTime A77TTBUS2_PlazoRecepcion ;
      private DateTime Z77TTBUS2_PlazoRecepcion ;
      private bool entryPointCalled ;
      private bool n87TTBUS2_Observaciones ;
      private bool wbErr ;
      private bool n46TTBUS2_FechaRecepcion ;
      private bool n77TTBUS2_PlazoRecepcion ;
      private bool Gx_longc ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private String Z47TTBUS2_MotivoEnvio ;
      private String Z87TTBUS2_Observaciones ;
      private String l47TTBUS2_MotivoEnvio ;
      private String l87TTBUS2_Observaciones ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTTBUS2_EstadoEnvio ;
      private IDataStoreProvider pr_default ;
      private long[] T00094_A52TTBUS2_IdMovimiento ;
      private int[] T00094_A22TTBUS2_IdBien ;
      private short[] T00094_A48TTBUS2_CodPosDesde ;
      private String[] T00094_A24TTBUS2_RespDesde ;
      private DateTime[] T00094_A45TTBUS2_FechaEnvio ;
      private short[] T00094_A49TTBUS2_CodPosHacia ;
      private String[] T00094_A25TTBUS2_RespHacia ;
      private DateTime[] T00094_A46TTBUS2_FechaRecepcion ;
      private bool[] T00094_n46TTBUS2_FechaRecepcion ;
      private short[] T00094_A26TTBUS2_EstadoEnvio ;
      private String[] T00094_A47TTBUS2_MotivoEnvio ;
      private String[] T00094_A87TTBUS2_Observaciones ;
      private bool[] T00094_n87TTBUS2_Observaciones ;
      private DateTime[] T00094_A77TTBUS2_PlazoRecepcion ;
      private bool[] T00094_n77TTBUS2_PlazoRecepcion ;
      private long[] T00095_A52TTBUS2_IdMovimiento ;
      private long[] T00093_A52TTBUS2_IdMovimiento ;
      private int[] T00093_A22TTBUS2_IdBien ;
      private short[] T00093_A48TTBUS2_CodPosDesde ;
      private String[] T00093_A24TTBUS2_RespDesde ;
      private DateTime[] T00093_A45TTBUS2_FechaEnvio ;
      private short[] T00093_A49TTBUS2_CodPosHacia ;
      private String[] T00093_A25TTBUS2_RespHacia ;
      private DateTime[] T00093_A46TTBUS2_FechaRecepcion ;
      private bool[] T00093_n46TTBUS2_FechaRecepcion ;
      private short[] T00093_A26TTBUS2_EstadoEnvio ;
      private String[] T00093_A47TTBUS2_MotivoEnvio ;
      private String[] T00093_A87TTBUS2_Observaciones ;
      private bool[] T00093_n87TTBUS2_Observaciones ;
      private DateTime[] T00093_A77TTBUS2_PlazoRecepcion ;
      private bool[] T00093_n77TTBUS2_PlazoRecepcion ;
      private long[] T00096_A52TTBUS2_IdMovimiento ;
      private long[] T00097_A52TTBUS2_IdMovimiento ;
      private long[] T00098_A52TTBUS2_IdMovimiento ;
      private int[] T00098_A22TTBUS2_IdBien ;
      private short[] T00098_A48TTBUS2_CodPosDesde ;
      private String[] T00098_A24TTBUS2_RespDesde ;
      private DateTime[] T00098_A45TTBUS2_FechaEnvio ;
      private short[] T00098_A49TTBUS2_CodPosHacia ;
      private String[] T00098_A25TTBUS2_RespHacia ;
      private DateTime[] T00098_A46TTBUS2_FechaRecepcion ;
      private bool[] T00098_n46TTBUS2_FechaRecepcion ;
      private short[] T00098_A26TTBUS2_EstadoEnvio ;
      private String[] T00098_A47TTBUS2_MotivoEnvio ;
      private String[] T00098_A87TTBUS2_Observaciones ;
      private bool[] T00098_n87TTBUS2_Observaciones ;
      private DateTime[] T00098_A77TTBUS2_PlazoRecepcion ;
      private bool[] T00098_n77TTBUS2_PlazoRecepcion ;
      private long[] T000910_A52TTBUS2_IdMovimiento ;
      private long[] T000913_A52TTBUS2_IdMovimiento ;
      private String[] T000913_A53TTBUS2_IdUsuario ;
      private long[] T000914_A52TTBUS2_IdMovimiento ;
      private String[] T000915_A47TTBUS2_MotivoEnvio ;
      private String[] T000916_A87TTBUS2_Observaciones ;
      private bool[] T000916_n87TTBUS2_Observaciones ;
      private long[] T00092_A52TTBUS2_IdMovimiento ;
      private int[] T00092_A22TTBUS2_IdBien ;
      private short[] T00092_A48TTBUS2_CodPosDesde ;
      private String[] T00092_A24TTBUS2_RespDesde ;
      private DateTime[] T00092_A45TTBUS2_FechaEnvio ;
      private short[] T00092_A49TTBUS2_CodPosHacia ;
      private String[] T00092_A25TTBUS2_RespHacia ;
      private DateTime[] T00092_A46TTBUS2_FechaRecepcion ;
      private short[] T00092_A26TTBUS2_EstadoEnvio ;
      private String[] T00092_A47TTBUS2_MotivoEnvio ;
      private String[] T00092_A87TTBUS2_Observaciones ;
      private DateTime[] T00092_A77TTBUS2_PlazoRecepcion ;
      private bool[] T00092_n46TTBUS2_FechaRecepcion ;
      private bool[] T00092_n87TTBUS2_Observaciones ;
      private bool[] T00092_n77TTBUS2_PlazoRecepcion ;
      private GXWebForm Form ;
   }

   public class ttbus002__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaEnvio",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaRecepcion",SqlDbType.DateTime,8,5} ,
          new Object[] {"@TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0} ,
          new Object[] {"@TTBUS2_PlazoRecepcion",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaEnvio",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaRecepcion",SqlDbType.DateTime,8,5} ,
          new Object[] {"@TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0} ,
          new Object[] {"@TTBUS2_PlazoRecepcion",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000912 ;
          prmT000912 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000913 ;
          prmT000913 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT000914 ;
          prmT000914 = new Object[] {
          } ;
          Object[] prmT000915 ;
          prmT000915 = new Object[] {
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmT000916 ;
          prmT000916 = new Object[] {
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_PlazoRecepcion] FROM [TTBUS002] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new CursorDef("T00093", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_PlazoRecepcion] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new CursorDef("T00094", "SELECT TM1.[TTBUS2_IdMovimiento], TM1.[TTBUS2_IdBien], TM1.[TTBUS2_CodPosDesde], TM1.[TTBUS2_RespDesde], TM1.[TTBUS2_FechaEnvio], TM1.[TTBUS2_CodPosHacia], TM1.[TTBUS2_RespHacia], TM1.[TTBUS2_FechaRecepcion], TM1.[TTBUS2_EstadoEnvio], TM1.[TTBUS2_MotivoEnvio], TM1.[TTBUS2_Observaciones], TM1.[TTBUS2_PlazoRecepcion] FROM [TTBUS002] TM1 WITH (NOLOCK) WHERE TM1.[TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ORDER BY TM1.[TTBUS2_IdMovimiento]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,100,0,true,false )
             ,new CursorDef("T00095", "SELECT [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
             ,new CursorDef("T00096", "SELECT TOP 1 [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ( [TTBUS2_IdMovimiento] > @TTBUS2_IdMovimiento) ORDER BY [TTBUS2_IdMovimiento]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,true )
             ,new CursorDef("T00097", "SELECT TOP 1 [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ( [TTBUS2_IdMovimiento] < @TTBUS2_IdMovimiento) ORDER BY [TTBUS2_IdMovimiento] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,true )
             ,new CursorDef("T00098", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_PlazoRecepcion] FROM [TTBUS002] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1,0,true,false )
             ,new CursorDef("T00099", "INSERT INTO [TTBUS002] ([TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_PlazoRecepcion], [TTBUS2_MotivoCancelacion]) VALUES (@TTBUS2_IdBien, @TTBUS2_CodPosDesde, @TTBUS2_RespDesde, @TTBUS2_FechaEnvio, @TTBUS2_CodPosHacia, @TTBUS2_RespHacia, @TTBUS2_FechaRecepcion, @TTBUS2_EstadoEnvio, @TTBUS2_MotivoEnvio, @TTBUS2_Observaciones, @TTBUS2_PlazoRecepcion, '')", GxErrorMask.GX_NOMASK,prmT00099)
             ,new CursorDef("T000910", "SELECT Ident_Current('[TTBUS002]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000910,1,0,true,false )
             ,new CursorDef("T000911", "UPDATE [TTBUS002] SET [TTBUS2_IdBien]=@TTBUS2_IdBien, [TTBUS2_CodPosDesde]=@TTBUS2_CodPosDesde, [TTBUS2_RespDesde]=@TTBUS2_RespDesde, [TTBUS2_FechaEnvio]=@TTBUS2_FechaEnvio, [TTBUS2_CodPosHacia]=@TTBUS2_CodPosHacia, [TTBUS2_RespHacia]=@TTBUS2_RespHacia, [TTBUS2_FechaRecepcion]=@TTBUS2_FechaRecepcion, [TTBUS2_EstadoEnvio]=@TTBUS2_EstadoEnvio, [TTBUS2_MotivoEnvio]=@TTBUS2_MotivoEnvio, [TTBUS2_Observaciones]=@TTBUS2_Observaciones, [TTBUS2_PlazoRecepcion]=@TTBUS2_PlazoRecepcion  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento", GxErrorMask.GX_NOMASK,prmT000911)
             ,new CursorDef("T000912", "DELETE FROM [TTBUS002]  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento", GxErrorMask.GX_NOMASK,prmT000912)
             ,new CursorDef("T000913", "SELECT TOP 1 [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento ",true, GxErrorMask.GX_NOMASK, false, this,prmT000913,1,0,true,true )
             ,new CursorDef("T000914", "SELECT [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) ORDER BY [TTBUS2_IdMovimiento]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000914,100,0,true,false )
             ,new CursorDef("T000915", "SELECT DISTINCT TOP 5 [TTBUS2_MotivoEnvio] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_MotivoEnvio] AS char(100))) like UPPER(CAST(@TTBUS2_MotivoEnvio AS char(100))) ORDER BY [TTBUS2_MotivoEnvio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000915,0,0,true,false )
             ,new CursorDef("T000916", "SELECT DISTINCT TOP 5 [TTBUS2_Observaciones] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_Observaciones] AS char(400))) like UPPER(CAST(@TTBUS2_Observaciones AS char(400))) ORDER BY [TTBUS2_Observaciones] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000916,0,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 15) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(12);
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 15) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(12);
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 15) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(12);
                break;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 15) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(12);
                break;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 11 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 12 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[7]);
                }
                stmt.SetParameter(8, (short)parms[8]);
                stmt.SetParameter(9, (String)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(11, (DateTime)parms[13]);
                }
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[7]);
                }
                stmt.SetParameter(8, (short)parms[8]);
                stmt.SetParameter(9, (String)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(11, (DateTime)parms[13]);
                }
                stmt.SetParameter(12, (long)parms[14]);
                break;
             case 10 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 14 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                break;
       }
    }

 }

}
