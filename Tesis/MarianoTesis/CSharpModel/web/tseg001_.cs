/*
               File: TSEG001_
        Description: ACT. PROGRAMAS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:40.25
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
   public class tseg001_ : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
         {
            A164PRG_SIS = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_13( A164PRG_SIS) ;
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
               AV10PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PRG_COD), 4, 0)));
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
                  AV10PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PRG_COD), 4, 0)));
               }
            }
         }
         cmbPRG_EXT.Name = "PRG_EXT" ;
         cmbPRG_EXT.WebTags = "" ;
         cmbPRG_EXT.addItem("I", "Intranetams vers 9", 0);
         cmbPRG_EXT.addItem("X", "IntranetamsX AMS09", 0);
         cmbPRG_EXT.addItem("E", "Extranet", 0);
         cmbPRG_EXT.addItem("3", "IntranetamsX AMS03", 0);
         cmbPRG_EXT.addItem("5", "IntranetamsX AMS15", 0);
         if ( ( cmbPRG_EXT.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A128PRG_EXT)) )
         {
            A128PRG_EXT = cmbPRG_EXT.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ACT. PROGRAMAS", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPRG_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tseg001_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg001_( IGxContext context )
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
                           short aP1_PRG_COD )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10PRG_COD = aP1_PRG_COD;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbPRG_EXT = new GXCombobox();
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("hmaster_seg_ck", "GeneXus.Programs.hmaster_seg_ck", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_0S27( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0S27e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0S27( bool wbgen )
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
            wb_table2_8_0S27( true) ;
         }
         return  ;
      }

      protected void wb_table2_8_0S27e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_47_0S27( true) ;
         }
         return  ;
      }

      protected void wb_table3_47_0S27e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0S27e( true) ;
         }
         else
         {
            wb_table1_2_0S27e( false) ;
         }
      }

      protected void wb_table3_47_0S27( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"" ;
            ClassString = "BtnCheck" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_check_Internalname, "Verificar", "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "rounded", 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_help_Internalname, "Ayuda", "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "rounded", 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_47_0S27e( true) ;
         }
         else
         {
            wb_table3_47_0S27e( false) ;
         }
      }

      protected void wb_table2_8_0S27( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Código", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtPRG_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(13);\"", 0, edtPRG_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG001_.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "BtnGet" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_get_Internalname, "=>", "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "rounded", 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, edtPRG_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", 0, edtPRG_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Nombre Físico", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_NFI_Internalname, StringUtil.RTrim( A289PRG_NFI), "", 8, "chr", 1, "row", 8, 1, edtPRG_NFI_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A289PRG_NFI, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(24);\"", 0, edtPRG_NFI_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Nombre Entorno Web", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_WEB_Internalname, StringUtil.RTrim( A117PRG_WEB), "", 30, "chr", 1, "row", 30, 1, edtPRG_WEB_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A117PRG_WEB, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtPRG_WEB_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "Entorno Publicación", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPRG_EXT, cmbPRG_EXT_Internalname, A128PRG_EXT, "", "char", 1, cmbPRG_EXT.Enabled, 0, 1, 0, 3, "chr", 0, "", StyleString, ClassString, "", 0, cmbPRG_EXT_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", true, "HLP_TSEG001_.htm");
            cmbPRG_EXT.CurrentValue = A128PRG_EXT ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPRG_EXT_Internalname, "Values", (String)(cmbPRG_EXT.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Código de Sistema", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_SIS_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A164PRG_SIS), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtPRG_SIS_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A164PRG_SIS), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(39);\"", 0, edtPRG_SIS_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG001_.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_164_Internalname, "", "prompt.gif", "Modern", imgprompt_164_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_164_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, edtSIS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG001_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_0S27e( true) ;
         }
         else
         {
            wb_table2_8_0S27e( false) ;
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
         /* Execute user event: E110S2 */
         E110S2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtPRG_COD_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRG_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A126PRG_COD = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               }
               else
               {
                  A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               }
               A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A289PRG_NFI = StringUtil.Upper( cgiGet( edtPRG_NFI_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
               A117PRG_WEB = cgiGet( edtPRG_WEB_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
               cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
               A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               if ( ! context.localUtil.VCNumber( cgiGet( edtPRG_SIS_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRG_SIS");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_SIS_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A164PRG_SIS = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
               }
               else
               {
                  A164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
               }
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               n259SIS_DES = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               /* Read saved values. */
               Z126PRG_COD = (short)(context.localUtil.CToN( cgiGet( "Z126PRG_COD"), ",", ".")) ;
               Z127PRG_DES = cgiGet( "Z127PRG_DES") ;
               Z289PRG_NFI = cgiGet( "Z289PRG_NFI") ;
               Z117PRG_WEB = cgiGet( "Z117PRG_WEB") ;
               Z128PRG_EXT = cgiGet( "Z128PRG_EXT") ;
               Z164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( "Z164PRG_SIS"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               N164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( "N164PRG_SIS"), ",", ".")) ;
               AV10PRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPRG_COD"), ",", ".")) ;
               AV15Insert_PRG_SIS = (short)(context.localUtil.CToN( cgiGet( "vINSERT_PRG_SIS"), ",", ".")) ;
               AV17Pgmname = cgiGet( "vPGMNAME") ;
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
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
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
                     sMode27 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode27 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound27 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0S0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "PRG_COD");
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
                           /* Execute user event: E110S2 */
                           E110S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120S2 */
                           E120S2 ();
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
            /* Execute user event: E120S2 */
            E120S2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0S27( ) ;
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
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
            edtPRG_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Enabled), 5, 0)));
            edtPRG_NFI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_NFI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_NFI_Enabled), 5, 0)));
            edtPRG_WEB_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_WEB_Enabled), 5, 0)));
            cmbPRG_EXT.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPRG_EXT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPRG_EXT.Enabled), 5, 0)));
            edtPRG_SIS_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_SIS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_SIS_Enabled), 5, 0)));
            edtSIS_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_DES_Enabled), 5, 0)));
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

      protected void CONFIRM_0S0( )
      {
         BeforeValidate0S27( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0S27( ) ;
            }
            else
            {
               CheckExtendedTable0S27( ) ;
               if ( AnyError == 0 )
               {
                  ZM0S27( 13) ;
               }
               CloseExtendedTableCursors0S27( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
         if ( AnyError == 0 )
         {
            ConfirmValues0S0( ) ;
         }
      }

      protected void ResetCaption0S0( )
      {
      }

      protected void E110S2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV17Pgmname, out  AV12IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12IsAuthorized", StringUtil.BoolToStr( AV12IsAuthorized));
         if ( ! AV12IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)) ;
         }
         AV13TrnContext.FromXml(AV14WebSession.Get("TrnContext"), "");
         AV15Insert_PRG_SIS = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_PRG_SIS), 3, 0)));
         if ( ( StringUtil.StrCmp(AV13TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV13TrnContext.gxTpr_Attributes.Count )
            {
               AV16TrnContextAtt = ((SdtTransactionContext_Attribute)AV13TrnContext.gxTpr_Attributes.Item(AV18GXV1)) ;
               if ( StringUtil.StrCmp(AV16TrnContextAtt.gxTpr_Attributename, "PRG_SIS") == 0 )
               {
                  AV15Insert_PRG_SIS = (short)(NumberUtil.Val( AV16TrnContextAtt.gxTpr_Attributevalue, ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_PRG_SIS), 3, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
      }

      protected void E120S2( )
      {
         /* After Trn Routine */
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV13TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwtseg001.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0S27( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z127PRG_DES = T000S3_A127PRG_DES[0] ;
               Z289PRG_NFI = T000S3_A289PRG_NFI[0] ;
               Z117PRG_WEB = T000S3_A117PRG_WEB[0] ;
               Z128PRG_EXT = T000S3_A128PRG_EXT[0] ;
               Z164PRG_SIS = T000S3_A164PRG_SIS[0] ;
            }
            else
            {
               Z127PRG_DES = A127PRG_DES ;
               Z289PRG_NFI = A289PRG_NFI ;
               Z117PRG_WEB = A117PRG_WEB ;
               Z128PRG_EXT = A128PRG_EXT ;
               Z164PRG_SIS = A164PRG_SIS ;
            }
         }
         if ( GX_JID == -12 )
         {
            Z126PRG_COD = A126PRG_COD ;
            Z127PRG_DES = A127PRG_DES ;
            Z289PRG_NFI = A289PRG_NFI ;
            Z117PRG_WEB = A117PRG_WEB ;
            Z128PRG_EXT = A128PRG_EXT ;
            Z164PRG_SIS = A164PRG_SIS ;
            Z259SIS_DES = A259SIS_DES ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_164_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00w0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_SIS"+"'), id:'"+"PRG_SIS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
         if ( ! (0==AV10PRG_COD) )
         {
            A126PRG_COD = AV10PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
         if ( ! (0==AV10PRG_COD) )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_PRG_SIS) )
         {
            edtPRG_SIS_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_SIS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_SIS_Enabled), 5, 0)));
         }
         else
         {
            edtPRG_SIS_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_SIS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_SIS_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_PRG_SIS) )
         {
            A164PRG_SIS = AV15Insert_PRG_SIS ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
         }
         if ( ! (0==AV10PRG_COD) )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         else
         {
            if ( true )
            {
               edtPRG_COD_Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  edtPRG_COD_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
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
            AV17Pgmname = "TSEG001_" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000S4 */
            pr_default.execute(2, new Object[] {A164PRG_SIS});
            A259SIS_DES = T000S4_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            n259SIS_DES = T000S4_n259SIS_DES[0] ;
            pr_default.close(2);
         }
      }

      protected void Load0S27( )
      {
         /* Using cursor T000S5 */
         pr_default.execute(3, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound27 = 1 ;
            A127PRG_DES = T000S5_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T000S5_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            A117PRG_WEB = T000S5_A117PRG_WEB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
            A128PRG_EXT = T000S5_A128PRG_EXT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            A259SIS_DES = T000S5_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            n259SIS_DES = T000S5_n259SIS_DES[0] ;
            A164PRG_SIS = T000S5_A164PRG_SIS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
            ZM0S27( -12) ;
         }
         pr_default.close(3);
         OnLoadActions0S27( ) ;
      }

      protected void OnLoadActions0S27( )
      {
         AV17Pgmname = "TSEG001_" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable0S27( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV17Pgmname = "TSEG001_" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         if ( (0==A126PRG_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "");
            AnyError = 1 ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A127PRG_DES)) )
         {
            GX_msglist.addItem("Descripción NO debe ser NULA", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T000S4 */
         pr_default.execute(2, new Object[] {A164PRG_SIS});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'SISTEMA'.", "ForeignKeyNotFound", 1, "PRG_SIS");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_SIS_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000S4_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            n259SIS_DES = T000S4_n259SIS_DES[0] ;
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0S27( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_13( short A164PRG_SIS )
      {
         /* Using cursor T000S6 */
         pr_default.execute(4, new Object[] {A164PRG_SIS});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'SISTEMA'.", "ForeignKeyNotFound", 1, "PRG_SIS");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_SIS_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000S6_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            n259SIS_DES = T000S6_n259SIS_DES[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A259SIS_DES))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0S27( )
      {
         /* Using cursor T000S7 */
         pr_default.execute(5, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound27 = 1 ;
         }
         else
         {
            RcdFound27 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000S3 */
         pr_default.execute(1, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0S27( 12) ;
            RcdFound27 = 1 ;
            A126PRG_COD = T000S3_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A127PRG_DES = T000S3_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T000S3_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            A117PRG_WEB = T000S3_A117PRG_WEB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
            A128PRG_EXT = T000S3_A128PRG_EXT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            A164PRG_SIS = T000S3_A164PRG_SIS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
            Z126PRG_COD = A126PRG_COD ;
            sMode27 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0S27( ) ;
            Gx_mode = sMode27 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound27 = 0 ;
            InitializeNonKey0S27( ) ;
            sMode27 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode27 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0S27( ) ;
         if ( RcdFound27 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound27 = 0 ;
         /* Using cursor T000S8 */
         pr_default.execute(6, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000S8_A126PRG_COD[0] < A126PRG_COD ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000S8_A126PRG_COD[0] > A126PRG_COD ) ) )
            {
               A126PRG_COD = T000S8_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               RcdFound27 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound27 = 0 ;
         /* Using cursor T000S9 */
         pr_default.execute(7, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000S9_A126PRG_COD[0] > A126PRG_COD ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000S9_A126PRG_COD[0] < A126PRG_COD ) ) )
            {
               A126PRG_COD = T000S9_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               RcdFound27 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0S27( ) ;
         if ( RcdFound27 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "PRG_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A126PRG_COD != Z126PRG_COD )
            {
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "PRG_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0S27( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A126PRG_COD != Z126PRG_COD )
            {
               /* Insert record */
               Insert0S27( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "PRG_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0S27( ) ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
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
         if ( A126PRG_COD != Z126PRG_COD )
         {
            A126PRG_COD = Z126PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPRG_COD_Internalname ;
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
         GetKey0S27( ) ;
         if ( RcdFound27 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "PRG_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A126PRG_COD != Z126PRG_COD )
            {
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "DuplicatePrimaryKey", 1, "PRG_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
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
            if ( A126PRG_COD != Z126PRG_COD )
            {
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "PRG_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(7);
         pr_default.close(6);
         context.RollbackDataStores("TSEG001_");
         GX_FocusControl = edtPRG_DES_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
      }

      protected void insert_Check( )
      {
         CONFIRM_0S0( ) ;
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

      protected void CheckOptimisticConcurrency0S27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000S10 */
            pr_default.execute(8, new Object[] {A126PRG_COD});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG001"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z127PRG_DES, T000S10_A127PRG_DES[0]) != 0 ) || ( StringUtil.StrCmp(Z289PRG_NFI, T000S10_A289PRG_NFI[0]) != 0 ) || ( StringUtil.StrCmp(Z117PRG_WEB, T000S10_A117PRG_WEB[0]) != 0 ) || ( StringUtil.StrCmp(Z128PRG_EXT, T000S10_A128PRG_EXT[0]) != 0 ) || ( Z164PRG_SIS != T000S10_A164PRG_SIS[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG001"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0S27( )
      {
         BeforeValidate0S27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S27( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0S27( 0) ;
            CheckOptimisticConcurrency0S27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0S27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S11 */
                     pr_default.execute(9, new Object[] {A126PRG_COD, A127PRG_DES, A289PRG_NFI, A117PRG_WEB, A128PRG_EXT, A164PRG_SIS});
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
                           ResetCaption0S0( ) ;
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
               Load0S27( ) ;
            }
            EndLevel0S27( ) ;
         }
         CloseExtendedTableCursors0S27( ) ;
      }

      protected void Update0S27( )
      {
         BeforeValidate0S27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S27( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0S27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S12 */
                     pr_default.execute(10, new Object[] {A127PRG_DES, A289PRG_NFI, A117PRG_WEB, A128PRG_EXT, A164PRG_SIS, A126PRG_COD});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG001"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0S27( ) ;
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
            EndLevel0S27( ) ;
         }
         CloseExtendedTableCursors0S27( ) ;
      }

      protected void DeferredUpdate0S27( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0S27( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S27( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0S27( ) ;
            AfterConfirm0S27( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0S27( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000S13 */
                  pr_default.execute(11, new Object[] {A126PRG_COD});
                  pr_default.close(11);
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
         sMode27 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0S27( ) ;
         Gx_mode = sMode27 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0S27( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "TSEG001_" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000S14 */
            pr_default.execute(12, new Object[] {A164PRG_SIS});
            A259SIS_DES = T000S14_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            n259SIS_DES = T000S14_n259SIS_DES[0] ;
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000S15 */
            pr_default.execute(13, new Object[] {A126PRG_COD});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Relaciones Programas - Objetos web"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
            /* Using cursor T000S16 */
            pr_default.execute(14, new Object[] {A126PRG_COD});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"INFO MENUES X"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
            /* Using cursor T000S17 */
            pr_default.execute(15, new Object[] {A126PRG_COD});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SEG004"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
         }
      }

      protected void EndLevel0S27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0S27( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.CommitDataStores("TSEG001_");
            if ( AnyError == 0 )
            {
               ConfirmValues0S0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.RollbackDataStores("TSEG001_");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0S27( )
      {
         /* Using cursor T000S18 */
         pr_default.execute(16);
         RcdFound27 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound27 = 1 ;
            A126PRG_COD = T000S18_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0S27( )
      {
         pr_default.readNext(16);
         RcdFound27 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound27 = 1 ;
            A126PRG_COD = T000S18_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
      }

      protected void ScanEnd0S27( )
      {
      }

      protected void AfterConfirm0S27( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0S27( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0S27( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0S27( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0S27( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0S27( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0S0( )
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
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10PRG_COD) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg001_.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z127PRG_DES", StringUtil.RTrim( Z127PRG_DES));
         GxWebStd.gx_hidden_field( context, "Z289PRG_NFI", StringUtil.RTrim( Z289PRG_NFI));
         GxWebStd.gx_hidden_field( context, "Z117PRG_WEB", StringUtil.RTrim( Z117PRG_WEB));
         GxWebStd.gx_hidden_field( context, "Z128PRG_EXT", StringUtil.RTrim( Z128PRG_EXT));
         GxWebStd.gx_hidden_field( context, "Z164PRG_SIS", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z164PRG_SIS), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "N164PRG_SIS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A164PRG_SIS), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_PRG_SIS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Insert_PRG_SIS), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
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
         return "TSEG001_" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACT. PROGRAMAS" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10PRG_COD) ;
         return formatLink("tseg001_.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void InitializeNonKey0S27( )
      {
         A164PRG_SIS = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
         A127PRG_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         A289PRG_NFI = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         A117PRG_WEB = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
         A128PRG_EXT = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
         A259SIS_DES = "" ;
         n259SIS_DES = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
      }

      protected void InitAll0S27( )
      {
         A126PRG_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         InitializeNonKey0S27( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11194134");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tseg001_.js", "?11194134");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtPRG_COD_Internalname = "PRG_COD" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtPRG_DES_Internalname = "PRG_DES" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtPRG_NFI_Internalname = "PRG_NFI" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtPRG_WEB_Internalname = "PRG_WEB" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         cmbPRG_EXT_Internalname = "PRG_EXT" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtPRG_SIS_Internalname = "PRG_SIS" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtSIS_DES_Internalname = "SIS_DES" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_164_Internalname = "PROMPT_164" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ACT. PROGRAMAS" ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_DES_Enabled = 0 ;
         imgprompt_164_Visible = 1 ;
         imgprompt_164_Link = "" ;
         edtPRG_SIS_Jsonclick = "" ;
         edtPRG_SIS_Enabled = 1 ;
         cmbPRG_EXT_Jsonclick = "" ;
         cmbPRG_EXT.Enabled = 1 ;
         edtPRG_WEB_Jsonclick = "" ;
         edtPRG_WEB_Enabled = 1 ;
         edtPRG_NFI_Jsonclick = "" ;
         edtPRG_NFI_Enabled = 1 ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_DES_Enabled = 1 ;
         bttBtn_get_Enabled = 0 ;
         bttBtn_get_Visible = 1 ;
         edtPRG_COD_Jsonclick = "" ;
         edtPRG_COD_Enabled = 1 ;
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

      public void Valid_Prg_sis( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A164PRG_SIS = GX_Parm1 ;
         A259SIS_DES = GX_Parm2 ;
         n259SIS_DES = false ;
         /* Using cursor T000S14 */
         pr_default.execute(12, new Object[] {A164PRG_SIS});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'SISTEMA'.", "ForeignKeyNotFound", 1, "PRG_SIS");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_SIS_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000S14_A259SIS_DES[0] ;
            n259SIS_DES = T000S14_n259SIS_DES[0] ;
         }
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A259SIS_DES = "" ;
            n259SIS_DES = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A259SIS_DES)));
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
         pr_default.close(16);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(12);
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
         A128PRG_EXT = "" ;
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
         lblTextblock2_Jsonclick = "" ;
         A127PRG_DES = "" ;
         lblTextblock3_Jsonclick = "" ;
         A289PRG_NFI = "" ;
         lblTextblock4_Jsonclick = "" ;
         A117PRG_WEB = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         A259SIS_DES = "" ;
         Z127PRG_DES = "" ;
         Z289PRG_NFI = "" ;
         Z117PRG_WEB = "" ;
         Z128PRG_EXT = "" ;
         AV17Pgmname = "" ;
         sMode27 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV13TrnContext = new SdtTransactionContext(context);
         AV14WebSession = new GxWebSession( context);
         AV16TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z259SIS_DES = "" ;
         T000S4_A259SIS_DES = new String[] {""} ;
         T000S4_n259SIS_DES = new bool[] {false} ;
         T000S5_A126PRG_COD = new short[1] ;
         T000S5_A127PRG_DES = new String[] {""} ;
         T000S5_A289PRG_NFI = new String[] {""} ;
         T000S5_A117PRG_WEB = new String[] {""} ;
         T000S5_A128PRG_EXT = new String[] {""} ;
         T000S5_A259SIS_DES = new String[] {""} ;
         T000S5_n259SIS_DES = new bool[] {false} ;
         T000S5_A164PRG_SIS = new short[1] ;
         T000S6_A259SIS_DES = new String[] {""} ;
         T000S6_n259SIS_DES = new bool[] {false} ;
         T000S7_A126PRG_COD = new short[1] ;
         T000S3_A126PRG_COD = new short[1] ;
         T000S3_A127PRG_DES = new String[] {""} ;
         T000S3_A289PRG_NFI = new String[] {""} ;
         T000S3_A117PRG_WEB = new String[] {""} ;
         T000S3_A128PRG_EXT = new String[] {""} ;
         T000S3_A164PRG_SIS = new short[1] ;
         T000S8_A126PRG_COD = new short[1] ;
         T000S9_A126PRG_COD = new short[1] ;
         T000S10_A126PRG_COD = new short[1] ;
         T000S10_A127PRG_DES = new String[] {""} ;
         T000S10_A289PRG_NFI = new String[] {""} ;
         T000S10_A117PRG_WEB = new String[] {""} ;
         T000S10_A128PRG_EXT = new String[] {""} ;
         T000S10_A164PRG_SIS = new short[1] ;
         T000S14_A259SIS_DES = new String[] {""} ;
         T000S14_n259SIS_DES = new bool[] {false} ;
         T000S15_A116SIS_COD = new short[1] ;
         T000S15_A126PRG_COD = new short[1] ;
         T000S15_A152ACW_OBJ = new String[] {""} ;
         T000S16_A126PRG_COD = new short[1] ;
         T000S16_A361MNU_NIV = new int[1] ;
         T000S17_A6USU_COD = new String[] {""} ;
         T000S17_A116SIS_COD = new short[1] ;
         T000S17_A126PRG_COD = new short[1] ;
         T000S18_A126PRG_COD = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXEncryptionTmp = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg001___default(),
            new Object[][] {
                new Object[] {
               T000S2_A126PRG_COD, T000S2_A127PRG_DES, T000S2_A289PRG_NFI, T000S2_A117PRG_WEB, T000S2_A128PRG_EXT, T000S2_A164PRG_SIS
               }
               , new Object[] {
               T000S3_A126PRG_COD, T000S3_A127PRG_DES, T000S3_A289PRG_NFI, T000S3_A117PRG_WEB, T000S3_A128PRG_EXT, T000S3_A164PRG_SIS
               }
               , new Object[] {
               T000S4_A259SIS_DES, T000S4_n259SIS_DES
               }
               , new Object[] {
               T000S5_A126PRG_COD, T000S5_A127PRG_DES, T000S5_A289PRG_NFI, T000S5_A117PRG_WEB, T000S5_A128PRG_EXT, T000S5_A259SIS_DES, T000S5_n259SIS_DES, T000S5_A164PRG_SIS
               }
               , new Object[] {
               T000S6_A259SIS_DES, T000S6_n259SIS_DES
               }
               , new Object[] {
               T000S7_A126PRG_COD
               }
               , new Object[] {
               T000S8_A126PRG_COD
               }
               , new Object[] {
               T000S9_A126PRG_COD
               }
               , new Object[] {
               T000S10_A126PRG_COD, T000S10_A127PRG_DES, T000S10_A289PRG_NFI, T000S10_A117PRG_WEB, T000S10_A128PRG_EXT, T000S10_A164PRG_SIS
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000S14_A259SIS_DES, T000S14_n259SIS_DES
               }
               , new Object[] {
               T000S15_A116SIS_COD, T000S15_A126PRG_COD, T000S15_A152ACW_OBJ
               }
               , new Object[] {
               T000S16_A126PRG_COD, T000S16_A361MNU_NIV
               }
               , new Object[] {
               T000S17_A6USU_COD, T000S17_A116SIS_COD, T000S17_A126PRG_COD
               }
               , new Object[] {
               T000S18_A126PRG_COD
               }
            }
         );
         AV17Pgmname = "TSEG001_" ;
      }

      private short wcpOAV10PRG_COD ;
      private short GxWebError ;
      private short A164PRG_SIS ;
      private short AV10PRG_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A126PRG_COD ;
      private short Z126PRG_COD ;
      private short Z164PRG_SIS ;
      private short N164PRG_SIS ;
      private short AV15Insert_PRG_SIS ;
      private short RcdFound27 ;
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
      private int edtPRG_COD_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtPRG_DES_Enabled ;
      private int edtPRG_NFI_Enabled ;
      private int edtPRG_WEB_Enabled ;
      private int edtPRG_SIS_Enabled ;
      private int imgprompt_164_Visible ;
      private int edtSIS_DES_Enabled ;
      private int AV18GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String GXDecQS ;
      private String A128PRG_EXT ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPRG_COD_Internalname ;
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
      private String edtPRG_COD_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtPRG_DES_Internalname ;
      private String A127PRG_DES ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtPRG_NFI_Internalname ;
      private String A289PRG_NFI ;
      private String edtPRG_NFI_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtPRG_WEB_Internalname ;
      private String A117PRG_WEB ;
      private String edtPRG_WEB_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String cmbPRG_EXT_Internalname ;
      private String cmbPRG_EXT_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtPRG_SIS_Internalname ;
      private String edtPRG_SIS_Jsonclick ;
      private String imgprompt_164_Internalname ;
      private String imgprompt_164_Link ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtSIS_DES_Internalname ;
      private String A259SIS_DES ;
      private String edtSIS_DES_Jsonclick ;
      private String Z127PRG_DES ;
      private String Z289PRG_NFI ;
      private String Z117PRG_WEB ;
      private String Z128PRG_EXT ;
      private String AV17Pgmname ;
      private String sMode27 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z259SIS_DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXEncryptionTmp ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n259SIS_DES ;
      private bool AV12IsAuthorized ;
      private bool returnInSub ;
      private GxWebSession AV14WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPRG_EXT ;
      private IDataStoreProvider pr_default ;
      private String[] T000S4_A259SIS_DES ;
      private bool[] T000S4_n259SIS_DES ;
      private short[] T000S5_A126PRG_COD ;
      private String[] T000S5_A127PRG_DES ;
      private String[] T000S5_A289PRG_NFI ;
      private String[] T000S5_A117PRG_WEB ;
      private String[] T000S5_A128PRG_EXT ;
      private String[] T000S5_A259SIS_DES ;
      private bool[] T000S5_n259SIS_DES ;
      private short[] T000S5_A164PRG_SIS ;
      private String[] T000S6_A259SIS_DES ;
      private bool[] T000S6_n259SIS_DES ;
      private short[] T000S7_A126PRG_COD ;
      private short[] T000S3_A126PRG_COD ;
      private String[] T000S3_A127PRG_DES ;
      private String[] T000S3_A289PRG_NFI ;
      private String[] T000S3_A117PRG_WEB ;
      private String[] T000S3_A128PRG_EXT ;
      private short[] T000S3_A164PRG_SIS ;
      private short[] T000S8_A126PRG_COD ;
      private short[] T000S9_A126PRG_COD ;
      private short[] T000S10_A126PRG_COD ;
      private String[] T000S10_A127PRG_DES ;
      private String[] T000S10_A289PRG_NFI ;
      private String[] T000S10_A117PRG_WEB ;
      private String[] T000S10_A128PRG_EXT ;
      private short[] T000S10_A164PRG_SIS ;
      private String[] T000S14_A259SIS_DES ;
      private bool[] T000S14_n259SIS_DES ;
      private short[] T000S15_A116SIS_COD ;
      private short[] T000S15_A126PRG_COD ;
      private String[] T000S15_A152ACW_OBJ ;
      private short[] T000S16_A126PRG_COD ;
      private int[] T000S16_A361MNU_NIV ;
      private String[] T000S17_A6USU_COD ;
      private short[] T000S17_A116SIS_COD ;
      private short[] T000S17_A126PRG_COD ;
      private short[] T000S18_A126PRG_COD ;
      private short[] T000S2_A126PRG_COD ;
      private String[] T000S2_A127PRG_DES ;
      private String[] T000S2_A289PRG_NFI ;
      private String[] T000S2_A117PRG_WEB ;
      private String[] T000S2_A128PRG_EXT ;
      private short[] T000S2_A164PRG_SIS ;
      private GXWebForm Form ;
      private SdtTransactionContext AV13TrnContext ;
      private SdtTransactionContext_Attribute AV16TrnContextAtt ;
   }

   public class tseg001___default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000S2 ;
          prmT000S2 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S5 ;
          prmT000S5 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S4 ;
          prmT000S4 = new Object[] {
          new Object[] {"@PRG_SIS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000S6 ;
          prmT000S6 = new Object[] {
          new Object[] {"@PRG_SIS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000S7 ;
          prmT000S7 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S3 ;
          prmT000S3 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S8 ;
          prmT000S8 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S9 ;
          prmT000S9 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S10 ;
          prmT000S10 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S11 ;
          prmT000S11 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRG_DES",SqlDbType.Char,30,0} ,
          new Object[] {"@PRG_NFI",SqlDbType.Char,8,0} ,
          new Object[] {"@PRG_WEB",SqlDbType.Char,30,0} ,
          new Object[] {"@PRG_EXT",SqlDbType.Char,3,0} ,
          new Object[] {"@PRG_SIS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000S12 ;
          prmT000S12 = new Object[] {
          new Object[] {"@PRG_DES",SqlDbType.Char,30,0} ,
          new Object[] {"@PRG_NFI",SqlDbType.Char,8,0} ,
          new Object[] {"@PRG_WEB",SqlDbType.Char,30,0} ,
          new Object[] {"@PRG_EXT",SqlDbType.Char,3,0} ,
          new Object[] {"@PRG_SIS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S13 ;
          prmT000S13 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S15 ;
          prmT000S15 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S16 ;
          prmT000S16 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S17 ;
          prmT000S17 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S18 ;
          prmT000S18 = new Object[] {
          } ;
          Object[] prmT000S14 ;
          prmT000S14 = new Object[] {
          new Object[] {"@PRG_SIS",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000S2", "SELECT [PRG_COD], [PRG_DES], [PRG_NFI], [PRG_WEB], [PRG_EXT], [PRG_SIS] AS PRG_SIS FROM [SEG001] WITH (UPDLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S2,1,1,true,false )
             ,new CursorDef("T000S3", "SELECT [PRG_COD], [PRG_DES], [PRG_NFI], [PRG_WEB], [PRG_EXT], [PRG_SIS] AS PRG_SIS FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S3,1,1,true,false )
             ,new CursorDef("T000S4", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @PRG_SIS ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S4,1,1,true,false )
             ,new CursorDef("T000S5", "SELECT TM1.[PRG_COD], TM1.[PRG_DES], TM1.[PRG_NFI], TM1.[PRG_WEB], TM1.[PRG_EXT], T2.[SIS_DES], TM1.[PRG_SIS] AS PRG_SIS FROM ([SEG001] TM1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = TM1.[PRG_SIS]) WHERE TM1.[PRG_COD] = @PRG_COD ORDER BY TM1.[PRG_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S5,100,1,true,false )
             ,new CursorDef("T000S6", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @PRG_SIS ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S6,1,1,true,false )
             ,new CursorDef("T000S7", "SELECT [PRG_COD] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S7,1,1,true,false )
             ,new CursorDef("T000S8", "SELECT TOP 1 [PRG_COD] FROM [SEG001] WITH (NOLOCK) WHERE ( [PRG_COD] > @PRG_COD) ORDER BY [PRG_COD]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S8,1,1,true,true )
             ,new CursorDef("T000S9", "SELECT TOP 1 [PRG_COD] FROM [SEG001] WITH (NOLOCK) WHERE ( [PRG_COD] < @PRG_COD) ORDER BY [PRG_COD] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S9,1,1,true,true )
             ,new CursorDef("T000S10", "SELECT [PRG_COD], [PRG_DES], [PRG_NFI], [PRG_WEB], [PRG_EXT], [PRG_SIS] AS PRG_SIS FROM [SEG001] WITH (UPDLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S10,1,1,true,false )
             ,new CursorDef("T000S11", "INSERT INTO [SEG001] ([PRG_COD], [PRG_DES], [PRG_NFI], [PRG_WEB], [PRG_EXT], [PRG_SIS], [PRG_SEG]) VALUES (@PRG_COD, @PRG_DES, @PRG_NFI, @PRG_WEB, @PRG_EXT, @PRG_SIS, '')", GxErrorMask.GX_NOMASK,prmT000S11)
             ,new CursorDef("T000S12", "UPDATE [SEG001] SET [PRG_DES]=@PRG_DES, [PRG_NFI]=@PRG_NFI, [PRG_WEB]=@PRG_WEB, [PRG_EXT]=@PRG_EXT, [PRG_SIS]=@PRG_SIS  WHERE [PRG_COD] = @PRG_COD", GxErrorMask.GX_NOMASK,prmT000S12)
             ,new CursorDef("T000S13", "DELETE FROM [SEG001]  WHERE [PRG_COD] = @PRG_COD", GxErrorMask.GX_NOMASK,prmT000S13)
             ,new CursorDef("T000S14", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @PRG_SIS ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S14,1,1,true,false )
             ,new CursorDef("T000S15", "SELECT TOP 1 [SIS_COD], [PRG_COD], [ACW_OBJ] FROM [SEG009] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S15,1,1,true,true )
             ,new CursorDef("T000S16", "SELECT TOP 1 [PRG_COD], [MNU_NIV] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S16,1,1,true,true )
             ,new CursorDef("T000S17", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S17,1,1,true,true )
             ,new CursorDef("T000S18", "SELECT [PRG_COD] FROM [SEG001] WITH (NOLOCK) ORDER BY [PRG_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S18,100,1,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 15) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 16 :
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
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
