/*
               File: Gx00O0
        Description: Selection List BUS000
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:48.1
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
   public class gx00o0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00o0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00o0( IGxContext context )
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

      public void execute( out String aP0_pBUS_EMP ,
                           out short aP1_pBUS_RUB ,
                           out short aP2_pBUS_COD ,
                           out short aP3_pBUS_PAR )
      {
         this.AV15pBUS_EMP = "" ;
         this.AV16pBUS_RUB = 0 ;
         this.AV17pBUS_COD = 0 ;
         this.AV18pBUS_PAR = 0 ;
         executePrivate();
         aP0_pBUS_EMP=this.AV15pBUS_EMP;
         aP1_pBUS_RUB=this.AV16pBUS_RUB;
         aP2_pBUS_COD=this.AV17pBUS_COD;
         aP3_pBUS_PAR=this.AV18pBUS_PAR;
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
               AV6cBUS_EMP = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cBUS_EMP", AV6cBUS_EMP);
               AV7cBUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cBUS_RUB), 4, 0)));
               AV8cBUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cBUS_COD), 4, 0)));
               AV9cBUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cBUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cBUS_PAR), 2, 0)));
               AV12cBUS_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_DES", AV12cBUS_DES);
               AV13cBUS_FAL = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cBUS_FAL", context.localUtil.Format(AV13cBUS_FAL, "99/99/9999"));
               AV14cBUS_FAD = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cBUS_FAD", context.localUtil.Format(AV14cBUS_FAD, "99/99/9999"));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cBUS_EMP, AV7cBUS_RUB, AV8cBUS_COD, AV9cBUS_PAR, AV12cBUS_DES, AV13cBUS_FAL, AV14cBUS_FAD) ;
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
               AV15pBUS_EMP = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pBUS_EMP", AV15pBUS_EMP);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV16pBUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pBUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pBUS_RUB), 4, 0)));
                  AV17pBUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17pBUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17pBUS_COD), 4, 0)));
                  AV18pBUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18pBUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18pBUS_PAR), 2, 0)));
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
         PA2K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2K2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00o0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15pBUS_EMP)) + "," + UrlEncode("" +AV16pBUS_RUB) + "," + UrlEncode("" +AV17pBUS_COD) + "," + UrlEncode("" +AV18pBUS_PAR)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_EMP", StringUtil.RTrim( AV6cBUS_EMP));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cBUS_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cBUS_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_PAR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cBUS_PAR), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_DES", StringUtil.RTrim( AV12cBUS_DES));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_FAL", context.localUtil.Format(AV13cBUS_FAL, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_FAD", context.localUtil.Format(AV14cBUS_FAD, "99/99/9999"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPBUS_EMP", StringUtil.RTrim( AV15pBUS_EMP));
         GxWebStd.gx_hidden_field( context, "vPBUS_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16pBUS_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPBUS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17pBUS_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPBUS_PAR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18pBUS_PAR), 2, 0, ",", "")));
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
            WE2K2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2K2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00O0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List BUS000" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00o0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15pBUS_EMP)) + "," + UrlEncode("" +AV16pBUS_RUB) + "," + UrlEncode("" +AV17pBUS_COD) + "," + UrlEncode("" +AV18pBUS_PAR) ;
      }

      protected void WB2K0( )
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
            wb_table1_2_2K2( true) ;
         }
         else
         {
            wb_table1_2_2K2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2K2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2K2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List BUS000", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2K0( ) ;
      }

      protected void WS2K2( )
      {
         START2K2( ) ;
         EVT2K2( ) ;
      }

      protected void EVT2K2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_EMP"), AV6cBUS_EMP) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_RUB"), ",", ".") != Convert.ToDecimal( AV7cBUS_RUB )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_COD"), ",", ".") != Convert.ToDecimal( AV8cBUS_COD )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_PAR"), ",", ".") != Convert.ToDecimal( AV9cBUS_PAR )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_DES"), AV12cBUS_DES) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_FAL"), 4) != AV13cBUS_FAL )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_FAD"), 4) != AV14cBUS_FAD )
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
                              edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_51_idx ;
                              edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_51_idx ;
                              edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_51_idx ;
                              edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_51_idx ;
                              edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_51_idx ;
                              edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A8BUS_EMP = StringUtil.Upper( cgiGet( edtBUS_EMP_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                              A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
                              A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
                              A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
                              A170BUS_FAL = context.localUtil.CToD( cgiGet( edtBUS_FAL_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
                              A331BUS_COM = StringUtil.Upper( cgiGet( edtBUS_COM_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112K2 */
                                    E112K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122K2 */
                                    E122K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cbus_emp Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_EMP"), AV6cBUS_EMP) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_rub Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_RUB"), ",", ".") != Convert.ToDecimal( AV7cBUS_RUB )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_cod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_COD"), ",", ".") != Convert.ToDecimal( AV8cBUS_COD )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_par Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_PAR"), ",", ".") != Convert.ToDecimal( AV9cBUS_PAR )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_DES"), AV12cBUS_DES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_fal Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_FAL"), 4) != AV13cBUS_FAL )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_fad Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_FAD"), 4) != AV14cBUS_FAD )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132K2 */
                                          E132K2 ();
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

      protected void WE2K2( )
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

      protected void PA2K2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCbus_emp_Internalname ;
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
         edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_51_idx ;
         edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_51_idx ;
         edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_51_idx ;
         edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_51_idx ;
         edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_51_idx ;
         edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_51_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_51_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_51_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_51_idx ;
            edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_51_idx ;
            edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cBUS_EMP ,
                                        short AV7cBUS_RUB ,
                                        short AV8cBUS_COD ,
                                        short AV9cBUS_PAR ,
                                        String AV12cBUS_DES ,
                                        DateTime AV13cBUS_FAL ,
                                        DateTime AV14cBUS_FAD )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF2K2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2K2( ) ;
         /* End function Refresh */
      }

      protected void RF2K2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_51_idx ;
         edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_51_idx ;
         edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_51_idx ;
         edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_51_idx ;
         edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_51_idx ;
         edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_51_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_51_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_51_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_51_idx ;
            edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_51_idx ;
            edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_51_idx ;
            lV6cBUS_EMP = StringUtil.PadR( StringUtil.RTrim( AV6cBUS_EMP), 1, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cBUS_EMP", AV6cBUS_EMP);
            lV12cBUS_DES = StringUtil.PadR( StringUtil.RTrim( AV12cBUS_DES), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_DES", AV12cBUS_DES);
            /* Using cursor H002K2 */
            pr_default.execute(0, new Object[] {lV6cBUS_EMP, AV7cBUS_RUB, AV8cBUS_COD, AV9cBUS_PAR, lV12cBUS_DES, AV13cBUS_FAL, AV14cBUS_FAD});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A54BUS_DES = H002K2_A54BUS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
               A55BUS_FAD = H002K2_A55BUS_FAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               A331BUS_COM = H002K2_A331BUS_COM[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
               A170BUS_FAL = H002K2_A170BUS_FAL[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
               A4BUS_PAR = H002K2_A4BUS_PAR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               A3BUS_COD = H002K2_A3BUS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               A1BUS_RUB = H002K2_A1BUS_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               A8BUS_EMP = H002K2_A8BUS_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               /* Execute user event: E122K2 */
               E122K2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB2K0( ) ;
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
         lV6cBUS_EMP = StringUtil.PadR( StringUtil.RTrim( AV6cBUS_EMP), 1, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cBUS_EMP", AV6cBUS_EMP);
         lV12cBUS_DES = StringUtil.PadR( StringUtil.RTrim( AV12cBUS_DES), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_DES", AV12cBUS_DES);
         /* Using cursor H002K3 */
         pr_default.execute(1, new Object[] {lV6cBUS_EMP, AV7cBUS_RUB, AV8cBUS_COD, AV9cBUS_PAR, lV12cBUS_DES, AV13cBUS_FAL, AV14cBUS_FAD});
         GRID1_nRecordCount = H002K3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2K0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112K2 */
         E112K2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cBUS_EMP = StringUtil.Upper( cgiGet( edtavCbus_emp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cBUS_EMP", AV6cBUS_EMP);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCbus_rub_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCbus_rub_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCbus_rub_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCBUS_RUB");
               GX_FocusControl = edtavCbus_rub_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cBUS_RUB = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cBUS_RUB), 4, 0)));
            }
            else
            {
               AV7cBUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtavCbus_rub_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cBUS_RUB), 4, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCbus_cod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCbus_cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCbus_cod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCBUS_COD");
               GX_FocusControl = edtavCbus_cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cBUS_COD = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cBUS_COD), 4, 0)));
            }
            else
            {
               AV8cBUS_COD = (short)(context.localUtil.CToN( cgiGet( edtavCbus_cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cBUS_COD), 4, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCbus_par_Internalname), "Z9") || ( context.localUtil.CToN( cgiGet( edtavCbus_par_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCbus_par_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCBUS_PAR");
               GX_FocusControl = edtavCbus_par_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cBUS_PAR = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cBUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cBUS_PAR), 2, 0)));
            }
            else
            {
               AV9cBUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtavCbus_par_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cBUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cBUS_PAR), 2, 0)));
            }
            AV12cBUS_DES = StringUtil.Upper( cgiGet( edtavCbus_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_DES", AV12cBUS_DES);
            if ( context.localUtil.VCDate( cgiGet( edtavCbus_fal_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ALTA DEL BIEN"}), 1, "vCBUS_FAL");
               GX_FocusControl = edtavCbus_fal_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV13cBUS_FAL = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cBUS_FAL", context.localUtil.Format(AV13cBUS_FAL, "99/99/9999"));
            }
            else
            {
               AV13cBUS_FAL = context.localUtil.CToD( cgiGet( edtavCbus_fal_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cBUS_FAL", context.localUtil.Format(AV13cBUS_FAL, "99/99/9999"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCbus_fad_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ADQUISICION DEL BIEN"}), 1, "vCBUS_FAD");
               GX_FocusControl = edtavCbus_fad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14cBUS_FAD = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cBUS_FAD", context.localUtil.Format(AV14cBUS_FAD, "99/99/9999"));
            }
            else
            {
               AV14cBUS_FAD = context.localUtil.CToD( cgiGet( edtavCbus_fad_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cBUS_FAD", context.localUtil.Format(AV14cBUS_FAD, "99/99/9999"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV15pBUS_EMP = cgiGet( "vPBUS_EMP") ;
            AV16pBUS_RUB = (short)(context.localUtil.CToN( cgiGet( "vPBUS_RUB"), ",", ".")) ;
            AV17pBUS_COD = (short)(context.localUtil.CToN( cgiGet( "vPBUS_COD"), ",", ".")) ;
            AV18pBUS_PAR = (short)(context.localUtil.CToN( cgiGet( "vPBUS_PAR"), ",", ".")) ;
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
         /* Execute user event: E112K2 */
         E112K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112K2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "BUS000", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122K2( )
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
         /* Execute user event: E132K2 */
         E132K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132K2( )
      {
         /* Enter Routine */
         AV15pBUS_EMP = A8BUS_EMP ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pBUS_EMP", AV15pBUS_EMP);
         AV16pBUS_RUB = A1BUS_RUB ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pBUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pBUS_RUB), 4, 0)));
         AV17pBUS_COD = A3BUS_COD ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17pBUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17pBUS_COD), 4, 0)));
         AV18pBUS_PAR = A4BUS_PAR ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18pBUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18pBUS_PAR), 2, 0)));
         context.setWebReturnParms(new Object[] {(String)AV15pBUS_EMP,(short)AV16pBUS_RUB,(short)AV17pBUS_COD,(short)AV18pBUS_PAR});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2K2( bool wbgen )
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
            wb_table2_9_2K2( true) ;
         }
         else
         {
            wb_table2_9_2K2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2K2e( bool wbgen )
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
            wb_table3_48_2K2( true) ;
         }
         else
         {
            wb_table3_48_2K2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2K2e( true) ;
         }
         else
         {
            wb_table1_2_2K2e( false) ;
         }
      }

      protected void wb_table3_48_2K2( bool wbgen )
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
               context.SendWebValue( "CODIGO DE EMPRESA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "RUBRO DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DE CODIGO DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DE PARTIDA DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "FECHA DE ALTA DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "COMPROBANTE DE COMPRA") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A8BUS_EMP));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A331BUS_COM));
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
            wb_table4_61_2K2( true) ;
         }
         else
         {
            wb_table4_61_2K2( false) ;
         }
         return  ;
      }

      protected void wb_table4_61_2K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2K2e( true) ;
         }
         else
         {
            wb_table3_48_2K2e( false) ;
         }
      }

      protected void wb_table4_61_2K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_61_2K2e( true) ;
         }
         else
         {
            wb_table4_61_2K2e( false) ;
         }
      }

      protected void wb_table2_9_2K2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_emp_Internalname, 1, 1, 0, "CODIGO DE EMPRESA", "", "", "", 0, lblTextblockbus_emp_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_emp_Internalname, StringUtil.RTrim( AV6cBUS_EMP), "", 1, "chr", 1, "row", 1, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6cBUS_EMP, "!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(14);\"", 0, edtavCbus_emp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_rub_Internalname, 1, 1, 0, "RUBRO DEL BIEN", "", "", "", 0, lblTextblockbus_rub_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_rub_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cBUS_RUB), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cBUS_RUB), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCbus_rub_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_cod_Internalname, 1, 1, 0, "NUMERO DE CODIGO DEL BIEN", "", "", "", 0, lblTextblockbus_cod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cBUS_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV8cBUS_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", 0, edtavCbus_cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_par_Internalname, 1, 1, 0, "NUMERO DE PARTIDA DEL BIEN", "", "", "", 0, lblTextblockbus_par_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_par_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cBUS_PAR), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9cBUS_PAR), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", 0, edtavCbus_par_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_des_Internalname, 1, 1, 0, "DESCRIPCION DEL BIEN", "", "", "", 0, lblTextblockbus_des_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_des_Internalname, StringUtil.RTrim( AV12cBUS_DES), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV12cBUS_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(34);\"", 0, edtavCbus_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fal_Internalname, 1, 1, 0, "FECHA DE ALTA DEL BIEN", "", "", "", 0, lblTextblockbus_fal_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCbus_fal_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_fal_Internalname, context.localUtil.Format(AV13cBUS_FAL, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV13cBUS_FAL, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(39);\"", 0, edtavCbus_fal_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00O0.htm");
            GxWebStd.gx_bitmap( context, edtavCbus_fal_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00O0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_fad_Internalname, 1, 1, 0, "FECHA DE ADQUISICION DEL BIEN", "", "", "", 0, lblTextblockbus_fad_Jsonclick, "", StyleString, ClassString, "HLP_Gx00O0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCbus_fad_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_fad_Internalname, context.localUtil.Format(AV14cBUS_FAD, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV14cBUS_FAD, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(44);\"", 0, edtavCbus_fad_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00O0.htm");
            GxWebStd.gx_bitmap( context, edtavCbus_fad_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00O0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2K2e( true) ;
         }
         else
         {
            wb_table2_9_2K2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV15pBUS_EMP = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pBUS_EMP", AV15pBUS_EMP);
         AV16pBUS_RUB = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pBUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pBUS_RUB), 4, 0)));
         AV17pBUS_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17pBUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17pBUS_COD), 4, 0)));
         AV18pBUS_PAR = Convert.ToInt16(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18pBUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18pBUS_PAR), 2, 0)));
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
         PA2K2( ) ;
         WS2K2( ) ;
         WE2K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1174875");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00o0.js", "?1174875");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB2K0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A8BUS_EMP))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_EMP_Internalname,StringUtil.RTrim( A8BUS_EMP),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A8BUS_EMP, "!")),(String)"",(short)0,(String)edtBUS_EMP_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_RUB_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A1BUS_RUB), "ZZZ9"),(String)"",(short)0,(String)edtBUS_RUB_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A3BUS_COD), "ZZZ9"),(String)"",(short)0,(String)edtBUS_COD_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_PAR_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A4BUS_PAR), "Z9"),(String)"",(short)0,(String)edtBUS_PAR_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_FAL_Internalname,context.localUtil.Format(A170BUS_FAL, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A170BUS_FAL, "99/99/9999"),(String)"",(short)0,(String)edtBUS_FAL_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_COM_Internalname,StringUtil.RTrim( A331BUS_COM),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A331BUS_COM, "@!")),(String)"",(short)0,(String)edtBUS_COM_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_51_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_51_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_51_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_51_idx ;
            edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_51_idx ;
            edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockbus_emp_Internalname = "TEXTBLOCKBUS_EMP" ;
         edtavCbus_emp_Internalname = "vCBUS_EMP" ;
         lblTextblockbus_rub_Internalname = "TEXTBLOCKBUS_RUB" ;
         edtavCbus_rub_Internalname = "vCBUS_RUB" ;
         lblTextblockbus_cod_Internalname = "TEXTBLOCKBUS_COD" ;
         edtavCbus_cod_Internalname = "vCBUS_COD" ;
         lblTextblockbus_par_Internalname = "TEXTBLOCKBUS_PAR" ;
         edtavCbus_par_Internalname = "vCBUS_PAR" ;
         lblTextblockbus_des_Internalname = "TEXTBLOCKBUS_DES" ;
         edtavCbus_des_Internalname = "vCBUS_DES" ;
         lblTextblockbus_fal_Internalname = "TEXTBLOCKBUS_FAL" ;
         edtavCbus_fal_Internalname = "vCBUS_FAL" ;
         lblTextblockbus_fad_Internalname = "TEXTBLOCKBUS_FAD" ;
         edtavCbus_fad_Internalname = "vCBUS_FAD" ;
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
         edtBUS_COM_Jsonclick = "" ;
         edtBUS_FAL_Jsonclick = "" ;
         edtBUS_PAR_Jsonclick = "" ;
         edtBUS_COD_Jsonclick = "" ;
         edtBUS_RUB_Jsonclick = "" ;
         edtBUS_EMP_Jsonclick = "" ;
         edtavCbus_fad_Jsonclick = "" ;
         edtavCbus_fal_Jsonclick = "" ;
         edtavCbus_des_Jsonclick = "" ;
         edtavCbus_par_Jsonclick = "" ;
         edtavCbus_cod_Jsonclick = "" ;
         edtavCbus_rub_Jsonclick = "" ;
         edtavCbus_emp_Jsonclick = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List BUS000" ;
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
         AV6cBUS_EMP = "" ;
         AV12cBUS_DES = "" ;
         AV13cBUS_FAL = DateTime.MinValue ;
         AV14cBUS_FAD = DateTime.MinValue ;
         AV15pBUS_EMP = "" ;
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
         edtBUS_EMP_Internalname = "" ;
         edtBUS_RUB_Internalname = "" ;
         edtBUS_COD_Internalname = "" ;
         edtBUS_PAR_Internalname = "" ;
         edtBUS_FAL_Internalname = "" ;
         edtBUS_COM_Internalname = "" ;
         AV5LinkSelection = "" ;
         A8BUS_EMP = "" ;
         A170BUS_FAL = DateTime.MinValue ;
         A331BUS_COM = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cBUS_EMP = "" ;
         lV12cBUS_DES = "" ;
         H002K2_A54BUS_DES = new String[] {""} ;
         H002K2_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         H002K2_A331BUS_COM = new String[] {""} ;
         H002K2_A170BUS_FAL = new DateTime[] {DateTime.MinValue} ;
         H002K2_A4BUS_PAR = new short[1] ;
         H002K2_A3BUS_COD = new short[1] ;
         H002K2_A1BUS_RUB = new short[1] ;
         H002K2_A8BUS_EMP = new String[] {""} ;
         A54BUS_DES = "" ;
         A55BUS_FAD = DateTime.MinValue ;
         H002K3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockbus_emp_Jsonclick = "" ;
         lblTextblockbus_rub_Jsonclick = "" ;
         lblTextblockbus_cod_Jsonclick = "" ;
         lblTextblockbus_par_Jsonclick = "" ;
         lblTextblockbus_des_Jsonclick = "" ;
         lblTextblockbus_fal_Jsonclick = "" ;
         lblTextblockbus_fad_Jsonclick = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00o0__default(),
            new Object[][] {
                new Object[] {
               H002K2_A54BUS_DES, H002K2_A55BUS_FAD, H002K2_A331BUS_COM, H002K2_A170BUS_FAL, H002K2_A4BUS_PAR, H002K2_A3BUS_COD, H002K2_A1BUS_RUB, H002K2_A8BUS_EMP
               }
               , new Object[] {
               H002K3_AGRID1_nRecordCount
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
      private short AV7cBUS_RUB ;
      private short AV8cBUS_COD ;
      private short AV9cBUS_PAR ;
      private short AV16pBUS_RUB ;
      private short AV17pBUS_COD ;
      private short AV18pBUS_PAR ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A1BUS_RUB ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int GRID1_nFirstRecordOnPage ;
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
      private String AV6cBUS_EMP ;
      private String AV12cBUS_DES ;
      private String AV15pBUS_EMP ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtBUS_EMP_Internalname ;
      private String edtBUS_RUB_Internalname ;
      private String edtBUS_COD_Internalname ;
      private String edtBUS_PAR_Internalname ;
      private String edtBUS_FAL_Internalname ;
      private String edtBUS_COM_Internalname ;
      private String A8BUS_EMP ;
      private String A331BUS_COM ;
      private String edtavCbus_emp_Internalname ;
      private String scmdbuf ;
      private String lV6cBUS_EMP ;
      private String lV12cBUS_DES ;
      private String A54BUS_DES ;
      private String edtavCbus_rub_Internalname ;
      private String edtavCbus_cod_Internalname ;
      private String edtavCbus_par_Internalname ;
      private String edtavCbus_des_Internalname ;
      private String edtavCbus_fal_Internalname ;
      private String edtavCbus_fad_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockbus_emp_Internalname ;
      private String lblTextblockbus_emp_Jsonclick ;
      private String edtavCbus_emp_Jsonclick ;
      private String lblTextblockbus_rub_Internalname ;
      private String lblTextblockbus_rub_Jsonclick ;
      private String edtavCbus_rub_Jsonclick ;
      private String lblTextblockbus_cod_Internalname ;
      private String lblTextblockbus_cod_Jsonclick ;
      private String edtavCbus_cod_Jsonclick ;
      private String lblTextblockbus_par_Internalname ;
      private String lblTextblockbus_par_Jsonclick ;
      private String edtavCbus_par_Jsonclick ;
      private String lblTextblockbus_des_Internalname ;
      private String lblTextblockbus_des_Jsonclick ;
      private String edtavCbus_des_Jsonclick ;
      private String lblTextblockbus_fal_Internalname ;
      private String lblTextblockbus_fal_Jsonclick ;
      private String edtavCbus_fal_Jsonclick ;
      private String lblTextblockbus_fad_Internalname ;
      private String lblTextblockbus_fad_Jsonclick ;
      private String GXt_char7 ;
      private String edtavCbus_fad_Jsonclick ;
      private String GXt_char6 ;
      private String ROClassString ;
      private String edtBUS_EMP_Jsonclick ;
      private String edtBUS_RUB_Jsonclick ;
      private String edtBUS_COD_Jsonclick ;
      private String edtBUS_PAR_Jsonclick ;
      private String edtBUS_FAL_Jsonclick ;
      private String edtBUS_COM_Jsonclick ;
      private String GXt_char8 ;
      private DateTime AV13cBUS_FAL ;
      private DateTime AV14cBUS_FAD ;
      private DateTime A170BUS_FAL ;
      private DateTime A55BUS_FAD ;
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
      private String[] H002K2_A54BUS_DES ;
      private DateTime[] H002K2_A55BUS_FAD ;
      private String[] H002K2_A331BUS_COM ;
      private DateTime[] H002K2_A170BUS_FAL ;
      private short[] H002K2_A4BUS_PAR ;
      private short[] H002K2_A3BUS_COD ;
      private short[] H002K2_A1BUS_RUB ;
      private String[] H002K2_A8BUS_EMP ;
      private int[] H002K3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pBUS_EMP ;
      private short aP1_pBUS_RUB ;
      private short aP2_pBUS_COD ;
      private short aP3_pBUS_PAR ;
      private GXWebForm Form ;
   }

   public class gx00o0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002K2 ;
          prmH002K2 = new Object[] {
          new Object[] {"@AV6cBUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV7cBUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cBUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cBUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV12cBUS_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@AV13cBUS_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV14cBUS_FAD",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmH002K3 ;
          prmH002K3 = new Object[] {
          new Object[] {"@AV6cBUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV7cBUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cBUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cBUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV12cBUS_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@AV13cBUS_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV14cBUS_FAD",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002K2", "SELECT [BUS_DES], [BUS_FAD], [BUS_COM], [BUS_FAL], [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP] FROM [BUS000] WITH (NOLOCK) WHERE ([BUS_EMP] like @AV6cBUS_EMP) AND ([BUS_RUB] >= @AV7cBUS_RUB) AND ([BUS_COD] >= @AV8cBUS_COD) AND ([BUS_PAR] >= @AV9cBUS_PAR) AND ([BUS_DES] like @AV12cBUS_DES) AND ([BUS_FAL] >= @AV13cBUS_FAL) AND ([BUS_FAD] >= @AV14cBUS_FAD) ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002K2,11,0,false,false )
             ,new CursorDef("H002K3", "SELECT COUNT(*) FROM [BUS000] WITH (NOLOCK) WHERE ([BUS_EMP] like @AV6cBUS_EMP) AND ([BUS_RUB] >= @AV7cBUS_RUB) AND ([BUS_COD] >= @AV8cBUS_COD) AND ([BUS_PAR] >= @AV9cBUS_PAR) AND ([BUS_DES] like @AV12cBUS_DES) AND ([BUS_FAL] >= @AV13cBUS_FAL) AND ([BUS_FAD] >= @AV14cBUS_FAD) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002K3,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 2) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 1) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                break;
       }
    }

 }

}
