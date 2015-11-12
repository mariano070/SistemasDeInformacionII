/*
               File: Gx0050
        Description: Selection List  T1452
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:41.4
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
   public class gx0050 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0050( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx0050( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pTTBUS2_IdMovimiento )
      {
         this.AV13pTTBUS2_IdMovimiento = 0 ;
         executePrivate();
         aP0_pTTBUS2_IdMovimiento=this.AV13pTTBUS2_IdMovimiento;
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
               AV6cTTBUS2_IdMovimiento = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS2_IdMovimiento), 12, 0)));
               AV7cTTBUS2_MotivoCancelacion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS2_MotivoCancelacion", AV7cTTBUS2_MotivoCancelacion);
               AV8cTTBUS2_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTTBUS2_IdBien), 8, 0)));
               AV9cTTBUS2_CodPosDesde = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cTTBUS2_CodPosDesde), 3, 0)));
               AV10cTTBUS2_RespDesde = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS2_RespDesde", AV10cTTBUS2_RespDesde);
               AV11cTTBUS2_FechaEnvio = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS2_FechaEnvio", context.localUtil.TToC( AV11cTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
               AV12cTTBUS2_CodPosHacia = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cTTBUS2_CodPosHacia), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cTTBUS2_IdMovimiento, AV7cTTBUS2_MotivoCancelacion, AV8cTTBUS2_IdBien, AV9cTTBUS2_CodPosDesde, AV10cTTBUS2_RespDesde, AV11cTTBUS2_FechaEnvio, AV12cTTBUS2_CodPosHacia) ;
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
               AV13pTTBUS2_IdMovimiento = (long)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTTBUS2_IdMovimiento), 12, 0)));
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
         PA2U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2U2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0050.aspx") + "?" + UrlEncode("" +AV13pTTBUS2_IdMovimiento)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS2_IDMOVIMIENTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS2_IdMovimiento), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS2_MOTIVOCANCELACION", StringUtil.RTrim( AV7cTTBUS2_MotivoCancelacion));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS2_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTTBUS2_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS2_CODPOSDESDE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cTTBUS2_CodPosDesde), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS2_RESPDESDE", StringUtil.RTrim( AV10cTTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS2_FECHAENVIO", context.localUtil.Format(AV11cTTBUS2_FechaEnvio, "99/99/9999 99:99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS2_CODPOSHACIA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cTTBUS2_CodPosHacia), 3, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS2_IDMOVIMIENTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pTTBUS2_IdMovimiento), 12, 0, ",", "")));
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
            WE2U2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2U2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0050" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List  T1452" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0050.aspx") + "?" + UrlEncode("" +AV13pTTBUS2_IdMovimiento) ;
      }

      protected void WB2U0( )
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
            wb_table1_2_2U2( true) ;
         }
         else
         {
            wb_table1_2_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2U2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2U2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List  T1452", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2U0( ) ;
      }

      protected void WS2U2( )
      {
         START2U2( ) ;
         EVT2U2( ) ;
      }

      protected void EVT2U2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_IDMOVIMIENTO"), ",", ".") != Convert.ToDecimal( AV6cTTBUS2_IdMovimiento )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS2_MOTIVOCANCELACION"), AV7cTTBUS2_MotivoCancelacion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_IDBIEN"), ",", ".") != Convert.ToDecimal( AV8cTTBUS2_IdBien )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_CODPOSDESDE"), ",", ".") != Convert.ToDecimal( AV9cTTBUS2_CodPosDesde )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS2_RESPDESDE"), AV10cTTBUS2_RespDesde) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToT( cgiGet( "GXH_vCTTBUS2_FECHAENVIO")) != AV11cTTBUS2_FechaEnvio )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_CODPOSHACIA"), ",", ".") != Convert.ToDecimal( AV12cTTBUS2_CodPosHacia )) )
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
                              edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_51_idx ;
                              edtTTBUS2_MotivoCancelacion_Internalname = "TTBUS2_MOTIVOCANCELACION_"+sGXsfl_51_idx ;
                              edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A52TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtTTBUS2_IdMovimiento_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
                              A50TTBUS2_MotivoCancelacion = StringUtil.Upper( cgiGet( edtTTBUS2_MotivoCancelacion_Internalname)) ;
                              n50TTBUS2_MotivoCancelacion = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50TTBUS2_MotivoCancelacion", A50TTBUS2_MotivoCancelacion);
                              A22TTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS2_IdBien_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112U2 */
                                    E112U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122U2 */
                                    E122U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cttbus2_idmovimiento Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_IDMOVIMIENTO"), ",", ".") != Convert.ToDecimal( AV6cTTBUS2_IdMovimiento )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus2_motivocancelacion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS2_MOTIVOCANCELACION"), AV7cTTBUS2_MotivoCancelacion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus2_idbien Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_IDBIEN"), ",", ".") != Convert.ToDecimal( AV8cTTBUS2_IdBien )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus2_codposdesde Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_CODPOSDESDE"), ",", ".") != Convert.ToDecimal( AV9cTTBUS2_CodPosDesde )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus2_respdesde Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS2_RESPDESDE"), AV10cTTBUS2_RespDesde) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus2_fechaenvio Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCTTBUS2_FECHAENVIO")) != AV11cTTBUS2_FechaEnvio )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus2_codposhacia Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS2_CODPOSHACIA"), ",", ".") != Convert.ToDecimal( AV12cTTBUS2_CodPosHacia )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132U2 */
                                          E132U2 ();
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

      protected void WE2U2( )
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

      protected void PA2U2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCttbus2_idmovimiento_Internalname ;
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
         edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_51_idx ;
         edtTTBUS2_MotivoCancelacion_Internalname = "TTBUS2_MOTIVOCANCELACION_"+sGXsfl_51_idx ;
         edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_51_idx ;
            edtTTBUS2_MotivoCancelacion_Internalname = "TTBUS2_MOTIVOCANCELACION_"+sGXsfl_51_idx ;
            edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        long AV6cTTBUS2_IdMovimiento ,
                                        String AV7cTTBUS2_MotivoCancelacion ,
                                        int AV8cTTBUS2_IdBien ,
                                        short AV9cTTBUS2_CodPosDesde ,
                                        String AV10cTTBUS2_RespDesde ,
                                        DateTime AV11cTTBUS2_FechaEnvio ,
                                        short AV12cTTBUS2_CodPosHacia )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF2U2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2U2( ) ;
         /* End function Refresh */
      }

      protected void RF2U2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_51_idx ;
         edtTTBUS2_MotivoCancelacion_Internalname = "TTBUS2_MOTIVOCANCELACION_"+sGXsfl_51_idx ;
         edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_51_idx ;
            edtTTBUS2_MotivoCancelacion_Internalname = "TTBUS2_MOTIVOCANCELACION_"+sGXsfl_51_idx ;
            edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_51_idx ;
            lV7cTTBUS2_MotivoCancelacion = StringUtil.PadR( StringUtil.RTrim( AV7cTTBUS2_MotivoCancelacion), 100, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS2_MotivoCancelacion", AV7cTTBUS2_MotivoCancelacion);
            lV10cTTBUS2_RespDesde = StringUtil.PadR( StringUtil.RTrim( AV10cTTBUS2_RespDesde), 15, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS2_RespDesde", AV10cTTBUS2_RespDesde);
            /* Using cursor H002U2 */
            pr_default.execute(0, new Object[] {AV6cTTBUS2_IdMovimiento, lV7cTTBUS2_MotivoCancelacion, AV8cTTBUS2_IdBien, AV9cTTBUS2_CodPosDesde, lV10cTTBUS2_RespDesde, AV11cTTBUS2_FechaEnvio, AV12cTTBUS2_CodPosHacia});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A48TTBUS2_CodPosDesde = H002U2_A48TTBUS2_CodPosDesde[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
               A24TTBUS2_RespDesde = H002U2_A24TTBUS2_RespDesde[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A45TTBUS2_FechaEnvio = H002U2_A45TTBUS2_FechaEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
               A49TTBUS2_CodPosHacia = H002U2_A49TTBUS2_CodPosHacia[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
               A22TTBUS2_IdBien = H002U2_A22TTBUS2_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               A50TTBUS2_MotivoCancelacion = H002U2_A50TTBUS2_MotivoCancelacion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50TTBUS2_MotivoCancelacion", A50TTBUS2_MotivoCancelacion);
               n50TTBUS2_MotivoCancelacion = H002U2_n50TTBUS2_MotivoCancelacion[0] ;
               A52TTBUS2_IdMovimiento = H002U2_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               /* Execute user event: E122U2 */
               E122U2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB2U0( ) ;
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
         lV7cTTBUS2_MotivoCancelacion = StringUtil.PadR( StringUtil.RTrim( AV7cTTBUS2_MotivoCancelacion), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS2_MotivoCancelacion", AV7cTTBUS2_MotivoCancelacion);
         lV10cTTBUS2_RespDesde = StringUtil.PadR( StringUtil.RTrim( AV10cTTBUS2_RespDesde), 15, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS2_RespDesde", AV10cTTBUS2_RespDesde);
         /* Using cursor H002U3 */
         pr_default.execute(1, new Object[] {AV6cTTBUS2_IdMovimiento, lV7cTTBUS2_MotivoCancelacion, AV8cTTBUS2_IdBien, AV9cTTBUS2_CodPosDesde, lV10cTTBUS2_RespDesde, AV11cTTBUS2_FechaEnvio, AV12cTTBUS2_CodPosHacia});
         GRID1_nRecordCount = H002U3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112U2 */
         E112U2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS2_IDMOVIMIENTO");
               GX_FocusControl = edtavCttbus2_idmovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cTTBUS2_IdMovimiento = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS2_IdMovimiento), 12, 0)));
            }
            else
            {
               AV6cTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavCttbus2_idmovimiento_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS2_IdMovimiento), 12, 0)));
            }
            AV7cTTBUS2_MotivoCancelacion = StringUtil.Upper( cgiGet( edtavCttbus2_motivocancelacion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS2_MotivoCancelacion", AV7cTTBUS2_MotivoCancelacion);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS2_IDBIEN");
               GX_FocusControl = edtavCttbus2_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cTTBUS2_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTTBUS2_IdBien), 8, 0)));
            }
            else
            {
               AV8cTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavCttbus2_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTTBUS2_IdBien), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus2_codposdesde_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus2_codposdesde_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus2_codposdesde_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS2_CODPOSDESDE");
               GX_FocusControl = edtavCttbus2_codposdesde_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cTTBUS2_CodPosDesde = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cTTBUS2_CodPosDesde), 3, 0)));
            }
            else
            {
               AV9cTTBUS2_CodPosDesde = (short)(context.localUtil.CToN( cgiGet( edtavCttbus2_codposdesde_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cTTBUS2_CodPosDesde), 3, 0)));
            }
            AV10cTTBUS2_RespDesde = cgiGet( edtavCttbus2_respdesde_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS2_RespDesde", AV10cTTBUS2_RespDesde);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCttbus2_fechaenvio_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Fecha de envío"}), 1, "vCTTBUS2_FECHAENVIO");
               GX_FocusControl = edtavCttbus2_fechaenvio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV11cTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS2_FechaEnvio", context.localUtil.TToC( AV11cTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV11cTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavCttbus2_fechaenvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS2_FechaEnvio", context.localUtil.TToC( AV11cTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus2_codposhacia_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus2_codposhacia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus2_codposhacia_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS2_CODPOSHACIA");
               GX_FocusControl = edtavCttbus2_codposhacia_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cTTBUS2_CodPosHacia = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cTTBUS2_CodPosHacia), 3, 0)));
            }
            else
            {
               AV12cTTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtavCttbus2_codposhacia_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cTTBUS2_CodPosHacia), 3, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13pTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( "vPTTBUS2_IDMOVIMIENTO"), ",", ".")) ;
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
         /* Execute user event: E112U2 */
         E112U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112U2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", " T1452", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122U2( )
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
         /* Execute user event: E132U2 */
         E132U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132U2( )
      {
         /* Enter Routine */
         AV13pTTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTTBUS2_IdMovimiento), 12, 0)));
         context.setWebReturnParms(new Object[] {(long)AV13pTTBUS2_IdMovimiento});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2U2( bool wbgen )
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
            wb_table2_9_2U2( true) ;
         }
         else
         {
            wb_table2_9_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2U2e( bool wbgen )
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
            wb_table3_48_2U2( true) ;
         }
         else
         {
            wb_table3_48_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2U2e( true) ;
         }
         else
         {
            wb_table1_2_2U2e( false) ;
         }
      }

      protected void wb_table3_48_2U2( bool wbgen )
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
               context.SendWebValue( "Movimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Motivo de Cancelación") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Id Bien") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A50TTBUS2_MotivoCancelacion));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTTBUS2_MotivoCancelacion_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ".", "")));
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
            wb_table4_58_2U2( true) ;
         }
         else
         {
            wb_table4_58_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table4_58_2U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2U2e( true) ;
         }
         else
         {
            wb_table3_48_2U2e( false) ;
         }
      }

      protected void wb_table4_58_2U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_58_2U2e( true) ;
         }
         else
         {
            wb_table4_58_2U2e( false) ;
         }
      }

      protected void wb_table2_9_2U2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_idmovimiento_Internalname, 1, 1, 0, "Id Movimiento", "", "", "", 0, lblTextblockttbus2_idmovimiento_Jsonclick, "", StyleString, ClassString, "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus2_idmovimiento_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS2_IdMovimiento), 12, 0, ",", "")), "", 12, "chr", 1, "row", 12, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cTTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCttbus2_idmovimiento_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_motivocancelacion_Internalname, 1, 1, 0, "Motivo de Cancelación", "", "", "", 0, lblTextblockttbus2_motivocancelacion_Jsonclick, "", StyleString, ClassString, "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus2_motivocancelacion_Internalname, StringUtil.RTrim( AV7cTTBUS2_MotivoCancelacion), "", 80, "chr", 1, "row", 100, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7cTTBUS2_MotivoCancelacion, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"", 0, edtavCttbus2_motivocancelacion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_idbien_Internalname, 1, 1, 0, "Id Bien", "", "", "", 0, lblTextblockttbus2_idbien_Jsonclick, "", StyleString, ClassString, "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus2_idbien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTTBUS2_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV8cTTBUS2_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", 0, edtavCttbus2_idbien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_codposdesde_Internalname, 1, 1, 0, "Código Posición Desde", "", "", "", 0, lblTextblockttbus2_codposdesde_Jsonclick, "", StyleString, ClassString, "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus2_codposdesde_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cTTBUS2_CodPosDesde), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9cTTBUS2_CodPosDesde), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", 0, edtavCttbus2_codposdesde_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_respdesde_Internalname, 1, 1, 0, "Responsable de envío", "", "", "", 0, lblTextblockttbus2_respdesde_Jsonclick, "", StyleString, ClassString, "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus2_respdesde_Internalname, StringUtil.RTrim( AV10cTTBUS2_RespDesde), "", 15, "chr", 1, "row", 15, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10cTTBUS2_RespDesde, "XXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavCttbus2_respdesde_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_fechaenvio_Internalname, 1, 1, 0, "Fecha de envío", "", "", "", 0, lblTextblockttbus2_fechaenvio_Jsonclick, "", StyleString, ClassString, "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCttbus2_fechaenvio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus2_fechaenvio_Internalname, context.localUtil.Format(AV11cTTBUS2_FechaEnvio, "99/99/9999 99:99"), "", 16, "chr", 1, "row", 16, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV11cTTBUS2_FechaEnvio, "99/99/9999 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(39);\"", 0, edtavCttbus2_fechaenvio_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0050.htm");
            GxWebStd.gx_bitmap( context, edtavCttbus2_fechaenvio_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx0050.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus2_codposhacia_Internalname, 1, 1, 0, "Código Posición Hacia", "", "", "", 0, lblTextblockttbus2_codposhacia_Jsonclick, "", StyleString, ClassString, "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus2_codposhacia_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cTTBUS2_CodPosHacia), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV12cTTBUS2_CodPosHacia), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", 0, edtavCttbus2_codposhacia_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0050.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2U2e( true) ;
         }
         else
         {
            wb_table2_9_2U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pTTBUS2_IdMovimiento = Convert.ToInt64(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTTBUS2_IdMovimiento), 12, 0)));
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
         PA2U2( ) ;
         WS2U2( ) ;
         WE2U2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19294147");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx0050.js", "?19294148");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB2U0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_IdMovimiento_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)12,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A52TTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS2_IdMovimiento_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTTBUS2_MotivoCancelacion_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS2_MotivoCancelacion_Internalname, "Link", edtTTBUS2_MotivoCancelacion_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_MotivoCancelacion_Internalname,StringUtil.RTrim( A50TTBUS2_MotivoCancelacion),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)100,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtTTBUS2_MotivoCancelacion_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A50TTBUS2_MotivoCancelacion, "@!")),(String)"",(short)0,(String)edtTTBUS2_MotivoCancelacion_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_IdBien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A22TTBUS2_IdBien), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS2_IdBien_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_51_idx ;
            edtTTBUS2_MotivoCancelacion_Internalname = "TTBUS2_MOTIVOCANCELACION_"+sGXsfl_51_idx ;
            edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockttbus2_idmovimiento_Internalname = "TEXTBLOCKTTBUS2_IDMOVIMIENTO" ;
         edtavCttbus2_idmovimiento_Internalname = "vCTTBUS2_IDMOVIMIENTO" ;
         lblTextblockttbus2_motivocancelacion_Internalname = "TEXTBLOCKTTBUS2_MOTIVOCANCELACION" ;
         edtavCttbus2_motivocancelacion_Internalname = "vCTTBUS2_MOTIVOCANCELACION" ;
         lblTextblockttbus2_idbien_Internalname = "TEXTBLOCKTTBUS2_IDBIEN" ;
         edtavCttbus2_idbien_Internalname = "vCTTBUS2_IDBIEN" ;
         lblTextblockttbus2_codposdesde_Internalname = "TEXTBLOCKTTBUS2_CODPOSDESDE" ;
         edtavCttbus2_codposdesde_Internalname = "vCTTBUS2_CODPOSDESDE" ;
         lblTextblockttbus2_respdesde_Internalname = "TEXTBLOCKTTBUS2_RESPDESDE" ;
         edtavCttbus2_respdesde_Internalname = "vCTTBUS2_RESPDESDE" ;
         lblTextblockttbus2_fechaenvio_Internalname = "TEXTBLOCKTTBUS2_FECHAENVIO" ;
         edtavCttbus2_fechaenvio_Internalname = "vCTTBUS2_FECHAENVIO" ;
         lblTextblockttbus2_codposhacia_Internalname = "TEXTBLOCKTTBUS2_CODPOSHACIA" ;
         edtavCttbus2_codposhacia_Internalname = "vCTTBUS2_CODPOSHACIA" ;
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
         edtTTBUS2_IdBien_Jsonclick = "" ;
         edtTTBUS2_MotivoCancelacion_Jsonclick = "" ;
         edtTTBUS2_IdMovimiento_Jsonclick = "" ;
         edtavCttbus2_codposhacia_Jsonclick = "" ;
         edtavCttbus2_fechaenvio_Jsonclick = "" ;
         edtavCttbus2_respdesde_Jsonclick = "" ;
         edtavCttbus2_codposdesde_Jsonclick = "" ;
         edtavCttbus2_idbien_Jsonclick = "" ;
         edtavCttbus2_motivocancelacion_Jsonclick = "" ;
         edtavCttbus2_idmovimiento_Jsonclick = "" ;
         edtTTBUS2_MotivoCancelacion_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List  T1452" ;
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
         AV7cTTBUS2_MotivoCancelacion = "" ;
         AV10cTTBUS2_RespDesde = "" ;
         AV11cTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
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
         edtTTBUS2_IdMovimiento_Internalname = "" ;
         edtTTBUS2_MotivoCancelacion_Internalname = "" ;
         edtTTBUS2_IdBien_Internalname = "" ;
         AV5LinkSelection = "" ;
         A50TTBUS2_MotivoCancelacion = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7cTTBUS2_MotivoCancelacion = "" ;
         lV10cTTBUS2_RespDesde = "" ;
         H002U2_A48TTBUS2_CodPosDesde = new short[1] ;
         H002U2_A24TTBUS2_RespDesde = new String[] {""} ;
         H002U2_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H002U2_A49TTBUS2_CodPosHacia = new short[1] ;
         H002U2_A22TTBUS2_IdBien = new int[1] ;
         H002U2_A50TTBUS2_MotivoCancelacion = new String[] {""} ;
         H002U2_n50TTBUS2_MotivoCancelacion = new bool[] {false} ;
         H002U2_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         H002U3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockttbus2_idmovimiento_Jsonclick = "" ;
         lblTextblockttbus2_motivocancelacion_Jsonclick = "" ;
         lblTextblockttbus2_idbien_Jsonclick = "" ;
         lblTextblockttbus2_codposdesde_Jsonclick = "" ;
         lblTextblockttbus2_respdesde_Jsonclick = "" ;
         lblTextblockttbus2_fechaenvio_Jsonclick = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         lblTextblockttbus2_codposhacia_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char5 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0050__default(),
            new Object[][] {
                new Object[] {
               H002U2_A48TTBUS2_CodPosDesde, H002U2_A24TTBUS2_RespDesde, H002U2_A45TTBUS2_FechaEnvio, H002U2_A49TTBUS2_CodPosHacia, H002U2_A22TTBUS2_IdBien, H002U2_A50TTBUS2_MotivoCancelacion, H002U2_n50TTBUS2_MotivoCancelacion, H002U2_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               H002U3_AGRID1_nRecordCount
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
      private short AV9cTTBUS2_CodPosDesde ;
      private short AV12cTTBUS2_CodPosHacia ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV8cTTBUS2_IdBien ;
      private int GRID1_nFirstRecordOnPage ;
      private int A22TTBUS2_IdBien ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV6cTTBUS2_IdMovimiento ;
      private long AV13pTTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String AV10cTTBUS2_RespDesde ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtTTBUS2_IdMovimiento_Internalname ;
      private String edtTTBUS2_MotivoCancelacion_Internalname ;
      private String edtTTBUS2_IdBien_Internalname ;
      private String edtavCttbus2_idmovimiento_Internalname ;
      private String scmdbuf ;
      private String lV10cTTBUS2_RespDesde ;
      private String A24TTBUS2_RespDesde ;
      private String edtavCttbus2_motivocancelacion_Internalname ;
      private String edtavCttbus2_idbien_Internalname ;
      private String edtavCttbus2_codposdesde_Internalname ;
      private String edtavCttbus2_respdesde_Internalname ;
      private String edtavCttbus2_fechaenvio_Internalname ;
      private String edtavCttbus2_codposhacia_Internalname ;
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
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String edtavLinkselection_Link ;
      private String edtTTBUS2_MotivoCancelacion_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus2_idmovimiento_Internalname ;
      private String lblTextblockttbus2_idmovimiento_Jsonclick ;
      private String edtavCttbus2_idmovimiento_Jsonclick ;
      private String lblTextblockttbus2_motivocancelacion_Internalname ;
      private String lblTextblockttbus2_motivocancelacion_Jsonclick ;
      private String edtavCttbus2_motivocancelacion_Jsonclick ;
      private String lblTextblockttbus2_idbien_Internalname ;
      private String lblTextblockttbus2_idbien_Jsonclick ;
      private String edtavCttbus2_idbien_Jsonclick ;
      private String lblTextblockttbus2_codposdesde_Internalname ;
      private String lblTextblockttbus2_codposdesde_Jsonclick ;
      private String edtavCttbus2_codposdesde_Jsonclick ;
      private String lblTextblockttbus2_respdesde_Internalname ;
      private String lblTextblockttbus2_respdesde_Jsonclick ;
      private String edtavCttbus2_respdesde_Jsonclick ;
      private String lblTextblockttbus2_fechaenvio_Internalname ;
      private String lblTextblockttbus2_fechaenvio_Jsonclick ;
      private String GXt_char4 ;
      private String edtavCttbus2_fechaenvio_Jsonclick ;
      private String GXt_char3 ;
      private String lblTextblockttbus2_codposhacia_Internalname ;
      private String lblTextblockttbus2_codposhacia_Jsonclick ;
      private String edtavCttbus2_codposhacia_Jsonclick ;
      private String ROClassString ;
      private String edtTTBUS2_IdMovimiento_Jsonclick ;
      private String edtTTBUS2_MotivoCancelacion_Jsonclick ;
      private String edtTTBUS2_IdBien_Jsonclick ;
      private String GXt_char5 ;
      private DateTime AV11cTTBUS2_FechaEnvio ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n50TTBUS2_MotivoCancelacion ;
      private bool returnInSub ;
      private String AV7cTTBUS2_MotivoCancelacion ;
      private String A50TTBUS2_MotivoCancelacion ;
      private String lV7cTTBUS2_MotivoCancelacion ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H002U2_A48TTBUS2_CodPosDesde ;
      private String[] H002U2_A24TTBUS2_RespDesde ;
      private DateTime[] H002U2_A45TTBUS2_FechaEnvio ;
      private short[] H002U2_A49TTBUS2_CodPosHacia ;
      private int[] H002U2_A22TTBUS2_IdBien ;
      private String[] H002U2_A50TTBUS2_MotivoCancelacion ;
      private bool[] H002U2_n50TTBUS2_MotivoCancelacion ;
      private long[] H002U2_A52TTBUS2_IdMovimiento ;
      private int[] H002U3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pTTBUS2_IdMovimiento ;
      private GXWebForm Form ;
   }

   public class gx0050__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002U2 ;
          prmH002U2 = new Object[] {
          new Object[] {"@AV6cTTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV7cTTBUS2_MotivoCancelacion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV8cTTBUS2_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV9cTTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10cTTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@AV11cTTBUS2_FechaEnvio",SqlDbType.DateTime,10,5} ,
          new Object[] {"@AV12cTTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH002U3 ;
          prmH002U3 = new Object[] {
          new Object[] {"@AV6cTTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV7cTTBUS2_MotivoCancelacion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV8cTTBUS2_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV9cTTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10cTTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@AV11cTTBUS2_FechaEnvio",SqlDbType.DateTime,10,5} ,
          new Object[] {"@AV12cTTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002U2", "SELECT [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_IdBien], [TTBUS2_MotivoCancelacion], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdMovimiento] >= @AV6cTTBUS2_IdMovimiento) AND ([TTBUS2_MotivoCancelacion] like @AV7cTTBUS2_MotivoCancelacion) AND ([TTBUS2_IdBien] >= @AV8cTTBUS2_IdBien) AND ([TTBUS2_CodPosDesde] >= @AV9cTTBUS2_CodPosDesde) AND ([TTBUS2_RespDesde] like @AV10cTTBUS2_RespDesde) AND ([TTBUS2_FechaEnvio] >= @AV11cTTBUS2_FechaEnvio) AND ([TTBUS2_CodPosHacia] >= @AV12cTTBUS2_CodPosHacia) ORDER BY [TTBUS2_IdMovimiento]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002U2,11,0,false,false )
             ,new CursorDef("H002U3", "SELECT COUNT(*) FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdMovimiento] >= @AV6cTTBUS2_IdMovimiento) AND ([TTBUS2_MotivoCancelacion] like @AV7cTTBUS2_MotivoCancelacion) AND ([TTBUS2_IdBien] >= @AV8cTTBUS2_IdBien) AND ([TTBUS2_CodPosDesde] >= @AV9cTTBUS2_CodPosDesde) AND ([TTBUS2_RespDesde] like @AV10cTTBUS2_RespDesde) AND ([TTBUS2_FechaEnvio] >= @AV11cTTBUS2_FechaEnvio) AND ([TTBUS2_CodPosHacia] >= @AV12cTTBUS2_CodPosHacia) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002U3,1,0,false,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((long[]) buf[7])[0] = rslt.getLong(7) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
