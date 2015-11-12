/*
               File: Gx00B0
        Description: Selection List Historial de Asociaciones de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:31.17
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
   public class gx00b0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00b0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00b0( IGxContext context )
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

      public void execute( out int aP0_pTTBUS3_IdBien ,
                           out int aP1_pTTBUS3_NroAsoc )
      {
         this.AV13pTTBUS3_IdBien = 0 ;
         this.AV14pTTBUS3_NroAsoc = 0 ;
         executePrivate();
         aP0_pTTBUS3_IdBien=this.AV13pTTBUS3_IdBien;
         aP1_pTTBUS3_NroAsoc=this.AV14pTTBUS3_NroAsoc;
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
               AV6cTTBUS3_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS3_IdBien), 8, 0)));
               AV7cTTBUS3_NroAsoc = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTTBUS3_NroAsoc), 8, 0)));
               AV8cTTBUS3_Sist = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTTBUS3_Sist), 2, 0)));
               AV9cTTBUS3_HdwId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cTTBUS3_HdwId), 4, 0)));
               AV10cTTBUS3_BusEmp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS3_BusEmp", AV10cTTBUS3_BusEmp);
               AV11cTTBUS3_BusRub = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTTBUS3_BusRub), 4, 0)));
               AV12cTTBUS3_BusCod = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cTTBUS3_BusCod), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cTTBUS3_IdBien, AV7cTTBUS3_NroAsoc, AV8cTTBUS3_Sist, AV9cTTBUS3_HdwId, AV10cTTBUS3_BusEmp, AV11cTTBUS3_BusRub, AV12cTTBUS3_BusCod) ;
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
               AV13pTTBUS3_IdBien = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTTBUS3_IdBien), 8, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pTTBUS3_NroAsoc = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS3_NroAsoc), 8, 0)));
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
         PA2W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2W2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00b0.aspx") + "?" + UrlEncode("" +AV13pTTBUS3_IdBien) + "," + UrlEncode("" +AV14pTTBUS3_NroAsoc)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS3_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS3_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS3_NROASOC", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cTTBUS3_NroAsoc), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS3_SIST", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTTBUS3_Sist), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS3_HDWID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cTTBUS3_HdwId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS3_BUSEMP", StringUtil.RTrim( AV10cTTBUS3_BusEmp));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS3_BUSRUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTTBUS3_BusRub), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS3_BUSCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cTTBUS3_BusCod), 4, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS3_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pTTBUS3_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS3_NROASOC", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pTTBUS3_NroAsoc), 8, 0, ",", "")));
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
            WE2W2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2W2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00B0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Historial de Asociaciones de Bienes de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00b0.aspx") + "?" + UrlEncode("" +AV13pTTBUS3_IdBien) + "," + UrlEncode("" +AV14pTTBUS3_NroAsoc) ;
      }

      protected void WB2W0( )
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
            wb_table1_2_2W2( true) ;
         }
         else
         {
            wb_table1_2_2W2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2W2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2W2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List Historial de Asociaciones de Bienes de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2W0( ) ;
      }

      protected void WS2W2( )
      {
         START2W2( ) ;
         EVT2W2( ) ;
      }

      protected void EVT2W2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_IDBIEN"), ",", ".") != Convert.ToDecimal( AV6cTTBUS3_IdBien )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_NROASOC"), ",", ".") != Convert.ToDecimal( AV7cTTBUS3_NroAsoc )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_SIST"), ",", ".") != Convert.ToDecimal( AV8cTTBUS3_Sist )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_HDWID"), ",", ".") != Convert.ToDecimal( AV9cTTBUS3_HdwId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS3_BUSEMP"), AV10cTTBUS3_BusEmp) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_BUSRUB"), ",", ".") != Convert.ToDecimal( AV11cTTBUS3_BusRub )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_BUSCOD"), ",", ".") != Convert.ToDecimal( AV12cTTBUS3_BusCod )) )
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
                              edtTTBUS3_IdBien_Internalname = "TTBUS3_IDBIEN_"+sGXsfl_51_idx ;
                              edtTTBUS3_NroAsoc_Internalname = "TTBUS3_NROASOC_"+sGXsfl_51_idx ;
                              edtTTBUS3_Sist_Internalname = "TTBUS3_SIST_"+sGXsfl_51_idx ;
                              edtTTBUS3_HdwId_Internalname = "TTBUS3_HDWID_"+sGXsfl_51_idx ;
                              edtTTBUS3_BusEmp_Internalname = "TTBUS3_BUSEMP_"+sGXsfl_51_idx ;
                              edtTTBUS3_BusRub_Internalname = "TTBUS3_BUSRUB_"+sGXsfl_51_idx ;
                              edtTTBUS3_BusPar_Internalname = "TTBUS3_BUSPAR_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A105TTBUS3_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS3_IdBien_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
                              A106TTBUS3_NroAsoc = (int)(context.localUtil.CToN( cgiGet( edtTTBUS3_NroAsoc_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
                              A107TTBUS3_Sist = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_Sist_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107TTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(A107TTBUS3_Sist), 2, 0)));
                              A108TTBUS3_HdwId = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_HdwId_Internalname), ",", ".")) ;
                              n108TTBUS3_HdwId = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(A108TTBUS3_HdwId), 4, 0)));
                              A109TTBUS3_BusEmp = cgiGet( edtTTBUS3_BusEmp_Internalname) ;
                              n109TTBUS3_BusEmp = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109TTBUS3_BusEmp", A109TTBUS3_BusEmp);
                              A110TTBUS3_BusRub = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_BusRub_Internalname), ",", ".")) ;
                              n110TTBUS3_BusRub = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(A110TTBUS3_BusRub), 4, 0)));
                              A112TTBUS3_BusPar = (short)(context.localUtil.CToN( cgiGet( edtTTBUS3_BusPar_Internalname), ",", ".")) ;
                              n112TTBUS3_BusPar = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.Str( (decimal)(A112TTBUS3_BusPar), 2, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112W2 */
                                    E112W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122W2 */
                                    E122W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cttbus3_idbien Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_IDBIEN"), ",", ".") != Convert.ToDecimal( AV6cTTBUS3_IdBien )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus3_nroasoc Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_NROASOC"), ",", ".") != Convert.ToDecimal( AV7cTTBUS3_NroAsoc )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus3_sist Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_SIST"), ",", ".") != Convert.ToDecimal( AV8cTTBUS3_Sist )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus3_hdwid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_HDWID"), ",", ".") != Convert.ToDecimal( AV9cTTBUS3_HdwId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus3_busemp Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS3_BUSEMP"), AV10cTTBUS3_BusEmp) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus3_busrub Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_BUSRUB"), ",", ".") != Convert.ToDecimal( AV11cTTBUS3_BusRub )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus3_buscod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS3_BUSCOD"), ",", ".") != Convert.ToDecimal( AV12cTTBUS3_BusCod )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132W2 */
                                          E132W2 ();
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

      protected void WE2W2( )
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

      protected void PA2W2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCttbus3_idbien_Internalname ;
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
         edtTTBUS3_IdBien_Internalname = "TTBUS3_IDBIEN_"+sGXsfl_51_idx ;
         edtTTBUS3_NroAsoc_Internalname = "TTBUS3_NROASOC_"+sGXsfl_51_idx ;
         edtTTBUS3_Sist_Internalname = "TTBUS3_SIST_"+sGXsfl_51_idx ;
         edtTTBUS3_HdwId_Internalname = "TTBUS3_HDWID_"+sGXsfl_51_idx ;
         edtTTBUS3_BusEmp_Internalname = "TTBUS3_BUSEMP_"+sGXsfl_51_idx ;
         edtTTBUS3_BusRub_Internalname = "TTBUS3_BUSRUB_"+sGXsfl_51_idx ;
         edtTTBUS3_BusPar_Internalname = "TTBUS3_BUSPAR_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS3_IdBien_Internalname = "TTBUS3_IDBIEN_"+sGXsfl_51_idx ;
            edtTTBUS3_NroAsoc_Internalname = "TTBUS3_NROASOC_"+sGXsfl_51_idx ;
            edtTTBUS3_Sist_Internalname = "TTBUS3_SIST_"+sGXsfl_51_idx ;
            edtTTBUS3_HdwId_Internalname = "TTBUS3_HDWID_"+sGXsfl_51_idx ;
            edtTTBUS3_BusEmp_Internalname = "TTBUS3_BUSEMP_"+sGXsfl_51_idx ;
            edtTTBUS3_BusRub_Internalname = "TTBUS3_BUSRUB_"+sGXsfl_51_idx ;
            edtTTBUS3_BusPar_Internalname = "TTBUS3_BUSPAR_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        int AV6cTTBUS3_IdBien ,
                                        int AV7cTTBUS3_NroAsoc ,
                                        short AV8cTTBUS3_Sist ,
                                        short AV9cTTBUS3_HdwId ,
                                        String AV10cTTBUS3_BusEmp ,
                                        short AV11cTTBUS3_BusRub ,
                                        short AV12cTTBUS3_BusCod )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF2W2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2W2( ) ;
         /* End function Refresh */
      }

      protected void RF2W2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTTBUS3_IdBien_Internalname = "TTBUS3_IDBIEN_"+sGXsfl_51_idx ;
         edtTTBUS3_NroAsoc_Internalname = "TTBUS3_NROASOC_"+sGXsfl_51_idx ;
         edtTTBUS3_Sist_Internalname = "TTBUS3_SIST_"+sGXsfl_51_idx ;
         edtTTBUS3_HdwId_Internalname = "TTBUS3_HDWID_"+sGXsfl_51_idx ;
         edtTTBUS3_BusEmp_Internalname = "TTBUS3_BUSEMP_"+sGXsfl_51_idx ;
         edtTTBUS3_BusRub_Internalname = "TTBUS3_BUSRUB_"+sGXsfl_51_idx ;
         edtTTBUS3_BusPar_Internalname = "TTBUS3_BUSPAR_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS3_IdBien_Internalname = "TTBUS3_IDBIEN_"+sGXsfl_51_idx ;
            edtTTBUS3_NroAsoc_Internalname = "TTBUS3_NROASOC_"+sGXsfl_51_idx ;
            edtTTBUS3_Sist_Internalname = "TTBUS3_SIST_"+sGXsfl_51_idx ;
            edtTTBUS3_HdwId_Internalname = "TTBUS3_HDWID_"+sGXsfl_51_idx ;
            edtTTBUS3_BusEmp_Internalname = "TTBUS3_BUSEMP_"+sGXsfl_51_idx ;
            edtTTBUS3_BusRub_Internalname = "TTBUS3_BUSRUB_"+sGXsfl_51_idx ;
            edtTTBUS3_BusPar_Internalname = "TTBUS3_BUSPAR_"+sGXsfl_51_idx ;
            lV10cTTBUS3_BusEmp = StringUtil.PadR( StringUtil.RTrim( AV10cTTBUS3_BusEmp), 1, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS3_BusEmp", AV10cTTBUS3_BusEmp);
            /* Using cursor H002W2 */
            pr_default.execute(0, new Object[] {AV6cTTBUS3_IdBien, AV7cTTBUS3_NroAsoc, AV8cTTBUS3_Sist, AV9cTTBUS3_HdwId, lV10cTTBUS3_BusEmp, AV11cTTBUS3_BusRub, AV12cTTBUS3_BusCod});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A111TTBUS3_BusCod = H002W2_A111TTBUS3_BusCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111TTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A111TTBUS3_BusCod), 4, 0)));
               n111TTBUS3_BusCod = H002W2_n111TTBUS3_BusCod[0] ;
               A112TTBUS3_BusPar = H002W2_A112TTBUS3_BusPar[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112TTBUS3_BusPar", StringUtil.LTrim( StringUtil.Str( (decimal)(A112TTBUS3_BusPar), 2, 0)));
               n112TTBUS3_BusPar = H002W2_n112TTBUS3_BusPar[0] ;
               A110TTBUS3_BusRub = H002W2_A110TTBUS3_BusRub[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110TTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(A110TTBUS3_BusRub), 4, 0)));
               n110TTBUS3_BusRub = H002W2_n110TTBUS3_BusRub[0] ;
               A109TTBUS3_BusEmp = H002W2_A109TTBUS3_BusEmp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109TTBUS3_BusEmp", A109TTBUS3_BusEmp);
               n109TTBUS3_BusEmp = H002W2_n109TTBUS3_BusEmp[0] ;
               A108TTBUS3_HdwId = H002W2_A108TTBUS3_HdwId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108TTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(A108TTBUS3_HdwId), 4, 0)));
               n108TTBUS3_HdwId = H002W2_n108TTBUS3_HdwId[0] ;
               A107TTBUS3_Sist = H002W2_A107TTBUS3_Sist[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107TTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(A107TTBUS3_Sist), 2, 0)));
               A106TTBUS3_NroAsoc = H002W2_A106TTBUS3_NroAsoc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106TTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(A106TTBUS3_NroAsoc), 8, 0)));
               A105TTBUS3_IdBien = H002W2_A105TTBUS3_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105TTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A105TTBUS3_IdBien), 8, 0)));
               /* Execute user event: E122W2 */
               E122W2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB2W0( ) ;
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
         lV10cTTBUS3_BusEmp = StringUtil.PadR( StringUtil.RTrim( AV10cTTBUS3_BusEmp), 1, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS3_BusEmp", AV10cTTBUS3_BusEmp);
         /* Using cursor H002W3 */
         pr_default.execute(1, new Object[] {AV6cTTBUS3_IdBien, AV7cTTBUS3_NroAsoc, AV8cTTBUS3_Sist, AV9cTTBUS3_HdwId, lV10cTTBUS3_BusEmp, AV11cTTBUS3_BusRub, AV12cTTBUS3_BusCod});
         GRID1_nRecordCount = H002W3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2W0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112W2 */
         E112W2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus3_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus3_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus3_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS3_IDBIEN");
               GX_FocusControl = edtavCttbus3_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cTTBUS3_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS3_IdBien), 8, 0)));
            }
            else
            {
               AV6cTTBUS3_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavCttbus3_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS3_IdBien), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus3_nroasoc_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus3_nroasoc_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus3_nroasoc_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS3_NROASOC");
               GX_FocusControl = edtavCttbus3_nroasoc_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cTTBUS3_NroAsoc = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTTBUS3_NroAsoc), 8, 0)));
            }
            else
            {
               AV7cTTBUS3_NroAsoc = (int)(context.localUtil.CToN( cgiGet( edtavCttbus3_nroasoc_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTTBUS3_NroAsoc), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus3_sist_Internalname), "Z9") || ( context.localUtil.CToN( cgiGet( edtavCttbus3_sist_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus3_sist_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS3_SIST");
               GX_FocusControl = edtavCttbus3_sist_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cTTBUS3_Sist = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTTBUS3_Sist), 2, 0)));
            }
            else
            {
               AV8cTTBUS3_Sist = (short)(context.localUtil.CToN( cgiGet( edtavCttbus3_sist_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS3_Sist", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTTBUS3_Sist), 2, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus3_hdwid_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus3_hdwid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus3_hdwid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS3_HDWID");
               GX_FocusControl = edtavCttbus3_hdwid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cTTBUS3_HdwId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cTTBUS3_HdwId), 4, 0)));
            }
            else
            {
               AV9cTTBUS3_HdwId = (short)(context.localUtil.CToN( cgiGet( edtavCttbus3_hdwid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS3_HdwId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cTTBUS3_HdwId), 4, 0)));
            }
            AV10cTTBUS3_BusEmp = cgiGet( edtavCttbus3_busemp_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS3_BusEmp", AV10cTTBUS3_BusEmp);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus3_busrub_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus3_busrub_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus3_busrub_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS3_BUSRUB");
               GX_FocusControl = edtavCttbus3_busrub_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV11cTTBUS3_BusRub = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTTBUS3_BusRub), 4, 0)));
            }
            else
            {
               AV11cTTBUS3_BusRub = (short)(context.localUtil.CToN( cgiGet( edtavCttbus3_busrub_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS3_BusRub", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTTBUS3_BusRub), 4, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus3_buscod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus3_buscod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus3_buscod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS3_BUSCOD");
               GX_FocusControl = edtavCttbus3_buscod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cTTBUS3_BusCod = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cTTBUS3_BusCod), 4, 0)));
            }
            else
            {
               AV12cTTBUS3_BusCod = (short)(context.localUtil.CToN( cgiGet( edtavCttbus3_buscod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS3_BusCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cTTBUS3_BusCod), 4, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13pTTBUS3_IdBien = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS3_IDBIEN"), ",", ".")) ;
            AV14pTTBUS3_NroAsoc = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS3_NROASOC"), ",", ".")) ;
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
         /* Execute user event: E112W2 */
         E112W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112W2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Historial de Asociaciones de Bienes de Uso", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122W2( )
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
         /* Execute user event: E132W2 */
         E132W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132W2( )
      {
         /* Enter Routine */
         AV13pTTBUS3_IdBien = A105TTBUS3_IdBien ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTTBUS3_IdBien), 8, 0)));
         AV14pTTBUS3_NroAsoc = A106TTBUS3_NroAsoc ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS3_NroAsoc), 8, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pTTBUS3_IdBien,(int)AV14pTTBUS3_NroAsoc});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2W2( bool wbgen )
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
            wb_table2_9_2W2( true) ;
         }
         else
         {
            wb_table2_9_2W2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2W2e( bool wbgen )
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
            wb_table3_48_2W2( true) ;
         }
         else
         {
            wb_table3_48_2W2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2W2e( true) ;
         }
         else
         {
            wb_table1_2_2W2e( false) ;
         }
      }

      protected void wb_table3_48_2W2( bool wbgen )
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
               context.SendWebValue( "de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de asociación") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "la asociación") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de hardware") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "empresa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de rubro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de partida") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A105TTBUS3_IdBien), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A106TTBUS3_NroAsoc), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A107TTBUS3_Sist), 2, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTTBUS3_Sist_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A108TTBUS3_HdwId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A109TTBUS3_BusEmp));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A110TTBUS3_BusRub), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A112TTBUS3_BusPar), 2, 0, ".", "")));
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
            wb_table4_62_2W2( true) ;
         }
         else
         {
            wb_table4_62_2W2( false) ;
         }
         return  ;
      }

      protected void wb_table4_62_2W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2W2e( true) ;
         }
         else
         {
            wb_table3_48_2W2e( false) ;
         }
      }

      protected void wb_table4_62_2W2( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_62_2W2e( true) ;
         }
         else
         {
            wb_table4_62_2W2e( false) ;
         }
      }

      protected void wb_table2_9_2W2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_idbien_Internalname, 1, 1, 0, "Id del bien de uso", "", "", "", 0, lblTextblockttbus3_idbien_Jsonclick, "", StyleString, ClassString, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus3_idbien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS3_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cTTBUS3_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCttbus3_idbien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_nroasoc_Internalname, 1, 1, 0, "Nro. de asociación", "", "", "", 0, lblTextblockttbus3_nroasoc_Jsonclick, "", StyleString, ClassString, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus3_nroasoc_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cTTBUS3_NroAsoc), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cTTBUS3_NroAsoc), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCttbus3_nroasoc_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_sist_Internalname, 1, 1, 0, "Sistema que realiza la asociación", "", "", "", 0, lblTextblockttbus3_sist_Jsonclick, "", StyleString, ClassString, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus3_sist_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTTBUS3_Sist), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV8cTTBUS3_Sist), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", 0, edtavCttbus3_sist_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_hdwid_Internalname, 1, 1, 0, "Id de hardware", "", "", "", 0, lblTextblockttbus3_hdwid_Jsonclick, "", StyleString, ClassString, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus3_hdwid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cTTBUS3_HdwId), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9cTTBUS3_HdwId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", 0, edtavCttbus3_hdwid_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_busemp_Internalname, 1, 1, 0, "Cód. empresa", "", "", "", 0, lblTextblockttbus3_busemp_Jsonclick, "", StyleString, ClassString, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus3_busemp_Internalname, StringUtil.RTrim( AV10cTTBUS3_BusEmp), "", 1, "chr", 1, "row", 1, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10cTTBUS3_BusEmp, "X")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavCttbus3_busemp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_busrub_Internalname, 1, 1, 0, "Cód. de rubro", "", "", "", 0, lblTextblockttbus3_busrub_Jsonclick, "", StyleString, ClassString, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus3_busrub_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTTBUS3_BusRub), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV11cTTBUS3_BusRub), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(39);\"", 0, edtavCttbus3_busrub_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus3_buscod_Internalname, 1, 1, 0, "Cód. de bien en contabilidad", "", "", "", 0, lblTextblockttbus3_buscod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus3_buscod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cTTBUS3_BusCod), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV12cTTBUS3_BusCod), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", 0, edtavCttbus3_buscod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2W2e( true) ;
         }
         else
         {
            wb_table2_9_2W2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pTTBUS3_IdBien = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS3_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTTBUS3_IdBien), 8, 0)));
         AV14pTTBUS3_NroAsoc = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS3_NroAsoc", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS3_NroAsoc), 8, 0)));
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
         PA2W2( ) ;
         WS2W2( ) ;
         WE2W2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?17203189");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00b0.js", "?17203189");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB2W0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A105TTBUS3_IdBien), 8, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A106TTBUS3_NroAsoc), 8, 0, ",", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS3_IdBien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A105TTBUS3_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A105TTBUS3_IdBien), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS3_IdBien_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS3_NroAsoc_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A106TTBUS3_NroAsoc), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A106TTBUS3_NroAsoc), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS3_NroAsoc_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTTBUS3_Sist_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A105TTBUS3_IdBien), 8, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A106TTBUS3_NroAsoc), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS3_Sist_Internalname, "Link", edtTTBUS3_Sist_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS3_Sist_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A107TTBUS3_Sist), 2, 0, ",", "")),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtTTBUS3_Sist_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A107TTBUS3_Sist), "Z9"),(String)"",(short)0,(String)edtTTBUS3_Sist_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS3_HdwId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A108TTBUS3_HdwId), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A108TTBUS3_HdwId), "ZZZ9"),(String)"",(short)0,(String)edtTTBUS3_HdwId_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS3_BusEmp_Internalname,StringUtil.RTrim( A109TTBUS3_BusEmp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A109TTBUS3_BusEmp, "X")),(String)"",(short)0,(String)edtTTBUS3_BusEmp_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS3_BusRub_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A110TTBUS3_BusRub), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A110TTBUS3_BusRub), "ZZZ9"),(String)"",(short)0,(String)edtTTBUS3_BusRub_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS3_BusPar_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A112TTBUS3_BusPar), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A112TTBUS3_BusPar), "Z9"),(String)"",(short)0,(String)edtTTBUS3_BusPar_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS3_IdBien_Internalname = "TTBUS3_IDBIEN_"+sGXsfl_51_idx ;
            edtTTBUS3_NroAsoc_Internalname = "TTBUS3_NROASOC_"+sGXsfl_51_idx ;
            edtTTBUS3_Sist_Internalname = "TTBUS3_SIST_"+sGXsfl_51_idx ;
            edtTTBUS3_HdwId_Internalname = "TTBUS3_HDWID_"+sGXsfl_51_idx ;
            edtTTBUS3_BusEmp_Internalname = "TTBUS3_BUSEMP_"+sGXsfl_51_idx ;
            edtTTBUS3_BusRub_Internalname = "TTBUS3_BUSRUB_"+sGXsfl_51_idx ;
            edtTTBUS3_BusPar_Internalname = "TTBUS3_BUSPAR_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockttbus3_idbien_Internalname = "TEXTBLOCKTTBUS3_IDBIEN" ;
         edtavCttbus3_idbien_Internalname = "vCTTBUS3_IDBIEN" ;
         lblTextblockttbus3_nroasoc_Internalname = "TEXTBLOCKTTBUS3_NROASOC" ;
         edtavCttbus3_nroasoc_Internalname = "vCTTBUS3_NROASOC" ;
         lblTextblockttbus3_sist_Internalname = "TEXTBLOCKTTBUS3_SIST" ;
         edtavCttbus3_sist_Internalname = "vCTTBUS3_SIST" ;
         lblTextblockttbus3_hdwid_Internalname = "TEXTBLOCKTTBUS3_HDWID" ;
         edtavCttbus3_hdwid_Internalname = "vCTTBUS3_HDWID" ;
         lblTextblockttbus3_busemp_Internalname = "TEXTBLOCKTTBUS3_BUSEMP" ;
         edtavCttbus3_busemp_Internalname = "vCTTBUS3_BUSEMP" ;
         lblTextblockttbus3_busrub_Internalname = "TEXTBLOCKTTBUS3_BUSRUB" ;
         edtavCttbus3_busrub_Internalname = "vCTTBUS3_BUSRUB" ;
         lblTextblockttbus3_buscod_Internalname = "TEXTBLOCKTTBUS3_BUSCOD" ;
         edtavCttbus3_buscod_Internalname = "vCTTBUS3_BUSCOD" ;
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
         edtTTBUS3_BusPar_Jsonclick = "" ;
         edtTTBUS3_BusRub_Jsonclick = "" ;
         edtTTBUS3_BusEmp_Jsonclick = "" ;
         edtTTBUS3_HdwId_Jsonclick = "" ;
         edtTTBUS3_Sist_Jsonclick = "" ;
         edtTTBUS3_NroAsoc_Jsonclick = "" ;
         edtTTBUS3_IdBien_Jsonclick = "" ;
         edtavCttbus3_buscod_Jsonclick = "" ;
         edtavCttbus3_busrub_Jsonclick = "" ;
         edtavCttbus3_busemp_Jsonclick = "" ;
         edtavCttbus3_hdwid_Jsonclick = "" ;
         edtavCttbus3_sist_Jsonclick = "" ;
         edtavCttbus3_nroasoc_Jsonclick = "" ;
         edtavCttbus3_idbien_Jsonclick = "" ;
         edtTTBUS3_Sist_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Historial de Asociaciones de Bienes de Uso" ;
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
         AV10cTTBUS3_BusEmp = "" ;
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
         edtTTBUS3_IdBien_Internalname = "" ;
         edtTTBUS3_NroAsoc_Internalname = "" ;
         edtTTBUS3_Sist_Internalname = "" ;
         edtTTBUS3_HdwId_Internalname = "" ;
         edtTTBUS3_BusEmp_Internalname = "" ;
         edtTTBUS3_BusRub_Internalname = "" ;
         edtTTBUS3_BusPar_Internalname = "" ;
         AV5LinkSelection = "" ;
         A109TTBUS3_BusEmp = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV10cTTBUS3_BusEmp = "" ;
         H002W2_A111TTBUS3_BusCod = new short[1] ;
         H002W2_n111TTBUS3_BusCod = new bool[] {false} ;
         H002W2_A112TTBUS3_BusPar = new short[1] ;
         H002W2_n112TTBUS3_BusPar = new bool[] {false} ;
         H002W2_A110TTBUS3_BusRub = new short[1] ;
         H002W2_n110TTBUS3_BusRub = new bool[] {false} ;
         H002W2_A109TTBUS3_BusEmp = new String[] {""} ;
         H002W2_n109TTBUS3_BusEmp = new bool[] {false} ;
         H002W2_A108TTBUS3_HdwId = new short[1] ;
         H002W2_n108TTBUS3_HdwId = new bool[] {false} ;
         H002W2_A107TTBUS3_Sist = new short[1] ;
         H002W2_A106TTBUS3_NroAsoc = new int[1] ;
         H002W2_A105TTBUS3_IdBien = new int[1] ;
         H002W3_AGRID1_nRecordCount = new int[1] ;
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
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockttbus3_idbien_Jsonclick = "" ;
         lblTextblockttbus3_nroasoc_Jsonclick = "" ;
         lblTextblockttbus3_sist_Jsonclick = "" ;
         lblTextblockttbus3_hdwid_Jsonclick = "" ;
         lblTextblockttbus3_busemp_Jsonclick = "" ;
         lblTextblockttbus3_busrub_Jsonclick = "" ;
         lblTextblockttbus3_buscod_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00b0__default(),
            new Object[][] {
                new Object[] {
               H002W2_A111TTBUS3_BusCod, H002W2_n111TTBUS3_BusCod, H002W2_A112TTBUS3_BusPar, H002W2_n112TTBUS3_BusPar, H002W2_A110TTBUS3_BusRub, H002W2_n110TTBUS3_BusRub, H002W2_A109TTBUS3_BusEmp, H002W2_n109TTBUS3_BusEmp, H002W2_A108TTBUS3_HdwId, H002W2_n108TTBUS3_HdwId,
               H002W2_A107TTBUS3_Sist, H002W2_A106TTBUS3_NroAsoc, H002W2_A105TTBUS3_IdBien
               }
               , new Object[] {
               H002W3_AGRID1_nRecordCount
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
      private short AV8cTTBUS3_Sist ;
      private short AV9cTTBUS3_HdwId ;
      private short AV11cTTBUS3_BusRub ;
      private short AV12cTTBUS3_BusCod ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A107TTBUS3_Sist ;
      private short A108TTBUS3_HdwId ;
      private short A110TTBUS3_BusRub ;
      private short A112TTBUS3_BusPar ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A111TTBUS3_BusCod ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV6cTTBUS3_IdBien ;
      private int AV7cTTBUS3_NroAsoc ;
      private int AV13pTTBUS3_IdBien ;
      private int AV14pTTBUS3_NroAsoc ;
      private int GRID1_nFirstRecordOnPage ;
      private int A105TTBUS3_IdBien ;
      private int A106TTBUS3_NroAsoc ;
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
      private String AV10cTTBUS3_BusEmp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtTTBUS3_IdBien_Internalname ;
      private String edtTTBUS3_NroAsoc_Internalname ;
      private String edtTTBUS3_Sist_Internalname ;
      private String edtTTBUS3_HdwId_Internalname ;
      private String edtTTBUS3_BusEmp_Internalname ;
      private String edtTTBUS3_BusRub_Internalname ;
      private String edtTTBUS3_BusPar_Internalname ;
      private String A109TTBUS3_BusEmp ;
      private String edtavCttbus3_idbien_Internalname ;
      private String scmdbuf ;
      private String lV10cTTBUS3_BusEmp ;
      private String edtavCttbus3_nroasoc_Internalname ;
      private String edtavCttbus3_sist_Internalname ;
      private String edtavCttbus3_hdwid_Internalname ;
      private String edtavCttbus3_busemp_Internalname ;
      private String edtavCttbus3_busrub_Internalname ;
      private String edtavCttbus3_buscod_Internalname ;
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
      private String edtTTBUS3_Sist_Link ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus3_idbien_Internalname ;
      private String lblTextblockttbus3_idbien_Jsonclick ;
      private String edtavCttbus3_idbien_Jsonclick ;
      private String lblTextblockttbus3_nroasoc_Internalname ;
      private String lblTextblockttbus3_nroasoc_Jsonclick ;
      private String edtavCttbus3_nroasoc_Jsonclick ;
      private String lblTextblockttbus3_sist_Internalname ;
      private String lblTextblockttbus3_sist_Jsonclick ;
      private String edtavCttbus3_sist_Jsonclick ;
      private String lblTextblockttbus3_hdwid_Internalname ;
      private String lblTextblockttbus3_hdwid_Jsonclick ;
      private String edtavCttbus3_hdwid_Jsonclick ;
      private String lblTextblockttbus3_busemp_Internalname ;
      private String lblTextblockttbus3_busemp_Jsonclick ;
      private String edtavCttbus3_busemp_Jsonclick ;
      private String lblTextblockttbus3_busrub_Internalname ;
      private String lblTextblockttbus3_busrub_Jsonclick ;
      private String edtavCttbus3_busrub_Jsonclick ;
      private String lblTextblockttbus3_buscod_Internalname ;
      private String lblTextblockttbus3_buscod_Jsonclick ;
      private String edtavCttbus3_buscod_Jsonclick ;
      private String ROClassString ;
      private String edtTTBUS3_IdBien_Jsonclick ;
      private String edtTTBUS3_NroAsoc_Jsonclick ;
      private String edtTTBUS3_Sist_Jsonclick ;
      private String edtTTBUS3_HdwId_Jsonclick ;
      private String edtTTBUS3_BusEmp_Jsonclick ;
      private String edtTTBUS3_BusRub_Jsonclick ;
      private String edtTTBUS3_BusPar_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n108TTBUS3_HdwId ;
      private bool n109TTBUS3_BusEmp ;
      private bool n110TTBUS3_BusRub ;
      private bool n112TTBUS3_BusPar ;
      private bool n111TTBUS3_BusCod ;
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
      private short[] H002W2_A111TTBUS3_BusCod ;
      private bool[] H002W2_n111TTBUS3_BusCod ;
      private short[] H002W2_A112TTBUS3_BusPar ;
      private bool[] H002W2_n112TTBUS3_BusPar ;
      private short[] H002W2_A110TTBUS3_BusRub ;
      private bool[] H002W2_n110TTBUS3_BusRub ;
      private String[] H002W2_A109TTBUS3_BusEmp ;
      private bool[] H002W2_n109TTBUS3_BusEmp ;
      private short[] H002W2_A108TTBUS3_HdwId ;
      private bool[] H002W2_n108TTBUS3_HdwId ;
      private short[] H002W2_A107TTBUS3_Sist ;
      private int[] H002W2_A106TTBUS3_NroAsoc ;
      private int[] H002W2_A105TTBUS3_IdBien ;
      private int[] H002W3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pTTBUS3_IdBien ;
      private int aP1_pTTBUS3_NroAsoc ;
      private GXWebForm Form ;
   }

   public class gx00b0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002W2 ;
          prmH002W2 = new Object[] {
          new Object[] {"@AV6cTTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV7cTTBUS3_NroAsoc",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cTTBUS3_Sist",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV9cTTBUS3_HdwId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cTTBUS3_BusEmp",SqlDbType.Char,1,0} ,
          new Object[] {"@AV11cTTBUS3_BusRub",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cTTBUS3_BusCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH002W3 ;
          prmH002W3 = new Object[] {
          new Object[] {"@AV6cTTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV7cTTBUS3_NroAsoc",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cTTBUS3_Sist",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV9cTTBUS3_HdwId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cTTBUS3_BusEmp",SqlDbType.Char,1,0} ,
          new Object[] {"@AV11cTTBUS3_BusRub",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cTTBUS3_BusCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002W2", "SELECT [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_BusRub], [TTBUS3_BusEmp], [TTBUS3_HdwId], [TTBUS3_Sist], [TTBUS3_NroAsoc], [TTBUS3_IdBien] FROM [TTBUS003] WITH (NOLOCK) WHERE ([TTBUS3_IdBien] >= @AV6cTTBUS3_IdBien and [TTBUS3_NroAsoc] >= @AV7cTTBUS3_NroAsoc) AND ([TTBUS3_Sist] >= @AV8cTTBUS3_Sist) AND ([TTBUS3_HdwId] >= @AV9cTTBUS3_HdwId) AND ([TTBUS3_BusEmp] like @AV10cTTBUS3_BusEmp) AND ([TTBUS3_BusRub] >= @AV11cTTBUS3_BusRub) AND ([TTBUS3_BusCod] >= @AV12cTTBUS3_BusCod) ORDER BY [TTBUS3_IdBien], [TTBUS3_NroAsoc]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002W2,11,0,false,false )
             ,new CursorDef("H002W3", "SELECT COUNT(*) FROM [TTBUS003] WITH (NOLOCK) WHERE ([TTBUS3_IdBien] >= @AV6cTTBUS3_IdBien and [TTBUS3_NroAsoc] >= @AV7cTTBUS3_NroAsoc) AND ([TTBUS3_Sist] >= @AV8cTTBUS3_Sist) AND ([TTBUS3_HdwId] >= @AV9cTTBUS3_HdwId) AND ([TTBUS3_BusEmp] like @AV10cTTBUS3_BusEmp) AND ([TTBUS3_BusRub] >= @AV11cTTBUS3_BusRub) AND ([TTBUS3_BusCod] >= @AV12cTTBUS3_BusCod) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002W3,1,0,false,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
