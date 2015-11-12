/*
               File: Gx00Y0
        Description: Selection List SESIONES POR USUARIO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:17.35
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
   public class gx00y0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00y0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00y0( IGxContext context )
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

      public void execute( out String aP0_pUSU_COD ,
                           out short aP1_pSIS_COD ,
                           out short aP2_pPRG_COD ,
                           out int aP3_pPRS_NRO )
      {
         this.AV13pUSU_COD = "" ;
         this.AV14pSIS_COD = 0 ;
         this.AV15pPRG_COD = 0 ;
         this.AV16pPRS_NRO = 0 ;
         executePrivate();
         aP0_pUSU_COD=this.AV13pUSU_COD;
         aP1_pSIS_COD=this.AV14pSIS_COD;
         aP2_pPRG_COD=this.AV15pPRG_COD;
         aP3_pPRS_NRO=this.AV16pPRS_NRO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cUSU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUSU_COD", AV6cUSU_COD);
               AV7cSIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cSIS_COD), 3, 0)));
               AV8cPRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPRG_COD), 4, 0)));
               AV9cPRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cPRS_NRO), 8, 0)));
               AV10cPRS_INI = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPRS_INI", context.localUtil.TToC( AV10cPRS_INI, 8, 5, 0, 3, "/", ":", " "));
               AV11cPRS_UOB = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPRS_UOB", AV11cPRS_UOB);
               AV12cPRS_CAD = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cPRS_CAD", context.localUtil.TToC( AV12cPRS_CAD, 8, 5, 0, 3, "/", ":", " "));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cUSU_COD, AV7cSIS_COD, AV8cPRG_COD, AV9cPRS_NRO, AV10cPRS_INI, AV11cPRS_UOB, AV12cPRS_CAD) ;
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
            if ( ! entryPointCalled )
            {
               AV13pUSU_COD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pUSU_COD", AV13pUSU_COD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pSIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pSIS_COD), 3, 0)));
                  AV15pPRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pPRG_COD), 4, 0)));
                  AV16pPRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pPRS_NRO), 8, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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

      public override short ExecuteStartEvent( )
      {
         PA4H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4H2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00y0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pUSU_COD)) + "," + UrlEncode("" +AV14pSIS_COD) + "," + UrlEncode("" +AV15pPRG_COD) + "," + UrlEncode("" +AV16pPRS_NRO)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCUSU_COD", StringUtil.RTrim( AV6cUSU_COD));
         GxWebStd.gx_hidden_field( context, "GXH_vCSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cSIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cPRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cPRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRS_INI", context.localUtil.Format(AV10cPRS_INI, "99/99/99 99:99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRS_UOB", StringUtil.RTrim( AV11cPRS_UOB));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRS_CAD", context.localUtil.Format(AV12cPRS_CAD, "99/99/99 99:99"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSU_COD", StringUtil.RTrim( AV13pUSU_COD));
         GxWebStd.gx_hidden_field( context, "vPSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pSIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15pPRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16pPRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE4H2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4H2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00Y0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List SESIONES POR USUARIO" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00y0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pUSU_COD)) + "," + UrlEncode("" +AV14pSIS_COD) + "," + UrlEncode("" +AV15pPRG_COD) + "," + UrlEncode("" +AV16pPRS_NRO) ;
      }

      protected void WB4H0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_4H2( true) ;
         }
         else
         {
            wb_table1_2_4H2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_4H2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START4H2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List SESIONES POR USUARIO", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4H0( ) ;
      }

      protected void WS4H2( )
      {
         START4H2( ) ;
         EVT4H2( ) ;
      }

      protected void EVT4H2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSU_COD"), AV6cUSU_COD) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSIS_COD"), ",", ".") != Convert.ToDecimal( AV7cSIS_COD )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRG_COD"), ",", ".") != Convert.ToDecimal( AV8cPRG_COD )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRS_NRO"), ",", ".") != Convert.ToDecimal( AV9cPRS_NRO )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToT( cgiGet( "GXH_vCPRS_INI")) != AV10cPRS_INI )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRS_UOB"), AV11cPRS_UOB) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToT( cgiGet( "GXH_vCPRS_CAD")) != AV12cPRS_CAD )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_51_idx ;
                              edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_51_idx ;
                              edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_51_idx ;
                              edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_51_idx ;
                              edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_51_idx ;
                              edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_51_idx ;
                              edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                              A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                              A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                              A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
                              A166PRS_INI = context.localUtil.CToT( cgiGet( edtPRS_INI_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
                              A404PRS_UOB = cgiGet( edtPRS_UOB_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
                              A165PRS_CAD = context.localUtil.CToT( cgiGet( edtPRS_CAD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E114H2 */
                                    E114H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E124H2 */
                                    E124H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cusu_cod Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSU_COD"), AV6cUSU_COD) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csis_cod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSIS_COD"), ",", ".") != Convert.ToDecimal( AV7cSIS_COD )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprg_cod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRG_COD"), ",", ".") != Convert.ToDecimal( AV8cPRG_COD )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprs_nro Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRS_NRO"), ",", ".") != Convert.ToDecimal( AV9cPRS_NRO )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprs_ini Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCPRS_INI")) != AV10cPRS_INI )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprs_uob Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRS_UOB"), AV11cPRS_UOB) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprs_cad Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCPRS_CAD")) != AV12cPRS_CAD )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E134H2 */
                                          E134H2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
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

      protected void WE4H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA4H2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCusu_cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_51_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_51_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_51_idx ;
         edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_51_idx ;
         edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_51_idx ;
         edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_51_idx ;
         edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_51_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_51_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_51_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_51_idx ;
            edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_51_idx ;
            edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_51_idx ;
            edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cUSU_COD ,
                                        short AV7cSIS_COD ,
                                        short AV8cPRG_COD ,
                                        int AV9cPRS_NRO ,
                                        DateTime AV10cPRS_INI ,
                                        String AV11cPRS_UOB ,
                                        DateTime AV12cPRS_CAD )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF4H2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF4H2( ) ;
         /* End function Refresh */
      }

      protected void RF4H2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_51_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_51_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_51_idx ;
         edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_51_idx ;
         edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_51_idx ;
         edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_51_idx ;
         edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_51_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_51_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_51_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_51_idx ;
            edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_51_idx ;
            edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_51_idx ;
            edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_51_idx ;
            lV6cUSU_COD = StringUtil.PadR( StringUtil.RTrim( AV6cUSU_COD), 16, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUSU_COD", AV6cUSU_COD);
            lV11cPRS_UOB = StringUtil.PadR( StringUtil.RTrim( AV11cPRS_UOB), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPRS_UOB", AV11cPRS_UOB);
            /* Using cursor H004H2 */
            pr_default.execute(0, new Object[] {lV6cUSU_COD, AV7cSIS_COD, AV8cPRG_COD, AV9cPRS_NRO, AV10cPRS_INI, lV11cPRS_UOB, AV12cPRS_CAD});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A165PRS_CAD = H004H2_A165PRS_CAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
               A404PRS_UOB = H004H2_A404PRS_UOB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
               A166PRS_INI = H004H2_A166PRS_INI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               A118PRS_NRO = H004H2_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A126PRG_COD = H004H2_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A116SIS_COD = H004H2_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A6USU_COD = H004H2_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               /* Execute user event: E124H2 */
               E124H2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB4H0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV6cUSU_COD = StringUtil.PadR( StringUtil.RTrim( AV6cUSU_COD), 16, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUSU_COD", AV6cUSU_COD);
         lV11cPRS_UOB = StringUtil.PadR( StringUtil.RTrim( AV11cPRS_UOB), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPRS_UOB", AV11cPRS_UOB);
         /* Using cursor H004H3 */
         pr_default.execute(1, new Object[] {lV6cUSU_COD, AV7cSIS_COD, AV8cPRG_COD, AV9cPRS_NRO, AV10cPRS_INI, lV11cPRS_UOB, AV12cPRS_CAD});
         GRID1_nRecordCount = H004H3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid1_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP4H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E114H2 */
         E114H2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cUSU_COD = StringUtil.Upper( cgiGet( edtavCusu_cod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUSU_COD", AV6cUSU_COD);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCsis_cod_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCsis_cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCsis_cod_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCSIS_COD");
               GX_FocusControl = edtavCsis_cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cSIS_COD = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cSIS_COD), 3, 0)));
            }
            else
            {
               AV7cSIS_COD = (short)(context.localUtil.CToN( cgiGet( edtavCsis_cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cSIS_COD), 3, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCprg_cod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCprg_cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCprg_cod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCPRG_COD");
               GX_FocusControl = edtavCprg_cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cPRG_COD = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPRG_COD), 4, 0)));
            }
            else
            {
               AV8cPRG_COD = (short)(context.localUtil.CToN( cgiGet( edtavCprg_cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPRG_COD), 4, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCprs_nro_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCprs_nro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCprs_nro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCPRS_NRO");
               GX_FocusControl = edtavCprs_nro_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cPRS_NRO = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cPRS_NRO), 8, 0)));
            }
            else
            {
               AV9cPRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtavCprs_nro_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cPRS_NRO), 8, 0)));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCprs_ini_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"MOMENTO DE INICIO SESION"}), 1, "vCPRS_INI");
               GX_FocusControl = edtavCprs_ini_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cPRS_INI = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPRS_INI", context.localUtil.TToC( AV10cPRS_INI, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV10cPRS_INI = context.localUtil.CToT( cgiGet( edtavCprs_ini_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPRS_INI", context.localUtil.TToC( AV10cPRS_INI, 8, 5, 0, 3, "/", ":", " "));
            }
            AV11cPRS_UOB = cgiGet( edtavCprs_uob_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPRS_UOB", AV11cPRS_UOB);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCprs_cad_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"MOMENTO CADUCIDAD SESION"}), 1, "vCPRS_CAD");
               GX_FocusControl = edtavCprs_cad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cPRS_CAD = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cPRS_CAD", context.localUtil.TToC( AV12cPRS_CAD, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV12cPRS_CAD = context.localUtil.CToT( cgiGet( edtavCprs_cad_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cPRS_CAD", context.localUtil.TToC( AV12cPRS_CAD, 8, 5, 0, 3, "/", ":", " "));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13pUSU_COD = cgiGet( "vPUSU_COD") ;
            AV14pSIS_COD = (short)(context.localUtil.CToN( cgiGet( "vPSIS_COD"), ",", ".")) ;
            AV15pPRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPPRG_COD"), ",", ".")) ;
            AV16pPRS_NRO = (int)(context.localUtil.CToN( cgiGet( "vPPRS_NRO"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
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
         /* Execute user event: E114H2 */
         E114H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E114H2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "SESIONES POR USUARIO", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E124H2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E134H2 */
         E134H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E134H2( )
      {
         /* Enter Routine */
         AV13pUSU_COD = A6USU_COD ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pUSU_COD", AV13pUSU_COD);
         AV14pSIS_COD = A116SIS_COD ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pSIS_COD), 3, 0)));
         AV15pPRG_COD = A126PRG_COD ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pPRG_COD), 4, 0)));
         AV16pPRS_NRO = A118PRS_NRO ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pPRS_NRO), 8, 0)));
         context.setWebReturnParms(new Object[] {(String)AV13pUSU_COD,(short)AV14pSIS_COD,(short)AV15pPRG_COD,(int)AV16pPRS_NRO});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_4H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_4H2( true) ;
         }
         else
         {
            wb_table2_9_4H2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_4H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_48_4H2( true) ;
         }
         else
         {
            wb_table3_48_4H2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_4H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_4H2e( true) ;
         }
         else
         {
            wb_table1_2_4H2e( false) ;
         }
      }

      protected void wb_table3_48_4H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NRO DE SESION ASIGNADA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "MOMENTO DE INICIO SESION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ULTIMO OBJETO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "MOMENTO CADUCIDAD SESION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A6USU_COD));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtPRS_INI_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A404PRS_UOB));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_62_4H2( true) ;
         }
         else
         {
            wb_table4_62_4H2( false) ;
         }
         return  ;
      }

      protected void wb_table4_62_4H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_4H2e( true) ;
         }
         else
         {
            wb_table3_48_4H2e( false) ;
         }
      }

      protected void wb_table4_62_4H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_62_4H2e( true) ;
         }
         else
         {
            wb_table4_62_4H2e( false) ;
         }
      }

      protected void wb_table2_9_4H2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockusu_cod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCusu_cod_Internalname, StringUtil.RTrim( AV6cUSU_COD), "", 16, "chr", 1, "row", 16, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6cUSU_COD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(14);\"", 0, edtavCusu_cod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksis_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblocksis_cod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsis_cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cSIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cSIS_COD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCsis_cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCprg_cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cPRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV8cPRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", 0, edtavCprg_cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_nro_Internalname, 1, 1, 0, "NRO DE SESION ASIGNADA", "", "", "", 0, lblTextblockprs_nro_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCprs_nro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cPRS_NRO), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9cPRS_NRO), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", 0, edtavCprs_nro_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_ini_Internalname, 1, 1, 0, "MOMENTO DE INICIO SESION", "", "", "", 0, lblTextblockprs_ini_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCprs_ini_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCprs_ini_Internalname, context.localUtil.Format(AV10cPRS_INI, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV10cPRS_INI, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(34);\"", 0, edtavCprs_ini_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Y0.htm");
            GxWebStd.gx_bitmap( context, edtavCprs_ini_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00Y0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_uob_Internalname, 1, 1, 0, "ULTIMO OBJETO", "", "", "", 0, lblTextblockprs_uob_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCprs_uob_Internalname, StringUtil.RTrim( AV11cPRS_UOB), "", 20, "chr", 1, "row", 20, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV11cPRS_UOB, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", 0, edtavCprs_uob_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_cad_Internalname, 1, 1, 0, "MOMENTO CADUCIDAD SESION", "", "", "", 0, lblTextblockprs_cad_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Y0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCprs_cad_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCprs_cad_Internalname, context.localUtil.Format(AV12cPRS_CAD, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV12cPRS_CAD, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(44);\"", 0, edtavCprs_cad_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Y0.htm");
            GxWebStd.gx_bitmap( context, edtavCprs_cad_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00Y0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_4H2e( true) ;
         }
         else
         {
            wb_table2_9_4H2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pUSU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pUSU_COD", AV13pUSU_COD);
         AV14pSIS_COD = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pSIS_COD), 3, 0)));
         AV15pPRG_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pPRG_COD), 4, 0)));
         AV16pPRS_NRO = Convert.ToInt32(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pPRS_NRO), 8, 0)));
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
         PA4H2( ) ;
         WS4H2( ) ;
         WE4H2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1118189");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00y0.js", "?1118189");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB4H0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A6USU_COD))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_COD_Internalname,StringUtil.RTrim( A6USU_COD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")),(String)"",(short)0,(String)edtUSU_COD_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"),(String)"",(short)0,(String)edtSIS_COD_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"),(String)"",(short)0,(String)edtPRG_COD_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_NRO_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A118PRS_NRO), "ZZZZZZZ9"),(String)"",(short)0,(String)edtPRS_NRO_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtPRS_INI_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A6USU_COD))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_INI_Internalname, "Link", edtPRS_INI_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_INI_Internalname,context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtPRS_INI_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A166PRS_INI, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRS_INI_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_UOB_Internalname,StringUtil.RTrim( A404PRS_UOB),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A404PRS_UOB, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRS_UOB_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_CAD_Internalname,context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A165PRS_CAD, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRS_CAD_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_51_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_51_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_51_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_51_idx ;
            edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_51_idx ;
            edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_51_idx ;
            edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockusu_cod_Internalname = "TEXTBLOCKUSU_COD" ;
         edtavCusu_cod_Internalname = "vCUSU_COD" ;
         lblTextblocksis_cod_Internalname = "TEXTBLOCKSIS_COD" ;
         edtavCsis_cod_Internalname = "vCSIS_COD" ;
         lblTextblockprg_cod_Internalname = "TEXTBLOCKPRG_COD" ;
         edtavCprg_cod_Internalname = "vCPRG_COD" ;
         lblTextblockprs_nro_Internalname = "TEXTBLOCKPRS_NRO" ;
         edtavCprs_nro_Internalname = "vCPRS_NRO" ;
         lblTextblockprs_ini_Internalname = "TEXTBLOCKPRS_INI" ;
         edtavCprs_ini_Internalname = "vCPRS_INI" ;
         lblTextblockprs_uob_Internalname = "TEXTBLOCKPRS_UOB" ;
         edtavCprs_uob_Internalname = "vCPRS_UOB" ;
         lblTextblockprs_cad_Internalname = "TEXTBLOCKPRS_CAD" ;
         edtavCprs_cad_Internalname = "vCPRS_CAD" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtPRS_CAD_Jsonclick = "" ;
         edtPRS_UOB_Jsonclick = "" ;
         edtPRS_INI_Jsonclick = "" ;
         edtPRS_NRO_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtSIS_COD_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtavCprs_cad_Jsonclick = "" ;
         edtavCprs_uob_Jsonclick = "" ;
         edtavCprs_ini_Jsonclick = "" ;
         edtavCprs_nro_Jsonclick = "" ;
         edtavCprg_cod_Jsonclick = "" ;
         edtavCsis_cod_Jsonclick = "" ;
         edtavCusu_cod_Jsonclick = "" ;
         edtPRS_INI_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List SESIONES POR USUARIO" ;
         context.GX_msglist.DisplayMode = 1 ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV6cUSU_COD = "" ;
         AV10cPRS_INI = (DateTime)(DateTime.MinValue) ;
         AV11cPRS_UOB = "" ;
         AV12cPRS_CAD = (DateTime)(DateTime.MinValue) ;
         AV13pUSU_COD = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtUSU_COD_Internalname = "" ;
         edtSIS_COD_Internalname = "" ;
         edtPRG_COD_Internalname = "" ;
         edtPRS_NRO_Internalname = "" ;
         edtPRS_INI_Internalname = "" ;
         edtPRS_UOB_Internalname = "" ;
         edtPRS_CAD_Internalname = "" ;
         AV5LinkSelection = "" ;
         A6USU_COD = "" ;
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         A404PRS_UOB = "" ;
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cUSU_COD = "" ;
         lV11cPRS_UOB = "" ;
         H004H2_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         H004H2_A404PRS_UOB = new String[] {""} ;
         H004H2_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         H004H2_A118PRS_NRO = new int[1] ;
         H004H2_A126PRG_COD = new short[1] ;
         H004H2_A116SIS_COD = new short[1] ;
         H004H2_A6USU_COD = new String[] {""} ;
         H004H3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockusu_cod_Jsonclick = "" ;
         lblTextblocksis_cod_Jsonclick = "" ;
         lblTextblockprg_cod_Jsonclick = "" ;
         lblTextblockprs_nro_Jsonclick = "" ;
         lblTextblockprs_ini_Jsonclick = "" ;
         lblTextblockprs_uob_Jsonclick = "" ;
         lblTextblockprs_cad_Jsonclick = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00y0__default(),
            new Object[][] {
                new Object[] {
               H004H2_A165PRS_CAD, H004H2_A404PRS_UOB, H004H2_A166PRS_INI, H004H2_A118PRS_NRO, H004H2_A126PRG_COD, H004H2_A116SIS_COD, H004H2_A6USU_COD
               }
               , new Object[] {
               H004H3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short AV7cSIS_COD ;
      private short AV8cPRG_COD ;
      private short AV14pSIS_COD ;
      private short AV15pPRG_COD ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV9cPRS_NRO ;
      private int AV16pPRS_NRO ;
      private int GRID1_nFirstRecordOnPage ;
      private int A118PRS_NRO ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String AV6cUSU_COD ;
      private String AV11cPRS_UOB ;
      private String AV13pUSU_COD ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtUSU_COD_Internalname ;
      private String edtSIS_COD_Internalname ;
      private String edtPRG_COD_Internalname ;
      private String edtPRS_NRO_Internalname ;
      private String edtPRS_INI_Internalname ;
      private String edtPRS_UOB_Internalname ;
      private String edtPRS_CAD_Internalname ;
      private String A6USU_COD ;
      private String A404PRS_UOB ;
      private String edtavCusu_cod_Internalname ;
      private String scmdbuf ;
      private String lV6cUSU_COD ;
      private String lV11cPRS_UOB ;
      private String edtavCsis_cod_Internalname ;
      private String edtavCprg_cod_Internalname ;
      private String edtavCprs_nro_Internalname ;
      private String edtavCprs_ini_Internalname ;
      private String edtavCprs_uob_Internalname ;
      private String edtavCprs_cad_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String edtavLinkselection_Link ;
      private String edtPRS_INI_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockusu_cod_Internalname ;
      private String lblTextblockusu_cod_Jsonclick ;
      private String edtavCusu_cod_Jsonclick ;
      private String lblTextblocksis_cod_Internalname ;
      private String lblTextblocksis_cod_Jsonclick ;
      private String edtavCsis_cod_Jsonclick ;
      private String lblTextblockprg_cod_Internalname ;
      private String lblTextblockprg_cod_Jsonclick ;
      private String edtavCprg_cod_Jsonclick ;
      private String lblTextblockprs_nro_Internalname ;
      private String lblTextblockprs_nro_Jsonclick ;
      private String edtavCprs_nro_Jsonclick ;
      private String lblTextblockprs_ini_Internalname ;
      private String lblTextblockprs_ini_Jsonclick ;
      private String edtavCprs_ini_Jsonclick ;
      private String lblTextblockprs_uob_Internalname ;
      private String lblTextblockprs_uob_Jsonclick ;
      private String edtavCprs_uob_Jsonclick ;
      private String lblTextblockprs_cad_Internalname ;
      private String lblTextblockprs_cad_Jsonclick ;
      private String GXt_char8 ;
      private String edtavCprs_cad_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtUSU_COD_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String edtPRG_COD_Jsonclick ;
      private String edtPRS_NRO_Jsonclick ;
      private String edtPRS_INI_Jsonclick ;
      private String edtPRS_UOB_Jsonclick ;
      private String edtPRS_CAD_Jsonclick ;
      private String GXt_char9 ;
      private DateTime AV10cPRS_INI ;
      private DateTime AV12cPRS_CAD ;
      private DateTime A166PRS_INI ;
      private DateTime A165PRS_CAD ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H004H2_A165PRS_CAD ;
      private String[] H004H2_A404PRS_UOB ;
      private DateTime[] H004H2_A166PRS_INI ;
      private int[] H004H2_A118PRS_NRO ;
      private short[] H004H2_A126PRG_COD ;
      private short[] H004H2_A116SIS_COD ;
      private String[] H004H2_A6USU_COD ;
      private int[] H004H3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pUSU_COD ;
      private short aP1_pSIS_COD ;
      private short aP2_pPRG_COD ;
      private int aP3_pPRS_NRO ;
      private GXWebForm Form ;
   }

   public class gx00y0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH004H2 ;
          prmH004H2 = new Object[] {
          new Object[] {"@AV6cUSU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV7cSIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8cPRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cPRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@AV10cPRS_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV11cPRS_UOB",SqlDbType.Char,20,0} ,
          new Object[] {"@AV12cPRS_CAD",SqlDbType.DateTime,8,5}
          } ;
          Object[] prmH004H3 ;
          prmH004H3 = new Object[] {
          new Object[] {"@AV6cUSU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV7cSIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8cPRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cPRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@AV10cPRS_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV11cPRS_UOB",SqlDbType.Char,20,0} ,
          new Object[] {"@AV12cPRS_CAD",SqlDbType.DateTime,8,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004H2", "SELECT [PRS_CAD], [PRS_UOB], [PRS_INI], [PRS_NRO], [PRG_COD], [SIS_COD], [USU_COD] FROM [SEG006] WITH (NOLOCK) WHERE ([USU_COD] like @AV6cUSU_COD) AND ([SIS_COD] >= @AV7cSIS_COD) AND ([PRG_COD] >= @AV8cPRG_COD) AND ([PRS_NRO] >= @AV9cPRS_NRO) AND ([PRS_INI] >= @AV10cPRS_INI) AND ([PRS_UOB] like @AV11cPRS_UOB) AND ([PRS_CAD] >= @AV12cPRS_CAD) ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004H2,11,1,false,false )
             ,new CursorDef("H004H3", "SELECT COUNT(*) FROM [SEG006] WITH (NOLOCK) WHERE ([USU_COD] like @AV6cUSU_COD) AND ([SIS_COD] >= @AV7cSIS_COD) AND ([PRG_COD] >= @AV8cPRG_COD) AND ([PRS_NRO] >= @AV9cPRS_NRO) AND ([PRS_INI] >= @AV10cPRS_INI) AND ([PRS_UOB] like @AV11cPRS_UOB) AND ([PRS_CAD] >= @AV12cPRS_CAD) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004H3,1,1,false,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
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
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                break;
       }
    }

 }

}
