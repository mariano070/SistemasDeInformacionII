/*
               File: GESTORESEMP_GSTWC
        Description: GESTORESEMP_ GSTWC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:16.65
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
   public class gestoresemp_gstwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public gestoresemp_gstwc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gestoresemp_gstwc( IGxContext context )
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

      public void execute( String aP0_GstEmpCod )
      {
         this.AV7GstEmpCod = aP0_GstEmpCod;
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
                  AV7GstEmpCod = GetNextPar( ) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV7GstEmpCod});
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
                  AV13Delete = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
                  edtavUpdate_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
                  AV12Update = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid_newrow( nRC_Grid, nGXsfl_12_idx, sGXsfl_12_idx, AV13Delete, AV12Update, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
               {
                  /* GeneXus formulas. */
                  AV16Pgmname = "GESTORESEMP_GSTWC" ;
                  context.Gx_err = 0 ;
                  Grid_PageSize12 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV7GstEmpCod = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7GstEmpCod", AV7GstEmpCod);
                  edtavDelete_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
                  AV13Delete = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
                  edtavUpdate_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
                  AV12Update = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid_refresh( Grid_PageSize12, AV7GstEmpCod, AV13Delete, AV12Update, sPrefix) ;
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
            PA0Y2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "GESTORESEMP_GSTWC" ;
               context.Gx_err = 0 ;
               WS0Y2( ) ;
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
            context.WriteHtmlText( "GESTORESEMP_ GSTWC") ;
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gestoresemp_gstwc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7GstEmpCod))+"\" class=\""+"Form"+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            }
         }
      }

      protected void RenderHtmlCloseForm0Y2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7GstEmpCod", StringUtil.RTrim( wcpOAV7GstEmpCod));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGSTEMPCOD", StringUtil.RTrim( AV7GstEmpCod));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 3, 0, ".", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("gestoresemp_gstwc.js", "?19171670");
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

      protected void WB0Y0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "gestoresemp_gstwc.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_0Y2( true) ;
         }
         else
         {
            wb_table1_2_0Y2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGstEmpCod_Internalname, StringUtil.RTrim( A297GstEmpCod), "", 15, "chr", 1, "row", 15, edtGstEmpCod_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A297GstEmpCod, "@!")), "", 0, edtGstEmpCod_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GESTORESEMP_GSTWC.htm");
         }
         wbLoad = true ;
      }

      protected void START0Y2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "GESTORESEMP_ GSTWC", 0) ;
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
               STRUP0Y0( ) ;
            }
         }
      }

      protected void WS0Y2( )
      {
         START0Y2( ) ;
         EVT0Y2( ) ;
      }

      protected void EVT0Y2( )
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
                                 STRUP0Y0( ) ;
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
                                 STRUP0Y0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E110Y2 */
                                    E110Y2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Y0( ) ;
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
                                 STRUP0Y0( ) ;
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
                                 STRUP0Y0( ) ;
                              }
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
                              edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
                              edtEmpGstCod_Internalname = sPrefix+"EMPGSTCOD_"+sGXsfl_12_idx ;
                              edtEmpGstDes_Internalname = sPrefix+"EMPGSTDES_"+sGXsfl_12_idx ;
                              edtEmpGstGpoCod_Internalname = sPrefix+"EMPGSTGPOCOD_"+sGXsfl_12_idx ;
                              AV12Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
                              AV13Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
                              A291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( edtEmpGstCod_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
                              A293EmpGstDes = (short)(context.localUtil.CToN( cgiGet( edtEmpGstDes_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
                              A295EmpGstGpoCod = (short)(context.localUtil.CToN( cgiGet( edtEmpGstGpoCod_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A295EmpGstGpoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A295EmpGstGpoCod), 4, 0)));
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
                                          /* Execute user event: E120Y2 */
                                          E120Y2 ();
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
                                          /* Execute user event: E130Y2 */
                                          E130Y2 ();
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
                                          /* Execute user event: E110Y2 */
                                          E110Y2 ();
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
                                       STRUP0Y0( ) ;
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

      protected void WE0Y2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0Y2( ) ;
            }
         }
      }

      protected void PA0Y2( )
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
                                      String AV13Delete ,
                                      String AV12Update ,
                                      String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
         edtEmpGstCod_Internalname = sPrefix+"EMPGSTCOD_"+sGXsfl_12_idx ;
         edtEmpGstDes_Internalname = sPrefix+"EMPGSTDES_"+sGXsfl_12_idx ;
         edtEmpGstGpoCod_Internalname = sPrefix+"EMPGSTGPOCOD_"+sGXsfl_12_idx ;
         while ( nGXsfl_12_idx <= nRC_Grid )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtEmpGstCod_Internalname = sPrefix+"EMPGSTCOD_"+sGXsfl_12_idx ;
            edtEmpGstDes_Internalname = sPrefix+"EMPGSTDES_"+sGXsfl_12_idx ;
            edtEmpGstGpoCod_Internalname = sPrefix+"EMPGSTGPOCOD_"+sGXsfl_12_idx ;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int Grid_PageSize12 ,
                                       String AV7GstEmpCod ,
                                       String AV13Delete ,
                                       String AV12Update ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid_Rows = (short)(Grid_PageSize12) ;
         RF0Y2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF0Y2( ) ;
         /* End function Refresh */
      }

      protected void RF0Y2( )
      {
         GridContainer.PageSize = subGrid_Recordsperpage( ) ;
         wbStart = 12 ;
         nGXsfl_12_idx = 1 ;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
         edtEmpGstCod_Internalname = sPrefix+"EMPGSTCOD_"+sGXsfl_12_idx ;
         edtEmpGstDes_Internalname = sPrefix+"EMPGSTDES_"+sGXsfl_12_idx ;
         edtEmpGstGpoCod_Internalname = sPrefix+"EMPGSTGPOCOD_"+sGXsfl_12_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtEmpGstCod_Internalname = sPrefix+"EMPGSTCOD_"+sGXsfl_12_idx ;
            edtEmpGstDes_Internalname = sPrefix+"EMPGSTDES_"+sGXsfl_12_idx ;
            edtEmpGstGpoCod_Internalname = sPrefix+"EMPGSTGPOCOD_"+sGXsfl_12_idx ;
            /* Using cursor H000Y2 */
            pr_default.execute(0, new Object[] {AV7GstEmpCod});
            nGXsfl_12_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A297GstEmpCod = H000Y2_A297GstEmpCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A297GstEmpCod", A297GstEmpCod);
               A295EmpGstGpoCod = H000Y2_A295EmpGstGpoCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A295EmpGstGpoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A295EmpGstGpoCod), 4, 0)));
               A293EmpGstDes = H000Y2_A293EmpGstDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
               A291EmpGstCod = H000Y2_A291EmpGstCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
               /* Execute user event: E130Y2 */
               E130Y2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 12 ;
            WB0Y0( ) ;
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
         /* Using cursor H000Y3 */
         pr_default.execute(1, new Object[] {AV7GstEmpCod});
         GRID_nRecordCount = H000Y3_AGRID_nRecordCount[0] ;
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

      protected void STRUP0Y0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "GESTORESEMP_GSTWC" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E120Y2 */
         E120Y2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A297GstEmpCod = StringUtil.Upper( cgiGet( edtGstEmpCod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A297GstEmpCod", A297GstEmpCod);
            /* Read saved values. */
            nRC_Grid = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid"), ",", ".")) ;
            wcpOAV7GstEmpCod = cgiGet( sPrefix+"wcpOAV7GstEmpCod") ;
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
         /* Execute user event: E120Y2 */
         E120Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E120Y2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV16Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)) ;
         }
         subGrid_Rows = 10 ;
         AV12Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
         edtavUpdate_Tooltiptext = "Modifica" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
         AV13Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
         edtavDelete_Tooltiptext = "Eliminar" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
         edtGstEmpCod_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtGstEmpCod_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGstEmpCod_Visible), 5, 0)));
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E130Y2( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("emp_gst.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A291EmpGstCod) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Link", edtavUpdate_Link);
         edtavDelete_Link = formatLink("emp_gst.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A291EmpGstCod) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Link", edtavDelete_Link);
         edtEmpGstDes_Link = formatLink("viewemp_gst.aspx") + "?" + UrlEncode("" +A291EmpGstCod) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtEmpGstDes_Internalname, "Link", edtEmpGstDes_Link);
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

      protected void E110Y2( )
      {
         /* 'DoInsert' Routine */
         context.wjLoc = formatLink("emp_gst.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new SdtTransactionContext(context) ;
         AV10TrnContext.gxTpr_Callerobject = AV16Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Callerondelete = true ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Transactionname = "EMP_GST" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV11TrnContextAtt.gxTpr_Attributename = "GstEmpCod" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV11TrnContextAtt.gxTpr_Attributevalue = AV7GstEmpCod ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV8Session.Set("TrnContext", AV10TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_0Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable_Internalname, tblTable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0Y2( true) ;
         }
         else
         {
            wb_table2_5_0Y2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_0Y2e( bool wbgen )
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
            wb_table1_2_0Y2e( true) ;
         }
         else
         {
            wb_table1_2_0Y2e( false) ;
         }
      }

      protected void wb_table2_5_0Y2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, sPrefix+"E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_GESTORESEMP_GSTWC.htm");
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
               context.SendWebValue( "Gst Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Gst Des") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Gpo Cod") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV13Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A291EmpGstCod), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A293EmpGstDes), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtEmpGstDes_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A295EmpGstGpoCod), 4, 0, ".", "")));
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
            wb_table2_5_0Y2e( true) ;
         }
         else
         {
            wb_table2_5_0Y2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7GstEmpCod = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7GstEmpCod", AV7GstEmpCod);
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
         PA0Y2( ) ;
         WS0Y2( ) ;
         WE0Y2( ) ;
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
         sCtrlAV7GstEmpCod = (String)((String)getParm(obj,0)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA0Y2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "gestoresemp_gstwc");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0Y2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7GstEmpCod = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7GstEmpCod", AV7GstEmpCod);
         }
         wcpOAV7GstEmpCod = cgiGet( sPrefix+"wcpOAV7GstEmpCod") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV7GstEmpCod, wcpOAV7GstEmpCod) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV7GstEmpCod = AV7GstEmpCod ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7GstEmpCod = cgiGet( sPrefix+"AV7GstEmpCod_CTRL") ;
         if ( StringUtil.Len( sCtrlAV7GstEmpCod) > 0 )
         {
            AV7GstEmpCod = cgiGet( sCtrlAV7GstEmpCod) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7GstEmpCod", AV7GstEmpCod);
         }
         else
         {
            AV7GstEmpCod = cgiGet( sPrefix+"AV7GstEmpCod_PARM") ;
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
         PA0Y2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS0Y2( ) ;
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
         WS0Y2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7GstEmpCod_PARM", StringUtil.RTrim( AV7GstEmpCod));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7GstEmpCod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7GstEmpCod_CTRL", StringUtil.RTrim( sCtrlAV7GstEmpCod));
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
         WE0Y2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?1915234");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1917173");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("gestoresemp_gstwc.js", "?1917173");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_122( )
      {
         WB0Y0( ) ;
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
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV12Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavUpdate_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV13Delete,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavDelete_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpGstCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A291EmpGstCod), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A291EmpGstCod), "ZZZZZZZ9"),(String)"",(short)0,(String)edtEmpGstCod_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpGstDes_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A293EmpGstDes), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtEmpGstDes_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A293EmpGstDes), "ZZZ9"),(String)"",(short)0,(String)edtEmpGstDes_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpGstGpoCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A295EmpGstGpoCod), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A295EmpGstGpoCod), "ZZZ9"),(String)"",(short)0,(String)edtEmpGstGpoCod_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtEmpGstCod_Internalname = sPrefix+"EMPGSTCOD_"+sGXsfl_12_idx ;
            edtEmpGstDes_Internalname = sPrefix+"EMPGSTDES_"+sGXsfl_12_idx ;
            edtEmpGstGpoCod_Internalname = sPrefix+"EMPGSTGPOCOD_"+sGXsfl_12_idx ;
         }
         /* End function sendrow_122 */
      }

      protected void init_default_properties( )
      {
         imgInsert_Internalname = sPrefix+"INSERT" ;
         tblTablegridcontainer_Internalname = sPrefix+"TABLEGRIDCONTAINER" ;
         tblTable_Internalname = sPrefix+"TABLE" ;
         edtGstEmpCod_Internalname = sPrefix+"GSTEMPCOD" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid_Internalname = sPrefix+"GRID" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtEmpGstGpoCod_Jsonclick = "" ;
         edtEmpGstDes_Jsonclick = "" ;
         edtEmpGstCod_Jsonclick = "" ;
         subGrid_Class = "WorkWith" ;
         subGrid_Backcolorstyle = 3 ;
         edtEmpGstDes_Link = "" ;
         edtavDelete_Link = "" ;
         edtavUpdate_Link = "" ;
         edtGstEmpCod_Jsonclick = "" ;
         edtGstEmpCod_Visible = 1 ;
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
         wcpOAV7GstEmpCod = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         edtavDelete_Internalname = "" ;
         AV13Delete = "" ;
         edtavUpdate_Internalname = "" ;
         AV12Update = "" ;
         AV16Pgmname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GX_FocusControl = "" ;
         ClassString = "" ;
         StyleString = "" ;
         A297GstEmpCod = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtEmpGstCod_Internalname = "" ;
         edtEmpGstDes_Internalname = "" ;
         edtEmpGstGpoCod_Internalname = "" ;
         GridContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         H000Y2_A297GstEmpCod = new String[] {""} ;
         H000Y2_A295EmpGstGpoCod = new short[1] ;
         H000Y2_A293EmpGstDes = new short[1] ;
         H000Y2_A291EmpGstCod = new int[1] ;
         H000Y3_AGRID_nRecordCount = new int[1] ;
         AV10TrnContext = new SdtTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8Session = new GxWebSession( context);
         sStyleString = "" ;
         TempTags = "" ;
         imgInsert_Jsonclick = "" ;
         subGrid_Linesclass = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GridColumn = new GXWebColumn();
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV7GstEmpCod = "" ;
         GridRow = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gestoresemp_gstwc__default(),
            new Object[][] {
                new Object[] {
               H000Y2_A297GstEmpCod, H000Y2_A295EmpGstGpoCod, H000Y2_A293EmpGstDes, H000Y2_A291EmpGstCod
               }
               , new Object[] {
               H000Y3_AGRID_nRecordCount
               }
            }
         );
         AV16Pgmname = "GESTORESEMP_GSTWC" ;
         /* GeneXus formulas. */
         AV16Pgmname = "GESTORESEMP_GSTWC" ;
         context.Gx_err = 0 ;
      }

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
      private short nDraw ;
      private short nDoneStart ;
      private short A293EmpGstDes ;
      private short A295EmpGstGpoCod ;
      private short nDonePA ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Grid_PageSize12 ;
      private int GRID_nFirstRecordOnPage ;
      private int edtGstEmpCod_Visible ;
      private int A291EmpGstCod ;
      private int subGrid_Islastpage ;
      private int GRID_nCurrentRecord ;
      private int GRID_nRecordCount ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private String AV7GstEmpCod ;
      private String wcpOAV7GstEmpCod ;
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
      private String AV16Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GX_FocusControl ;
      private String ClassString ;
      private String StyleString ;
      private String edtGstEmpCod_Internalname ;
      private String A297GstEmpCod ;
      private String edtGstEmpCod_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEmpGstCod_Internalname ;
      private String edtEmpGstDes_Internalname ;
      private String edtEmpGstGpoCod_Internalname ;
      private String scmdbuf ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String edtEmpGstDes_Link ;
      private String sStyleString ;
      private String tblTable_Internalname ;
      private String tblTablegridcontainer_Internalname ;
      private String TempTags ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String sCtrlAV7GstEmpCod ;
      private String ROClassString ;
      private String edtEmpGstCod_Jsonclick ;
      private String edtEmpGstDes_Jsonclick ;
      private String edtEmpGstGpoCod_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String AV13Delete ;
      private String AV12Update ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000Y2_A297GstEmpCod ;
      private short[] H000Y2_A295EmpGstGpoCod ;
      private short[] H000Y2_A293EmpGstDes ;
      private int[] H000Y2_A291EmpGstCod ;
      private int[] H000Y3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GxWebSession AV8Session ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class gestoresemp_gstwc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000Y2 ;
          prmH000Y2 = new Object[] {
          new Object[] {"@AV7GstEmpCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmH000Y3 ;
          prmH000Y3 = new Object[] {
          new Object[] {"@AV7GstEmpCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000Y2", "SELECT [GstEmpCod], [EmpGstGpoCod], [EmpGstDes], [EmpGstCod] FROM [EMP_GST] WITH (NOLOCK) WHERE [GstEmpCod] = @AV7GstEmpCod ORDER BY [EmpGstCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Y2,11,0,true,false )
             ,new CursorDef("H000Y3", "SELECT COUNT(*) FROM [EMP_GST] WITH (NOLOCK) WHERE [GstEmpCod] = @AV7GstEmpCod ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Y3,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}