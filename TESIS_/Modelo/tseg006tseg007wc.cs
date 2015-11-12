/*
               File: TSEG006TSEG007WC
        Description: TSEG006 TSEG007 WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:17.93
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
   public class tseg006tseg007wc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tseg006tseg007wc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg006tseg007wc( IGxContext context )
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

      public void execute( String aP0_USU_COD ,
                           short aP1_SIS_COD ,
                           short aP2_PRG_COD ,
                           int aP3_PRS_NRO )
      {
         this.AV7USU_COD = aP0_USU_COD;
         this.AV8SIS_COD = aP1_SIS_COD;
         this.AV9PRG_COD = aP2_PRG_COD;
         this.AV10PRS_NRO = aP3_PRS_NRO;
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
                  AV7USU_COD = GetNextPar( ) ;
                  AV8SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV9PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV10PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV7USU_COD,(short)AV8SIS_COD,(short)AV9PRG_COD,(int)AV10PRS_NRO});
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
               {
                  nRC_Grid = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sGXsfl_12_idx = GetNextPar( ) ;
                  edtavDelete_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
                  AV16Delete = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV16Delete));
                  edtavUpdate_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
                  AV15Update = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV15Update));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid_newrow( nRC_Grid, nGXsfl_12_idx, sGXsfl_12_idx, AV16Delete, AV15Update, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
               {
                  /* GeneXus formulas. */
                  AV19Pgmname = "TSEG006TSEG007WC" ;
                  context.Gx_err = 0 ;
                  Grid_PageSize12 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV7USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_COD", AV7USU_COD);
                  AV8SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SIS_COD), 3, 0)));
                  AV9PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9PRG_COD), 4, 0)));
                  AV10PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PRS_NRO), 8, 0)));
                  edtavDelete_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
                  AV16Delete = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV16Delete));
                  edtavUpdate_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
                  AV15Update = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV15Update));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid_refresh( Grid_PageSize12, AV7USU_COD, AV8SIS_COD, AV9PRG_COD, AV10PRS_NRO, AV16Delete, AV15Update, sPrefix) ;
                  return  ;
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
            PA452( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV19Pgmname = "TSEG006TSEG007WC" ;
               context.Gx_err = 0 ;
               WS452( ) ;
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
            context.WriteHtmlText( "TSEG006 TSEG007 WC") ;
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg006tseg007wc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7USU_COD)) + "," + UrlEncode("" +AV8SIS_COD) + "," + UrlEncode("" +AV9PRG_COD) + "," + UrlEncode("" +AV10PRS_NRO)+"\" class=\""+"Form"+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            }
         }
      }

      protected void RenderHtmlCloseForm452( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7USU_COD", StringUtil.RTrim( wcpOAV7USU_COD));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV9PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV9PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV10PRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV10PRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUSU_COD", StringUtil.RTrim( AV7USU_COD));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10PRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 3, 0, ".", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tseg006tseg007wc.js", "?118181");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
            include_jscripts( ) ;
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
         }
      }

      protected void WB450( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tseg006tseg007wc.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_452( true) ;
         }
         else
         {
            wb_table1_2_452( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_452e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, edtUSU_COD_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), "", 0, edtUSU_COD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006TSEG007WC.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, edtSIS_COD_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), "", 0, edtSIS_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006TSEG007WC.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, edtPRG_COD_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), "", 0, edtPRG_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006TSEG007WC.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_NRO_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, edtPRS_NRO_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A118PRS_NRO), "ZZZZZZZ9"), "", 0, edtPRS_NRO_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006TSEG007WC.htm");
         }
         wbLoad = true ;
      }

      protected void START452( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "TSEG006 TSEG007 WC", 0) ;
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
               STRUP450( ) ;
            }
         }
      }

      protected void WS452( )
      {
         START452( ) ;
         EVT452( ) ;
      }

      protected void EVT452( )
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
                     /* Check if conditions changed and reset current page numbers */
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
                                 STRUP450( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP450( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E11452 */
                                    E11452 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP450( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP450( ) ;
                              }
                              sEvt = cgiGet( sPrefix+"GRIDPAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'DOINSERT'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP450( ) ;
                              }
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
                              edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
                              edtPRS_ORD_Internalname = sPrefix+"PRS_ORD_"+sGXsfl_12_idx ;
                              edtPRS_DES_Internalname = sPrefix+"PRS_DES_"+sGXsfl_12_idx ;
                              edtPRS_LINK_Internalname = sPrefix+"PRS_LINK_"+sGXsfl_12_idx ;
                              AV15Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV15Update));
                              AV16Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV16Delete));
                              A407PRS_ORD = (short)(context.localUtil.CToN( cgiGet( edtPRS_ORD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
                              A408PRS_DES = cgiGet( edtPRS_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A408PRS_DES", A408PRS_DES);
                              A409PRS_LINK = cgiGet( edtPRS_LINK_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A409PRS_LINK", A409PRS_LINK);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E12452 */
                                          E12452 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E13452 */
                                          E13452 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E11452 */
                                          E11452 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
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
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP450( ) ;
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
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE452( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm452( ) ;
            }
         }
      }

      protected void PA452( )
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

      protected void gxnrGrid_newrow( short nRC_Grid ,
                                      short nGXsfl_12_idx ,
                                      String sGXsfl_12_idx ,
                                      String AV16Delete ,
                                      String AV15Update ,
                                      String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
         edtPRS_ORD_Internalname = sPrefix+"PRS_ORD_"+sGXsfl_12_idx ;
         edtPRS_DES_Internalname = sPrefix+"PRS_DES_"+sGXsfl_12_idx ;
         edtPRS_LINK_Internalname = sPrefix+"PRS_LINK_"+sGXsfl_12_idx ;
         while ( nGXsfl_12_idx <= nRC_Grid )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtPRS_ORD_Internalname = sPrefix+"PRS_ORD_"+sGXsfl_12_idx ;
            edtPRS_DES_Internalname = sPrefix+"PRS_DES_"+sGXsfl_12_idx ;
            edtPRS_LINK_Internalname = sPrefix+"PRS_LINK_"+sGXsfl_12_idx ;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int Grid_PageSize12 ,
                                       String AV7USU_COD ,
                                       short AV8SIS_COD ,
                                       short AV9PRG_COD ,
                                       int AV10PRS_NRO ,
                                       String AV16Delete ,
                                       String AV15Update ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid_Rows = (short)(Grid_PageSize12) ;
         RF452( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF452( ) ;
         /* End function Refresh */
      }

      protected void RF452( )
      {
         GridContainer.PageSize = subGrid_Recordsperpage( ) ;
         wbStart = 12 ;
         nGXsfl_12_idx = 1 ;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
         edtPRS_ORD_Internalname = sPrefix+"PRS_ORD_"+sGXsfl_12_idx ;
         edtPRS_DES_Internalname = sPrefix+"PRS_DES_"+sGXsfl_12_idx ;
         edtPRS_LINK_Internalname = sPrefix+"PRS_LINK_"+sGXsfl_12_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtPRS_ORD_Internalname = sPrefix+"PRS_ORD_"+sGXsfl_12_idx ;
            edtPRS_DES_Internalname = sPrefix+"PRS_DES_"+sGXsfl_12_idx ;
            edtPRS_LINK_Internalname = sPrefix+"PRS_LINK_"+sGXsfl_12_idx ;
            /* Using cursor H00452 */
            pr_default.execute(0, new Object[] {AV7USU_COD, AV8SIS_COD, AV9PRG_COD, AV10PRS_NRO});
            nGXsfl_12_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A6USU_COD = H00452_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = H00452_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = H00452_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = H00452_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A409PRS_LINK = H00452_A409PRS_LINK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A409PRS_LINK", A409PRS_LINK);
               A408PRS_DES = H00452_A408PRS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A408PRS_DES", A408PRS_DES);
               A407PRS_ORD = H00452_A407PRS_ORD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               /* Execute user event: E13452 */
               E13452 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 12 ;
            WB450( ) ;
         }
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( ((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         /* Using cursor H00453 */
         pr_default.execute(1, new Object[] {AV7USU_COD, AV8SIS_COD, AV9PRG_COD, AV10PRS_NRO});
         GRID_nRecordCount = H00453_AGRID_nRecordCount[0] ;
         pr_default.close(1);
         return GRID_nRecordCount ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(subGrid_Rows*1) ;
            }
            else
            {
               return (int)(subGrid_Rows) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (int)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (int)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( ))) == 0 )
            {
               GRID_nFirstRecordOnPage = (int)(GRID_nRecordCount-subGrid_Recordsperpage( )) ;
            }
            else
            {
               GRID_nFirstRecordOnPage = (int)(GRID_nRecordCount-((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID_nFirstRecordOnPage = (int)(subGrid_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID_nFirstRecordOnPage = (int)(subGrid_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP450( )
      {
         /* Before Start, stand alone formulas. */
         AV19Pgmname = "TSEG006TSEG007WC" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E12452 */
         E12452 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            /* Read saved values. */
            nRC_Grid = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid"), ",", ".")) ;
            wcpOAV7USU_COD = cgiGet( sPrefix+"wcpOAV7USU_COD") ;
            wcpOAV8SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8SIS_COD"), ",", ".")) ;
            wcpOAV9PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV9PRG_COD"), ",", ".")) ;
            wcpOAV10PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV10PRS_NRO"), ",", ".")) ;
            GRID_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ",", ".")) ;
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ",", ".")) ;
            subGrid_Rows = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ",", ".")) ;
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
         /* Execute user event: E12452 */
         E12452 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12452( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV19Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)) ;
         }
         subGrid_Rows = 10 ;
         AV15Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV15Update));
         edtavUpdate_Tooltiptext = "Modifica" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
         AV16Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV16Delete));
         edtavDelete_Tooltiptext = "Eliminar" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
         edtUSU_COD_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUSU_COD_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Visible), 5, 0)));
         edtSIS_COD_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSIS_COD_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Visible), 5, 0)));
         edtPRG_COD_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtPRG_COD_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Visible), 5, 0)));
         edtPRS_NRO_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtPRS_NRO_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_NRO_Visible), 5, 0)));
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E13452( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("tseg007.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV7USU_COD)) + "," + UrlEncode("" +AV8SIS_COD) + "," + UrlEncode("" +AV9PRG_COD) + "," + UrlEncode("" +AV10PRS_NRO) + "," + UrlEncode("" +A407PRS_ORD) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Link", edtavUpdate_Link);
         edtavDelete_Link = formatLink("tseg007.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(AV7USU_COD)) + "," + UrlEncode("" +AV8SIS_COD) + "," + UrlEncode("" +AV9PRG_COD) + "," + UrlEncode("" +AV10PRS_NRO) + "," + UrlEncode("" +A407PRS_ORD) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Link", edtavDelete_Link);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12 ;
         }
         if ( ( subGrid_Islastpage == 1 ) || ( subGrid_Rows == 0 ) || ( ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage ) && ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) )
         {
            sendrow_122( ) ;
         }
         GRID_nCurrentRecord = (int)(GRID_nCurrentRecord+1) ;
      }

      protected void E11452( )
      {
         /* 'DoInsert' Routine */
         context.wjLoc = formatLink("tseg007.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim(AV7USU_COD)) + "," + UrlEncode("" +AV8SIS_COD) + "," + UrlEncode("" +AV9PRG_COD) + "," + UrlEncode("" +AV10PRS_NRO) + "," + UrlEncode("" +0) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV13TrnContext = new SdtTransactionContext(context) ;
         AV13TrnContext.gxTpr_Callerobject = AV19Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV13TrnContext", (Object)(AV13TrnContext));
         AV13TrnContext.gxTpr_Callerondelete = true ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV13TrnContext", (Object)(AV13TrnContext));
         AV13TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV13TrnContext", (Object)(AV13TrnContext));
         AV13TrnContext.gxTpr_Transactionname = "TSEG007" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV13TrnContext", (Object)(AV13TrnContext));
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV14TrnContextAtt.gxTpr_Attributename = "USU_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV14TrnContextAtt.gxTpr_Attributevalue = AV7USU_COD ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV13TrnContext.gxTpr_Attributes.Add(AV14TrnContextAtt, 0);
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV14TrnContextAtt.gxTpr_Attributename = "SIS_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV14TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8SIS_COD), 3, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV13TrnContext.gxTpr_Attributes.Add(AV14TrnContextAtt, 0);
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV14TrnContextAtt.gxTpr_Attributename = "PRG_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV14TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV9PRG_COD), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV13TrnContext.gxTpr_Attributes.Add(AV14TrnContextAtt, 0);
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV14TrnContextAtt.gxTpr_Attributename = "PRS_NRO" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV14TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV10PRS_NRO), 8, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14TrnContextAtt", (Object)(AV14TrnContextAtt));
         AV13TrnContext.gxTpr_Attributes.Add(AV14TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV13TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_452( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable_Internalname, tblTable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_452( true) ;
         }
         else
         {
            wb_table2_5_452( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_452e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_452e( true) ;
         }
         else
         {
            wb_table1_2_452e( false) ;
         }
      }

      protected void wb_table2_5_452( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablegridcontainer_Internalname, tblTablegridcontainer_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td colspan=\"1\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "PagingButtons" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, sPrefix+"E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TSEG006TSEG007WC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" colspan=\"2\" >") ;
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "WorkWith", 0, "", "", 4, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1 ;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor ;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ORDEN DE LLAMADOS") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION PROGRAMA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "LINK PROGRAMA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               GridContainer.Clear();
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Class", "WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(4), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV15Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV16Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A407PRS_ORD), 3, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A408PRS_DES));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", A409PRS_LINK);
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", "false");
               GridContainer.AddObjectProperty("Allowcollapsing", "false");
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 12 )
         {
            wbEnd = 0 ;
            nRC_Grid = (short)(nGXsfl_12_idx-1) ;
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", (Object)(GridContainer));
               GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_452e( true) ;
         }
         else
         {
            wb_table2_5_452e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7USU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_COD", AV7USU_COD);
         AV8SIS_COD = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SIS_COD), 3, 0)));
         AV9PRG_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9PRG_COD), 4, 0)));
         AV10PRS_NRO = Convert.ToInt32(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PRS_NRO), 8, 0)));
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
         PA452( ) ;
         WS452( ) ;
         WE452( ) ;
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
         sCtrlAV7USU_COD = (String)((String)getParm(obj,0)) ;
         sCtrlAV8SIS_COD = (String)((String)getParm(obj,1)) ;
         sCtrlAV9PRG_COD = (String)((String)getParm(obj,2)) ;
         sCtrlAV10PRS_NRO = (String)((String)getParm(obj,3)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA452( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "tseg006tseg007wc");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA452( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7USU_COD = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_COD", AV7USU_COD);
            AV8SIS_COD = Convert.ToInt16(getParm(obj,3)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SIS_COD), 3, 0)));
            AV9PRG_COD = Convert.ToInt16(getParm(obj,4)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9PRG_COD), 4, 0)));
            AV10PRS_NRO = Convert.ToInt32(getParm(obj,5)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PRS_NRO), 8, 0)));
         }
         wcpOAV7USU_COD = cgiGet( sPrefix+"wcpOAV7USU_COD") ;
         wcpOAV8SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8SIS_COD"), ",", ".")) ;
         wcpOAV9PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV9PRG_COD"), ",", ".")) ;
         wcpOAV10PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV10PRS_NRO"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV7USU_COD, wcpOAV7USU_COD) != 0 ) || ( AV8SIS_COD != wcpOAV8SIS_COD ) || ( AV9PRG_COD != wcpOAV9PRG_COD ) || ( AV10PRS_NRO != wcpOAV10PRS_NRO ) ) )
         {
            setjustcreated();
         }
         wcpOAV7USU_COD = AV7USU_COD ;
         wcpOAV8SIS_COD = AV8SIS_COD ;
         wcpOAV9PRG_COD = AV9PRG_COD ;
         wcpOAV10PRS_NRO = AV10PRS_NRO ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7USU_COD = cgiGet( sPrefix+"AV7USU_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlAV7USU_COD) > 0 )
         {
            AV7USU_COD = cgiGet( sCtrlAV7USU_COD) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_COD", AV7USU_COD);
         }
         else
         {
            AV7USU_COD = cgiGet( sPrefix+"AV7USU_COD_PARM") ;
         }
         sCtrlAV8SIS_COD = cgiGet( sPrefix+"AV8SIS_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlAV8SIS_COD) > 0 )
         {
            AV8SIS_COD = (short)(context.localUtil.CToN( cgiGet( sCtrlAV8SIS_COD), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SIS_COD), 3, 0)));
         }
         else
         {
            AV8SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV8SIS_COD_PARM"), ",", ".")) ;
         }
         sCtrlAV9PRG_COD = cgiGet( sPrefix+"AV9PRG_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlAV9PRG_COD) > 0 )
         {
            AV9PRG_COD = (short)(context.localUtil.CToN( cgiGet( sCtrlAV9PRG_COD), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9PRG_COD), 4, 0)));
         }
         else
         {
            AV9PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV9PRG_COD_PARM"), ",", ".")) ;
         }
         sCtrlAV10PRS_NRO = cgiGet( sPrefix+"AV10PRS_NRO_CTRL") ;
         if ( StringUtil.Len( sCtrlAV10PRS_NRO) > 0 )
         {
            AV10PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sCtrlAV10PRS_NRO), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PRS_NRO), 8, 0)));
         }
         else
         {
            AV10PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sPrefix+"AV10PRS_NRO_PARM"), ",", ".")) ;
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
         PA452( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS452( ) ;
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
         WS452( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7USU_COD_PARM", StringUtil.RTrim( AV7USU_COD));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7USU_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7USU_COD_CTRL", StringUtil.RTrim( sCtrlAV7USU_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8SIS_COD_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SIS_COD), 3, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8SIS_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8SIS_COD_CTRL", StringUtil.RTrim( sCtrlAV8SIS_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV9PRG_COD_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9PRG_COD), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV9PRG_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV9PRG_COD_CTRL", StringUtil.RTrim( sCtrlAV9PRG_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV10PRS_NRO_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10PRS_NRO), 8, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV10PRS_NRO)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV10PRS_NRO_CTRL", StringUtil.RTrim( sCtrlAV10PRS_NRO));
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
         WE452( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1181851");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("tseg006tseg007wc.js", "?1181851");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_122( )
      {
         WB450( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer) ;
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd" ;
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0 ;
               subGrid_Backcolor = subGrid_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform" ;
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd" ;
               }
               subGrid_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1 ;
               if ( ((int)(nGXsfl_12_idx) % (2)) == 0 )
               {
                  subGrid_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd" ;
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV15Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavUpdate_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV16Delete,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavDelete_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_ORD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A407PRS_ORD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A407PRS_ORD), "ZZ9"),(String)"",(short)0,(String)edtPRS_ORD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_DES_Internalname,StringUtil.RTrim( A408PRS_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A408PRS_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRS_DES_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_LINK_Internalname,(String)A409PRS_LINK,(String)"",(short)0,(String)"px",(short)17,(String)"",(short)300,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,(String)A409PRS_LINK,(String)"",(short)0,(String)edtPRS_LINK_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtPRS_ORD_Internalname = sPrefix+"PRS_ORD_"+sGXsfl_12_idx ;
            edtPRS_DES_Internalname = sPrefix+"PRS_DES_"+sGXsfl_12_idx ;
            edtPRS_LINK_Internalname = sPrefix+"PRS_LINK_"+sGXsfl_12_idx ;
         }
         /* End function sendrow_122 */
      }

      protected void init_default_properties( )
      {
         imgInsert_Internalname = sPrefix+"INSERT" ;
         tblTablegridcontainer_Internalname = sPrefix+"TABLEGRIDCONTAINER" ;
         tblTable_Internalname = sPrefix+"TABLE" ;
         edtUSU_COD_Internalname = sPrefix+"USU_COD" ;
         edtSIS_COD_Internalname = sPrefix+"SIS_COD" ;
         edtPRG_COD_Internalname = sPrefix+"PRG_COD" ;
         edtPRS_NRO_Internalname = sPrefix+"PRS_NRO" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid_Internalname = sPrefix+"GRID" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtPRS_LINK_Jsonclick = "" ;
         edtPRS_DES_Jsonclick = "" ;
         edtPRS_ORD_Jsonclick = "" ;
         subGrid_Class = "WorkWith" ;
         subGrid_Backcolorstyle = 3 ;
         edtavDelete_Link = "" ;
         edtavUpdate_Link = "" ;
         edtPRS_NRO_Jsonclick = "" ;
         edtPRS_NRO_Visible = 1 ;
         edtPRG_COD_Jsonclick = "" ;
         edtPRG_COD_Visible = 1 ;
         edtSIS_COD_Jsonclick = "" ;
         edtSIS_COD_Visible = 1 ;
         edtUSU_COD_Jsonclick = "" ;
         edtUSU_COD_Visible = 1 ;
         subGrid_Rows = 0 ;
         edtavUpdate_Tooltiptext = "Modifica" ;
         edtavDelete_Tooltiptext = "Eliminar" ;
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
         wcpOAV7USU_COD = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         edtavDelete_Internalname = "" ;
         AV16Delete = "" ;
         edtavUpdate_Internalname = "" ;
         AV15Update = "" ;
         AV19Pgmname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GX_FocusControl = "" ;
         ClassString = "" ;
         StyleString = "" ;
         A6USU_COD = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtPRS_ORD_Internalname = "" ;
         edtPRS_DES_Internalname = "" ;
         edtPRS_LINK_Internalname = "" ;
         A408PRS_DES = "" ;
         A409PRS_LINK = "" ;
         GridContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         H00452_A6USU_COD = new String[] {""} ;
         H00452_A116SIS_COD = new short[1] ;
         H00452_A126PRG_COD = new short[1] ;
         H00452_A118PRS_NRO = new int[1] ;
         H00452_A409PRS_LINK = new String[] {""} ;
         H00452_A408PRS_DES = new String[] {""} ;
         H00452_A407PRS_ORD = new short[1] ;
         H00453_AGRID_nRecordCount = new int[1] ;
         AV13TrnContext = new SdtTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11Session = new GxWebSession( context);
         sStyleString = "" ;
         TempTags = "" ;
         imgInsert_Jsonclick = "" ;
         subGrid_Linesclass = "" ;
         GXt_char10 = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GridColumn = new GXWebColumn();
         GXt_char11 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV7USU_COD = "" ;
         sCtrlAV8SIS_COD = "" ;
         sCtrlAV9PRG_COD = "" ;
         sCtrlAV10PRS_NRO = "" ;
         GXt_char12 = "" ;
         GridRow = new GXWebRow();
         ROClassString = "" ;
         GXt_char13 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg006tseg007wc__default(),
            new Object[][] {
                new Object[] {
               H00452_A6USU_COD, H00452_A116SIS_COD, H00452_A126PRG_COD, H00452_A118PRS_NRO, H00452_A409PRS_LINK, H00452_A408PRS_DES, H00452_A407PRS_ORD
               }
               , new Object[] {
               H00453_AGRID_nRecordCount
               }
            }
         );
         AV19Pgmname = "TSEG006TSEG007WC" ;
         /* GeneXus formulas. */
         AV19Pgmname = "TSEG006TSEG007WC" ;
         context.Gx_err = 0 ;
      }

      private short AV8SIS_COD ;
      private short AV9PRG_COD ;
      private short wcpOAV8SIS_COD ;
      private short wcpOAV9PRG_COD ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_Grid ;
      private short nGXsfl_12_idx=1 ;
      private short initialized ;
      private short nGXWrapped ;
      private short GRID_nEOF ;
      private short subGrid_Rows ;
      private short wbEnd ;
      private short wbStart ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short nDraw ;
      private short nDoneStart ;
      private short A407PRS_ORD ;
      private short nDonePA ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int AV10PRS_NRO ;
      private int wcpOAV10PRS_NRO ;
      private int Grid_PageSize12 ;
      private int GRID_nFirstRecordOnPage ;
      private int edtUSU_COD_Visible ;
      private int edtSIS_COD_Visible ;
      private int edtPRG_COD_Visible ;
      private int A118PRS_NRO ;
      private int edtPRS_NRO_Visible ;
      private int subGrid_Islastpage ;
      private int GRID_nCurrentRecord ;
      private int GRID_nRecordCount ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private String AV7USU_COD ;
      private String wcpOAV7USU_COD ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_12_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String AV19Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GX_FocusControl ;
      private String ClassString ;
      private String StyleString ;
      private String edtUSU_COD_Internalname ;
      private String A6USU_COD ;
      private String edtUSU_COD_Jsonclick ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_COD_Jsonclick ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_COD_Jsonclick ;
      private String edtPRS_NRO_Internalname ;
      private String edtPRS_NRO_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtPRS_ORD_Internalname ;
      private String edtPRS_DES_Internalname ;
      private String edtPRS_LINK_Internalname ;
      private String A408PRS_DES ;
      private String scmdbuf ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String sStyleString ;
      private String tblTable_Internalname ;
      private String tblTablegridcontainer_Internalname ;
      private String TempTags ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String GXt_char10 ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char11 ;
      private String sCtrlAV7USU_COD ;
      private String sCtrlAV8SIS_COD ;
      private String sCtrlAV9PRG_COD ;
      private String sCtrlAV10PRS_NRO ;
      private String GXt_char12 ;
      private String ROClassString ;
      private String edtPRS_ORD_Jsonclick ;
      private String edtPRS_DES_Jsonclick ;
      private String edtPRS_LINK_Jsonclick ;
      private String GXt_char13 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A409PRS_LINK ;
      private String AV16Delete ;
      private String AV15Update ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00452_A6USU_COD ;
      private short[] H00452_A116SIS_COD ;
      private short[] H00452_A126PRG_COD ;
      private int[] H00452_A118PRS_NRO ;
      private String[] H00452_A409PRS_LINK ;
      private String[] H00452_A408PRS_DES ;
      private short[] H00452_A407PRS_ORD ;
      private int[] H00453_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private GxWebSession AV11Session ;
      private SdtTransactionContext AV13TrnContext ;
      private SdtTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class tseg006tseg007wc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00452 ;
          prmH00452 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV8SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmH00453 ;
          prmH00453 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV8SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10PRS_NRO",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00452", "SELECT [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_LINK], [PRS_DES], [PRS_ORD] FROM [SEG007] WITH (NOLOCK) WHERE [USU_COD] = @AV7USU_COD and [SIS_COD] = @AV8SIS_COD and [PRG_COD] = @AV9PRG_COD and [PRS_NRO] = @AV10PRS_NRO ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00452,11,1,true,false )
             ,new CursorDef("H00453", "SELECT COUNT(*) FROM [SEG007] WITH (NOLOCK) WHERE [USU_COD] = @AV7USU_COD and [SIS_COD] = @AV8SIS_COD and [PRG_COD] = @AV9PRG_COD and [PRS_NRO] = @AV10PRS_NRO ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00453,1,1,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
