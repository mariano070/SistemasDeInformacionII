/*
               File: TBUS000General
        Description: TBUS000 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:0.84
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tbus000general : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tbus000general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tbus000general( IGxContext context )
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

      public void execute( String aP0_BUS_EMP ,
                           short aP1_BUS_RUB ,
                           short aP2_BUS_COD ,
                           short aP3_BUS_PAR )
      {
         this.A8BUS_EMP = aP0_BUS_EMP;
         this.A1BUS_RUB = aP1_BUS_RUB;
         this.A3BUS_COD = aP2_BUS_COD;
         this.A4BUS_PAR = aP3_BUS_PAR;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            if ( nGotPars == 0 )
            {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  nDynComponent = 1 ;
                  sCompPrefix = GetNextPar( ) ;
                  sSFPrefix = GetNextPar( ) ;
                  A8BUS_EMP = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8BUS_EMP", A8BUS_EMP);
                  A1BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
                  A3BUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
                  A4BUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A8BUS_EMP,(short)A1BUS_RUB,(short)A3BUS_COD,(short)A4BUS_PAR});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            PA2D2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV17Pgmname = "TBUS000General" ;
               context.Gx_err = 0 ;
               /* Using cursor H002D2 */
               pr_default.execute(0, new Object[] {A1BUS_RUB});
               A178BUS_AMO = H002D2_A178BUS_AMO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A178BUS_AMO", A178BUS_AMO);
               n178BUS_AMO = H002D2_n178BUS_AMO[0] ;
               A61BUS_RUD = H002D2_A61BUS_RUD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BUS_RUD", A61BUS_RUD);
               n61BUS_RUD = H002D2_n61BUS_RUD[0] ;
               pr_default.close(0);
               WS2D2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.WriteHtmlText( "<title>") ;
            context.WriteHtmlText( "TBUS000 General") ;
            context.WriteHtmlTextNl( "</title>") ;
            if ( StringUtil.Len( sDynURL) > 0 )
            {
               context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
            }
            define_styles( ) ;
         }
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
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tbus000general.aspx") + "?" + UrlEncode(StringUtil.RTrim(A8BUS_EMP)) + "," + UrlEncode("" +A1BUS_RUB) + "," + UrlEncode("" +A3BUS_COD) + "," + UrlEncode("" +A4BUS_PAR)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm2D2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA8BUS_EMP", StringUtil.RTrim( wcpOA8BUS_EMP));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA1BUS_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA1BUS_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA3BUS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA3BUS_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA4BUS_PAR", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA4BUS_PAR), 2, 0, ",", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tbus000general.js", "?118092");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            context.WriteHtmlTextNl( "</form>") ;
            include_jscripts( ) ;
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
         }
      }

      protected void WB2D0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tbus000general.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_2D2( true) ;
         }
         else
         {
            wb_table1_2_2D2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2D2e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_TBUS000General.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FPR_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FPR_Internalname, context.localUtil.Format(A340BUS_FPR, "99/99/9999"), "", 10, "chr", 1, "row", 10, edtBUS_FPR_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A340BUS_FPR, "99/99/9999"), "", 0, edtBUS_FPR_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FPR_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((edtBUS_FPR_Visible==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VUT_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A335BUS_VUT), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, edtBUS_VUT_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A335BUS_VUT), "ZZZ9"), "", 0, edtBUS_VUT_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_COE_Internalname, StringUtil.LTrim( StringUtil.NToC( A336BUS_COE, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, edtBUS_COE_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A336BUS_COE, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_COE_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VOC_Internalname, StringUtil.LTrim( StringUtil.NToC( A341BUS_VOC, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, edtBUS_VOC_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A341BUS_VOC, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VOC_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VOA_Internalname, StringUtil.LTrim( StringUtil.NToC( A337BUS_VOA, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, edtBUS_VOA_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A337BUS_VOA, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VOA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AAA_Internalname, StringUtil.LTrim( StringUtil.NToC( A338BUS_AAA, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, edtBUS_AAA_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A338BUS_AAA, "ZZZZZZ9.99"), "", 0, edtBUS_AAA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AEA_Internalname, StringUtil.LTrim( StringUtil.NToC( A339BUS_AEA, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, edtBUS_AEA_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A339BUS_AEA, "ZZZZZZ9.99"), "", 0, edtBUS_AEA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VAH_Internalname, StringUtil.LTrim( StringUtil.NToC( A342BUS_VAH, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, edtBUS_VAH_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A342BUS_VAH, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VAH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_VHF_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VHF_Internalname, context.localUtil.Format(A343BUS_VHF, "99/99/9999"), "", 10, "chr", 1, "row", 10, edtBUS_VHF_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A343BUS_VHF, "99/99/9999"), "", 0, edtBUS_VHF_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            GxWebStd.gx_bitmap( context, edtBUS_VHF_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((edtBUS_VHF_Visible==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VOH_Internalname, StringUtil.LTrim( StringUtil.NToC( A344BUS_VOH, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, edtBUS_VOH_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A344BUS_VOH, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VOH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AAH_Internalname, StringUtil.LTrim( StringUtil.NToC( A345BUS_AAH, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, edtBUS_AAH_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A345BUS_AAH, "ZZZZZZ9.99"), "", 0, edtBUS_AAH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AEH_Internalname, StringUtil.LTrim( StringUtil.NToC( A346BUS_AEH, 10, 2, ",", "")), "", 10, "chr", 1, "row", 10, edtBUS_AEH_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A346BUS_AEH, "ZZZZZZ9.99"), "", 0, edtBUS_AEH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VRA_Internalname, StringUtil.LTrim( StringUtil.NToC( A347BUS_VRA, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, edtBUS_VRA_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A347BUS_VRA, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VRA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VRH_Internalname, StringUtil.LTrim( StringUtil.NToC( A348BUS_VRH, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, edtBUS_VRH_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A348BUS_VRH, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VRH_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VUR_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A349BUS_VUR), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, edtBUS_VUR_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A349BUS_VUR), "ZZZ9"), "", 0, edtBUS_VUR_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
         }
         wbLoad = true ;
      }

      protected void START2D2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "TBUS000 General", 0) ;
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
            context.wbHandled = 0 ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName") ;
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false ;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP2D0( ) ;
            }
         }
      }

      protected void WS2D2( )
      {
         START2D2( ) ;
         EVT2D2( ) ;
      }

      protected void EVT2D2( )
      {
         sXEvt = cgiGet( "_EventName") ;
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName") ;
                     EvtGridId = cgiGet( "_EventGridId") ;
                     EvtRowId = cgiGet( "_EventRowId") ;
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1) ;
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2D0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2D0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E112D2 */
                                    E112D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2D0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E122D2 */
                                    E122D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2D0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E132D2 */
                                    E132D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2D0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E142D2 */
                                    E142D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2D0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2D0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
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
      }

      protected void WE2D2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2D2( ) ;
            }
         }
      }

      protected void PA2D2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF2D2( ) ;
         /* End function Refresh */
      }

      protected void RF2D2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H002D3 */
            pr_default.execute(1, new Object[] {A8BUS_EMP, A1BUS_RUB, A3BUS_COD, A4BUS_PAR});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A343BUS_VHF = H002D3_A343BUS_VHF[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
               A342BUS_VAH = H002D3_A342BUS_VAH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
               A341BUS_VOC = H002D3_A341BUS_VOC[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
               A336BUS_COE = H002D3_A336BUS_COE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
               A340BUS_FPR = H002D3_A340BUS_FPR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
               A103BUS_IDT = H002D3_A103BUS_IDT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
               A334BUS_MBA = H002D3_A334BUS_MBA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A334BUS_MBA", A334BUS_MBA);
               A174BUS_FBA = H002D3_A174BUS_FBA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
               A59BUS_TID = H002D3_A59BUS_TID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A59BUS_TID", A59BUS_TID);
               A56BUS_TIP = H002D3_A56BUS_TIP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
               A176BUS_SED = H002D3_A176BUS_SED[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176BUS_SED", A176BUS_SED);
               A172BUS_SEC = H002D3_A172BUS_SEC[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
               A175BUS_ARD = H002D3_A175BUS_ARD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A175BUS_ARD", A175BUS_ARD);
               A171BUS_ARE = H002D3_A171BUS_ARE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
               A333BUS_NCO = H002D3_A333BUS_NCO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A333BUS_NCO", A333BUS_NCO);
               A350BUS_CBD = H002D3_A350BUS_CBD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A350BUS_CBD", A350BUS_CBD);
               A331BUS_COM = H002D3_A331BUS_COM[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A331BUS_COM", A331BUS_COM);
               A330BUS_VAO = H002D3_A330BUS_VAO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
               A55BUS_FAD = H002D3_A55BUS_FAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               A170BUS_FAL = H002D3_A170BUS_FAL[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
               A54BUS_DES = H002D3_A54BUS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A54BUS_DES", A54BUS_DES);
               A339BUS_AEA = H002D3_A339BUS_AEA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
               A338BUS_AAA = H002D3_A338BUS_AAA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
               A337BUS_VOA = H002D3_A337BUS_VOA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
               A346BUS_AEH = H002D3_A346BUS_AEH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
               A345BUS_AAH = H002D3_A345BUS_AAH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
               A344BUS_VOH = H002D3_A344BUS_VOH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
               A335BUS_VUT = H002D3_A335BUS_VUT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
               A329BUS_VUA = H002D3_A329BUS_VUA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
               A349BUS_VUR = (short)(A329BUS_VUA-A335BUS_VUT) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
               A348BUS_VRH = (decimal)(A344BUS_VOH-A345BUS_AAH-A346BUS_AEH) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
               A347BUS_VRA = (decimal)(A337BUS_VOA-A338BUS_AAA-A339BUS_AEA) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
               /* Execute user event: E122D2 */
               E122D2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            WB2D0( ) ;
         }
      }

      protected void STRUP2D0( )
      {
         /* Before Start, stand alone formulas. */
         AV17Pgmname = "TBUS000General" ;
         context.Gx_err = 0 ;
         /* Using cursor H002D4 */
         pr_default.execute(2, new Object[] {A1BUS_RUB});
         A178BUS_AMO = H002D4_A178BUS_AMO[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A178BUS_AMO", A178BUS_AMO);
         n178BUS_AMO = H002D4_n178BUS_AMO[0] ;
         A61BUS_RUD = H002D4_A61BUS_RUD[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BUS_RUD", A61BUS_RUD);
         n61BUS_RUD = H002D4_n61BUS_RUD[0] ;
         pr_default.close(2);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112D2 */
         E112D2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A8BUS_EMP = StringUtil.Upper( cgiGet( edtBUS_EMP_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8BUS_EMP", A8BUS_EMP);
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            }
            A54BUS_DES = StringUtil.Upper( cgiGet( edtBUS_DES_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A54BUS_DES", A54BUS_DES);
            A170BUS_FAL = context.localUtil.CToD( cgiGet( edtBUS_FAL_Internalname), 4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
            A55BUS_FAD = context.localUtil.CToD( cgiGet( edtBUS_FAD_Internalname), 4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
            A329BUS_VUA = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUA_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
            A330BUS_VAO = context.localUtil.CToN( cgiGet( edtBUS_VAO_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
            A331BUS_COM = StringUtil.Upper( cgiGet( edtBUS_COM_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A331BUS_COM", A331BUS_COM);
            A350BUS_CBD = StringUtil.Upper( cgiGet( edtBUS_CBD_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A350BUS_CBD", A350BUS_CBD);
            A333BUS_NCO = cgiGet( edtBUS_NCO_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A333BUS_NCO", A333BUS_NCO);
            A171BUS_ARE = (short)(context.localUtil.CToN( cgiGet( edtBUS_ARE_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
            A175BUS_ARD = StringUtil.Upper( cgiGet( edtBUS_ARD_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A175BUS_ARD", A175BUS_ARD);
            A172BUS_SEC = (short)(context.localUtil.CToN( cgiGet( edtBUS_SEC_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
            A176BUS_SED = StringUtil.Upper( cgiGet( edtBUS_SED_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176BUS_SED", A176BUS_SED);
            A56BUS_TIP = (short)(context.localUtil.CToN( cgiGet( edtBUS_TIP_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
            A59BUS_TID = StringUtil.Upper( cgiGet( edtBUS_TID_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A59BUS_TID", A59BUS_TID);
            A174BUS_FBA = context.localUtil.CToD( cgiGet( edtBUS_FBA_Internalname), 4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
            A334BUS_MBA = cgiGet( edtBUS_MBA_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A334BUS_MBA", A334BUS_MBA);
            A61BUS_RUD = cgiGet( edtBUS_RUD_Internalname) ;
            n61BUS_RUD = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BUS_RUD", A61BUS_RUD);
            A178BUS_AMO = StringUtil.Upper( cgiGet( edtBUS_AMO_Internalname)) ;
            n178BUS_AMO = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A178BUS_AMO", A178BUS_AMO);
            A103BUS_IDT = (int)(context.localUtil.CToN( cgiGet( edtBUS_IDT_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
            A340BUS_FPR = context.localUtil.CToD( cgiGet( edtBUS_FPR_Internalname), 4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
            A335BUS_VUT = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUT_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
            A336BUS_COE = context.localUtil.CToN( cgiGet( edtBUS_COE_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
            A341BUS_VOC = context.localUtil.CToN( cgiGet( edtBUS_VOC_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
            A337BUS_VOA = context.localUtil.CToN( cgiGet( edtBUS_VOA_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
            A338BUS_AAA = context.localUtil.CToN( cgiGet( edtBUS_AAA_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
            A339BUS_AEA = context.localUtil.CToN( cgiGet( edtBUS_AEA_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
            A342BUS_VAH = context.localUtil.CToN( cgiGet( edtBUS_VAH_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
            A343BUS_VHF = context.localUtil.CToD( cgiGet( edtBUS_VHF_Internalname), 4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
            A344BUS_VOH = context.localUtil.CToN( cgiGet( edtBUS_VOH_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
            A345BUS_AAH = context.localUtil.CToN( cgiGet( edtBUS_AAH_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
            A346BUS_AEH = context.localUtil.CToN( cgiGet( edtBUS_AEH_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
            A347BUS_VRA = context.localUtil.CToN( cgiGet( edtBUS_VRA_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
            A348BUS_VRH = context.localUtil.CToN( cgiGet( edtBUS_VRH_Internalname), ",", ".") ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
            A349BUS_VUR = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUR_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
            /* Read saved values. */
            wcpOA8BUS_EMP = cgiGet( sPrefix+"wcpOA8BUS_EMP") ;
            wcpOA1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA1BUS_RUB"), ",", ".")) ;
            wcpOA3BUS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA3BUS_COD"), ",", ".")) ;
            wcpOA4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA4BUS_PAR"), ",", ".")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E112D2 */
         E112D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112D2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV17Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)) ;
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E122D2( )
      {
         /* Load Routine */
         edtBUS_FPR_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_FPR_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_FPR_Visible), 5, 0)));
         edtBUS_VUT_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VUT_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUT_Visible), 5, 0)));
         edtBUS_COE_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_COE_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_COE_Visible), 5, 0)));
         edtBUS_VOC_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VOC_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOC_Visible), 5, 0)));
         edtBUS_VOA_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VOA_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOA_Visible), 5, 0)));
         edtBUS_AAA_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_AAA_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAA_Visible), 5, 0)));
         edtBUS_AEA_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_AEA_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEA_Visible), 5, 0)));
         edtBUS_VAH_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VAH_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VAH_Visible), 5, 0)));
         edtBUS_VHF_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VHF_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VHF_Visible), 5, 0)));
         edtBUS_VOH_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VOH_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VOH_Visible), 5, 0)));
         edtBUS_AAH_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_AAH_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AAH_Visible), 5, 0)));
         edtBUS_AEH_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_AEH_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AEH_Visible), 5, 0)));
         edtBUS_VRA_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VRA_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRA_Visible), 5, 0)));
         edtBUS_VRH_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VRH_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VRH_Visible), 5, 0)));
         edtBUS_VUR_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_VUR_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_VUR_Visible), 5, 0)));
      }

      protected void E132D2( )
      {
         /* 'DoUpdate' Routine */
         context.wjLoc = formatLink("tbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A8BUS_EMP)) + "," + UrlEncode("" +A1BUS_RUB) + "," + UrlEncode("" +A3BUS_COD) + "," + UrlEncode("" +A4BUS_PAR) ;
      }

      protected void E142D2( )
      {
         /* 'DoDelete' Routine */
         context.wjLoc = formatLink("tbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A8BUS_EMP)) + "," + UrlEncode("" +A1BUS_RUB) + "," + UrlEncode("" +A3BUS_COD) + "," + UrlEncode("" +A4BUS_PAR) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context) ;
         AV11TrnContext.gxTpr_Callerobject = AV17Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerondelete = false ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerurl = AV14HTTPRequest.ScriptName+"?"+AV14HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Transactionname = "TBUS000" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "BUS_EMP" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = AV7BUS_EMP ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "BUS_RUB" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BUS_RUB), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "BUS_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV9BUS_COD), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "BUS_PAR" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV10BUS_PAR), 2, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV13Session.Set("TrnContext", AV11TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_2D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTbl2_Internalname, tblTbl2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_emp_Internalname, 1, 1, 0, "EMPRESA", "", "", "", 0, lblTextblockbus_emp_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_EMP_Internalname, StringUtil.RTrim( A8BUS_EMP), "", 1, "chr", 1, "row", 1, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A8BUS_EMP, "!")), "", 0, edtBUS_EMP_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_rub_Internalname, 1, 1, 0, "RUBRO", "", "", "", 0, lblTextblockbus_rub_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_RUB_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A1BUS_RUB), "ZZZ9"), "", 0, edtBUS_RUB_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockbus_cod_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A3BUS_COD), "ZZZ9"), "", 0, edtBUS_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_par_Internalname, 1, 1, 0, "PARTIDA", "", "", "", 0, lblTextblockbus_par_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_PAR_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A4BUS_PAR), "Z9"), "", 0, edtBUS_PAR_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockbus_des_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_DES_Internalname, StringUtil.RTrim( A54BUS_DES), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A54BUS_DES, "@!")), "", 0, edtBUS_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fal_Internalname, 1, 1, 0, "ALTA", "", "", "", 0, lblTextblockbus_fal_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FAL_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FAL_Internalname, context.localUtil.Format(A170BUS_FAL, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A170BUS_FAL, "99/99/9999"), "", 0, edtBUS_FAL_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FAL_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fad_Internalname, 1, 1, 0, "ADQUISICION", "", "", "", 0, lblTextblockbus_fad_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FAD_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FAD_Internalname, context.localUtil.Format(A55BUS_FAD, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A55BUS_FAD, "99/99/9999"), "", 0, edtBUS_FAD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FAD_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vua_Internalname, 1, 1, 0, "VIDA UTIL ASIGNADA AL BIEN", "", "", "", 0, lblTextblockbus_vua_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VUA_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A329BUS_VUA), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A329BUS_VUA), "ZZZ9"), "", 0, edtBUS_VUA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_vao_Internalname, 1, 1, 0, "VALOR DE ORIGEN DEL BIEN", "", "", "", 0, lblTextblockbus_vao_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_VAO_Internalname, StringUtil.LTrim( StringUtil.NToC( A330BUS_VAO, 18, 7, ",", "")), "", 18, "chr", 1, "row", 18, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A330BUS_VAO, "ZZZZZZZZZ9.9999999"), "", 0, edtBUS_VAO_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_com_Internalname, 1, 1, 0, "COMPROBANTE DE COMPRA", "", "", "", 0, lblTextblockbus_com_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_COM_Internalname, StringUtil.RTrim( A331BUS_COM), "", 2, "chr", 1, "row", 2, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A331BUS_COM, "@!")), "", 0, edtBUS_COM_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_cbd_Internalname, 1, 1, 0, "DE COMPRA", "", "", "", 0, lblTextblockbus_cbd_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_CBD_Internalname, StringUtil.RTrim( A350BUS_CBD), "", 20, "chr", 1, "row", 20, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A350BUS_CBD, "@!")), "", 0, edtBUS_CBD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_nco_Internalname, 1, 1, 0, "NUMERO DEL COMP. DE COMPRA", "", "", "", 0, lblTextblockbus_nco_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_NCO_Internalname, StringUtil.RTrim( A333BUS_NCO), "", 12, "chr", 1, "row", 12, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A333BUS_NCO, "999999999999")), "", 0, edtBUS_NCO_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_are_Internalname, 1, 1, 0, "SECTOR DE LA EMPRESA", "", "", "", 0, lblTextblockbus_are_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_ARE_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A171BUS_ARE), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A171BUS_ARE), "ZZZ9"), "", 0, edtBUS_ARE_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_ard_Internalname, 1, 1, 0, "ARD", "", "", "", 0, lblTextblockbus_ard_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_ARD_Internalname, StringUtil.RTrim( A175BUS_ARD), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A175BUS_ARD, "@!")), "", 0, edtBUS_ARD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_sec_Internalname, 1, 1, 0, "AREA A QUE PERTENECE EL BIEN", "", "", "", 0, lblTextblockbus_sec_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_SEC_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BUS_SEC), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A172BUS_SEC), "Z9"), "", 0, edtBUS_SEC_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_sed_Internalname, 1, 1, 0, "SED", "", "", "", 0, lblTextblockbus_sed_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_SED_Internalname, StringUtil.RTrim( A176BUS_SED), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A176BUS_SED, "@!")), "", 0, edtBUS_SED_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_tip_Internalname, 1, 1, 0, "CODIGO DE TIPO DE BIEN", "", "", "", 0, lblTextblockbus_tip_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_TIP_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A56BUS_TIP), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A56BUS_TIP), "ZZ9"), "", 0, edtBUS_TIP_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_tid_Internalname, 1, 1, 0, "TID", "", "", "", 0, lblTextblockbus_tid_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_TID_Internalname, StringUtil.RTrim( A59BUS_TID), "", 20, "chr", 1, "row", 20, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A59BUS_TID, "@!")), "", 0, edtBUS_TID_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fba_Internalname, 1, 1, 0, "FECHA DE BAJA DEL BIEN", "", "", "", 0, lblTextblockbus_fba_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_FBA_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_FBA_Internalname, context.localUtil.Format(A174BUS_FBA, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A174BUS_FBA, "99/99/9999"), "", 0, edtBUS_FBA_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            GxWebStd.gx_bitmap( context, edtBUS_FBA_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_mba_Internalname, 1, 1, 0, "MOTIVO DE BAJA DEL BIEN", "", "", "", 0, lblTextblockbus_mba_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_MBA_Internalname, StringUtil.RTrim( A334BUS_MBA), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A334BUS_MBA, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtBUS_MBA_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_rud_Internalname, 1, 1, 0, "RUBRO", "", "", "", 0, lblTextblockbus_rud_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_RUD_Internalname, StringUtil.RTrim( A61BUS_RUD), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A61BUS_RUD, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtBUS_RUD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_amo_Internalname, 1, 1, 0, "AMORTIZABLE", "", "", "", 0, lblTextblockbus_amo_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AMO_Internalname, StringUtil.RTrim( A178BUS_AMO), "", 1, "chr", 1, "row", 1, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A178BUS_AMO, "!")), "", 0, edtBUS_AMO_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_idt_Internalname, 1, 1, 0, "DE USO", "", "", "", 0, lblTextblockbus_idt_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_IDT_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A103BUS_IDT), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A103BUS_IDT), "ZZZZZZZ9"), "", 0, edtBUS_IDT_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS000General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2D2e( true) ;
         }
         else
         {
            wb_table1_2_2D2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A8BUS_EMP = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8BUS_EMP", A8BUS_EMP);
         A1BUS_RUB = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
         A3BUS_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
         A4BUS_PAR = Convert.ToInt16(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA2D2( ) ;
         WS2D2( ) ;
         WE2D2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA8BUS_EMP = (String)((String)getParm(obj,0)) ;
         sCtrlA1BUS_RUB = (String)((String)getParm(obj,1)) ;
         sCtrlA3BUS_COD = (String)((String)getParm(obj,2)) ;
         sCtrlA4BUS_PAR = (String)((String)getParm(obj,3)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA2D2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "tbus000general");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA2D2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A8BUS_EMP = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8BUS_EMP", A8BUS_EMP);
            A1BUS_RUB = Convert.ToInt16(getParm(obj,3)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            A3BUS_COD = Convert.ToInt16(getParm(obj,4)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            A4BUS_PAR = Convert.ToInt16(getParm(obj,5)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
         }
         wcpOA8BUS_EMP = cgiGet( sPrefix+"wcpOA8BUS_EMP") ;
         wcpOA1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA1BUS_RUB"), ",", ".")) ;
         wcpOA3BUS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA3BUS_COD"), ",", ".")) ;
         wcpOA4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA4BUS_PAR"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A8BUS_EMP, wcpOA8BUS_EMP) != 0 ) || ( A1BUS_RUB != wcpOA1BUS_RUB ) || ( A3BUS_COD != wcpOA3BUS_COD ) || ( A4BUS_PAR != wcpOA4BUS_PAR ) ) )
         {
            setjustcreated();
         }
         wcpOA8BUS_EMP = A8BUS_EMP ;
         wcpOA1BUS_RUB = A1BUS_RUB ;
         wcpOA3BUS_COD = A3BUS_COD ;
         wcpOA4BUS_PAR = A4BUS_PAR ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA8BUS_EMP = cgiGet( sPrefix+"A8BUS_EMP_CTRL") ;
         if ( StringUtil.Len( sCtrlA8BUS_EMP) > 0 )
         {
            A8BUS_EMP = cgiGet( sCtrlA8BUS_EMP) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8BUS_EMP", A8BUS_EMP);
         }
         else
         {
            A8BUS_EMP = cgiGet( sPrefix+"A8BUS_EMP_PARM") ;
         }
         sCtrlA1BUS_RUB = cgiGet( sPrefix+"A1BUS_RUB_CTRL") ;
         if ( StringUtil.Len( sCtrlA1BUS_RUB) > 0 )
         {
            A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( sCtrlA1BUS_RUB), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
         }
         else
         {
            A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A1BUS_RUB_PARM"), ",", ".")) ;
         }
         sCtrlA3BUS_COD = cgiGet( sPrefix+"A3BUS_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlA3BUS_COD) > 0 )
         {
            A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( sCtrlA3BUS_COD), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
         }
         else
         {
            A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A3BUS_COD_PARM"), ",", ".")) ;
         }
         sCtrlA4BUS_PAR = cgiGet( sPrefix+"A4BUS_PAR_CTRL") ;
         if ( StringUtil.Len( sCtrlA4BUS_PAR) > 0 )
         {
            A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( sCtrlA4BUS_PAR), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
         }
         else
         {
            A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A4BUS_PAR_PARM"), ",", ".")) ;
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix ;
         sSFPrefix = sPSFPrefix ;
         sPrefix = sCompPrefix + sSFPrefix ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         INITWEB( ) ;
         nDraw = 0 ;
         PA2D2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS2D2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1 ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WS2D2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A8BUS_EMP_PARM", StringUtil.RTrim( A8BUS_EMP));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA8BUS_EMP)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A8BUS_EMP_CTRL", StringUtil.RTrim( sCtrlA8BUS_EMP));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A1BUS_RUB_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA1BUS_RUB)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A1BUS_RUB_CTRL", StringUtil.RTrim( sCtrlA1BUS_RUB));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A3BUS_COD_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA3BUS_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A3BUS_COD_CTRL", StringUtil.RTrim( sCtrlA3BUS_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A4BUS_PAR_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA4BUS_PAR)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A4BUS_PAR_CTRL", StringUtil.RTrim( sCtrlA4BUS_PAR));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WCParametersSet( ) ;
         WE2D2( ) ;
         this.cleanup();
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1) ;
         }
         else
         {
            sCtrlName = sGXControl ;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?118214");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("tbus000general.js", "?118214");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbus_emp_Internalname = sPrefix+"TEXTBLOCKBUS_EMP" ;
         edtBUS_EMP_Internalname = sPrefix+"BUS_EMP" ;
         lblTextblockbus_rub_Internalname = sPrefix+"TEXTBLOCKBUS_RUB" ;
         edtBUS_RUB_Internalname = sPrefix+"BUS_RUB" ;
         lblTextblockbus_cod_Internalname = sPrefix+"TEXTBLOCKBUS_COD" ;
         edtBUS_COD_Internalname = sPrefix+"BUS_COD" ;
         lblTextblockbus_par_Internalname = sPrefix+"TEXTBLOCKBUS_PAR" ;
         edtBUS_PAR_Internalname = sPrefix+"BUS_PAR" ;
         lblTextblockbus_des_Internalname = sPrefix+"TEXTBLOCKBUS_DES" ;
         edtBUS_DES_Internalname = sPrefix+"BUS_DES" ;
         lblTextblockbus_fal_Internalname = sPrefix+"TEXTBLOCKBUS_FAL" ;
         edtBUS_FAL_Internalname = sPrefix+"BUS_FAL" ;
         lblTextblockbus_fad_Internalname = sPrefix+"TEXTBLOCKBUS_FAD" ;
         edtBUS_FAD_Internalname = sPrefix+"BUS_FAD" ;
         lblTextblockbus_vua_Internalname = sPrefix+"TEXTBLOCKBUS_VUA" ;
         edtBUS_VUA_Internalname = sPrefix+"BUS_VUA" ;
         lblTextblockbus_vao_Internalname = sPrefix+"TEXTBLOCKBUS_VAO" ;
         edtBUS_VAO_Internalname = sPrefix+"BUS_VAO" ;
         lblTextblockbus_com_Internalname = sPrefix+"TEXTBLOCKBUS_COM" ;
         edtBUS_COM_Internalname = sPrefix+"BUS_COM" ;
         lblTextblockbus_cbd_Internalname = sPrefix+"TEXTBLOCKBUS_CBD" ;
         edtBUS_CBD_Internalname = sPrefix+"BUS_CBD" ;
         lblTextblockbus_nco_Internalname = sPrefix+"TEXTBLOCKBUS_NCO" ;
         edtBUS_NCO_Internalname = sPrefix+"BUS_NCO" ;
         lblTextblockbus_are_Internalname = sPrefix+"TEXTBLOCKBUS_ARE" ;
         edtBUS_ARE_Internalname = sPrefix+"BUS_ARE" ;
         lblTextblockbus_ard_Internalname = sPrefix+"TEXTBLOCKBUS_ARD" ;
         edtBUS_ARD_Internalname = sPrefix+"BUS_ARD" ;
         lblTextblockbus_sec_Internalname = sPrefix+"TEXTBLOCKBUS_SEC" ;
         edtBUS_SEC_Internalname = sPrefix+"BUS_SEC" ;
         lblTextblockbus_sed_Internalname = sPrefix+"TEXTBLOCKBUS_SED" ;
         edtBUS_SED_Internalname = sPrefix+"BUS_SED" ;
         lblTextblockbus_tip_Internalname = sPrefix+"TEXTBLOCKBUS_TIP" ;
         edtBUS_TIP_Internalname = sPrefix+"BUS_TIP" ;
         lblTextblockbus_tid_Internalname = sPrefix+"TEXTBLOCKBUS_TID" ;
         edtBUS_TID_Internalname = sPrefix+"BUS_TID" ;
         lblTextblockbus_fba_Internalname = sPrefix+"TEXTBLOCKBUS_FBA" ;
         edtBUS_FBA_Internalname = sPrefix+"BUS_FBA" ;
         lblTextblockbus_mba_Internalname = sPrefix+"TEXTBLOCKBUS_MBA" ;
         edtBUS_MBA_Internalname = sPrefix+"BUS_MBA" ;
         lblTextblockbus_rud_Internalname = sPrefix+"TEXTBLOCKBUS_RUD" ;
         edtBUS_RUD_Internalname = sPrefix+"BUS_RUD" ;
         lblTextblockbus_amo_Internalname = sPrefix+"TEXTBLOCKBUS_AMO" ;
         edtBUS_AMO_Internalname = sPrefix+"BUS_AMO" ;
         lblTextblockbus_idt_Internalname = sPrefix+"TEXTBLOCKBUS_IDT" ;
         edtBUS_IDT_Internalname = sPrefix+"BUS_IDT" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         edtBUS_FPR_Internalname = sPrefix+"BUS_FPR" ;
         edtBUS_VUT_Internalname = sPrefix+"BUS_VUT" ;
         edtBUS_COE_Internalname = sPrefix+"BUS_COE" ;
         edtBUS_VOC_Internalname = sPrefix+"BUS_VOC" ;
         edtBUS_VOA_Internalname = sPrefix+"BUS_VOA" ;
         edtBUS_AAA_Internalname = sPrefix+"BUS_AAA" ;
         edtBUS_AEA_Internalname = sPrefix+"BUS_AEA" ;
         edtBUS_VAH_Internalname = sPrefix+"BUS_VAH" ;
         edtBUS_VHF_Internalname = sPrefix+"BUS_VHF" ;
         edtBUS_VOH_Internalname = sPrefix+"BUS_VOH" ;
         edtBUS_AAH_Internalname = sPrefix+"BUS_AAH" ;
         edtBUS_AEH_Internalname = sPrefix+"BUS_AEH" ;
         edtBUS_VRA_Internalname = sPrefix+"BUS_VRA" ;
         edtBUS_VRH_Internalname = sPrefix+"BUS_VRH" ;
         edtBUS_VUR_Internalname = sPrefix+"BUS_VUR" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtBUS_IDT_Jsonclick = "" ;
         edtBUS_AMO_Jsonclick = "" ;
         edtBUS_RUD_Jsonclick = "" ;
         edtBUS_MBA_Jsonclick = "" ;
         edtBUS_FBA_Jsonclick = "" ;
         edtBUS_TID_Jsonclick = "" ;
         edtBUS_TIP_Jsonclick = "" ;
         edtBUS_SED_Jsonclick = "" ;
         edtBUS_SEC_Jsonclick = "" ;
         edtBUS_ARD_Jsonclick = "" ;
         edtBUS_ARE_Jsonclick = "" ;
         edtBUS_NCO_Jsonclick = "" ;
         edtBUS_CBD_Jsonclick = "" ;
         edtBUS_COM_Jsonclick = "" ;
         edtBUS_VAO_Jsonclick = "" ;
         edtBUS_VUA_Jsonclick = "" ;
         edtBUS_FAD_Jsonclick = "" ;
         edtBUS_FAL_Jsonclick = "" ;
         edtBUS_DES_Jsonclick = "" ;
         edtBUS_PAR_Jsonclick = "" ;
         edtBUS_COD_Jsonclick = "" ;
         edtBUS_RUB_Jsonclick = "" ;
         edtBUS_EMP_Jsonclick = "" ;
         edtBUS_VUR_Jsonclick = "" ;
         edtBUS_VUR_Visible = 1 ;
         edtBUS_VRH_Jsonclick = "" ;
         edtBUS_VRH_Visible = 1 ;
         edtBUS_VRA_Jsonclick = "" ;
         edtBUS_VRA_Visible = 1 ;
         edtBUS_AEH_Jsonclick = "" ;
         edtBUS_AEH_Visible = 1 ;
         edtBUS_AAH_Jsonclick = "" ;
         edtBUS_AAH_Visible = 1 ;
         edtBUS_VOH_Jsonclick = "" ;
         edtBUS_VOH_Visible = 1 ;
         edtBUS_VHF_Jsonclick = "" ;
         edtBUS_VHF_Visible = 1 ;
         edtBUS_VAH_Jsonclick = "" ;
         edtBUS_VAH_Visible = 1 ;
         edtBUS_AEA_Jsonclick = "" ;
         edtBUS_AEA_Visible = 1 ;
         edtBUS_AAA_Jsonclick = "" ;
         edtBUS_AAA_Visible = 1 ;
         edtBUS_VOA_Jsonclick = "" ;
         edtBUS_VOA_Visible = 1 ;
         edtBUS_VOC_Jsonclick = "" ;
         edtBUS_VOC_Visible = 1 ;
         edtBUS_COE_Jsonclick = "" ;
         edtBUS_COE_Visible = 1 ;
         edtBUS_VUT_Jsonclick = "" ;
         edtBUS_VUT_Visible = 1 ;
         edtBUS_FPR_Jsonclick = "" ;
         edtBUS_FPR_Visible = 1 ;
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
      }

      public override void initialize( )
      {
         wcpOA8BUS_EMP = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         AV17Pgmname = "" ;
         scmdbuf = "" ;
         H002D2_A178BUS_AMO = new String[] {""} ;
         H002D2_n178BUS_AMO = new bool[] {false} ;
         H002D2_A61BUS_RUD = new String[] {""} ;
         H002D2_n61BUS_RUD = new bool[] {false} ;
         A178BUS_AMO = "" ;
         A61BUS_RUD = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GX_FocusControl = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtnupdate_Jsonclick = "" ;
         bttBtndelete_Jsonclick = "" ;
         A340BUS_FPR = DateTime.MinValue ;
         A343BUS_VHF = DateTime.MinValue ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         H002D3_A8BUS_EMP = new String[] {""} ;
         H002D3_A1BUS_RUB = new short[1] ;
         H002D3_A3BUS_COD = new short[1] ;
         H002D3_A4BUS_PAR = new short[1] ;
         H002D3_A343BUS_VHF = new DateTime[] {DateTime.MinValue} ;
         H002D3_A342BUS_VAH = new decimal[1] ;
         H002D3_A341BUS_VOC = new decimal[1] ;
         H002D3_A336BUS_COE = new decimal[1] ;
         H002D3_A340BUS_FPR = new DateTime[] {DateTime.MinValue} ;
         H002D3_A103BUS_IDT = new int[1] ;
         H002D3_A178BUS_AMO = new String[] {""} ;
         H002D3_n178BUS_AMO = new bool[] {false} ;
         H002D3_A61BUS_RUD = new String[] {""} ;
         H002D3_n61BUS_RUD = new bool[] {false} ;
         H002D3_A334BUS_MBA = new String[] {""} ;
         H002D3_A174BUS_FBA = new DateTime[] {DateTime.MinValue} ;
         H002D3_A59BUS_TID = new String[] {""} ;
         H002D3_A56BUS_TIP = new short[1] ;
         H002D3_A176BUS_SED = new String[] {""} ;
         H002D3_A172BUS_SEC = new short[1] ;
         H002D3_A175BUS_ARD = new String[] {""} ;
         H002D3_A171BUS_ARE = new short[1] ;
         H002D3_A333BUS_NCO = new String[] {""} ;
         H002D3_A350BUS_CBD = new String[] {""} ;
         H002D3_A331BUS_COM = new String[] {""} ;
         H002D3_A330BUS_VAO = new decimal[1] ;
         H002D3_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         H002D3_A170BUS_FAL = new DateTime[] {DateTime.MinValue} ;
         H002D3_A54BUS_DES = new String[] {""} ;
         H002D3_A339BUS_AEA = new decimal[1] ;
         H002D3_A338BUS_AAA = new decimal[1] ;
         H002D3_A337BUS_VOA = new decimal[1] ;
         H002D3_A346BUS_AEH = new decimal[1] ;
         H002D3_A345BUS_AAH = new decimal[1] ;
         H002D3_A344BUS_VOH = new decimal[1] ;
         H002D3_A335BUS_VUT = new short[1] ;
         H002D3_A329BUS_VUA = new short[1] ;
         A334BUS_MBA = "" ;
         A174BUS_FBA = DateTime.MinValue ;
         A59BUS_TID = "" ;
         A176BUS_SED = "" ;
         A175BUS_ARD = "" ;
         A333BUS_NCO = "" ;
         A350BUS_CBD = "" ;
         A331BUS_COM = "" ;
         A55BUS_FAD = DateTime.MinValue ;
         A170BUS_FAL = DateTime.MinValue ;
         A54BUS_DES = "" ;
         H002D4_A178BUS_AMO = new String[] {""} ;
         H002D4_n178BUS_AMO = new bool[] {false} ;
         H002D4_A61BUS_RUD = new String[] {""} ;
         H002D4_n61BUS_RUD = new bool[] {false} ;
         AV11TrnContext = new SdtTransactionContext(context);
         AV14HTTPRequest = new GxHttpRequest( context);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7BUS_EMP = "" ;
         AV13Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockbus_emp_Jsonclick = "" ;
         lblTextblockbus_rub_Jsonclick = "" ;
         lblTextblockbus_cod_Jsonclick = "" ;
         lblTextblockbus_par_Jsonclick = "" ;
         lblTextblockbus_des_Jsonclick = "" ;
         lblTextblockbus_fal_Jsonclick = "" ;
         lblTextblockbus_fad_Jsonclick = "" ;
         lblTextblockbus_vua_Jsonclick = "" ;
         lblTextblockbus_vao_Jsonclick = "" ;
         lblTextblockbus_com_Jsonclick = "" ;
         lblTextblockbus_cbd_Jsonclick = "" ;
         lblTextblockbus_nco_Jsonclick = "" ;
         lblTextblockbus_are_Jsonclick = "" ;
         lblTextblockbus_ard_Jsonclick = "" ;
         lblTextblockbus_sec_Jsonclick = "" ;
         lblTextblockbus_sed_Jsonclick = "" ;
         lblTextblockbus_tip_Jsonclick = "" ;
         lblTextblockbus_tid_Jsonclick = "" ;
         lblTextblockbus_fba_Jsonclick = "" ;
         lblTextblockbus_mba_Jsonclick = "" ;
         lblTextblockbus_rud_Jsonclick = "" ;
         lblTextblockbus_amo_Jsonclick = "" ;
         lblTextblockbus_idt_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA8BUS_EMP = "" ;
         sCtrlA1BUS_RUB = "" ;
         sCtrlA3BUS_COD = "" ;
         sCtrlA4BUS_PAR = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tbus000general__default(),
            new Object[][] {
                new Object[] {
               H002D2_A178BUS_AMO, H002D2_n178BUS_AMO, H002D2_A61BUS_RUD, H002D2_n61BUS_RUD
               }
               , new Object[] {
               H002D3_A8BUS_EMP, H002D3_A1BUS_RUB, H002D3_A3BUS_COD, H002D3_A4BUS_PAR, H002D3_A343BUS_VHF, H002D3_A342BUS_VAH, H002D3_A341BUS_VOC, H002D3_A336BUS_COE, H002D3_A340BUS_FPR, H002D3_A103BUS_IDT,
               H002D3_A178BUS_AMO, H002D3_n178BUS_AMO, H002D3_A61BUS_RUD, H002D3_n61BUS_RUD, H002D3_A334BUS_MBA, H002D3_A174BUS_FBA, H002D3_A59BUS_TID, H002D3_A56BUS_TIP, H002D3_A176BUS_SED, H002D3_A172BUS_SEC,
               H002D3_A175BUS_ARD, H002D3_A171BUS_ARE, H002D3_A333BUS_NCO, H002D3_A350BUS_CBD, H002D3_A331BUS_COM, H002D3_A330BUS_VAO, H002D3_A55BUS_FAD, H002D3_A170BUS_FAL, H002D3_A54BUS_DES, H002D3_A339BUS_AEA,
               H002D3_A338BUS_AAA, H002D3_A337BUS_VOA, H002D3_A346BUS_AEH, H002D3_A345BUS_AAH, H002D3_A344BUS_VOH, H002D3_A335BUS_VUT, H002D3_A329BUS_VUA
               }
               , new Object[] {
               H002D4_A178BUS_AMO, H002D4_n178BUS_AMO, H002D4_A61BUS_RUD, H002D4_n61BUS_RUD
               }
            }
         );
         AV17Pgmname = "TBUS000General" ;
         /* GeneXus formulas. */
         AV17Pgmname = "TBUS000General" ;
         context.Gx_err = 0 ;
      }

      private short A1BUS_RUB ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short wcpOA1BUS_RUB ;
      private short wcpOA3BUS_COD ;
      private short wcpOA4BUS_PAR ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A335BUS_VUT ;
      private short A349BUS_VUR ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short A56BUS_TIP ;
      private short A172BUS_SEC ;
      private short A171BUS_ARE ;
      private short A329BUS_VUA ;
      private short AV8BUS_RUB ;
      private short AV9BUS_COD ;
      private short AV10BUS_PAR ;
      private short nGXWrapped ;
      private int edtBUS_FPR_Visible ;
      private int edtBUS_VUT_Visible ;
      private int edtBUS_COE_Visible ;
      private int edtBUS_VOC_Visible ;
      private int edtBUS_VOA_Visible ;
      private int edtBUS_AAA_Visible ;
      private int edtBUS_AEA_Visible ;
      private int edtBUS_VAH_Visible ;
      private int edtBUS_VHF_Visible ;
      private int edtBUS_VOH_Visible ;
      private int edtBUS_AAH_Visible ;
      private int edtBUS_AEH_Visible ;
      private int edtBUS_VRA_Visible ;
      private int edtBUS_VRH_Visible ;
      private int edtBUS_VUR_Visible ;
      private int A103BUS_IDT ;
      private int idxLst ;
      private decimal A336BUS_COE ;
      private decimal A341BUS_VOC ;
      private decimal A337BUS_VOA ;
      private decimal A338BUS_AAA ;
      private decimal A339BUS_AEA ;
      private decimal A342BUS_VAH ;
      private decimal A344BUS_VOH ;
      private decimal A345BUS_AAH ;
      private decimal A346BUS_AEH ;
      private decimal A347BUS_VRA ;
      private decimal A348BUS_VRH ;
      private decimal A330BUS_VAO ;
      private String A8BUS_EMP ;
      private String wcpOA8BUS_EMP ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV17Pgmname ;
      private String scmdbuf ;
      private String A178BUS_AMO ;
      private String A61BUS_RUD ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GX_FocusControl ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String edtBUS_FPR_Internalname ;
      private String edtBUS_FPR_Jsonclick ;
      private String edtBUS_VUT_Internalname ;
      private String edtBUS_VUT_Jsonclick ;
      private String edtBUS_COE_Internalname ;
      private String edtBUS_COE_Jsonclick ;
      private String edtBUS_VOC_Internalname ;
      private String edtBUS_VOC_Jsonclick ;
      private String edtBUS_VOA_Internalname ;
      private String edtBUS_VOA_Jsonclick ;
      private String edtBUS_AAA_Internalname ;
      private String edtBUS_AAA_Jsonclick ;
      private String edtBUS_AEA_Internalname ;
      private String edtBUS_AEA_Jsonclick ;
      private String edtBUS_VAH_Internalname ;
      private String edtBUS_VAH_Jsonclick ;
      private String edtBUS_VHF_Internalname ;
      private String edtBUS_VHF_Jsonclick ;
      private String edtBUS_VOH_Internalname ;
      private String edtBUS_VOH_Jsonclick ;
      private String edtBUS_AAH_Internalname ;
      private String edtBUS_AAH_Jsonclick ;
      private String edtBUS_AEH_Internalname ;
      private String edtBUS_AEH_Jsonclick ;
      private String edtBUS_VRA_Internalname ;
      private String edtBUS_VRA_Jsonclick ;
      private String edtBUS_VRH_Internalname ;
      private String edtBUS_VRH_Jsonclick ;
      private String edtBUS_VUR_Internalname ;
      private String edtBUS_VUR_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String A334BUS_MBA ;
      private String A59BUS_TID ;
      private String A176BUS_SED ;
      private String A175BUS_ARD ;
      private String A333BUS_NCO ;
      private String A350BUS_CBD ;
      private String A331BUS_COM ;
      private String A54BUS_DES ;
      private String edtBUS_EMP_Internalname ;
      private String edtBUS_RUB_Internalname ;
      private String edtBUS_COD_Internalname ;
      private String edtBUS_PAR_Internalname ;
      private String edtBUS_DES_Internalname ;
      private String edtBUS_FAL_Internalname ;
      private String edtBUS_FAD_Internalname ;
      private String edtBUS_VUA_Internalname ;
      private String edtBUS_VAO_Internalname ;
      private String edtBUS_COM_Internalname ;
      private String edtBUS_CBD_Internalname ;
      private String edtBUS_NCO_Internalname ;
      private String edtBUS_ARE_Internalname ;
      private String edtBUS_ARD_Internalname ;
      private String edtBUS_SEC_Internalname ;
      private String edtBUS_SED_Internalname ;
      private String edtBUS_TIP_Internalname ;
      private String edtBUS_TID_Internalname ;
      private String edtBUS_FBA_Internalname ;
      private String edtBUS_MBA_Internalname ;
      private String edtBUS_RUD_Internalname ;
      private String edtBUS_AMO_Internalname ;
      private String edtBUS_IDT_Internalname ;
      private String AV7BUS_EMP ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockbus_emp_Internalname ;
      private String lblTextblockbus_emp_Jsonclick ;
      private String edtBUS_EMP_Jsonclick ;
      private String lblTextblockbus_rub_Internalname ;
      private String lblTextblockbus_rub_Jsonclick ;
      private String edtBUS_RUB_Jsonclick ;
      private String lblTextblockbus_cod_Internalname ;
      private String lblTextblockbus_cod_Jsonclick ;
      private String edtBUS_COD_Jsonclick ;
      private String lblTextblockbus_par_Internalname ;
      private String lblTextblockbus_par_Jsonclick ;
      private String edtBUS_PAR_Jsonclick ;
      private String lblTextblockbus_des_Internalname ;
      private String lblTextblockbus_des_Jsonclick ;
      private String edtBUS_DES_Jsonclick ;
      private String lblTextblockbus_fal_Internalname ;
      private String lblTextblockbus_fal_Jsonclick ;
      private String edtBUS_FAL_Jsonclick ;
      private String lblTextblockbus_fad_Internalname ;
      private String lblTextblockbus_fad_Jsonclick ;
      private String edtBUS_FAD_Jsonclick ;
      private String lblTextblockbus_vua_Internalname ;
      private String lblTextblockbus_vua_Jsonclick ;
      private String edtBUS_VUA_Jsonclick ;
      private String lblTextblockbus_vao_Internalname ;
      private String lblTextblockbus_vao_Jsonclick ;
      private String edtBUS_VAO_Jsonclick ;
      private String lblTextblockbus_com_Internalname ;
      private String lblTextblockbus_com_Jsonclick ;
      private String edtBUS_COM_Jsonclick ;
      private String lblTextblockbus_cbd_Internalname ;
      private String lblTextblockbus_cbd_Jsonclick ;
      private String edtBUS_CBD_Jsonclick ;
      private String lblTextblockbus_nco_Internalname ;
      private String lblTextblockbus_nco_Jsonclick ;
      private String edtBUS_NCO_Jsonclick ;
      private String lblTextblockbus_are_Internalname ;
      private String lblTextblockbus_are_Jsonclick ;
      private String edtBUS_ARE_Jsonclick ;
      private String lblTextblockbus_ard_Internalname ;
      private String lblTextblockbus_ard_Jsonclick ;
      private String edtBUS_ARD_Jsonclick ;
      private String lblTextblockbus_sec_Internalname ;
      private String lblTextblockbus_sec_Jsonclick ;
      private String edtBUS_SEC_Jsonclick ;
      private String lblTextblockbus_sed_Internalname ;
      private String lblTextblockbus_sed_Jsonclick ;
      private String edtBUS_SED_Jsonclick ;
      private String lblTextblockbus_tip_Internalname ;
      private String lblTextblockbus_tip_Jsonclick ;
      private String edtBUS_TIP_Jsonclick ;
      private String lblTextblockbus_tid_Internalname ;
      private String lblTextblockbus_tid_Jsonclick ;
      private String edtBUS_TID_Jsonclick ;
      private String lblTextblockbus_fba_Internalname ;
      private String lblTextblockbus_fba_Jsonclick ;
      private String edtBUS_FBA_Jsonclick ;
      private String lblTextblockbus_mba_Internalname ;
      private String lblTextblockbus_mba_Jsonclick ;
      private String edtBUS_MBA_Jsonclick ;
      private String lblTextblockbus_rud_Internalname ;
      private String lblTextblockbus_rud_Jsonclick ;
      private String edtBUS_RUD_Jsonclick ;
      private String lblTextblockbus_amo_Internalname ;
      private String lblTextblockbus_amo_Jsonclick ;
      private String edtBUS_AMO_Jsonclick ;
      private String lblTextblockbus_idt_Internalname ;
      private String lblTextblockbus_idt_Jsonclick ;
      private String edtBUS_IDT_Jsonclick ;
      private String sCtrlA8BUS_EMP ;
      private String sCtrlA1BUS_RUB ;
      private String sCtrlA3BUS_COD ;
      private String sCtrlA4BUS_PAR ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private DateTime A340BUS_FPR ;
      private DateTime A343BUS_VHF ;
      private DateTime A174BUS_FBA ;
      private DateTime A55BUS_FAD ;
      private DateTime A170BUS_FAL ;
      private bool entryPointCalled ;
      private bool n178BUS_AMO ;
      private bool n61BUS_RUD ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002D2_A178BUS_AMO ;
      private bool[] H002D2_n178BUS_AMO ;
      private String[] H002D2_A61BUS_RUD ;
      private bool[] H002D2_n61BUS_RUD ;
      private String[] H002D3_A8BUS_EMP ;
      private short[] H002D3_A1BUS_RUB ;
      private short[] H002D3_A3BUS_COD ;
      private short[] H002D3_A4BUS_PAR ;
      private DateTime[] H002D3_A343BUS_VHF ;
      private decimal[] H002D3_A342BUS_VAH ;
      private decimal[] H002D3_A341BUS_VOC ;
      private decimal[] H002D3_A336BUS_COE ;
      private DateTime[] H002D3_A340BUS_FPR ;
      private int[] H002D3_A103BUS_IDT ;
      private String[] H002D3_A178BUS_AMO ;
      private bool[] H002D3_n178BUS_AMO ;
      private String[] H002D3_A61BUS_RUD ;
      private bool[] H002D3_n61BUS_RUD ;
      private String[] H002D3_A334BUS_MBA ;
      private DateTime[] H002D3_A174BUS_FBA ;
      private String[] H002D3_A59BUS_TID ;
      private short[] H002D3_A56BUS_TIP ;
      private String[] H002D3_A176BUS_SED ;
      private short[] H002D3_A172BUS_SEC ;
      private String[] H002D3_A175BUS_ARD ;
      private short[] H002D3_A171BUS_ARE ;
      private String[] H002D3_A333BUS_NCO ;
      private String[] H002D3_A350BUS_CBD ;
      private String[] H002D3_A331BUS_COM ;
      private decimal[] H002D3_A330BUS_VAO ;
      private DateTime[] H002D3_A55BUS_FAD ;
      private DateTime[] H002D3_A170BUS_FAL ;
      private String[] H002D3_A54BUS_DES ;
      private decimal[] H002D3_A339BUS_AEA ;
      private decimal[] H002D3_A338BUS_AAA ;
      private decimal[] H002D3_A337BUS_VOA ;
      private decimal[] H002D3_A346BUS_AEH ;
      private decimal[] H002D3_A345BUS_AAH ;
      private decimal[] H002D3_A344BUS_VOH ;
      private short[] H002D3_A335BUS_VUT ;
      private short[] H002D3_A329BUS_VUA ;
      private String[] H002D4_A178BUS_AMO ;
      private bool[] H002D4_n178BUS_AMO ;
      private String[] H002D4_A61BUS_RUD ;
      private bool[] H002D4_n61BUS_RUD ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV14HTTPRequest ;
      private GxWebSession AV13Session ;
      private SdtTransactionContext AV11TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class tbus000general__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002D2 ;
          prmH002D2 = new Object[] {
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH002D3 ;
          prmH002D3 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmH002D4 ;
          prmH002D4 = new Object[] {
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002D2", "SELECT [RBR_AMO] AS BUS_AMO, [RBR_DES] AS BUS_RUD FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @BUS_RUB ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002D2,1,0,true,true )
             ,new CursorDef("H002D3", "SELECT T1.[BUS_EMP], T1.[BUS_RUB] AS BUS_RUB, T1.[BUS_COD], T1.[BUS_PAR], T1.[BUS_VHF], T1.[BUS_VAH], T1.[BUS_VOC], T1.[BUS_COE], T1.[BUS_FPR], T1.[BUS_IDT], T2.[RBR_AMO] AS BUS_AMO, T2.[RBR_DES] AS BUS_RUD, T1.[BUS_MBA], T1.[BUS_FBA], T1.[BUS_TID], T1.[BUS_TIP], T1.[BUS_SED], T1.[BUS_SEC], T1.[BUS_ARD], T1.[BUS_ARE], T1.[BUS_NCO], T1.[BUS_CBD], T1.[BUS_COM], T1.[BUS_VAO], T1.[BUS_FAD], T1.[BUS_FAL], T1.[BUS_DES], T1.[BUS_AEA], T1.[BUS_AAA], T1.[BUS_VOA], T1.[BUS_AEH], T1.[BUS_AAH], T1.[BUS_VOH], T1.[BUS_VUT], T1.[BUS_VUA] FROM ([BUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[BUS_RUB]) WHERE T1.[BUS_EMP] = @BUS_EMP and T1.[BUS_RUB] = @BUS_RUB and T1.[BUS_COD] = @BUS_COD and T1.[BUS_PAR] = @BUS_PAR ORDER BY T1.[BUS_EMP], T1.[BUS_RUB], T1.[BUS_COD], T1.[BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002D3,1,0,true,true )
             ,new CursorDef("H002D4", "SELECT [RBR_AMO] AS BUS_AMO, [RBR_DES] AS BUS_RUD FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @BUS_RUB ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002D4,1,0,true,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 30) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((int[]) buf[9])[0] = rslt.getInt(10) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 1) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(11);
                ((String[]) buf[12])[0] = rslt.getString(12, 30) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(12);
                ((String[]) buf[14])[0] = rslt.getString(13, 30) ;
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(14) ;
                ((String[]) buf[16])[0] = rslt.getString(15, 20) ;
                ((short[]) buf[17])[0] = rslt.getShort(16) ;
                ((String[]) buf[18])[0] = rslt.getString(17, 30) ;
                ((short[]) buf[19])[0] = rslt.getShort(18) ;
                ((String[]) buf[20])[0] = rslt.getString(19, 30) ;
                ((short[]) buf[21])[0] = rslt.getShort(20) ;
                ((String[]) buf[22])[0] = rslt.getString(21, 12) ;
                ((String[]) buf[23])[0] = rslt.getString(22, 20) ;
                ((String[]) buf[24])[0] = rslt.getString(23, 2) ;
                ((decimal[]) buf[25])[0] = rslt.getDecimal(24) ;
                ((DateTime[]) buf[26])[0] = rslt.getGXDate(25) ;
                ((DateTime[]) buf[27])[0] = rslt.getGXDate(26) ;
                ((String[]) buf[28])[0] = rslt.getString(27, 50) ;
                ((decimal[]) buf[29])[0] = rslt.getDecimal(28) ;
                ((decimal[]) buf[30])[0] = rslt.getDecimal(29) ;
                ((decimal[]) buf[31])[0] = rslt.getDecimal(30) ;
                ((decimal[]) buf[32])[0] = rslt.getDecimal(31) ;
                ((decimal[]) buf[33])[0] = rslt.getDecimal(32) ;
                ((decimal[]) buf[34])[0] = rslt.getDecimal(33) ;
                ((short[]) buf[35])[0] = rslt.getShort(34) ;
                ((short[]) buf[36])[0] = rslt.getShort(35) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 30) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
