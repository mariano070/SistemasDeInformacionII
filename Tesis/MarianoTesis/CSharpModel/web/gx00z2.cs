/*
               File: Gx00Z2
        Description: Selection List PROGRAMAS ACCEDIDOS POR SESION
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:13.52
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
   public class gx00z2 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00z2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00z2( IGxContext context )
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

      public void execute( String aP0_pUSU_COD ,
                           short aP1_pSIS_COD ,
                           out short aP2_pPRG_COD ,
                           out int aP3_pPRS_NRO ,
                           out short aP4_pPRS_ORD )
      {
         this.AV10pUSU_COD = aP0_pUSU_COD;
         this.AV11pSIS_COD = aP1_pSIS_COD;
         this.AV12pPRG_COD = 0 ;
         this.AV13pPRS_NRO = 0 ;
         this.AV14pPRS_ORD = 0 ;
         executePrivate();
         aP2_pPRG_COD=this.AV12pPRG_COD;
         aP3_pPRS_NRO=this.AV13pPRS_NRO;
         aP4_pPRS_ORD=this.AV14pPRS_ORD;
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
               nGXsfl_36_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_36_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_36_idx, sGXsfl_36_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize36 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cPRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPRG_COD), 4, 0)));
               AV7cPRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cPRS_NRO), 8, 0)));
               AV8cPRS_ORD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPRS_ORD), 3, 0)));
               AV9cPRS_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPRS_DES", AV9cPRS_DES);
               AV10pUSU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pUSU_COD", AV10pUSU_COD);
               AV11pSIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pSIS_COD), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize36, AV6cPRG_COD, AV7cPRS_NRO, AV8cPRS_ORD, AV9cPRS_DES, AV10pUSU_COD, AV11pSIS_COD) ;
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
               AV10pUSU_COD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pUSU_COD", AV10pUSU_COD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11pSIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pSIS_COD), 3, 0)));
                  AV12pPRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPRG_COD), 4, 0)));
                  AV13pPRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPRS_NRO), 8, 0)));
                  AV14pPRS_ORD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pPRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pPRS_ORD), 3, 0)));
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
         PA4E2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4E2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00z2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pUSU_COD)) + "," + UrlEncode("" +AV11pSIS_COD) + "," + UrlEncode("" +AV12pPRG_COD) + "," + UrlEncode("" +AV13pPRS_NRO) + "," + UrlEncode("" +AV14pPRS_ORD)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cPRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRS_ORD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cPRS_ORD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRS_DES", StringUtil.RTrim( AV9cPRS_DES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSU_COD", StringUtil.RTrim( AV10pUSU_COD));
         GxWebStd.gx_hidden_field( context, "vPSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pSIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pPRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pPRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRS_ORD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pPRS_ORD), 3, 0, ",", "")));
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
            WE4E2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4E2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00Z2" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List PROGRAMAS ACCEDIDOS POR SESION" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00z2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pUSU_COD)) + "," + UrlEncode("" +AV11pSIS_COD) + "," + UrlEncode("" +AV12pPRG_COD) + "," + UrlEncode("" +AV13pPRS_NRO) + "," + UrlEncode("" +AV14pPRS_ORD) ;
      }

      protected void WB4E0( )
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
            wb_table1_2_4E2( true) ;
         }
         else
         {
            wb_table1_2_4E2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_4E2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START4E2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List PROGRAMAS ACCEDIDOS POR SESION", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4E0( ) ;
      }

      protected void WS4E2( )
      {
         START4E2( ) ;
         EVT4E2( ) ;
      }

      protected void EVT4E2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRG_COD"), ",", ".") != Convert.ToDecimal( AV6cPRG_COD )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRS_NRO"), ",", ".") != Convert.ToDecimal( AV7cPRS_NRO )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRS_ORD"), ",", ".") != Convert.ToDecimal( AV8cPRS_ORD )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRS_DES"), AV9cPRS_DES) != 0 )
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
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
                              edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_36_idx ;
                              edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_36_idx ;
                              edtPRS_ORD_Internalname = "PRS_ORD_"+sGXsfl_36_idx ;
                              edtPRS_DES_Internalname = "PRS_DES_"+sGXsfl_36_idx ;
                              edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_36_idx ;
                              edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_36_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                              A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
                              A407PRS_ORD = (short)(context.localUtil.CToN( cgiGet( edtPRS_ORD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
                              A408PRS_DES = cgiGet( edtPRS_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408PRS_DES", A408PRS_DES);
                              A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                              A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E114E2 */
                                    E114E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E124E2 */
                                    E124E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cprg_cod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRG_COD"), ",", ".") != Convert.ToDecimal( AV6cPRG_COD )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprs_nro Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRS_NRO"), ",", ".") != Convert.ToDecimal( AV7cPRS_NRO )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprs_ord Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRS_ORD"), ",", ".") != Convert.ToDecimal( AV8cPRS_ORD )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cprs_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRS_DES"), AV9cPRS_DES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E134E2 */
                                          E134E2 ();
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

      protected void WE4E2( )
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

      protected void PA4E2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCprg_cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_36_idx ,
                                       String sGXsfl_36_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_36_idx ;
         edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_36_idx ;
         edtPRS_ORD_Internalname = "PRS_ORD_"+sGXsfl_36_idx ;
         edtPRS_DES_Internalname = "PRS_DES_"+sGXsfl_36_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_36_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_36_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_36_idx ;
            edtPRS_ORD_Internalname = "PRS_ORD_"+sGXsfl_36_idx ;
            edtPRS_DES_Internalname = "PRS_DES_"+sGXsfl_36_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_36_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize36 ,
                                        short AV6cPRG_COD ,
                                        int AV7cPRS_NRO ,
                                        short AV8cPRS_ORD ,
                                        String AV9cPRS_DES ,
                                        String AV10pUSU_COD ,
                                        short AV11pSIS_COD )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize36) ;
         RF4E2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF4E2( ) ;
         /* End function Refresh */
      }

      protected void RF4E2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_36_idx ;
         edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_36_idx ;
         edtPRS_ORD_Internalname = "PRS_ORD_"+sGXsfl_36_idx ;
         edtPRS_DES_Internalname = "PRS_DES_"+sGXsfl_36_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_36_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_36_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_36_idx ;
            edtPRS_ORD_Internalname = "PRS_ORD_"+sGXsfl_36_idx ;
            edtPRS_DES_Internalname = "PRS_DES_"+sGXsfl_36_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_36_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_36_idx ;
            lV9cPRS_DES = StringUtil.PadR( StringUtil.RTrim( AV9cPRS_DES), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPRS_DES", AV9cPRS_DES);
            /* Using cursor H004E2 */
            pr_default.execute(0, new Object[] {AV10pUSU_COD, AV11pSIS_COD, AV6cPRG_COD, AV7cPRS_NRO, AV8cPRS_ORD, lV9cPRS_DES});
            nGXsfl_36_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A116SIS_COD = H004E2_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A6USU_COD = H004E2_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A408PRS_DES = H004E2_A408PRS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408PRS_DES", A408PRS_DES);
               A407PRS_ORD = H004E2_A407PRS_ORD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407PRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(A407PRS_ORD), 3, 0)));
               A118PRS_NRO = H004E2_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A126PRG_COD = H004E2_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               /* Execute user event: E124E2 */
               E124E2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 36 ;
            WB4E0( ) ;
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
         lV9cPRS_DES = StringUtil.PadR( StringUtil.RTrim( AV9cPRS_DES), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPRS_DES", AV9cPRS_DES);
         /* Using cursor H004E3 */
         pr_default.execute(1, new Object[] {AV10pUSU_COD, AV11pSIS_COD, AV6cPRG_COD, AV7cPRS_NRO, AV8cPRS_ORD, lV9cPRS_DES});
         GRID1_nRecordCount = H004E3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP4E0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E114E2 */
         E114E2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCprg_cod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCprg_cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCprg_cod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCPRG_COD");
               GX_FocusControl = edtavCprg_cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cPRG_COD = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPRG_COD), 4, 0)));
            }
            else
            {
               AV6cPRG_COD = (short)(context.localUtil.CToN( cgiGet( edtavCprg_cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPRG_COD), 4, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCprs_nro_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCprs_nro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCprs_nro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCPRS_NRO");
               GX_FocusControl = edtavCprs_nro_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cPRS_NRO = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cPRS_NRO), 8, 0)));
            }
            else
            {
               AV7cPRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtavCprs_nro_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cPRS_NRO), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCprs_ord_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCprs_ord_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCprs_ord_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCPRS_ORD");
               GX_FocusControl = edtavCprs_ord_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cPRS_ORD = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPRS_ORD), 3, 0)));
            }
            else
            {
               AV8cPRS_ORD = (short)(context.localUtil.CToN( cgiGet( edtavCprs_ord_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPRS_ORD), 3, 0)));
            }
            AV9cPRS_DES = cgiGet( edtavCprs_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPRS_DES", AV9cPRS_DES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV10pUSU_COD = cgiGet( "vPUSU_COD") ;
            AV11pSIS_COD = (short)(context.localUtil.CToN( cgiGet( "vPSIS_COD"), ",", ".")) ;
            AV12pPRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPPRG_COD"), ",", ".")) ;
            AV13pPRS_NRO = (int)(context.localUtil.CToN( cgiGet( "vPPRS_NRO"), ",", ".")) ;
            AV14pPRS_ORD = (short)(context.localUtil.CToN( cgiGet( "vPPRS_ORD"), ",", ".")) ;
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
         /* Execute user event: E114E2 */
         E114E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E114E2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "PROGRAMAS ACCEDIDOS POR SESION", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E124E2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_362( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E134E2 */
         E134E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E134E2( )
      {
         /* Enter Routine */
         AV12pPRG_COD = A126PRG_COD ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPRG_COD), 4, 0)));
         AV13pPRS_NRO = A118PRS_NRO ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPRS_NRO), 8, 0)));
         AV14pPRS_ORD = A407PRS_ORD ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pPRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pPRS_ORD), 3, 0)));
         context.setWebReturnParms(new Object[] {(short)AV12pPRG_COD,(int)AV13pPRS_NRO,(short)AV14pPRS_ORD});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_4E2( bool wbgen )
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
            wb_table2_9_4E2( true) ;
         }
         else
         {
            wb_table2_9_4E2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_4E2e( bool wbgen )
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
            wb_table3_33_4E2( true) ;
         }
         else
         {
            wb_table3_33_4E2( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_4E2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_4E2e( true) ;
         }
         else
         {
            wb_table1_2_4E2e( false) ;
         }
      }

      protected void wb_table3_33_4E2( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NRO DE SESION ASIGNADA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ORDEN DE LLAMADOS") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION PROGRAMA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A407PRS_ORD), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A408PRS_DES));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtPRS_DES_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A6USU_COD));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 36 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_36_idx-1) ;
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
            wb_table4_46_4E2( true) ;
         }
         else
         {
            wb_table4_46_4E2( false) ;
         }
         return  ;
      }

      protected void wb_table4_46_4E2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_4E2e( true) ;
         }
         else
         {
            wb_table3_33_4E2e( false) ;
         }
      }

      protected void wb_table4_46_4E2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "", "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_46_4E2e( true) ;
         }
         else
         {
            wb_table4_46_4E2e( false) ;
         }
      }

      protected void wb_table2_9_4E2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCprg_cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cPRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCprg_cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_nro_Internalname, 1, 1, 0, "NRO DE SESION ASIGNADA", "", "", "", 0, lblTextblockprs_nro_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCprs_nro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cPRS_NRO), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cPRS_NRO), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCprs_nro_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_ord_Internalname, 1, 1, 0, "ORDEN DE LLAMADOS", "", "", "", 0, lblTextblockprs_ord_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCprs_ord_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cPRS_ORD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV8cPRS_ORD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", 0, edtavCprs_ord_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_des_Internalname, 1, 1, 0, "DESCRIPCION PROGRAMA", "", "", "", 0, lblTextblockprs_des_Jsonclick, "", StyleString, ClassString, "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCprs_des_Internalname, StringUtil.RTrim( AV9cPRS_DES), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9cPRS_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtavCprs_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00Z2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_4E2e( true) ;
         }
         else
         {
            wb_table2_9_4E2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10pUSU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pUSU_COD", AV10pUSU_COD);
         AV11pSIS_COD = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pSIS_COD), 3, 0)));
         AV12pPRG_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPRG_COD), 4, 0)));
         AV13pPRS_NRO = Convert.ToInt32(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPRS_NRO), 8, 0)));
         AV14pPRS_ORD = Convert.ToInt16(getParm(obj,4)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pPRS_ORD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pPRS_ORD), 3, 0)));
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
         PA4E2( ) ;
         WS4E2( ) ;
         WE4E2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1181414");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00z2.js", "?1181414");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB4E0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_36_idx) % (2)) == 0 )
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A407PRS_ORD), 3, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"),(String)"",(short)0,(String)edtPRG_COD_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_NRO_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A118PRS_NRO), "ZZZZZZZ9"),(String)"",(short)0,(String)edtPRS_NRO_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_ORD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A407PRS_ORD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A407PRS_ORD), "ZZ9"),(String)"",(short)0,(String)edtPRS_ORD_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtPRS_DES_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A407PRS_ORD), 3, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_DES_Internalname, "Link", edtPRS_DES_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_DES_Internalname,StringUtil.RTrim( A408PRS_DES),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtPRS_DES_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A408PRS_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRS_DES_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_COD_Internalname,StringUtil.RTrim( A6USU_COD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")),(String)"",(short)0,(String)edtUSU_COD_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"),(String)"",(short)0,(String)edtSIS_COD_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_36_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_36_idx ;
            edtPRS_ORD_Internalname = "PRS_ORD_"+sGXsfl_36_idx ;
            edtPRS_DES_Internalname = "PRS_DES_"+sGXsfl_36_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_36_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_36_idx ;
         }
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblockprg_cod_Internalname = "TEXTBLOCKPRG_COD" ;
         edtavCprg_cod_Internalname = "vCPRG_COD" ;
         lblTextblockprs_nro_Internalname = "TEXTBLOCKPRS_NRO" ;
         edtavCprs_nro_Internalname = "vCPRS_NRO" ;
         lblTextblockprs_ord_Internalname = "TEXTBLOCKPRS_ORD" ;
         edtavCprs_ord_Internalname = "vCPRS_ORD" ;
         lblTextblockprs_des_Internalname = "TEXTBLOCKPRS_DES" ;
         edtavCprs_des_Internalname = "vCPRS_DES" ;
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
         edtSIS_COD_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtPRS_DES_Jsonclick = "" ;
         edtPRS_ORD_Jsonclick = "" ;
         edtPRS_NRO_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtavCprs_des_Jsonclick = "" ;
         edtavCprs_ord_Jsonclick = "" ;
         edtavCprs_nro_Jsonclick = "" ;
         edtavCprg_cod_Jsonclick = "" ;
         edtPRS_DES_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List PROGRAMAS ACCEDIDOS POR SESION" ;
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
         wcpOAV10pUSU_COD = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV9cPRS_DES = "" ;
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
         edtPRG_COD_Internalname = "" ;
         edtPRS_NRO_Internalname = "" ;
         edtPRS_ORD_Internalname = "" ;
         edtPRS_DES_Internalname = "" ;
         edtUSU_COD_Internalname = "" ;
         edtSIS_COD_Internalname = "" ;
         AV5LinkSelection = "" ;
         A408PRS_DES = "" ;
         A6USU_COD = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV9cPRS_DES = "" ;
         H004E2_A116SIS_COD = new short[1] ;
         H004E2_A6USU_COD = new String[] {""} ;
         H004E2_A408PRS_DES = new String[] {""} ;
         H004E2_A407PRS_ORD = new short[1] ;
         H004E2_A118PRS_NRO = new int[1] ;
         H004E2_A126PRG_COD = new short[1] ;
         H004E3_AGRID1_nRecordCount = new int[1] ;
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
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockprg_cod_Jsonclick = "" ;
         lblTextblockprs_nro_Jsonclick = "" ;
         lblTextblockprs_ord_Jsonclick = "" ;
         lblTextblockprs_des_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00z2__default(),
            new Object[][] {
                new Object[] {
               H004E2_A116SIS_COD, H004E2_A6USU_COD, H004E2_A408PRS_DES, H004E2_A407PRS_ORD, H004E2_A118PRS_NRO, H004E2_A126PRG_COD
               }
               , new Object[] {
               H004E3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11pSIS_COD ;
      private short wcpOAV11pSIS_COD ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_36_idx=1 ;
      private short AV6cPRG_COD ;
      private short AV8cPRS_ORD ;
      private short AV12pPRG_COD ;
      private short AV14pPRS_ORD ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A126PRG_COD ;
      private short A407PRS_ORD ;
      private short A116SIS_COD ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize36 ;
      private int AV7cPRS_NRO ;
      private int AV13pPRS_NRO ;
      private int GRID1_nFirstRecordOnPage ;
      private int A118PRS_NRO ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String AV10pUSU_COD ;
      private String wcpOAV10pUSU_COD ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
      private String AV9cPRS_DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtPRG_COD_Internalname ;
      private String edtPRS_NRO_Internalname ;
      private String edtPRS_ORD_Internalname ;
      private String edtPRS_DES_Internalname ;
      private String edtUSU_COD_Internalname ;
      private String edtSIS_COD_Internalname ;
      private String A408PRS_DES ;
      private String A6USU_COD ;
      private String edtavCprg_cod_Internalname ;
      private String scmdbuf ;
      private String lV9cPRS_DES ;
      private String edtavCprs_nro_Internalname ;
      private String edtavCprs_ord_Internalname ;
      private String edtavCprs_des_Internalname ;
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
      private String edtPRS_DES_Link ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockprg_cod_Internalname ;
      private String lblTextblockprg_cod_Jsonclick ;
      private String edtavCprg_cod_Jsonclick ;
      private String lblTextblockprs_nro_Internalname ;
      private String lblTextblockprs_nro_Jsonclick ;
      private String edtavCprs_nro_Jsonclick ;
      private String lblTextblockprs_ord_Internalname ;
      private String lblTextblockprs_ord_Jsonclick ;
      private String edtavCprs_ord_Jsonclick ;
      private String lblTextblockprs_des_Internalname ;
      private String lblTextblockprs_des_Jsonclick ;
      private String edtavCprs_des_Jsonclick ;
      private String ROClassString ;
      private String edtPRG_COD_Jsonclick ;
      private String edtPRS_NRO_Jsonclick ;
      private String edtPRS_ORD_Jsonclick ;
      private String edtPRS_DES_Jsonclick ;
      private String edtUSU_COD_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String GXt_char8 ;
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
      private short[] H004E2_A116SIS_COD ;
      private String[] H004E2_A6USU_COD ;
      private String[] H004E2_A408PRS_DES ;
      private short[] H004E2_A407PRS_ORD ;
      private int[] H004E2_A118PRS_NRO ;
      private short[] H004E2_A126PRG_COD ;
      private int[] H004E3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP2_pPRG_COD ;
      private int aP3_pPRS_NRO ;
      private short aP4_pPRS_ORD ;
      private GXWebForm Form ;
   }

   public class gx00z2__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH004E2 ;
          prmH004E2 = new Object[] {
          new Object[] {"@AV10pUSU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV11pSIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV6cPRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cPRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cPRS_ORD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9cPRS_DES",SqlDbType.Char,30,0}
          } ;
          Object[] prmH004E3 ;
          prmH004E3 = new Object[] {
          new Object[] {"@AV10pUSU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV11pSIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV6cPRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cPRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cPRS_ORD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9cPRS_DES",SqlDbType.Char,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004E2", "SELECT [SIS_COD], [USU_COD], [PRS_DES], [PRS_ORD], [PRS_NRO], [PRG_COD] FROM [SEG007] WITH (NOLOCK) WHERE ([USU_COD] = @AV10pUSU_COD and [SIS_COD] = @AV11pSIS_COD and [PRG_COD] >= @AV6cPRG_COD and [PRS_NRO] >= @AV7cPRS_NRO and [PRS_ORD] >= @AV8cPRS_ORD) AND ([PRS_DES] like @AV9cPRS_DES) ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004E2,11,1,false,false )
             ,new CursorDef("H004E3", "SELECT COUNT(*) FROM [SEG007] WITH (NOLOCK) WHERE ([USU_COD] = @AV10pUSU_COD and [SIS_COD] = @AV11pSIS_COD and [PRG_COD] >= @AV6cPRG_COD and [PRS_NRO] >= @AV7cPRS_NRO and [PRS_ORD] >= @AV8cPRS_ORD) AND ([PRS_DES] like @AV9cPRS_DES) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004E3,1,1,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
