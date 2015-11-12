/*
               File: TTBUS003
        Description: Historial de Asociaciones de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:21:9.33
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
   public class ttbus003 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Historial de Asociaciones de Bienes de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus003( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus003( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
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
            wb_table1_2_0B11( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0B11e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0B11( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0B11( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0B11e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Historial de Asociaciones de Bienes de Uso"+"</legend>") ;
            wb_table3_27_0B11( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0B11e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0B11e( true) ;
         }
         else
         {
            wb_table1_2_0B11e( false) ;
         }
      }

      protected void wb_table3_27_0B11( bool wbgen )
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
            wb_table4_33_0B11( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0B11e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS003.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS003.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0B11e( true) ;
         }
         else
         {
            wb_table3_27_0B11e( false) ;
         }
      }

      protected void wb_table4_33_0B11( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_idbien_Internalname, 1, 1, 0, "de uso", "", "", "", 0, lblTextblockttbus3_idbien_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_IdBien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A105TTBUS3_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtTTBUS3_IdBien_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A105TTBUS3_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtTTBUS3_IdBien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_nroasoc_Internalname, 1, 1, 0, "de asociación", "", "", "", 0, lblTextblockttbus3_nroasoc_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_NroAsoc_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A106TTBUS3_NroAsoc), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtTTBUS3_NroAsoc_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A106TTBUS3_NroAsoc), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(43);\"", 0, edtTTBUS3_NroAsoc_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_sist_Internalname, 1, 1, 0, "la asociación", "", "", "", 0, lblTextblockttbus3_sist_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_Sist_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A107TTBUS3_Sist), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, edtTTBUS3_Sist_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A107TTBUS3_Sist), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtTTBUS3_Sist_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_hdwid_Internalname, 1, 1, 0, "de hardware", "", "", "", 0, lblTextblockttbus3_hdwid_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_HdwId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A108TTBUS3_HdwId), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtTTBUS3_HdwId_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A108TTBUS3_HdwId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(53);\"", 0, edtTTBUS3_HdwId_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_busemp_Internalname, 1, 1, 0, "empresa", "", "", "", 0, lblTextblockttbus3_busemp_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_BusEmp_Internalname, StringUtil.RTrim( A109TTBUS3_BusEmp), "", 1, "chr", 1, "row", 1, 1, edtTTBUS3_BusEmp_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A109TTBUS3_BusEmp, "X")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", 0, edtTTBUS3_BusEmp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_busrub_Internalname, 1, 1, 0, "de rubro", "", "", "", 0, lblTextblockttbus3_busrub_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_BusRub_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A110TTBUS3_BusRub), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtTTBUS3_BusRub_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A110TTBUS3_BusRub), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(63);\"", 0, edtTTBUS3_BusRub_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_buscod_Internalname, 1, 1, 0, "en contabilidad", "", "", "", 0, lblTextblockttbus3_buscod_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_BusCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A111TTBUS3_BusCod), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtTTBUS3_BusCod_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A111TTBUS3_BusCod), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(68);\"", 0, edtTTBUS3_BusCod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_buspar_Internalname, 1, 1, 0, "de partida", "", "", "", 0, lblTextblockttbus3_buspar_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_BusPar_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A112TTBUS3_BusPar), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, edtTTBUS3_BusPar_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A112TTBUS3_BusPar), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(73);\"", 0, edtTTBUS3_BusPar_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_usuario_Internalname, 1, 1, 0, "la asociación", "", "", "", 0, lblTextblockttbus3_usuario_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_Usuario_Internalname, StringUtil.RTrim( A113TTBUS3_Usuario), "", 16, "chr", 1, "row", 16, 1, edtTTBUS3_Usuario_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A113TTBUS3_Usuario, "XXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", 0, edtTTBUS3_Usuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_fechaasoc_Internalname, 1, 1, 0, "de asociación", "", "", "", 0, lblTextblockttbus3_fechaasoc_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS3_FechaAsoc_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_FechaAsoc_Internalname, context.localUtil.Format(A114TTBUS3_FechaAsoc, "99/99/9999 99:99"), "", 16, "chr", 1, "row", 16, 1, edtTTBUS3_FechaAsoc_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A114TTBUS3_FechaAsoc, "99/99/9999 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(83);\"", 0, edtTTBUS3_FechaAsoc_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS003.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS3_FechaAsoc_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS3_FechaAsoc_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS003.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_maquinaasoc_Internalname, 1, 1, 0, "la asociación", "", "", "", 0, lblTextblockttbus3_maquinaasoc_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS3_MaquinaAsoc_Internalname, StringUtil.RTrim( A115TTBUS3_MaquinaAsoc), "", 20, "chr", 1, "row", 20, 1, edtTTBUS3_MaquinaAsoc_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A115TTBUS3_MaquinaAsoc, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(88);\"", 0, edtTTBUS3_MaquinaAsoc_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0B11e( true) ;
         }
         else
         {
            wb_table4_33_0B11e( false) ;
         }
      }

      protected void wb_table2_5_0B11( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00b0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS3_IDBIEN"+"'), id:'"+"TTBUS3_IDBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS3_NROASOC"+"'), id:'"+"TTBUS3_NROASOC"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00b0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS3_IDBIEN"+"'), id:'"+"TTBUS3_IDBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS3_NROASOC"+"'), id:'"+"TTBUS3_NROASOC"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS003.htm");
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
            wb_table2_5_0B11e( true) ;
         }
         else
         {
            wb_table2_5_0B11e( false) ;
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
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS3_IdBien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS3_IdBien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS3_IdBien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS3_IDBIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A105TTBUS3_IdBien = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
               }
               else
               {
                  A105TTBUS3_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS3_IdBien_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS3_NroAsoc_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS3_NroAsoc_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS3_NroAsoc_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS3_NROASOC");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_NroAsoc_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A106TTBUS3_NroAsoc = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
               }
               else
               {
                  A106TTBUS3_NroAsoc = (int)(context.localUtil.CToN( cgiGet( edtTTBUS3_NroAsoc_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS3_Sist_Internalname), "Z9") || ( context.localUtil.CToN( cgiGet( edtTTBUS3_Sist_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS3_Sist_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS3_SIST");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_Sist_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A107TTBUS3_Sist = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107TTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(A107TTBUS3_Sist), 2, 0)));
               }
               else
               {
                  A107TTBUS3_Sist = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_Sist_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107TTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(A107TTBUS3_Sist), 2, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS3_HdwId_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS3_HdwId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS3_HdwId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS3_HDWID");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_HdwId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A108TTBUS3_HdwId = 0 ;
                  n108TTBUS3_HdwId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(A108TTBUS3_HdwId), 4, 0)));
               }
               else
               {
                  A108TTBUS3_HdwId = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_HdwId_Internalname), ",", ".")) ;
                  n108TTBUS3_HdwId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(A108TTBUS3_HdwId), 4, 0)));
               }
               n108TTBUS3_HdwId = ((0==A108TTBUS3_HdwId) ? true : false) ;
               A109TTBUS3_BusEmp = cgiGet( edtTTBUS3_BusEmp_Internalname) ;
               n109TTBUS3_BusEmp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109TTBUS3_BusEmp", A109TTBUS3_BusEmp);
               n109TTBUS3_BusEmp = (String.IsNullOrEmpty(StringUtil.RTrim( A109TTBUS3_BusEmp)) ? true : false) ;
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS3_BusRub_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS3_BusRub_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS3_BusRub_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS3_BUSRUB");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_BusRub_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A110TTBUS3_BusRub = 0 ;
                  n110TTBUS3_BusRub = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(A110TTBUS3_BusRub), 4, 0)));
               }
               else
               {
                  A110TTBUS3_BusRub = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_BusRub_Internalname), ",", ".")) ;
                  n110TTBUS3_BusRub = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(A110TTBUS3_BusRub), 4, 0)));
               }
               n110TTBUS3_BusRub = ((0==A110TTBUS3_BusRub) ? true : false) ;
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS3_BusCod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS3_BusCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS3_BusCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS3_BUSCOD");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_BusCod_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A111TTBUS3_BusCod = 0 ;
                  n111TTBUS3_BusCod = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111TTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A111TTBUS3_BusCod), 4, 0)));
               }
               else
               {
                  A111TTBUS3_BusCod = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_BusCod_Internalname), ",", ".")) ;
                  n111TTBUS3_BusCod = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111TTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A111TTBUS3_BusCod), 4, 0)));
               }
               n111TTBUS3_BusCod = ((0==A111TTBUS3_BusCod) ? true : false) ;
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS3_BusPar_Internalname), "Z9") || ( context.localUtil.CToN( cgiGet( edtTTBUS3_BusPar_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS3_BusPar_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS3_BUSPAR");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_BusPar_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A112TTBUS3_BusPar = 0 ;
                  n112TTBUS3_BusPar = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.Str( (decimal)(A112TTBUS3_BusPar), 2, 0)));
               }
               else
               {
                  A112TTBUS3_BusPar = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_BusPar_Internalname), ",", ".")) ;
                  n112TTBUS3_BusPar = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.Str( (decimal)(A112TTBUS3_BusPar), 2, 0)));
               }
               n112TTBUS3_BusPar = ((0==A112TTBUS3_BusPar) ? true : false) ;
               A113TTBUS3_Usuario = cgiGet( edtTTBUS3_Usuario_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113TTBUS3_Usuario", A113TTBUS3_Usuario);
               if ( context.localUtil.VCDateTime( cgiGet( edtTTBUS3_FechaAsoc_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Fecha y hora de asociación"}), 1, "TTBUS3_FECHAASOC");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_FechaAsoc_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TTBUS3_FechaAsoc", context.localUtil.TToC( A114TTBUS3_FechaAsoc, 10, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A114TTBUS3_FechaAsoc = context.localUtil.CToT( cgiGet( edtTTBUS3_FechaAsoc_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TTBUS3_FechaAsoc", context.localUtil.TToC( A114TTBUS3_FechaAsoc, 10, 5, 0, 3, "/", ":", " "));
               }
               A115TTBUS3_MaquinaAsoc = cgiGet( edtTTBUS3_MaquinaAsoc_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TTBUS3_MaquinaAsoc", A115TTBUS3_MaquinaAsoc);
               /* Read saved values. */
               Z105TTBUS3_IdBien = (int)(context.localUtil.CToN( cgiGet( "Z105TTBUS3_IdBien"), ",", ".")) ;
               Z106TTBUS3_NroAsoc = (int)(context.localUtil.CToN( cgiGet( "Z106TTBUS3_NroAsoc"), ",", ".")) ;
               Z107TTBUS3_Sist = (short)(context.localUtil.CToN( cgiGet( "Z107TTBUS3_Sist"), ",", ".")) ;
               Z108TTBUS3_HdwId = (short)(context.localUtil.CToN( cgiGet( "Z108TTBUS3_HdwId"), ",", ".")) ;
               Z109TTBUS3_BusEmp = cgiGet( "Z109TTBUS3_BusEmp") ;
               Z110TTBUS3_BusRub = (short)(context.localUtil.CToN( cgiGet( "Z110TTBUS3_BusRub"), ",", ".")) ;
               Z111TTBUS3_BusCod = (short)(context.localUtil.CToN( cgiGet( "Z111TTBUS3_BusCod"), ",", ".")) ;
               Z112TTBUS3_BusPar = (short)(context.localUtil.CToN( cgiGet( "Z112TTBUS3_BusPar"), ",", ".")) ;
               Z113TTBUS3_Usuario = cgiGet( "Z113TTBUS3_Usuario") ;
               Z114TTBUS3_FechaAsoc = context.localUtil.CToT( cgiGet( "Z114TTBUS3_FechaAsoc")) ;
               Z115TTBUS3_MaquinaAsoc = cgiGet( "Z115TTBUS3_MaquinaAsoc") ;
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
                  A105TTBUS3_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
                  A106TTBUS3_NroAsoc = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
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
               InitAll0B11( ) ;
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
         edtTTBUS3_IdBien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_IdBien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_IdBien_Enabled), 5, 0)));
         edtTTBUS3_NroAsoc_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_NroAsoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_NroAsoc_Enabled), 5, 0)));
         edtTTBUS3_Sist_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_Sist_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_Sist_Enabled), 5, 0)));
         edtTTBUS3_HdwId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_HdwId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_HdwId_Enabled), 5, 0)));
         edtTTBUS3_BusEmp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_BusEmp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_BusEmp_Enabled), 5, 0)));
         edtTTBUS3_BusRub_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_BusRub_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_BusRub_Enabled), 5, 0)));
         edtTTBUS3_BusCod_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_BusCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_BusCod_Enabled), 5, 0)));
         edtTTBUS3_BusPar_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_BusPar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_BusPar_Enabled), 5, 0)));
         edtTTBUS3_Usuario_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_Usuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_Usuario_Enabled), 5, 0)));
         edtTTBUS3_FechaAsoc_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_FechaAsoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_FechaAsoc_Enabled), 5, 0)));
         edtTTBUS3_MaquinaAsoc_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_MaquinaAsoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS3_MaquinaAsoc_Enabled), 5, 0)));
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

      protected void ResetCaption0B0( )
      {
      }

      protected void ZM0B11( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z107TTBUS3_Sist = T000B3_A107TTBUS3_Sist[0] ;
               Z108TTBUS3_HdwId = T000B3_A108TTBUS3_HdwId[0] ;
               Z109TTBUS3_BusEmp = T000B3_A109TTBUS3_BusEmp[0] ;
               Z110TTBUS3_BusRub = T000B3_A110TTBUS3_BusRub[0] ;
               Z111TTBUS3_BusCod = T000B3_A111TTBUS3_BusCod[0] ;
               Z112TTBUS3_BusPar = T000B3_A112TTBUS3_BusPar[0] ;
               Z113TTBUS3_Usuario = T000B3_A113TTBUS3_Usuario[0] ;
               Z114TTBUS3_FechaAsoc = T000B3_A114TTBUS3_FechaAsoc[0] ;
               Z115TTBUS3_MaquinaAsoc = T000B3_A115TTBUS3_MaquinaAsoc[0] ;
            }
            else
            {
               Z107TTBUS3_Sist = A107TTBUS3_Sist ;
               Z108TTBUS3_HdwId = A108TTBUS3_HdwId ;
               Z109TTBUS3_BusEmp = A109TTBUS3_BusEmp ;
               Z110TTBUS3_BusRub = A110TTBUS3_BusRub ;
               Z111TTBUS3_BusCod = A111TTBUS3_BusCod ;
               Z112TTBUS3_BusPar = A112TTBUS3_BusPar ;
               Z113TTBUS3_Usuario = A113TTBUS3_Usuario ;
               Z114TTBUS3_FechaAsoc = A114TTBUS3_FechaAsoc ;
               Z115TTBUS3_MaquinaAsoc = A115TTBUS3_MaquinaAsoc ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z105TTBUS3_IdBien = A105TTBUS3_IdBien ;
            Z106TTBUS3_NroAsoc = A106TTBUS3_NroAsoc ;
            Z107TTBUS3_Sist = A107TTBUS3_Sist ;
            Z108TTBUS3_HdwId = A108TTBUS3_HdwId ;
            Z109TTBUS3_BusEmp = A109TTBUS3_BusEmp ;
            Z110TTBUS3_BusRub = A110TTBUS3_BusRub ;
            Z111TTBUS3_BusCod = A111TTBUS3_BusCod ;
            Z112TTBUS3_BusPar = A112TTBUS3_BusPar ;
            Z113TTBUS3_Usuario = A113TTBUS3_Usuario ;
            Z114TTBUS3_FechaAsoc = A114TTBUS3_FechaAsoc ;
            Z115TTBUS3_MaquinaAsoc = A115TTBUS3_MaquinaAsoc ;
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

      protected void Load0B11( )
      {
         /* Using cursor T000B4 */
         pr_default.execute(2, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound11 = 1 ;
            A107TTBUS3_Sist = T000B4_A107TTBUS3_Sist[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107TTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(A107TTBUS3_Sist), 2, 0)));
            A108TTBUS3_HdwId = T000B4_A108TTBUS3_HdwId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(A108TTBUS3_HdwId), 4, 0)));
            n108TTBUS3_HdwId = T000B4_n108TTBUS3_HdwId[0] ;
            A109TTBUS3_BusEmp = T000B4_A109TTBUS3_BusEmp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109TTBUS3_BusEmp", A109TTBUS3_BusEmp);
            n109TTBUS3_BusEmp = T000B4_n109TTBUS3_BusEmp[0] ;
            A110TTBUS3_BusRub = T000B4_A110TTBUS3_BusRub[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(A110TTBUS3_BusRub), 4, 0)));
            n110TTBUS3_BusRub = T000B4_n110TTBUS3_BusRub[0] ;
            A111TTBUS3_BusCod = T000B4_A111TTBUS3_BusCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111TTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A111TTBUS3_BusCod), 4, 0)));
            n111TTBUS3_BusCod = T000B4_n111TTBUS3_BusCod[0] ;
            A112TTBUS3_BusPar = T000B4_A112TTBUS3_BusPar[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.Str( (decimal)(A112TTBUS3_BusPar), 2, 0)));
            n112TTBUS3_BusPar = T000B4_n112TTBUS3_BusPar[0] ;
            A113TTBUS3_Usuario = T000B4_A113TTBUS3_Usuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113TTBUS3_Usuario", A113TTBUS3_Usuario);
            A114TTBUS3_FechaAsoc = T000B4_A114TTBUS3_FechaAsoc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TTBUS3_FechaAsoc", context.localUtil.TToC( A114TTBUS3_FechaAsoc, 10, 5, 0, 3, "/", ":", " "));
            A115TTBUS3_MaquinaAsoc = T000B4_A115TTBUS3_MaquinaAsoc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TTBUS3_MaquinaAsoc", A115TTBUS3_MaquinaAsoc);
            ZM0B11( -2) ;
         }
         pr_default.close(2);
         OnLoadActions0B11( ) ;
      }

      protected void OnLoadActions0B11( )
      {
      }

      protected void CheckExtendedTable0B11( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A114TTBUS3_FechaAsoc) || ( A114TTBUS3_FechaAsoc >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Fecha y hora de asociación fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0B11( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound11 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey0B11( )
      {
         /* Using cursor T000B5 */
         pr_default.execute(3, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound11 = 1 ;
         }
         else
         {
            RcdFound11 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000B3 */
         pr_default.execute(1, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B11( 2) ;
            RcdFound11 = 1 ;
            A105TTBUS3_IdBien = T000B3_A105TTBUS3_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
            A106TTBUS3_NroAsoc = T000B3_A106TTBUS3_NroAsoc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
            A107TTBUS3_Sist = T000B3_A107TTBUS3_Sist[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107TTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(A107TTBUS3_Sist), 2, 0)));
            A108TTBUS3_HdwId = T000B3_A108TTBUS3_HdwId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(A108TTBUS3_HdwId), 4, 0)));
            n108TTBUS3_HdwId = T000B3_n108TTBUS3_HdwId[0] ;
            A109TTBUS3_BusEmp = T000B3_A109TTBUS3_BusEmp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109TTBUS3_BusEmp", A109TTBUS3_BusEmp);
            n109TTBUS3_BusEmp = T000B3_n109TTBUS3_BusEmp[0] ;
            A110TTBUS3_BusRub = T000B3_A110TTBUS3_BusRub[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(A110TTBUS3_BusRub), 4, 0)));
            n110TTBUS3_BusRub = T000B3_n110TTBUS3_BusRub[0] ;
            A111TTBUS3_BusCod = T000B3_A111TTBUS3_BusCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111TTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A111TTBUS3_BusCod), 4, 0)));
            n111TTBUS3_BusCod = T000B3_n111TTBUS3_BusCod[0] ;
            A112TTBUS3_BusPar = T000B3_A112TTBUS3_BusPar[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.Str( (decimal)(A112TTBUS3_BusPar), 2, 0)));
            n112TTBUS3_BusPar = T000B3_n112TTBUS3_BusPar[0] ;
            A113TTBUS3_Usuario = T000B3_A113TTBUS3_Usuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113TTBUS3_Usuario", A113TTBUS3_Usuario);
            A114TTBUS3_FechaAsoc = T000B3_A114TTBUS3_FechaAsoc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TTBUS3_FechaAsoc", context.localUtil.TToC( A114TTBUS3_FechaAsoc, 10, 5, 0, 3, "/", ":", " "));
            A115TTBUS3_MaquinaAsoc = T000B3_A115TTBUS3_MaquinaAsoc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TTBUS3_MaquinaAsoc", A115TTBUS3_MaquinaAsoc);
            Z105TTBUS3_IdBien = A105TTBUS3_IdBien ;
            Z106TTBUS3_NroAsoc = A106TTBUS3_NroAsoc ;
            sMode11 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0B11( ) ;
            Gx_mode = sMode11 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0 ;
            InitializeNonKey0B11( ) ;
            sMode11 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode11 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B11( ) ;
         if ( RcdFound11 == 0 )
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
         RcdFound11 = 0 ;
         /* Using cursor T000B6 */
         pr_default.execute(4, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000B6_A105TTBUS3_IdBien[0] < A105TTBUS3_IdBien ) || ( T000B6_A105TTBUS3_IdBien[0] == A105TTBUS3_IdBien ) && ( T000B6_A106TTBUS3_NroAsoc[0] < A106TTBUS3_NroAsoc ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000B6_A105TTBUS3_IdBien[0] > A105TTBUS3_IdBien ) || ( T000B6_A105TTBUS3_IdBien[0] == A105TTBUS3_IdBien ) && ( T000B6_A106TTBUS3_NroAsoc[0] > A106TTBUS3_NroAsoc ) ) )
            {
               A105TTBUS3_IdBien = T000B6_A105TTBUS3_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
               A106TTBUS3_NroAsoc = T000B6_A106TTBUS3_NroAsoc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
               RcdFound11 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0 ;
         /* Using cursor T000B7 */
         pr_default.execute(5, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000B7_A105TTBUS3_IdBien[0] > A105TTBUS3_IdBien ) || ( T000B7_A105TTBUS3_IdBien[0] == A105TTBUS3_IdBien ) && ( T000B7_A106TTBUS3_NroAsoc[0] > A106TTBUS3_NroAsoc ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000B7_A105TTBUS3_IdBien[0] < A105TTBUS3_IdBien ) || ( T000B7_A105TTBUS3_IdBien[0] == A105TTBUS3_IdBien ) && ( T000B7_A106TTBUS3_NroAsoc[0] < A106TTBUS3_NroAsoc ) ) )
            {
               A105TTBUS3_IdBien = T000B7_A105TTBUS3_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
               A106TTBUS3_NroAsoc = T000B7_A106TTBUS3_NroAsoc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
               RcdFound11 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0B11( ) ;
         if ( RcdFound11 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS3_IDBIEN");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( A105TTBUS3_IdBien != Z105TTBUS3_IdBien ) || ( A106TTBUS3_NroAsoc != Z106TTBUS3_NroAsoc ) )
            {
               A105TTBUS3_IdBien = Z105TTBUS3_IdBien ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
               A106TTBUS3_NroAsoc = Z106TTBUS3_NroAsoc ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS3_IDBIEN");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0B11( ) ;
               GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A105TTBUS3_IdBien != Z105TTBUS3_IdBien ) || ( A106TTBUS3_NroAsoc != Z106TTBUS3_NroAsoc ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert0B11( ) ;
               GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS3_IDBIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert0B11( ) ;
                  GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( A105TTBUS3_IdBien != Z105TTBUS3_IdBien ) || ( A106TTBUS3_NroAsoc != Z106TTBUS3_NroAsoc ) )
         {
            A105TTBUS3_IdBien = Z105TTBUS3_IdBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
            A106TTBUS3_NroAsoc = Z106TTBUS3_NroAsoc ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS3_IDBIEN");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS3_IdBien_Internalname ;
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
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "TTBUS3_IDBIEN");
            AnyError = 1 ;
         }
         GX_FocusControl = edtTTBUS3_Sist_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0B11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS3_Sist_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0B11( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS3_Sist_Internalname ;
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
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS3_Sist_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0B11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound11 != 0 )
            {
               ScanNext0B11( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS3_Sist_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0B11( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0B11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000B8 */
            pr_default.execute(6, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS003"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( Z107TTBUS3_Sist != T000B8_A107TTBUS3_Sist[0] ) || ( Z108TTBUS3_HdwId != T000B8_A108TTBUS3_HdwId[0] ) || ( StringUtil.StrCmp(Z109TTBUS3_BusEmp, T000B8_A109TTBUS3_BusEmp[0]) != 0 ) || ( Z110TTBUS3_BusRub != T000B8_A110TTBUS3_BusRub[0] ) || ( Z111TTBUS3_BusCod != T000B8_A111TTBUS3_BusCod[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z112TTBUS3_BusPar != T000B8_A112TTBUS3_BusPar[0] ) || ( StringUtil.StrCmp(Z113TTBUS3_Usuario, T000B8_A113TTBUS3_Usuario[0]) != 0 ) || ( Z114TTBUS3_FechaAsoc != T000B8_A114TTBUS3_FechaAsoc[0] ) || ( StringUtil.StrCmp(Z115TTBUS3_MaquinaAsoc, T000B8_A115TTBUS3_MaquinaAsoc[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS003"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0B11( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B11( 0) ;
            CheckOptimisticConcurrency0B11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B9 */
                     pr_default.execute(7, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc, A107TTBUS3_Sist, n108TTBUS3_HdwId, A108TTBUS3_HdwId, n109TTBUS3_BusEmp, A109TTBUS3_BusEmp, n110TTBUS3_BusRub, A110TTBUS3_BusRub, n111TTBUS3_BusCod, A111TTBUS3_BusCod, n112TTBUS3_BusPar, A112TTBUS3_BusPar, A113TTBUS3_Usuario, A114TTBUS3_FechaAsoc, A115TTBUS3_MaquinaAsoc});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
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
                           ResetCaption0B0( ) ;
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
               Load0B11( ) ;
            }
            EndLevel0B11( ) ;
         }
         CloseExtendedTableCursors0B11( ) ;
      }

      protected void Update0B11( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B10 */
                     pr_default.execute(8, new Object[] {A107TTBUS3_Sist, n108TTBUS3_HdwId, A108TTBUS3_HdwId, n109TTBUS3_BusEmp, A109TTBUS3_BusEmp, n110TTBUS3_BusRub, A110TTBUS3_BusRub, n111TTBUS3_BusCod, A111TTBUS3_BusCod, n112TTBUS3_BusPar, A112TTBUS3_BusPar, A113TTBUS3_Usuario, A114TTBUS3_FechaAsoc, A115TTBUS3_MaquinaAsoc, A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS003"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0B11( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption0B0( ) ;
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
            EndLevel0B11( ) ;
         }
         CloseExtendedTableCursors0B11( ) ;
      }

      protected void DeferredUpdate0B11( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B11( ) ;
            AfterConfirm0B11( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B11( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000B11 */
                  pr_default.execute(9, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound11 == 0 )
                        {
                           InitAll0B11( ) ;
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
                        ResetCaption0B0( ) ;
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
         sMode11 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0B11( ) ;
         Gx_mode = sMode11 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0B11( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0B11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TTBUS003");
            if ( AnyError == 0 )
            {
               ConfirmValues0B0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TTBUS003");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0B11( )
      {
         /* Using cursor T000B12 */
         pr_default.execute(10);
         RcdFound11 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound11 = 1 ;
            A105TTBUS3_IdBien = T000B12_A105TTBUS3_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
            A106TTBUS3_NroAsoc = T000B12_A106TTBUS3_NroAsoc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B11( )
      {
         pr_default.readNext(10);
         RcdFound11 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound11 = 1 ;
            A105TTBUS3_IdBien = T000B12_A105TTBUS3_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
            A106TTBUS3_NroAsoc = T000B12_A106TTBUS3_NroAsoc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
         }
      }

      protected void ScanEnd0B11( )
      {
      }

      protected void AfterConfirm0B11( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B11( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B11( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B11( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B11( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B11( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0B0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus003.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z105TTBUS3_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z106TTBUS3_NroAsoc), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z107TTBUS3_Sist", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z107TTBUS3_Sist), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z108TTBUS3_HdwId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z109TTBUS3_BusEmp", StringUtil.RTrim( Z109TTBUS3_BusEmp));
         GxWebStd.gx_hidden_field( context, "Z110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z110TTBUS3_BusRub), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z111TTBUS3_BusCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z111TTBUS3_BusCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z112TTBUS3_BusPar), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z113TTBUS3_Usuario", StringUtil.RTrim( Z113TTBUS3_Usuario));
         GxWebStd.gx_hidden_field( context, "Z114TTBUS3_FechaAsoc", context.localUtil.TToC( Z114TTBUS3_FechaAsoc, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z115TTBUS3_MaquinaAsoc", StringUtil.RTrim( Z115TTBUS3_MaquinaAsoc));
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
         return "TTBUS003" ;
      }

      public override String GetPgmdesc( )
      {
         return "Historial de Asociaciones de Bienes de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus003.aspx")  ;
      }

      protected void InitializeNonKey0B11( )
      {
         A107TTBUS3_Sist = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107TTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(A107TTBUS3_Sist), 2, 0)));
         A108TTBUS3_HdwId = 0 ;
         n108TTBUS3_HdwId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(A108TTBUS3_HdwId), 4, 0)));
         n108TTBUS3_HdwId = ((0==A108TTBUS3_HdwId) ? true : false) ;
         A109TTBUS3_BusEmp = "" ;
         n109TTBUS3_BusEmp = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109TTBUS3_BusEmp", A109TTBUS3_BusEmp);
         n109TTBUS3_BusEmp = (String.IsNullOrEmpty(StringUtil.RTrim( A109TTBUS3_BusEmp)) ? true : false) ;
         A110TTBUS3_BusRub = 0 ;
         n110TTBUS3_BusRub = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(A110TTBUS3_BusRub), 4, 0)));
         n110TTBUS3_BusRub = ((0==A110TTBUS3_BusRub) ? true : false) ;
         A111TTBUS3_BusCod = 0 ;
         n111TTBUS3_BusCod = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111TTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A111TTBUS3_BusCod), 4, 0)));
         n111TTBUS3_BusCod = ((0==A111TTBUS3_BusCod) ? true : false) ;
         A112TTBUS3_BusPar = 0 ;
         n112TTBUS3_BusPar = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.Str( (decimal)(A112TTBUS3_BusPar), 2, 0)));
         n112TTBUS3_BusPar = ((0==A112TTBUS3_BusPar) ? true : false) ;
         A113TTBUS3_Usuario = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113TTBUS3_Usuario", A113TTBUS3_Usuario);
         A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TTBUS3_FechaAsoc", context.localUtil.TToC( A114TTBUS3_FechaAsoc, 10, 5, 0, 3, "/", ":", " "));
         A115TTBUS3_MaquinaAsoc = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115TTBUS3_MaquinaAsoc", A115TTBUS3_MaquinaAsoc);
      }

      protected void InitAll0B11( )
      {
         A105TTBUS3_IdBien = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
         A106TTBUS3_NroAsoc = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
         InitializeNonKey0B11( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?17211082");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus003.js", "?17211082");
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
         lblTextblockttbus3_idbien_Internalname = "TEXTBLOCKTTBUS3_IDBIEN" ;
         edtTTBUS3_IdBien_Internalname = "TTBUS3_IDBIEN" ;
         lblTextblockttbus3_nroasoc_Internalname = "TEXTBLOCKTTBUS3_NROASOC" ;
         edtTTBUS3_NroAsoc_Internalname = "TTBUS3_NROASOC" ;
         lblTextblockttbus3_sist_Internalname = "TEXTBLOCKTTBUS3_SIST" ;
         edtTTBUS3_Sist_Internalname = "TTBUS3_SIST" ;
         lblTextblockttbus3_hdwid_Internalname = "TEXTBLOCKTTBUS3_HDWID" ;
         edtTTBUS3_HdwId_Internalname = "TTBUS3_HDWID" ;
         lblTextblockttbus3_busemp_Internalname = "TEXTBLOCKTTBUS3_BUSEMP" ;
         edtTTBUS3_BusEmp_Internalname = "TTBUS3_BUSEMP" ;
         lblTextblockttbus3_busrub_Internalname = "TEXTBLOCKTTBUS3_BUSRUB" ;
         edtTTBUS3_BusRub_Internalname = "TTBUS3_BUSRUB" ;
         lblTextblockttbus3_buscod_Internalname = "TEXTBLOCKTTBUS3_BUSCOD" ;
         edtTTBUS3_BusCod_Internalname = "TTBUS3_BUSCOD" ;
         lblTextblockttbus3_buspar_Internalname = "TEXTBLOCKTTBUS3_BUSPAR" ;
         edtTTBUS3_BusPar_Internalname = "TTBUS3_BUSPAR" ;
         lblTextblockttbus3_usuario_Internalname = "TEXTBLOCKTTBUS3_USUARIO" ;
         edtTTBUS3_Usuario_Internalname = "TTBUS3_USUARIO" ;
         lblTextblockttbus3_fechaasoc_Internalname = "TEXTBLOCKTTBUS3_FECHAASOC" ;
         edtTTBUS3_FechaAsoc_Internalname = "TTBUS3_FECHAASOC" ;
         lblTextblockttbus3_maquinaasoc_Internalname = "TEXTBLOCKTTBUS3_MAQUINAASOC" ;
         edtTTBUS3_MaquinaAsoc_Internalname = "TTBUS3_MAQUINAASOC" ;
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
         Form.Caption = "Historial de Asociaciones de Bienes de Uso" ;
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
         edtTTBUS3_MaquinaAsoc_Jsonclick = "" ;
         edtTTBUS3_MaquinaAsoc_Enabled = 1 ;
         edtTTBUS3_FechaAsoc_Jsonclick = "" ;
         edtTTBUS3_FechaAsoc_Enabled = 1 ;
         edtTTBUS3_Usuario_Jsonclick = "" ;
         edtTTBUS3_Usuario_Enabled = 1 ;
         edtTTBUS3_BusPar_Jsonclick = "" ;
         edtTTBUS3_BusPar_Enabled = 1 ;
         edtTTBUS3_BusCod_Jsonclick = "" ;
         edtTTBUS3_BusCod_Enabled = 1 ;
         edtTTBUS3_BusRub_Jsonclick = "" ;
         edtTTBUS3_BusRub_Enabled = 1 ;
         edtTTBUS3_BusEmp_Jsonclick = "" ;
         edtTTBUS3_BusEmp_Enabled = 1 ;
         edtTTBUS3_HdwId_Jsonclick = "" ;
         edtTTBUS3_HdwId_Enabled = 1 ;
         edtTTBUS3_Sist_Jsonclick = "" ;
         edtTTBUS3_Sist_Enabled = 1 ;
         edtTTBUS3_NroAsoc_Jsonclick = "" ;
         edtTTBUS3_NroAsoc_Enabled = 1 ;
         edtTTBUS3_IdBien_Jsonclick = "" ;
         edtTTBUS3_IdBien_Enabled = 1 ;
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
         GX_FocusControl = edtTTBUS3_Sist_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ttbus3_nroasoc( int GX_Parm1 ,
                                        int GX_Parm2 ,
                                        short GX_Parm3 ,
                                        short GX_Parm4 ,
                                        String GX_Parm5 ,
                                        short GX_Parm6 ,
                                        short GX_Parm7 ,
                                        short GX_Parm8 ,
                                        String GX_Parm9 ,
                                        DateTime GX_Parm10 ,
                                        String GX_Parm11 )
      {
         A105TTBUS3_IdBien = GX_Parm1 ;
         A106TTBUS3_NroAsoc = GX_Parm2 ;
         A107TTBUS3_Sist = GX_Parm3 ;
         A108TTBUS3_HdwId = GX_Parm4 ;
         n108TTBUS3_HdwId = false ;
         A109TTBUS3_BusEmp = GX_Parm5 ;
         n109TTBUS3_BusEmp = false ;
         A110TTBUS3_BusRub = GX_Parm6 ;
         n110TTBUS3_BusRub = false ;
         A111TTBUS3_BusCod = GX_Parm7 ;
         n111TTBUS3_BusCod = false ;
         A112TTBUS3_BusPar = GX_Parm8 ;
         n112TTBUS3_BusPar = false ;
         A113TTBUS3_Usuario = GX_Parm9 ;
         A114TTBUS3_FechaAsoc = GX_Parm10 ;
         A115TTBUS3_MaquinaAsoc = GX_Parm11 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A107TTBUS3_Sist), 2, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A108TTBUS3_HdwId), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A109TTBUS3_BusEmp)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A110TTBUS3_BusRub), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A111TTBUS3_BusCod), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A112TTBUS3_BusPar), 2, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A113TTBUS3_Usuario)));
         isValidOutput.Add((Object)(context.localUtil.Format(A114TTBUS3_FechaAsoc, "99/99/9999 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A115TTBUS3_MaquinaAsoc)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z105TTBUS3_IdBien), 8, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z106TTBUS3_NroAsoc), 8, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z107TTBUS3_Sist), 2, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z108TTBUS3_HdwId), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z109TTBUS3_BusEmp)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z110TTBUS3_BusRub), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z111TTBUS3_BusCod), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z112TTBUS3_BusPar), 2, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z113TTBUS3_Usuario)));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z114TTBUS3_FechaAsoc, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z115TTBUS3_MaquinaAsoc)));
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
         pr_default.close(10);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
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
         lblTextblockttbus3_idbien_Jsonclick = "" ;
         lblTextblockttbus3_nroasoc_Jsonclick = "" ;
         lblTextblockttbus3_sist_Jsonclick = "" ;
         lblTextblockttbus3_hdwid_Jsonclick = "" ;
         lblTextblockttbus3_busemp_Jsonclick = "" ;
         A109TTBUS3_BusEmp = "" ;
         lblTextblockttbus3_busrub_Jsonclick = "" ;
         lblTextblockttbus3_buscod_Jsonclick = "" ;
         lblTextblockttbus3_buspar_Jsonclick = "" ;
         lblTextblockttbus3_usuario_Jsonclick = "" ;
         A113TTBUS3_Usuario = "" ;
         lblTextblockttbus3_fechaasoc_Jsonclick = "" ;
         A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         lblTextblockttbus3_maquinaasoc_Jsonclick = "" ;
         A115TTBUS3_MaquinaAsoc = "" ;
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
         Z109TTBUS3_BusEmp = "" ;
         Z113TTBUS3_Usuario = "" ;
         Z114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         Z115TTBUS3_MaquinaAsoc = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000B4_A105TTBUS3_IdBien = new int[1] ;
         T000B4_A106TTBUS3_NroAsoc = new int[1] ;
         T000B4_A107TTBUS3_Sist = new short[1] ;
         T000B4_A108TTBUS3_HdwId = new short[1] ;
         T000B4_n108TTBUS3_HdwId = new bool[] {false} ;
         T000B4_A109TTBUS3_BusEmp = new String[] {""} ;
         T000B4_n109TTBUS3_BusEmp = new bool[] {false} ;
         T000B4_A110TTBUS3_BusRub = new short[1] ;
         T000B4_n110TTBUS3_BusRub = new bool[] {false} ;
         T000B4_A111TTBUS3_BusCod = new short[1] ;
         T000B4_n111TTBUS3_BusCod = new bool[] {false} ;
         T000B4_A112TTBUS3_BusPar = new short[1] ;
         T000B4_n112TTBUS3_BusPar = new bool[] {false} ;
         T000B4_A113TTBUS3_Usuario = new String[] {""} ;
         T000B4_A114TTBUS3_FechaAsoc = new DateTime[] {DateTime.MinValue} ;
         T000B4_A115TTBUS3_MaquinaAsoc = new String[] {""} ;
         T000B5_A105TTBUS3_IdBien = new int[1] ;
         T000B5_A106TTBUS3_NroAsoc = new int[1] ;
         T000B3_A105TTBUS3_IdBien = new int[1] ;
         T000B3_A106TTBUS3_NroAsoc = new int[1] ;
         T000B3_A107TTBUS3_Sist = new short[1] ;
         T000B3_A108TTBUS3_HdwId = new short[1] ;
         T000B3_n108TTBUS3_HdwId = new bool[] {false} ;
         T000B3_A109TTBUS3_BusEmp = new String[] {""} ;
         T000B3_n109TTBUS3_BusEmp = new bool[] {false} ;
         T000B3_A110TTBUS3_BusRub = new short[1] ;
         T000B3_n110TTBUS3_BusRub = new bool[] {false} ;
         T000B3_A111TTBUS3_BusCod = new short[1] ;
         T000B3_n111TTBUS3_BusCod = new bool[] {false} ;
         T000B3_A112TTBUS3_BusPar = new short[1] ;
         T000B3_n112TTBUS3_BusPar = new bool[] {false} ;
         T000B3_A113TTBUS3_Usuario = new String[] {""} ;
         T000B3_A114TTBUS3_FechaAsoc = new DateTime[] {DateTime.MinValue} ;
         T000B3_A115TTBUS3_MaquinaAsoc = new String[] {""} ;
         sMode11 = "" ;
         T000B6_A105TTBUS3_IdBien = new int[1] ;
         T000B6_A106TTBUS3_NroAsoc = new int[1] ;
         T000B7_A105TTBUS3_IdBien = new int[1] ;
         T000B7_A106TTBUS3_NroAsoc = new int[1] ;
         T000B8_A105TTBUS3_IdBien = new int[1] ;
         T000B8_A106TTBUS3_NroAsoc = new int[1] ;
         T000B8_A107TTBUS3_Sist = new short[1] ;
         T000B8_A108TTBUS3_HdwId = new short[1] ;
         T000B8_n108TTBUS3_HdwId = new bool[] {false} ;
         T000B8_A109TTBUS3_BusEmp = new String[] {""} ;
         T000B8_n109TTBUS3_BusEmp = new bool[] {false} ;
         T000B8_A110TTBUS3_BusRub = new short[1] ;
         T000B8_n110TTBUS3_BusRub = new bool[] {false} ;
         T000B8_A111TTBUS3_BusCod = new short[1] ;
         T000B8_n111TTBUS3_BusCod = new bool[] {false} ;
         T000B8_A112TTBUS3_BusPar = new short[1] ;
         T000B8_n112TTBUS3_BusPar = new bool[] {false} ;
         T000B8_A113TTBUS3_Usuario = new String[] {""} ;
         T000B8_A114TTBUS3_FechaAsoc = new DateTime[] {DateTime.MinValue} ;
         T000B8_A115TTBUS3_MaquinaAsoc = new String[] {""} ;
         T000B12_A105TTBUS3_IdBien = new int[1] ;
         T000B12_A106TTBUS3_NroAsoc = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus003__default(),
            new Object[][] {
                new Object[] {
               T000B2_A105TTBUS3_IdBien, T000B2_A106TTBUS3_NroAsoc, T000B2_A107TTBUS3_Sist, T000B2_A108TTBUS3_HdwId, T000B2_n108TTBUS3_HdwId, T000B2_A109TTBUS3_BusEmp, T000B2_n109TTBUS3_BusEmp, T000B2_A110TTBUS3_BusRub, T000B2_n110TTBUS3_BusRub, T000B2_A111TTBUS3_BusCod,
               T000B2_n111TTBUS3_BusCod, T000B2_A112TTBUS3_BusPar, T000B2_n112TTBUS3_BusPar, T000B2_A113TTBUS3_Usuario, T000B2_A114TTBUS3_FechaAsoc, T000B2_A115TTBUS3_MaquinaAsoc
               }
               , new Object[] {
               T000B3_A105TTBUS3_IdBien, T000B3_A106TTBUS3_NroAsoc, T000B3_A107TTBUS3_Sist, T000B3_A108TTBUS3_HdwId, T000B3_n108TTBUS3_HdwId, T000B3_A109TTBUS3_BusEmp, T000B3_n109TTBUS3_BusEmp, T000B3_A110TTBUS3_BusRub, T000B3_n110TTBUS3_BusRub, T000B3_A111TTBUS3_BusCod,
               T000B3_n111TTBUS3_BusCod, T000B3_A112TTBUS3_BusPar, T000B3_n112TTBUS3_BusPar, T000B3_A113TTBUS3_Usuario, T000B3_A114TTBUS3_FechaAsoc, T000B3_A115TTBUS3_MaquinaAsoc
               }
               , new Object[] {
               T000B4_A105TTBUS3_IdBien, T000B4_A106TTBUS3_NroAsoc, T000B4_A107TTBUS3_Sist, T000B4_A108TTBUS3_HdwId, T000B4_n108TTBUS3_HdwId, T000B4_A109TTBUS3_BusEmp, T000B4_n109TTBUS3_BusEmp, T000B4_A110TTBUS3_BusRub, T000B4_n110TTBUS3_BusRub, T000B4_A111TTBUS3_BusCod,
               T000B4_n111TTBUS3_BusCod, T000B4_A112TTBUS3_BusPar, T000B4_n112TTBUS3_BusPar, T000B4_A113TTBUS3_Usuario, T000B4_A114TTBUS3_FechaAsoc, T000B4_A115TTBUS3_MaquinaAsoc
               }
               , new Object[] {
               T000B5_A105TTBUS3_IdBien, T000B5_A106TTBUS3_NroAsoc
               }
               , new Object[] {
               T000B6_A105TTBUS3_IdBien, T000B6_A106TTBUS3_NroAsoc
               }
               , new Object[] {
               T000B7_A105TTBUS3_IdBien, T000B7_A106TTBUS3_NroAsoc
               }
               , new Object[] {
               T000B8_A105TTBUS3_IdBien, T000B8_A106TTBUS3_NroAsoc, T000B8_A107TTBUS3_Sist, T000B8_A108TTBUS3_HdwId, T000B8_n108TTBUS3_HdwId, T000B8_A109TTBUS3_BusEmp, T000B8_n109TTBUS3_BusEmp, T000B8_A110TTBUS3_BusRub, T000B8_n110TTBUS3_BusRub, T000B8_A111TTBUS3_BusCod,
               T000B8_n111TTBUS3_BusCod, T000B8_A112TTBUS3_BusPar, T000B8_n112TTBUS3_BusPar, T000B8_A113TTBUS3_Usuario, T000B8_A114TTBUS3_FechaAsoc, T000B8_A115TTBUS3_MaquinaAsoc
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B12_A105TTBUS3_IdBien, T000B12_A106TTBUS3_NroAsoc
               }
            }
         );
      }

      private short RcdFound11 ;
      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A107TTBUS3_Sist ;
      private short A108TTBUS3_HdwId ;
      private short A110TTBUS3_BusRub ;
      private short A111TTBUS3_BusCod ;
      private short A112TTBUS3_BusPar ;
      private short Z107TTBUS3_Sist ;
      private short Z108TTBUS3_HdwId ;
      private short Z110TTBUS3_BusRub ;
      private short Z111TTBUS3_BusCod ;
      private short Z112TTBUS3_BusPar ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int A105TTBUS3_IdBien ;
      private int edtTTBUS3_IdBien_Enabled ;
      private int A106TTBUS3_NroAsoc ;
      private int edtTTBUS3_NroAsoc_Enabled ;
      private int edtTTBUS3_Sist_Enabled ;
      private int edtTTBUS3_HdwId_Enabled ;
      private int edtTTBUS3_BusEmp_Enabled ;
      private int edtTTBUS3_BusRub_Enabled ;
      private int edtTTBUS3_BusCod_Enabled ;
      private int edtTTBUS3_BusPar_Enabled ;
      private int edtTTBUS3_Usuario_Enabled ;
      private int edtTTBUS3_FechaAsoc_Enabled ;
      private int edtTTBUS3_MaquinaAsoc_Enabled ;
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
      private int Z105TTBUS3_IdBien ;
      private int Z106TTBUS3_NroAsoc ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS3_IdBien_Internalname ;
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
      private String lblTextblockttbus3_idbien_Internalname ;
      private String lblTextblockttbus3_idbien_Jsonclick ;
      private String edtTTBUS3_IdBien_Jsonclick ;
      private String lblTextblockttbus3_nroasoc_Internalname ;
      private String lblTextblockttbus3_nroasoc_Jsonclick ;
      private String edtTTBUS3_NroAsoc_Internalname ;
      private String edtTTBUS3_NroAsoc_Jsonclick ;
      private String lblTextblockttbus3_sist_Internalname ;
      private String lblTextblockttbus3_sist_Jsonclick ;
      private String edtTTBUS3_Sist_Internalname ;
      private String edtTTBUS3_Sist_Jsonclick ;
      private String lblTextblockttbus3_hdwid_Internalname ;
      private String lblTextblockttbus3_hdwid_Jsonclick ;
      private String edtTTBUS3_HdwId_Internalname ;
      private String edtTTBUS3_HdwId_Jsonclick ;
      private String lblTextblockttbus3_busemp_Internalname ;
      private String lblTextblockttbus3_busemp_Jsonclick ;
      private String edtTTBUS3_BusEmp_Internalname ;
      private String A109TTBUS3_BusEmp ;
      private String edtTTBUS3_BusEmp_Jsonclick ;
      private String lblTextblockttbus3_busrub_Internalname ;
      private String lblTextblockttbus3_busrub_Jsonclick ;
      private String edtTTBUS3_BusRub_Internalname ;
      private String edtTTBUS3_BusRub_Jsonclick ;
      private String lblTextblockttbus3_buscod_Internalname ;
      private String lblTextblockttbus3_buscod_Jsonclick ;
      private String edtTTBUS3_BusCod_Internalname ;
      private String edtTTBUS3_BusCod_Jsonclick ;
      private String lblTextblockttbus3_buspar_Internalname ;
      private String lblTextblockttbus3_buspar_Jsonclick ;
      private String edtTTBUS3_BusPar_Internalname ;
      private String edtTTBUS3_BusPar_Jsonclick ;
      private String lblTextblockttbus3_usuario_Internalname ;
      private String lblTextblockttbus3_usuario_Jsonclick ;
      private String edtTTBUS3_Usuario_Internalname ;
      private String A113TTBUS3_Usuario ;
      private String edtTTBUS3_Usuario_Jsonclick ;
      private String lblTextblockttbus3_fechaasoc_Internalname ;
      private String lblTextblockttbus3_fechaasoc_Jsonclick ;
      private String edtTTBUS3_FechaAsoc_Internalname ;
      private String edtTTBUS3_FechaAsoc_Jsonclick ;
      private String lblTextblockttbus3_maquinaasoc_Internalname ;
      private String lblTextblockttbus3_maquinaasoc_Jsonclick ;
      private String edtTTBUS3_MaquinaAsoc_Internalname ;
      private String A115TTBUS3_MaquinaAsoc ;
      private String edtTTBUS3_MaquinaAsoc_Jsonclick ;
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
      private String Z109TTBUS3_BusEmp ;
      private String Z113TTBUS3_Usuario ;
      private String Z115TTBUS3_MaquinaAsoc ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode11 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A114TTBUS3_FechaAsoc ;
      private DateTime Z114TTBUS3_FechaAsoc ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n108TTBUS3_HdwId ;
      private bool n109TTBUS3_BusEmp ;
      private bool n110TTBUS3_BusRub ;
      private bool n111TTBUS3_BusCod ;
      private bool n112TTBUS3_BusPar ;
      private bool Gx_longc ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000B4_A105TTBUS3_IdBien ;
      private int[] T000B4_A106TTBUS3_NroAsoc ;
      private short[] T000B4_A107TTBUS3_Sist ;
      private short[] T000B4_A108TTBUS3_HdwId ;
      private bool[] T000B4_n108TTBUS3_HdwId ;
      private String[] T000B4_A109TTBUS3_BusEmp ;
      private bool[] T000B4_n109TTBUS3_BusEmp ;
      private short[] T000B4_A110TTBUS3_BusRub ;
      private bool[] T000B4_n110TTBUS3_BusRub ;
      private short[] T000B4_A111TTBUS3_BusCod ;
      private bool[] T000B4_n111TTBUS3_BusCod ;
      private short[] T000B4_A112TTBUS3_BusPar ;
      private bool[] T000B4_n112TTBUS3_BusPar ;
      private String[] T000B4_A113TTBUS3_Usuario ;
      private DateTime[] T000B4_A114TTBUS3_FechaAsoc ;
      private String[] T000B4_A115TTBUS3_MaquinaAsoc ;
      private int[] T000B5_A105TTBUS3_IdBien ;
      private int[] T000B5_A106TTBUS3_NroAsoc ;
      private int[] T000B3_A105TTBUS3_IdBien ;
      private int[] T000B3_A106TTBUS3_NroAsoc ;
      private short[] T000B3_A107TTBUS3_Sist ;
      private short[] T000B3_A108TTBUS3_HdwId ;
      private bool[] T000B3_n108TTBUS3_HdwId ;
      private String[] T000B3_A109TTBUS3_BusEmp ;
      private bool[] T000B3_n109TTBUS3_BusEmp ;
      private short[] T000B3_A110TTBUS3_BusRub ;
      private bool[] T000B3_n110TTBUS3_BusRub ;
      private short[] T000B3_A111TTBUS3_BusCod ;
      private bool[] T000B3_n111TTBUS3_BusCod ;
      private short[] T000B3_A112TTBUS3_BusPar ;
      private bool[] T000B3_n112TTBUS3_BusPar ;
      private String[] T000B3_A113TTBUS3_Usuario ;
      private DateTime[] T000B3_A114TTBUS3_FechaAsoc ;
      private String[] T000B3_A115TTBUS3_MaquinaAsoc ;
      private int[] T000B6_A105TTBUS3_IdBien ;
      private int[] T000B6_A106TTBUS3_NroAsoc ;
      private int[] T000B7_A105TTBUS3_IdBien ;
      private int[] T000B7_A106TTBUS3_NroAsoc ;
      private int[] T000B8_A105TTBUS3_IdBien ;
      private int[] T000B8_A106TTBUS3_NroAsoc ;
      private short[] T000B8_A107TTBUS3_Sist ;
      private short[] T000B8_A108TTBUS3_HdwId ;
      private bool[] T000B8_n108TTBUS3_HdwId ;
      private String[] T000B8_A109TTBUS3_BusEmp ;
      private bool[] T000B8_n109TTBUS3_BusEmp ;
      private short[] T000B8_A110TTBUS3_BusRub ;
      private bool[] T000B8_n110TTBUS3_BusRub ;
      private short[] T000B8_A111TTBUS3_BusCod ;
      private bool[] T000B8_n111TTBUS3_BusCod ;
      private short[] T000B8_A112TTBUS3_BusPar ;
      private bool[] T000B8_n112TTBUS3_BusPar ;
      private String[] T000B8_A113TTBUS3_Usuario ;
      private DateTime[] T000B8_A114TTBUS3_FechaAsoc ;
      private String[] T000B8_A115TTBUS3_MaquinaAsoc ;
      private int[] T000B12_A105TTBUS3_IdBien ;
      private int[] T000B12_A106TTBUS3_NroAsoc ;
      private int[] T000B2_A105TTBUS3_IdBien ;
      private int[] T000B2_A106TTBUS3_NroAsoc ;
      private short[] T000B2_A107TTBUS3_Sist ;
      private short[] T000B2_A108TTBUS3_HdwId ;
      private String[] T000B2_A109TTBUS3_BusEmp ;
      private short[] T000B2_A110TTBUS3_BusRub ;
      private short[] T000B2_A111TTBUS3_BusCod ;
      private short[] T000B2_A112TTBUS3_BusPar ;
      private String[] T000B2_A113TTBUS3_Usuario ;
      private DateTime[] T000B2_A114TTBUS3_FechaAsoc ;
      private String[] T000B2_A115TTBUS3_MaquinaAsoc ;
      private bool[] T000B2_n108TTBUS3_HdwId ;
      private bool[] T000B2_n109TTBUS3_BusEmp ;
      private bool[] T000B2_n110TTBUS3_BusRub ;
      private bool[] T000B2_n111TTBUS3_BusCod ;
      private bool[] T000B2_n112TTBUS3_BusPar ;
      private GXWebForm Form ;
   }

   public class ttbus003__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000B2 ;
          prmT000B2 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B4 ;
          prmT000B4 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B5 ;
          prmT000B5 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B3 ;
          prmT000B3 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B6 ;
          prmT000B6 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B7 ;
          prmT000B7 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B8 ;
          prmT000B8 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B9 ;
          prmT000B9 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_Sist",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS3_HdwId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusEmp",SqlDbType.Char,1,0} ,
          new Object[] {"@TTBUS3_BusRub",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusPar",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS3_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS3_FechaAsoc",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS3_MaquinaAsoc",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000B10 ;
          prmT000B10 = new Object[] {
          new Object[] {"@TTBUS3_Sist",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS3_HdwId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusEmp",SqlDbType.Char,1,0} ,
          new Object[] {"@TTBUS3_BusRub",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusPar",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS3_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS3_FechaAsoc",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS3_MaquinaAsoc",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B11 ;
          prmT000B11 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000B12 ;
          prmT000B12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000B2", "SELECT [TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc] FROM [TTBUS003] WITH (UPDLOCK) WHERE [TTBUS3_IdBien] = @TTBUS3_IdBien AND [TTBUS3_NroAsoc] = @TTBUS3_NroAsoc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B2,1,0,true,false )
             ,new CursorDef("T000B3", "SELECT [TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE [TTBUS3_IdBien] = @TTBUS3_IdBien AND [TTBUS3_NroAsoc] = @TTBUS3_NroAsoc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B3,1,0,true,false )
             ,new CursorDef("T000B4", "SELECT TM1.[TTBUS3_IdBien], TM1.[TTBUS3_NroAsoc], TM1.[TTBUS3_Sist], TM1.[TTBUS3_HdwId], TM1.[TTBUS3_BusEmp], TM1.[TTBUS3_BusRub], TM1.[TTBUS3_BusCod], TM1.[TTBUS3_BusPar], TM1.[TTBUS3_Usuario], TM1.[TTBUS3_FechaAsoc], TM1.[TTBUS3_MaquinaAsoc] FROM [TTBUS003] TM1 WITH (NOLOCK) WHERE TM1.[TTBUS3_IdBien] = @TTBUS3_IdBien and TM1.[TTBUS3_NroAsoc] = @TTBUS3_NroAsoc ORDER BY TM1.[TTBUS3_IdBien], TM1.[TTBUS3_NroAsoc]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B4,100,0,true,false )
             ,new CursorDef("T000B5", "SELECT [TTBUS3_IdBien], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE [TTBUS3_IdBien] = @TTBUS3_IdBien AND [TTBUS3_NroAsoc] = @TTBUS3_NroAsoc  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B5,1,0,true,false )
             ,new CursorDef("T000B6", "SELECT TOP 1 [TTBUS3_IdBien], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE ( [TTBUS3_IdBien] > @TTBUS3_IdBien or [TTBUS3_IdBien] = @TTBUS3_IdBien and [TTBUS3_NroAsoc] > @TTBUS3_NroAsoc) ORDER BY [TTBUS3_IdBien], [TTBUS3_NroAsoc]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B6,1,0,true,true )
             ,new CursorDef("T000B7", "SELECT TOP 1 [TTBUS3_IdBien], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE ( [TTBUS3_IdBien] < @TTBUS3_IdBien or [TTBUS3_IdBien] = @TTBUS3_IdBien and [TTBUS3_NroAsoc] < @TTBUS3_NroAsoc) ORDER BY [TTBUS3_IdBien] DESC, [TTBUS3_NroAsoc] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B7,1,0,true,true )
             ,new CursorDef("T000B8", "SELECT [TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc] FROM [TTBUS003] WITH (UPDLOCK) WHERE [TTBUS3_IdBien] = @TTBUS3_IdBien AND [TTBUS3_NroAsoc] = @TTBUS3_NroAsoc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B8,1,0,true,false )
             ,new CursorDef("T000B9", "INSERT INTO [TTBUS003] ([TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc]) VALUES (@TTBUS3_IdBien, @TTBUS3_NroAsoc, @TTBUS3_Sist, @TTBUS3_HdwId, @TTBUS3_BusEmp, @TTBUS3_BusRub, @TTBUS3_BusCod, @TTBUS3_BusPar, @TTBUS3_Usuario, @TTBUS3_FechaAsoc, @TTBUS3_MaquinaAsoc)", GxErrorMask.GX_NOMASK,prmT000B9)
             ,new CursorDef("T000B10", "UPDATE [TTBUS003] SET [TTBUS3_Sist]=@TTBUS3_Sist, [TTBUS3_HdwId]=@TTBUS3_HdwId, [TTBUS3_BusEmp]=@TTBUS3_BusEmp, [TTBUS3_BusRub]=@TTBUS3_BusRub, [TTBUS3_BusCod]=@TTBUS3_BusCod, [TTBUS3_BusPar]=@TTBUS3_BusPar, [TTBUS3_Usuario]=@TTBUS3_Usuario, [TTBUS3_FechaAsoc]=@TTBUS3_FechaAsoc, [TTBUS3_MaquinaAsoc]=@TTBUS3_MaquinaAsoc  WHERE [TTBUS3_IdBien] = @TTBUS3_IdBien AND [TTBUS3_NroAsoc] = @TTBUS3_NroAsoc", GxErrorMask.GX_NOMASK,prmT000B10)
             ,new CursorDef("T000B11", "DELETE FROM [TTBUS003]  WHERE [TTBUS3_IdBien] = @TTBUS3_IdBien AND [TTBUS3_NroAsoc] = @TTBUS3_NroAsoc", GxErrorMask.GX_NOMASK,prmT000B11)
             ,new CursorDef("T000B12", "SELECT [TTBUS3_IdBien], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) ORDER BY [TTBUS3_IdBien], [TTBUS3_NroAsoc]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B12,100,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((String[]) buf[13])[0] = rslt.getString(9, 16) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((String[]) buf[15])[0] = rslt.getString(11, 20) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((String[]) buf[13])[0] = rslt.getString(9, 16) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((String[]) buf[15])[0] = rslt.getString(11, 20) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((String[]) buf[13])[0] = rslt.getString(9, 16) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((String[]) buf[15])[0] = rslt.getString(11, 20) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((String[]) buf[13])[0] = rslt.getString(9, 16) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((String[]) buf[15])[0] = rslt.getString(11, 20) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 8 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(8, (short)parms[12]);
                }
                stmt.SetParameter(9, (String)parms[13]);
                stmt.SetParameter(10, (DateTime)parms[14]);
                stmt.SetParameter(11, (String)parms[15]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[10]);
                }
                stmt.SetParameter(7, (String)parms[11]);
                stmt.SetParameter(8, (DateTime)parms[12]);
                stmt.SetParameter(9, (String)parms[13]);
                stmt.SetParameter(10, (int)parms[14]);
                stmt.SetParameter(11, (int)parms[15]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
