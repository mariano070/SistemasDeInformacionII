/*
               File: TSEG003
        Description: ACT. USUARIO/SISTEMA
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:25.1
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
   public class tseg003 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A6USU_COD = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_10( A6USU_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_11( A116SIS_COD) ;
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
               AV10USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USU_COD", AV10USU_COD);
               AV11SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11SIS_COD), 3, 0)));
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
                  AV10USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USU_COD", AV10USU_COD);
                  AV11SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11SIS_COD), 3, 0)));
               }
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ACT. USUARIO/SISTEMA", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUSU_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tseg003( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg003( IGxContext context )
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
                           String aP1_USU_COD ,
                           short aP2_SIS_COD )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10USU_COD = aP1_USU_COD;
         this.AV11SIS_COD = aP2_SIS_COD;
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
            wb_table1_2_0G16( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0G16e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0G16( bool wbgen )
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
            wb_table2_8_0G16( true) ;
         }
         return  ;
      }

      protected void wb_table2_8_0G16e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_37_0G16( true) ;
         }
         return  ;
      }

      protected void wb_table3_37_0G16e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0G16e( true) ;
         }
         else
         {
            wb_table1_2_0G16e( false) ;
         }
      }

      protected void wb_table3_37_0G16( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"" ;
            ClassString = "BtnCheck" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_check_Internalname, "Verificar", "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "rounded", 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_help_Internalname, "Ayuda", "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "rounded", 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_37_0G16e( true) ;
         }
         else
         {
            wb_table3_37_0G16e( false) ;
         }
      }

      protected void wb_table2_8_0G16( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Código", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, edtUSU_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtUSU_COD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG003.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_6_Internalname, "", "prompt.gif", "Modern", imgprompt_6_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_6_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, edtUSU_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Contraseña", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLA_Internalname, StringUtil.RTrim( A155USU_CLA), "", 20, "chr", 1, "row", 20, 1, edtUSU_CLA_Enabled, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtUSU_CLA_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Código", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtSIS_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(28);\"", 0, edtSIS_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG003.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_116_Internalname, "", "prompt.gif", "Modern", imgprompt_116_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_116_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG003.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"" ;
            ClassString = "BtnGet" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_get_Internalname, "=>", "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "rounded", 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, edtSIS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_0G16e( true) ;
         }
         else
         {
            wb_table2_8_0G16e( false) ;
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
         /* Execute user event: E110G2 */
         E110G2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
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
               /* Read saved values. */
               Z6USU_COD = cgiGet( "Z6USU_COD") ;
               Z116SIS_COD = (short)(context.localUtil.CToN( cgiGet( "Z116SIS_COD"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV10USU_COD = cgiGet( "vUSU_COD") ;
               AV11SIS_COD = (short)(context.localUtil.CToN( cgiGet( "vSIS_COD"), ",", ".")) ;
               AV16Pgmname = cgiGet( "vPGMNAME") ;
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
                  A6USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
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
                     sMode16 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode16 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound16 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0G0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "USU_COD");
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
                           /* Execute user event: E110G2 */
                           E110G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120G2 */
                           E120G2 ();
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
            /* Execute user event: E120G2 */
            E120G2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0G16( ) ;
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
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
            edtUSU_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_DES_Enabled), 5, 0)));
            edtUSU_CLA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_CLA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CLA_Enabled), 5, 0)));
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
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

      protected void CONFIRM_0G0( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0G16( ) ;
            }
            else
            {
               CheckExtendedTable0G16( ) ;
               if ( AnyError == 0 )
               {
                  ZM0G16( 10) ;
                  ZM0G16( 11) ;
               }
               CloseExtendedTableCursors0G16( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
         if ( AnyError == 0 )
         {
            ConfirmValues0G0( ) ;
         }
      }

      protected void ResetCaption0G0( )
      {
      }

      protected void E110G2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV16Pgmname, out  AV13IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", StringUtil.BoolToStr( AV13IsAuthorized));
         if ( ! AV13IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)) ;
         }
         AV14TrnContext.FromXml(AV15WebSession.Get("TrnContext"), "");
      }

      protected void E120G2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV14TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwtseg003.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0G16( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -9 )
         {
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            Z7USU_DES = A7USU_DES ;
            Z155USU_CLA = A155USU_CLA ;
            Z259SIS_DES = A259SIS_DES ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_6_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USU_COD"+"'), id:'"+"USU_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_116_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"hseg003.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SIS_COD"+"'), id:'"+"SIS_COD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10USU_COD)) )
         {
            A6USU_COD = AV10USU_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10USU_COD)) )
         {
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         else
         {
            edtUSU_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10USU_COD)) )
         {
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV11SIS_COD) )
         {
            A116SIS_COD = AV11SIS_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
         if ( ! (0==AV11SIS_COD) )
         {
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV11SIS_COD) )
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
            /* Using cursor T000G4 */
            pr_default.execute(2, new Object[] {A6USU_COD});
            A7USU_DES = T000G4_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000G4_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            pr_default.close(2);
            AV16Pgmname = "TSEG003" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T000G5 */
            pr_default.execute(3, new Object[] {A116SIS_COD});
            A259SIS_DES = T000G5_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            pr_default.close(3);
         }
      }

      protected void Load0G16( )
      {
         /* Using cursor T000G6 */
         pr_default.execute(4, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound16 = 1 ;
            A7USU_DES = T000G6_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000G6_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            A259SIS_DES = T000G6_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            ZM0G16( -9) ;
         }
         pr_default.close(4);
         OnLoadActions0G16( ) ;
      }

      protected void OnLoadActions0G16( )
      {
         AV16Pgmname = "TSEG003" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
      }

      protected void CheckExtendedTable0G16( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV16Pgmname = "TSEG003" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         /* Using cursor T000G4 */
         pr_default.execute(2, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T000G4_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000G4_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         }
         pr_default.close(2);
         /* Using cursor T000G5 */
         pr_default.execute(3, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(3) == 101) )
         {
            context.wjLoc = formatLink("hseg003.aspx") + "?" + UrlEncode("" +A116SIS_COD) ;
            /* Using cursor T000G5 */
            pr_default.execute(3, new Object[] {A116SIS_COD});
            if ( (pr_default.getStatus(3) == 101) )
            {
               GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
               AnyError = 1 ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000G5_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         pr_default.close(3);
         if ( (0==A116SIS_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0G16( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_10( String A6USU_COD )
      {
         /* Using cursor T000G7 */
         pr_default.execute(5, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T000G7_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000G7_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A7USU_DES))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A155USU_CLA))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_11( short A116SIS_COD )
      {
         /* Using cursor T000G8 */
         pr_default.execute(6, new Object[] {A116SIS_COD});
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000G8_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A259SIS_DES))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey0G16( )
      {
         /* Using cursor T000G9 */
         pr_default.execute(7, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound16 = 1 ;
         }
         else
         {
            RcdFound16 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000G3 */
         pr_default.execute(1, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0G16( 9) ;
            RcdFound16 = 1 ;
            A6USU_COD = T000G3_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = T000G3_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            sMode16 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0G16( ) ;
            Gx_mode = sMode16 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound16 = 0 ;
            InitializeNonKey0G16( ) ;
            sMode16 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode16 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0G16( ) ;
         if ( RcdFound16 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound16 = 0 ;
         /* Using cursor T000G10 */
         pr_default.execute(8, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000G10_A6USU_COD[0], A6USU_COD) < 0 ) || ( StringUtil.StrCmp(T000G10_A6USU_COD[0], A6USU_COD) == 0 ) && ( T000G10_A116SIS_COD[0] < A116SIS_COD ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000G10_A6USU_COD[0], A6USU_COD) > 0 ) || ( StringUtil.StrCmp(T000G10_A6USU_COD[0], A6USU_COD) == 0 ) && ( T000G10_A116SIS_COD[0] > A116SIS_COD ) ) )
            {
               A6USU_COD = T000G10_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = T000G10_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               RcdFound16 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound16 = 0 ;
         /* Using cursor T000G11 */
         pr_default.execute(9, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000G11_A6USU_COD[0], A6USU_COD) > 0 ) || ( StringUtil.StrCmp(T000G11_A6USU_COD[0], A6USU_COD) == 0 ) && ( T000G11_A116SIS_COD[0] > A116SIS_COD ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000G11_A6USU_COD[0], A6USU_COD) < 0 ) || ( StringUtil.StrCmp(T000G11_A6USU_COD[0], A6USU_COD) == 0 ) && ( T000G11_A116SIS_COD[0] < A116SIS_COD ) ) )
            {
               A6USU_COD = T000G11_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = T000G11_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               RcdFound16 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0G16( ) ;
         if ( RcdFound16 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) )
            {
               A6USU_COD = Z6USU_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = Z116SIS_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0G16( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) )
            {
               /* Insert record */
               Insert0G16( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0G16( ) ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
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
         if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) )
         {
            A6USU_COD = Z6USU_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = Z116SIS_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUSU_COD_Internalname ;
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
         GetKey0G16( ) ;
         if ( RcdFound16 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) )
            {
               A6USU_COD = Z6USU_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = Z116SIS_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
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
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) )
            {
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(9);
         pr_default.close(8);
         context.RollbackDataStores("TSEG003");
      }

      protected void insert_Check( )
      {
         CONFIRM_0G0( ) ;
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

      protected void CheckOptimisticConcurrency0G16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000G12 */
            pr_default.execute(10, new Object[] {A6USU_COD, A116SIS_COD});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG003"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG003"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0G16( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0G16( 0) ;
            CheckOptimisticConcurrency0G16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0G16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000G13 */
                     pr_default.execute(11, new Object[] {A6USU_COD, A116SIS_COD});
                     pr_default.close(11);
                     if ( (pr_default.getStatus(11) == 1) )
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
                           ResetCaption0G0( ) ;
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
               Load0G16( ) ;
            }
            EndLevel0G16( ) ;
         }
         CloseExtendedTableCursors0G16( ) ;
      }

      protected void Update0G16( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0G16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SEG003] */
                     DeferredUpdate0G16( ) ;
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
            EndLevel0G16( ) ;
         }
         CloseExtendedTableCursors0G16( ) ;
      }

      protected void DeferredUpdate0G16( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0G16( ) ;
            AfterConfirm0G16( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0G16( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000G14 */
                  pr_default.execute(12, new Object[] {A6USU_COD, A116SIS_COD});
                  pr_default.close(12);
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
         sMode16 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0G16( ) ;
         Gx_mode = sMode16 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0G16( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "TSEG003" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T000G15 */
            pr_default.execute(13, new Object[] {A6USU_COD});
            A7USU_DES = T000G15_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000G15_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            pr_default.close(13);
            /* Using cursor T000G16 */
            pr_default.execute(14, new Object[] {A116SIS_COD});
            A259SIS_DES = T000G16_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000G17 */
            pr_default.execute(15, new Object[] {A6USU_COD, A116SIS_COD});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SEG004"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
         }
      }

      protected void EndLevel0G16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("TSEG003");
            if ( AnyError == 0 )
            {
               ConfirmValues0G0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(13);
            pr_default.close(14);
            context.RollbackDataStores("TSEG003");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0G16( )
      {
         /* Using cursor T000G18 */
         pr_default.execute(16);
         RcdFound16 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound16 = 1 ;
            A6USU_COD = T000G18_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = T000G18_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0G16( )
      {
         pr_default.readNext(16);
         RcdFound16 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound16 = 1 ;
            A6USU_COD = T000G18_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = T000G18_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
      }

      protected void ScanEnd0G16( )
      {
      }

      protected void AfterConfirm0G16( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0G16( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0G16( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0G16( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0G16( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0G16( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0G0( )
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
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV10USU_COD)) + "," + UrlEncode("" +AV11SIS_COD) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z6USU_COD", StringUtil.RTrim( Z6USU_COD));
         GxWebStd.gx_hidden_field( context, "Z116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vUSU_COD", StringUtil.RTrim( AV10USU_COD));
         GxWebStd.gx_hidden_field( context, "vSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV16Pgmname));
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
         return "TSEG003" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACT. USUARIO/SISTEMA" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV10USU_COD)) + "," + UrlEncode("" +AV11SIS_COD) ;
         return formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void InitializeNonKey0G16( )
      {
         A7USU_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
         A155USU_CLA = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         A259SIS_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
      }

      protected void InitAll0G16( )
      {
         A6USU_COD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         A116SIS_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         InitializeNonKey0G16( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?118269");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tseg003.js", "?1182610");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtUSU_COD_Internalname = "USU_COD" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtUSU_DES_Internalname = "USU_DES" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtUSU_CLA_Internalname = "USU_CLA" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtSIS_COD_Internalname = "SIS_COD" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtSIS_DES_Internalname = "SIS_DES" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_6_Internalname = "PROMPT_6" ;
         imgprompt_116_Internalname = "PROMPT_116" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ACT. USUARIO/SISTEMA" ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_DES_Enabled = 0 ;
         bttBtn_get_Enabled = 0 ;
         bttBtn_get_Visible = 1 ;
         imgprompt_116_Visible = 1 ;
         imgprompt_116_Link = "" ;
         edtSIS_COD_Jsonclick = "" ;
         edtSIS_COD_Enabled = 1 ;
         edtUSU_CLA_Jsonclick = "" ;
         edtUSU_CLA_Enabled = 0 ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_DES_Enabled = 0 ;
         imgprompt_6_Visible = 1 ;
         imgprompt_6_Link = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtUSU_COD_Enabled = 1 ;
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

      public void Valid_Usu_cod( String GX_Parm1 ,
                                 String GX_Parm2 ,
                                 String GX_Parm3 )
      {
         A6USU_COD = GX_Parm1 ;
         A7USU_DES = GX_Parm2 ;
         A155USU_CLA = GX_Parm3 ;
         /* Using cursor T000G15 */
         pr_default.execute(13, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T000G15_A7USU_DES[0] ;
            A155USU_CLA = T000G15_A155USU_CLA[0] ;
         }
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A7USU_DES = "" ;
            A155USU_CLA = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A7USU_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A155USU_CLA)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Sis_cod( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A116SIS_COD = GX_Parm1 ;
         A259SIS_DES = GX_Parm2 ;
         /* Using cursor T000G16 */
         pr_default.execute(14, new Object[] {A116SIS_COD});
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000G16_A259SIS_DES[0] ;
         }
         pr_default.close(14);
         if ( (0==A116SIS_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A259SIS_DES = "" ;
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
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV10USU_COD = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A6USU_COD = "" ;
         GXKey = "" ;
         GXDecQS = "" ;
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
         lblTextblock2_Jsonclick = "" ;
         A7USU_DES = "" ;
         lblTextblock3_Jsonclick = "" ;
         A155USU_CLA = "" ;
         lblTextblock4_Jsonclick = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         A259SIS_DES = "" ;
         Z6USU_COD = "" ;
         AV16Pgmname = "" ;
         sMode16 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV14TrnContext = new SdtTransactionContext(context);
         AV15WebSession = new GxWebSession( context);
         Z7USU_DES = "" ;
         Z155USU_CLA = "" ;
         Z259SIS_DES = "" ;
         T000G4_A7USU_DES = new String[] {""} ;
         T000G4_A155USU_CLA = new String[] {""} ;
         T000G5_A259SIS_DES = new String[] {""} ;
         T000G6_A7USU_DES = new String[] {""} ;
         T000G6_A155USU_CLA = new String[] {""} ;
         T000G6_A259SIS_DES = new String[] {""} ;
         T000G6_A6USU_COD = new String[] {""} ;
         T000G6_A116SIS_COD = new short[1] ;
         T000G7_A7USU_DES = new String[] {""} ;
         T000G7_A155USU_CLA = new String[] {""} ;
         T000G8_A259SIS_DES = new String[] {""} ;
         T000G9_A6USU_COD = new String[] {""} ;
         T000G9_A116SIS_COD = new short[1] ;
         T000G3_A6USU_COD = new String[] {""} ;
         T000G3_A116SIS_COD = new short[1] ;
         T000G10_A6USU_COD = new String[] {""} ;
         T000G10_A116SIS_COD = new short[1] ;
         T000G11_A6USU_COD = new String[] {""} ;
         T000G11_A116SIS_COD = new short[1] ;
         T000G12_A6USU_COD = new String[] {""} ;
         T000G12_A116SIS_COD = new short[1] ;
         T000G15_A7USU_DES = new String[] {""} ;
         T000G15_A155USU_CLA = new String[] {""} ;
         T000G16_A259SIS_DES = new String[] {""} ;
         T000G17_A6USU_COD = new String[] {""} ;
         T000G17_A116SIS_COD = new short[1] ;
         T000G17_A126PRG_COD = new short[1] ;
         T000G18_A6USU_COD = new String[] {""} ;
         T000G18_A116SIS_COD = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXEncryptionTmp = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg003__default(),
            new Object[][] {
                new Object[] {
               T000G2_A6USU_COD, T000G2_A116SIS_COD
               }
               , new Object[] {
               T000G3_A6USU_COD, T000G3_A116SIS_COD
               }
               , new Object[] {
               T000G4_A7USU_DES, T000G4_A155USU_CLA
               }
               , new Object[] {
               T000G5_A259SIS_DES
               }
               , new Object[] {
               T000G6_A7USU_DES, T000G6_A155USU_CLA, T000G6_A259SIS_DES, T000G6_A6USU_COD, T000G6_A116SIS_COD
               }
               , new Object[] {
               T000G7_A7USU_DES, T000G7_A155USU_CLA
               }
               , new Object[] {
               T000G8_A259SIS_DES
               }
               , new Object[] {
               T000G9_A6USU_COD, T000G9_A116SIS_COD
               }
               , new Object[] {
               T000G10_A6USU_COD, T000G10_A116SIS_COD
               }
               , new Object[] {
               T000G11_A6USU_COD, T000G11_A116SIS_COD
               }
               , new Object[] {
               T000G12_A6USU_COD, T000G12_A116SIS_COD
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000G15_A7USU_DES, T000G15_A155USU_CLA
               }
               , new Object[] {
               T000G16_A259SIS_DES
               }
               , new Object[] {
               T000G17_A6USU_COD, T000G17_A116SIS_COD, T000G17_A126PRG_COD
               }
               , new Object[] {
               T000G18_A6USU_COD, T000G18_A116SIS_COD
               }
            }
         );
         AV16Pgmname = "TSEG003" ;
      }

      private short wcpOAV11SIS_COD ;
      private short GxWebError ;
      private short A116SIS_COD ;
      private short AV11SIS_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z116SIS_COD ;
      private short RcdFound16 ;
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
      private int edtUSU_COD_Enabled ;
      private int imgprompt_6_Visible ;
      private int edtUSU_DES_Enabled ;
      private int edtUSU_CLA_Enabled ;
      private int edtSIS_COD_Enabled ;
      private int imgprompt_116_Visible ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtSIS_DES_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV10USU_COD ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A6USU_COD ;
      private String Gx_mode ;
      private String AV10USU_COD ;
      private String GXKey ;
      private String GXDecQS ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUSU_COD_Internalname ;
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
      private String edtUSU_COD_Jsonclick ;
      private String imgprompt_6_Internalname ;
      private String imgprompt_6_Link ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtUSU_DES_Internalname ;
      private String A7USU_DES ;
      private String edtUSU_DES_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtUSU_CLA_Internalname ;
      private String A155USU_CLA ;
      private String edtUSU_CLA_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_COD_Jsonclick ;
      private String imgprompt_116_Internalname ;
      private String imgprompt_116_Link ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtSIS_DES_Internalname ;
      private String A259SIS_DES ;
      private String edtSIS_DES_Jsonclick ;
      private String Z6USU_COD ;
      private String AV16Pgmname ;
      private String sMode16 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z7USU_DES ;
      private String Z155USU_CLA ;
      private String Z259SIS_DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXEncryptionTmp ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool AV13IsAuthorized ;
      private bool returnInSub ;
      private GxWebSession AV15WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000G4_A7USU_DES ;
      private String[] T000G4_A155USU_CLA ;
      private String[] T000G5_A259SIS_DES ;
      private String[] T000G6_A7USU_DES ;
      private String[] T000G6_A155USU_CLA ;
      private String[] T000G6_A259SIS_DES ;
      private String[] T000G6_A6USU_COD ;
      private short[] T000G6_A116SIS_COD ;
      private String[] T000G7_A7USU_DES ;
      private String[] T000G7_A155USU_CLA ;
      private String[] T000G8_A259SIS_DES ;
      private String[] T000G9_A6USU_COD ;
      private short[] T000G9_A116SIS_COD ;
      private String[] T000G3_A6USU_COD ;
      private short[] T000G3_A116SIS_COD ;
      private String[] T000G10_A6USU_COD ;
      private short[] T000G10_A116SIS_COD ;
      private String[] T000G11_A6USU_COD ;
      private short[] T000G11_A116SIS_COD ;
      private String[] T000G12_A6USU_COD ;
      private short[] T000G12_A116SIS_COD ;
      private String[] T000G15_A7USU_DES ;
      private String[] T000G15_A155USU_CLA ;
      private String[] T000G16_A259SIS_DES ;
      private String[] T000G17_A6USU_COD ;
      private short[] T000G17_A116SIS_COD ;
      private short[] T000G17_A126PRG_COD ;
      private String[] T000G18_A6USU_COD ;
      private short[] T000G18_A116SIS_COD ;
      private String[] T000G2_A6USU_COD ;
      private short[] T000G2_A116SIS_COD ;
      private GXWebForm Form ;
      private SdtTransactionContext AV14TrnContext ;
   }

   public class tseg003__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
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
          Object[] prmT000G2 ;
          prmT000G2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G6 ;
          prmT000G6 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G4 ;
          prmT000G4 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000G5 ;
          prmT000G5 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G7 ;
          prmT000G7 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000G8 ;
          prmT000G8 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G9 ;
          prmT000G9 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G3 ;
          prmT000G3 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G10 ;
          prmT000G10 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G11 ;
          prmT000G11 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G12 ;
          prmT000G12 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G13 ;
          prmT000G13 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G14 ;
          prmT000G14 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G17 ;
          prmT000G17 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000G18 ;
          prmT000G18 = new Object[] {
          } ;
          Object[] prmT000G15 ;
          prmT000G15 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000G16 ;
          prmT000G16 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000G2", "SELECT [USU_COD], [SIS_COD] FROM [SEG003] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G2,1,1,true,false )
             ,new CursorDef("T000G3", "SELECT [USU_COD], [SIS_COD] FROM [SEG003] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G3,1,1,true,false )
             ,new CursorDef("T000G4", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G4,1,0,true,false )
             ,new CursorDef("T000G5", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G5,1,1,true,false )
             ,new CursorDef("T000G6", "SELECT T2.[USU_DES], T2.[USU_CLA], T3.[SIS_DES], TM1.[USU_COD], TM1.[SIS_COD] FROM (([SEG003] TM1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = TM1.[USU_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = TM1.[SIS_COD]) WHERE TM1.[USU_COD] = @USU_COD and TM1.[SIS_COD] = @SIS_COD ORDER BY TM1.[USU_COD], TM1.[SIS_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G6,100,0,true,false )
             ,new CursorDef("T000G7", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G7,1,0,true,false )
             ,new CursorDef("T000G8", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G8,1,1,true,false )
             ,new CursorDef("T000G9", "SELECT [USU_COD], [SIS_COD] FROM [SEG003] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G9,1,1,true,false )
             ,new CursorDef("T000G10", "SELECT TOP 1 [USU_COD], [SIS_COD] FROM [SEG003] WITH (NOLOCK) WHERE ( [USU_COD] > @USU_COD or [USU_COD] = @USU_COD and [SIS_COD] > @SIS_COD) ORDER BY [USU_COD], [SIS_COD]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G10,1,1,true,true )
             ,new CursorDef("T000G11", "SELECT TOP 1 [USU_COD], [SIS_COD] FROM [SEG003] WITH (NOLOCK) WHERE ( [USU_COD] < @USU_COD or [USU_COD] = @USU_COD and [SIS_COD] < @SIS_COD) ORDER BY [USU_COD] DESC, [SIS_COD] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G11,1,1,true,true )
             ,new CursorDef("T000G12", "SELECT [USU_COD], [SIS_COD] FROM [SEG003] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G12,1,1,true,false )
             ,new CursorDef("T000G13", "INSERT INTO [SEG003] ([USU_COD], [SIS_COD]) VALUES (@USU_COD, @SIS_COD)", GxErrorMask.GX_NOMASK,prmT000G13)
             ,new CursorDef("T000G14", "DELETE FROM [SEG003]  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD", GxErrorMask.GX_NOMASK,prmT000G14)
             ,new CursorDef("T000G15", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G15,1,0,true,false )
             ,new CursorDef("T000G16", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G16,1,1,true,false )
             ,new CursorDef("T000G17", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G17,1,1,true,true )
             ,new CursorDef("T000G18", "SELECT [USU_COD], [SIS_COD] FROM [SEG003] WITH (NOLOCK) ORDER BY [USU_COD], [SIS_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G18,100,1,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
