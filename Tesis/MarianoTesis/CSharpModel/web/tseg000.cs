/*
               File: TSEG000
        Description: ACT. SISTEMAS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:37.23
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
   public class tseg000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         if ( ! entryPointCalled )
         {
            Gx_mode = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV10SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10SIS_COD), 3, 0)));
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            GxWebError = 1 ;
            context.HttpContext.Response.StatusDescription = 403.ToString();
            context.WriteHtmlText( "<title>403 Forbidden</title>") ;
            context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
            context.WriteHtmlText( "<p /><hr />") ;
         }
         if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
            if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
            {
               SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
            }
            else
            {
               GxWebError = 1 ;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
            }
         }
         if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            if ( ! entryPointCalled )
            {
               Gx_mode = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV10SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10SIS_COD), 3, 0)));
               }
            }
         }
         cmbSIS_MEX.Name = "SIS_MEX" ;
         cmbSIS_MEX.WebTags = "" ;
         cmbSIS_MEX.addItem("X", "Si", 0);
         cmbSIS_MEX.addItem("", "No", 0);
         if ( ( cmbSIS_MEX.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A125SIS_MEX)) )
         {
            A125SIS_MEX = cmbSIS_MEX.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125SIS_MEX", A125SIS_MEX);
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ACT. SISTEMAS", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSIS_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tseg000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg000( IGxContext context )
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

      public void execute( String aP0_Gx_mode ,
                           short aP1_SIS_COD )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10SIS_COD = aP1_SIS_COD;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbSIS_MEX = new GXCombobox();
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_0X32( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0X32e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0X32( bool wbgen )
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
            wb_table2_8_0X32( true) ;
         }
         return  ;
      }

      protected void wb_table2_8_0X32e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_43_0X32( true) ;
         }
         return  ;
      }

      protected void wb_table3_43_0X32e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0X32e( true) ;
         }
         else
         {
            wb_table1_2_0X32e( false) ;
         }
      }

      protected void wb_table3_43_0X32( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "BtnCheck" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_check_Internalname, "Verificar", "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "rounded", 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_help_Internalname, "Ayuda", "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "rounded", 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_43_0X32e( true) ;
         }
         else
         {
            wb_table3_43_0X32e( false) ;
         }
      }

      protected void wb_table2_8_0X32( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Código", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtSIS_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(13);\"", 0, edtSIS_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG000.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "BtnGet" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_get_Internalname, "=>", "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "rounded", 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "HLP_TSEG000.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndisponible_Internalname, "DISPONIBLE", "DISPONIBLE", "", StyleString, ClassString, bttBtndisponible_Visible, 1, "rounded", 5, bttBtndisponible_Jsonclick, "E\\'DISPONIBLE\\'.", TempTags, "", "", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, edtSIS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(20);\"", 0, edtSIS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Mostar Icono menú X", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbSIS_MEX, cmbSIS_MEX_Internalname, A125SIS_MEX, "", "char", 1, cmbSIS_MEX.Enabled, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbSIS_MEX_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(25);\"", true, "HLP_TSEG000.htm");
            cmbSIS_MEX.CurrentValue = A125SIS_MEX ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSIS_MEX_Internalname, "Values", (String)(cmbSIS_MEX.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Ícono", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_ICO_Internalname, StringUtil.RTrim( A123SIS_ICO), "", 80, "chr", 1, "row", 100, 1, edtSIS_ICO_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A123SIS_ICO, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(30);\"", 0, edtSIS_ICO_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Responsable del Sistema", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_RSP_Internalname, StringUtil.RTrim( A365SIS_RSP), "", 16, "chr", 1, "row", 16, 1, edtSIS_RSP_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A365SIS_RSP, "XXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(35);\"", 0, edtSIS_RSP_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Mail para Informar Asignaciones", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtSIS_MAI_Internalname, StringUtil.RTrim( A366SIS_MAI), 1, edtSIS_MAI_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(40);\"", -1, 0, "", "", true, "HLP_TSEG000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_0X32e( true) ;
         }
         else
         {
            wb_table2_8_0X32e( false) ;
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
         /* Execute user event: E110X2 */
         E110X2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtSIS_COD_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "SIS_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtSIS_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A116SIS_COD = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               }
               else
               {
                  A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               }
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               cmbSIS_MEX.CurrentValue = cgiGet( cmbSIS_MEX_Internalname) ;
               A125SIS_MEX = cgiGet( cmbSIS_MEX_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125SIS_MEX", A125SIS_MEX);
               A123SIS_ICO = cgiGet( edtSIS_ICO_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123SIS_ICO", A123SIS_ICO);
               A365SIS_RSP = cgiGet( edtSIS_RSP_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365SIS_RSP", A365SIS_RSP);
               A366SIS_MAI = cgiGet( edtSIS_MAI_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366SIS_MAI", A366SIS_MAI);
               /* Read saved values. */
               Z116SIS_COD = (short)(context.localUtil.CToN( cgiGet( "Z116SIS_COD"), ",", ".")) ;
               Z259SIS_DES = cgiGet( "Z259SIS_DES") ;
               Z123SIS_ICO = cgiGet( "Z123SIS_ICO") ;
               Z125SIS_MEX = cgiGet( "Z125SIS_MEX") ;
               Z124SIS_LINK = cgiGet( "Z124SIS_LINK") ;
               Z365SIS_RSP = cgiGet( "Z365SIS_RSP") ;
               Z366SIS_MAI = cgiGet( "Z366SIS_MAI") ;
               A124SIS_LINK = cgiGet( "Z124SIS_LINK") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV10SIS_COD = (short)(context.localUtil.CToN( cgiGet( "vSIS_COD"), ",", ".")) ;
               A124SIS_LINK = cgiGet( "SIS_LINK") ;
               AV18Pgmname = cgiGet( "vPGMNAME") ;
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
                  A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
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
                     sMode32 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode32 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound32 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0X0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "SIS_COD");
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E110X2 */
                           E110X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120X2 */
                           E120X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'DISPONIBLE'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E130X2 */
                           E130X2 ();
                           nKeyPressed = 3 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "CHECK") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_Check( ) ;
                           /* No code required for Help button. It is implemented at the Browser level. */
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
            /* Execute user event: E120X2 */
            E120X2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0X32( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
            edtSIS_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_DES_Enabled), 5, 0)));
            cmbSIS_MEX.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSIS_MEX_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSIS_MEX.Enabled), 5, 0)));
            edtSIS_ICO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_ICO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_ICO_Enabled), 5, 0)));
            edtSIS_RSP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_RSP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_RSP_Enabled), 5, 0)));
            edtSIS_MAI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_MAI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_MAI_Enabled), 5, 0)));
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

      protected void CONFIRM_0X0( )
      {
         BeforeValidate0X32( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0X32( ) ;
            }
            else
            {
               CheckExtendedTable0X32( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0X32( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
         if ( AnyError == 0 )
         {
            ConfirmValues0X0( ) ;
         }
      }

      protected void ResetCaption0X0( )
      {
      }

      protected void E110X2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV18Pgmname, out  AV12IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12IsAuthorized", StringUtil.BoolToStr( AV12IsAuthorized));
         if ( ! AV12IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV18Pgmname)) ;
         }
         AV13TrnContext.FromXml(AV14WebSession.Get("TrnContext"), "");
      }

      protected void E120X2( )
      {
         /* After Trn Routine */
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV13TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwtseg000.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void E130X2( )
      {
         /* 'DISPONIBLE' Routine */
         context.wjLoc = formatLink("hseg000_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO)) ;
      }

      protected void ZM0X32( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z259SIS_DES = T000X3_A259SIS_DES[0] ;
               Z123SIS_ICO = T000X3_A123SIS_ICO[0] ;
               Z125SIS_MEX = T000X3_A125SIS_MEX[0] ;
               Z124SIS_LINK = T000X3_A124SIS_LINK[0] ;
               Z365SIS_RSP = T000X3_A365SIS_RSP[0] ;
               Z366SIS_MAI = T000X3_A366SIS_MAI[0] ;
            }
            else
            {
               Z259SIS_DES = A259SIS_DES ;
               Z123SIS_ICO = A123SIS_ICO ;
               Z125SIS_MEX = A125SIS_MEX ;
               Z124SIS_LINK = A124SIS_LINK ;
               Z365SIS_RSP = A365SIS_RSP ;
               Z366SIS_MAI = A366SIS_MAI ;
            }
         }
         if ( GX_JID == -8 )
         {
            Z116SIS_COD = A116SIS_COD ;
            Z259SIS_DES = A259SIS_DES ;
            Z123SIS_ICO = A123SIS_ICO ;
            Z125SIS_MEX = A125SIS_MEX ;
            Z124SIS_LINK = A124SIS_LINK ;
            Z365SIS_RSP = A365SIS_RSP ;
            Z366SIS_MAI = A366SIS_MAI ;
         }
      }

      protected void standaloneNotModal( )
      {
         if ( ! (0==AV10SIS_COD) )
         {
            A116SIS_COD = AV10SIS_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
         if ( ! (0==AV10SIS_COD) )
         {
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            bttBtndisponible_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtndisponible_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtndisponible_Visible), 5, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               bttBtndisponible_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtndisponible_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtndisponible_Visible), 5, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
               {
                  bttBtndisponible_Visible = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtndisponible_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtndisponible_Visible), 5, 0)));
               }
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV10SIS_COD) )
         {
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
         else
         {
            if ( true )
            {
               edtSIS_COD_Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  edtSIS_COD_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
               }
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            bttBtn_get_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_get_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_check_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_check_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV18Pgmname = "TSEG000" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         }
      }

      protected void Load0X32( )
      {
         /* Using cursor T000X4 */
         pr_default.execute(2, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound32 = 1 ;
            A259SIS_DES = T000X4_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            A123SIS_ICO = T000X4_A123SIS_ICO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123SIS_ICO", A123SIS_ICO);
            A125SIS_MEX = T000X4_A125SIS_MEX[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125SIS_MEX", A125SIS_MEX);
            A124SIS_LINK = T000X4_A124SIS_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SIS_LINK", A124SIS_LINK);
            A365SIS_RSP = T000X4_A365SIS_RSP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365SIS_RSP", A365SIS_RSP);
            A366SIS_MAI = T000X4_A366SIS_MAI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366SIS_MAI", A366SIS_MAI);
            ZM0X32( -8) ;
         }
         pr_default.close(2);
         OnLoadActions0X32( ) ;
      }

      protected void OnLoadActions0X32( )
      {
         AV18Pgmname = "TSEG000" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
      }

      protected void CheckExtendedTable0X32( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV18Pgmname = "TSEG000" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         if ( (0==A116SIS_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "");
            AnyError = 1 ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A259SIS_DES)) )
         {
            GX_msglist.addItem("Descripción NO debe ser NULA", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0X32( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0X32( )
      {
         /* Using cursor T000X5 */
         pr_default.execute(3, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound32 = 1 ;
         }
         else
         {
            RcdFound32 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000X3 */
         pr_default.execute(1, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0X32( 8) ;
            RcdFound32 = 1 ;
            A116SIS_COD = T000X3_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A259SIS_DES = T000X3_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            A123SIS_ICO = T000X3_A123SIS_ICO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123SIS_ICO", A123SIS_ICO);
            A125SIS_MEX = T000X3_A125SIS_MEX[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125SIS_MEX", A125SIS_MEX);
            A124SIS_LINK = T000X3_A124SIS_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SIS_LINK", A124SIS_LINK);
            A365SIS_RSP = T000X3_A365SIS_RSP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365SIS_RSP", A365SIS_RSP);
            A366SIS_MAI = T000X3_A366SIS_MAI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366SIS_MAI", A366SIS_MAI);
            Z116SIS_COD = A116SIS_COD ;
            sMode32 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0X32( ) ;
            Gx_mode = sMode32 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound32 = 0 ;
            InitializeNonKey0X32( ) ;
            sMode32 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode32 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0X32( ) ;
         if ( RcdFound32 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound32 = 0 ;
         /* Using cursor T000X6 */
         pr_default.execute(4, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000X6_A116SIS_COD[0] < A116SIS_COD ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000X6_A116SIS_COD[0] > A116SIS_COD ) ) )
            {
               A116SIS_COD = T000X6_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               RcdFound32 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound32 = 0 ;
         /* Using cursor T000X7 */
         pr_default.execute(5, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000X7_A116SIS_COD[0] > A116SIS_COD ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000X7_A116SIS_COD[0] < A116SIS_COD ) ) )
            {
               A116SIS_COD = T000X7_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               RcdFound32 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0X32( ) ;
         if ( RcdFound32 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "SIS_COD");
               AnyError = 1 ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A116SIS_COD != Z116SIS_COD )
            {
               A116SIS_COD = Z116SIS_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "SIS_COD");
               AnyError = 1 ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0X32( ) ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A116SIS_COD != Z116SIS_COD )
            {
               /* Insert record */
               Insert0X32( ) ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "SIS_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtSIS_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0X32( ) ;
                  GX_FocusControl = edtSIS_COD_Internalname ;
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
         if ( A116SIS_COD != Z116SIS_COD )
         {
            A116SIS_COD = Z116SIS_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void btn_Check( )
      {
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey0X32( ) ;
         if ( RcdFound32 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "SIS_COD");
               AnyError = 1 ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A116SIS_COD != Z116SIS_COD )
            {
               A116SIS_COD = Z116SIS_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "DuplicatePrimaryKey", 1, "SIS_COD");
               AnyError = 1 ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               update_Check( ) ;
            }
         }
         else
         {
            if ( A116SIS_COD != Z116SIS_COD )
            {
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "SIS_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtSIS_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(5);
         pr_default.close(4);
         context.RollbackDataStores("TSEG000");
         GX_FocusControl = edtSIS_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
      }

      protected void insert_Check( )
      {
         CONFIRM_0X0( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency0X32( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000X8 */
            pr_default.execute(6, new Object[] {A116SIS_COD});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG000"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z259SIS_DES, T000X8_A259SIS_DES[0]) != 0 ) || ( StringUtil.StrCmp(Z123SIS_ICO, T000X8_A123SIS_ICO[0]) != 0 ) || ( StringUtil.StrCmp(Z125SIS_MEX, T000X8_A125SIS_MEX[0]) != 0 ) || ( StringUtil.StrCmp(Z124SIS_LINK, T000X8_A124SIS_LINK[0]) != 0 ) || ( StringUtil.StrCmp(Z365SIS_RSP, T000X8_A365SIS_RSP[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z366SIS_MAI, T000X8_A366SIS_MAI[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG000"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0X32( )
      {
         BeforeValidate0X32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X32( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0X32( 0) ;
            CheckOptimisticConcurrency0X32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0X32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X9 */
                     pr_default.execute(7, new Object[] {A116SIS_COD, A259SIS_DES, A123SIS_ICO, A125SIS_MEX, A124SIS_LINK, A365SIS_RSP, A366SIS_MAI});
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
                           ResetCaption0X0( ) ;
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
               Load0X32( ) ;
            }
            EndLevel0X32( ) ;
         }
         CloseExtendedTableCursors0X32( ) ;
      }

      protected void Update0X32( )
      {
         BeforeValidate0X32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X32( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0X32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X10 */
                     pr_default.execute(8, new Object[] {A259SIS_DES, A123SIS_ICO, A125SIS_MEX, A124SIS_LINK, A365SIS_RSP, A366SIS_MAI, A116SIS_COD});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG000"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0X32( ) ;
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
            EndLevel0X32( ) ;
         }
         CloseExtendedTableCursors0X32( ) ;
      }

      protected void DeferredUpdate0X32( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0X32( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X32( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0X32( ) ;
            AfterConfirm0X32( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0X32( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000X11 */
                  pr_default.execute(9, new Object[] {A116SIS_COD});
                  pr_default.close(9);
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
         sMode32 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0X32( ) ;
         Gx_mode = sMode32 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0X32( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV18Pgmname = "TSEG000" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000X12 */
            pr_default.execute(10, new Object[] {A116SIS_COD});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SEG001"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(10);
            /* Using cursor T000X13 */
            pr_default.execute(11, new Object[] {A116SIS_COD});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Relaciones Programas - Objetos web"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
            /* Using cursor T000X14 */
            pr_default.execute(12, new Object[] {A116SIS_COD});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SEG003"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel0X32( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0X32( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TSEG000");
            if ( AnyError == 0 )
            {
               ConfirmValues0X0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TSEG000");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0X32( )
      {
         /* Using cursor T000X15 */
         pr_default.execute(13);
         RcdFound32 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound32 = 1 ;
            A116SIS_COD = T000X15_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0X32( )
      {
         pr_default.readNext(13);
         RcdFound32 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound32 = 1 ;
            A116SIS_COD = T000X15_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
      }

      protected void ScanEnd0X32( )
      {
      }

      protected void AfterConfirm0X32( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0X32( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0X32( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0X32( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0X32( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0X32( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0X0( )
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10SIS_COD) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg000.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z259SIS_DES", StringUtil.RTrim( Z259SIS_DES));
         GxWebStd.gx_hidden_field( context, "Z123SIS_ICO", StringUtil.RTrim( Z123SIS_ICO));
         GxWebStd.gx_hidden_field( context, "Z125SIS_MEX", StringUtil.RTrim( Z125SIS_MEX));
         GxWebStd.gx_hidden_field( context, "Z124SIS_LINK", StringUtil.RTrim( Z124SIS_LINK));
         GxWebStd.gx_hidden_field( context, "Z365SIS_RSP", StringUtil.RTrim( Z365SIS_RSP));
         GxWebStd.gx_hidden_field( context, "Z366SIS_MAI", StringUtil.RTrim( Z366SIS_MAI));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SIS_LINK", StringUtil.RTrim( A124SIS_LINK));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV18Pgmname));
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
         return "TSEG000" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACT. SISTEMAS" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10SIS_COD) ;
         return formatLink("tseg000.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void InitializeNonKey0X32( )
      {
         A259SIS_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         A123SIS_ICO = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123SIS_ICO", A123SIS_ICO);
         A125SIS_MEX = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125SIS_MEX", A125SIS_MEX);
         A124SIS_LINK = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SIS_LINK", A124SIS_LINK);
         A365SIS_RSP = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365SIS_RSP", A365SIS_RSP);
         A366SIS_MAI = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366SIS_MAI", A366SIS_MAI);
      }

      protected void InitAll0X32( )
      {
         A116SIS_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         InitializeNonKey0X32( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11193819");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tseg000.js", "?11193819");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtSIS_COD_Internalname = "SIS_COD" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         bttBtndisponible_Internalname = "BTNDISPONIBLE" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtSIS_DES_Internalname = "SIS_DES" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         cmbSIS_MEX_Internalname = "SIS_MEX" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtSIS_ICO_Internalname = "SIS_ICO" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtSIS_RSP_Internalname = "SIS_RSP" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtSIS_MAI_Internalname = "SIS_MAI" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ACT. SISTEMAS" ;
         edtSIS_MAI_Enabled = 1 ;
         edtSIS_RSP_Jsonclick = "" ;
         edtSIS_RSP_Enabled = 1 ;
         edtSIS_ICO_Jsonclick = "" ;
         edtSIS_ICO_Enabled = 1 ;
         cmbSIS_MEX_Jsonclick = "" ;
         cmbSIS_MEX.Enabled = 1 ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_DES_Enabled = 1 ;
         bttBtndisponible_Visible = 1 ;
         bttBtn_get_Enabled = 0 ;
         bttBtn_get_Visible = 1 ;
         edtSIS_COD_Jsonclick = "" ;
         edtSIS_COD_Enabled = 1 ;
         bttBtn_help_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_check_Enabled = 1 ;
         bttBtn_check_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
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
         pr_default.close(13);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXKey = "" ;
         GXDecQS = "" ;
         A125SIS_MEX = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_check_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_help_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         bttBtn_get_Jsonclick = "" ;
         bttBtndisponible_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         A259SIS_DES = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         A123SIS_ICO = "" ;
         lblTextblock3_Jsonclick = "" ;
         A365SIS_RSP = "" ;
         lblTextblock4_Jsonclick = "" ;
         A366SIS_MAI = "" ;
         Z259SIS_DES = "" ;
         Z123SIS_ICO = "" ;
         Z125SIS_MEX = "" ;
         Z124SIS_LINK = "" ;
         Z365SIS_RSP = "" ;
         Z366SIS_MAI = "" ;
         A124SIS_LINK = "" ;
         AV18Pgmname = "" ;
         sMode32 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV13TrnContext = new SdtTransactionContext(context);
         AV14WebSession = new GxWebSession( context);
         AV8SISTEMA = "" ;
         AV9USUARIO = "" ;
         T000X4_A116SIS_COD = new short[1] ;
         T000X4_A259SIS_DES = new String[] {""} ;
         T000X4_A123SIS_ICO = new String[] {""} ;
         T000X4_A125SIS_MEX = new String[] {""} ;
         T000X4_A124SIS_LINK = new String[] {""} ;
         T000X4_A365SIS_RSP = new String[] {""} ;
         T000X4_A366SIS_MAI = new String[] {""} ;
         T000X5_A116SIS_COD = new short[1] ;
         T000X3_A116SIS_COD = new short[1] ;
         T000X3_A259SIS_DES = new String[] {""} ;
         T000X3_A123SIS_ICO = new String[] {""} ;
         T000X3_A125SIS_MEX = new String[] {""} ;
         T000X3_A124SIS_LINK = new String[] {""} ;
         T000X3_A365SIS_RSP = new String[] {""} ;
         T000X3_A366SIS_MAI = new String[] {""} ;
         T000X6_A116SIS_COD = new short[1] ;
         T000X7_A116SIS_COD = new short[1] ;
         T000X8_A116SIS_COD = new short[1] ;
         T000X8_A259SIS_DES = new String[] {""} ;
         T000X8_A123SIS_ICO = new String[] {""} ;
         T000X8_A125SIS_MEX = new String[] {""} ;
         T000X8_A124SIS_LINK = new String[] {""} ;
         T000X8_A365SIS_RSP = new String[] {""} ;
         T000X8_A366SIS_MAI = new String[] {""} ;
         T000X12_A126PRG_COD = new short[1] ;
         T000X13_A116SIS_COD = new short[1] ;
         T000X13_A126PRG_COD = new short[1] ;
         T000X13_A152ACW_OBJ = new String[] {""} ;
         T000X14_A6USU_COD = new String[] {""} ;
         T000X14_A116SIS_COD = new short[1] ;
         T000X15_A116SIS_COD = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXEncryptionTmp = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg000__default(),
            new Object[][] {
                new Object[] {
               T000X2_A116SIS_COD, T000X2_A259SIS_DES, T000X2_A123SIS_ICO, T000X2_A125SIS_MEX, T000X2_A124SIS_LINK, T000X2_A365SIS_RSP, T000X2_A366SIS_MAI
               }
               , new Object[] {
               T000X3_A116SIS_COD, T000X3_A259SIS_DES, T000X3_A123SIS_ICO, T000X3_A125SIS_MEX, T000X3_A124SIS_LINK, T000X3_A365SIS_RSP, T000X3_A366SIS_MAI
               }
               , new Object[] {
               T000X4_A116SIS_COD, T000X4_A259SIS_DES, T000X4_A123SIS_ICO, T000X4_A125SIS_MEX, T000X4_A124SIS_LINK, T000X4_A365SIS_RSP, T000X4_A366SIS_MAI
               }
               , new Object[] {
               T000X5_A116SIS_COD
               }
               , new Object[] {
               T000X6_A116SIS_COD
               }
               , new Object[] {
               T000X7_A116SIS_COD
               }
               , new Object[] {
               T000X8_A116SIS_COD, T000X8_A259SIS_DES, T000X8_A123SIS_ICO, T000X8_A125SIS_MEX, T000X8_A124SIS_LINK, T000X8_A365SIS_RSP, T000X8_A366SIS_MAI
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000X12_A126PRG_COD
               }
               , new Object[] {
               T000X13_A116SIS_COD, T000X13_A126PRG_COD, T000X13_A152ACW_OBJ
               }
               , new Object[] {
               T000X14_A6USU_COD, T000X14_A116SIS_COD
               }
               , new Object[] {
               T000X15_A116SIS_COD
               }
            }
         );
         AV18Pgmname = "TSEG000" ;
      }

      private short wcpOAV10SIS_COD ;
      private short GxWebError ;
      private short AV10SIS_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A116SIS_COD ;
      private short Z116SIS_COD ;
      private short RcdFound32 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_check_Visible ;
      private int bttBtn_check_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_help_Visible ;
      private int edtSIS_COD_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int bttBtndisponible_Visible ;
      private int edtSIS_DES_Enabled ;
      private int edtSIS_ICO_Enabled ;
      private int edtSIS_RSP_Enabled ;
      private int edtSIS_MAI_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String GXDecQS ;
      private String A125SIS_MEX ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSIS_COD_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String tblTable3_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_check_Internalname ;
      private String bttBtn_check_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_help_Internalname ;
      private String bttBtn_help_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String bttBtndisponible_Internalname ;
      private String bttBtndisponible_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtSIS_DES_Internalname ;
      private String A259SIS_DES ;
      private String edtSIS_DES_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String cmbSIS_MEX_Internalname ;
      private String cmbSIS_MEX_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtSIS_ICO_Internalname ;
      private String A123SIS_ICO ;
      private String edtSIS_ICO_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtSIS_RSP_Internalname ;
      private String A365SIS_RSP ;
      private String edtSIS_RSP_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtSIS_MAI_Internalname ;
      private String Z259SIS_DES ;
      private String Z123SIS_ICO ;
      private String Z125SIS_MEX ;
      private String Z124SIS_LINK ;
      private String Z365SIS_RSP ;
      private String A124SIS_LINK ;
      private String AV18Pgmname ;
      private String sMode32 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV8SISTEMA ;
      private String AV9USUARIO ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXEncryptionTmp ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool AV12IsAuthorized ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String A366SIS_MAI ;
      private String Z366SIS_MAI ;
      private GxWebSession AV14WebSession ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbSIS_MEX ;
      private IDataStoreProvider pr_default ;
      private short[] T000X4_A116SIS_COD ;
      private String[] T000X4_A259SIS_DES ;
      private String[] T000X4_A123SIS_ICO ;
      private String[] T000X4_A125SIS_MEX ;
      private String[] T000X4_A124SIS_LINK ;
      private String[] T000X4_A365SIS_RSP ;
      private String[] T000X4_A366SIS_MAI ;
      private short[] T000X5_A116SIS_COD ;
      private short[] T000X3_A116SIS_COD ;
      private String[] T000X3_A259SIS_DES ;
      private String[] T000X3_A123SIS_ICO ;
      private String[] T000X3_A125SIS_MEX ;
      private String[] T000X3_A124SIS_LINK ;
      private String[] T000X3_A365SIS_RSP ;
      private String[] T000X3_A366SIS_MAI ;
      private short[] T000X6_A116SIS_COD ;
      private short[] T000X7_A116SIS_COD ;
      private short[] T000X8_A116SIS_COD ;
      private String[] T000X8_A259SIS_DES ;
      private String[] T000X8_A123SIS_ICO ;
      private String[] T000X8_A125SIS_MEX ;
      private String[] T000X8_A124SIS_LINK ;
      private String[] T000X8_A365SIS_RSP ;
      private String[] T000X8_A366SIS_MAI ;
      private short[] T000X12_A126PRG_COD ;
      private short[] T000X13_A116SIS_COD ;
      private short[] T000X13_A126PRG_COD ;
      private String[] T000X13_A152ACW_OBJ ;
      private String[] T000X14_A6USU_COD ;
      private short[] T000X14_A116SIS_COD ;
      private short[] T000X15_A116SIS_COD ;
      private short[] T000X2_A116SIS_COD ;
      private String[] T000X2_A259SIS_DES ;
      private String[] T000X2_A123SIS_ICO ;
      private String[] T000X2_A125SIS_MEX ;
      private String[] T000X2_A124SIS_LINK ;
      private String[] T000X2_A365SIS_RSP ;
      private String[] T000X2_A366SIS_MAI ;
      private GXWebForm Form ;
      private SdtTransactionContext AV13TrnContext ;
   }

   public class tseg000__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000X2 ;
          prmT000X2 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X4 ;
          prmT000X4 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X5 ;
          prmT000X5 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X3 ;
          prmT000X3 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X6 ;
          prmT000X6 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X7 ;
          prmT000X7 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X8 ;
          prmT000X8 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X9 ;
          prmT000X9 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@SIS_DES",SqlDbType.Char,15,0} ,
          new Object[] {"@SIS_ICO",SqlDbType.Char,100,0} ,
          new Object[] {"@SIS_MEX",SqlDbType.Char,1,0} ,
          new Object[] {"@SIS_LINK",SqlDbType.Char,256,0} ,
          new Object[] {"@SIS_RSP",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_MAI",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000X10 ;
          prmT000X10 = new Object[] {
          new Object[] {"@SIS_DES",SqlDbType.Char,15,0} ,
          new Object[] {"@SIS_ICO",SqlDbType.Char,100,0} ,
          new Object[] {"@SIS_MEX",SqlDbType.Char,1,0} ,
          new Object[] {"@SIS_LINK",SqlDbType.Char,256,0} ,
          new Object[] {"@SIS_RSP",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_MAI",SqlDbType.VarChar,256,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X11 ;
          prmT000X11 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X12 ;
          prmT000X12 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X13 ;
          prmT000X13 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X14 ;
          prmT000X14 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000X15 ;
          prmT000X15 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000X2", "SELECT [SIS_COD], [SIS_DES], [SIS_ICO], [SIS_MEX], [SIS_LINK], [SIS_RSP], [SIS_MAI] FROM [SEG000] WITH (UPDLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X2,1,1,true,false )
             ,new CursorDef("T000X3", "SELECT [SIS_COD], [SIS_DES], [SIS_ICO], [SIS_MEX], [SIS_LINK], [SIS_RSP], [SIS_MAI] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X3,1,1,true,false )
             ,new CursorDef("T000X4", "SELECT TM1.[SIS_COD], TM1.[SIS_DES], TM1.[SIS_ICO], TM1.[SIS_MEX], TM1.[SIS_LINK], TM1.[SIS_RSP], TM1.[SIS_MAI] FROM [SEG000] TM1 WITH (NOLOCK) WHERE TM1.[SIS_COD] = @SIS_COD ORDER BY TM1.[SIS_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X4,100,1,true,false )
             ,new CursorDef("T000X5", "SELECT [SIS_COD] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X5,1,1,true,false )
             ,new CursorDef("T000X6", "SELECT TOP 1 [SIS_COD] FROM [SEG000] WITH (NOLOCK) WHERE ( [SIS_COD] > @SIS_COD) ORDER BY [SIS_COD]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X6,1,1,true,true )
             ,new CursorDef("T000X7", "SELECT TOP 1 [SIS_COD] FROM [SEG000] WITH (NOLOCK) WHERE ( [SIS_COD] < @SIS_COD) ORDER BY [SIS_COD] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X7,1,1,true,true )
             ,new CursorDef("T000X8", "SELECT [SIS_COD], [SIS_DES], [SIS_ICO], [SIS_MEX], [SIS_LINK], [SIS_RSP], [SIS_MAI] FROM [SEG000] WITH (UPDLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X8,1,1,true,false )
             ,new CursorDef("T000X9", "INSERT INTO [SEG000] ([SIS_COD], [SIS_DES], [SIS_ICO], [SIS_MEX], [SIS_LINK], [SIS_RSP], [SIS_MAI]) VALUES (@SIS_COD, @SIS_DES, @SIS_ICO, @SIS_MEX, @SIS_LINK, @SIS_RSP, @SIS_MAI)", GxErrorMask.GX_NOMASK,prmT000X9)
             ,new CursorDef("T000X10", "UPDATE [SEG000] SET [SIS_DES]=@SIS_DES, [SIS_ICO]=@SIS_ICO, [SIS_MEX]=@SIS_MEX, [SIS_LINK]=@SIS_LINK, [SIS_RSP]=@SIS_RSP, [SIS_MAI]=@SIS_MAI  WHERE [SIS_COD] = @SIS_COD", GxErrorMask.GX_NOMASK,prmT000X10)
             ,new CursorDef("T000X11", "DELETE FROM [SEG000]  WHERE [SIS_COD] = @SIS_COD", GxErrorMask.GX_NOMASK,prmT000X11)
             ,new CursorDef("T000X12", "SELECT TOP 1 [PRG_COD] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_SIS] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X12,1,1,true,true )
             ,new CursorDef("T000X13", "SELECT TOP 1 [SIS_COD], [PRG_COD], [ACW_OBJ] FROM [SEG009] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X13,1,1,true,true )
             ,new CursorDef("T000X14", "SELECT TOP 1 [USU_COD], [SIS_COD] FROM [SEG003] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X14,1,1,true,true )
             ,new CursorDef("T000X15", "SELECT [SIS_COD] FROM [SEG000] WITH (NOLOCK) ORDER BY [SIS_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X15,100,1,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 256) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 16) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 256) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 16) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 256) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 16) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 256) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 16) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
