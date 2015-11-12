/*
               File: WWTSEG006
        Description: Work With SESIONES POR USUARIO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:20:25.29
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
   public class wwtseg006 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wwtseg006( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public wwtseg006( IGxContext context )
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

      public void execute( )
      {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_Grid = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_26_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_26_idx = GetNextPar( ) ;
               edtavDelete_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
               AV15Delete = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
               edtavUpdate_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
               AV14Update = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid_newrow( nRC_Grid, nGXsfl_26_idx, sGXsfl_26_idx, AV15Delete, AV14Update) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               /* GeneXus formulas. */
               AV18Pgmname = "WWTSEG006" ;
               context.Gx_err = 0 ;
               Grid_PageSize26 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV13PRS_INI = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PRS_INI", context.localUtil.TToC( AV13PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               edtavDelete_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
               AV15Delete = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
               edtavUpdate_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
               AV14Update = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid_refresh( Grid_PageSize26, AV13PRS_INI, AV15Delete, AV14Update) ;
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

      public override short ExecuteStartEvent( )
      {
         PA392( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START392( ) ;
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
         FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wwtseg006.aspx") +"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vPRS_INI", context.localUtil.Format(AV13PRS_INI, "99/99/99 99:99"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE392( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT392( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "WWTSEG006" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With SESIONES POR USUARIO" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwtseg006.aspx")  ;
      }

      protected void WB390( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            wb_table1_2_392( true) ;
         }
         else
         {
            wb_table1_2_392( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_392e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START392( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Work With SESIONES POR USUARIO", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP390( ) ;
      }

      protected void WS392( )
      {
         START392( ) ;
         EVT392( ) ;
      }

      protected void EVT392( )
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
                  if ( context.localUtil.CToT( cgiGet( "GXH_vPRS_INI")) != AV13PRS_INI )
                  {
                     GRID_nFirstRecordOnPage = 0 ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11392 */
                              E11392 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRIDPAGING") ;
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'DOINSERT'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_26_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
                              edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
                              edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
                              edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
                              edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
                              edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
                              edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
                              edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_26_idx ;
                              edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_26_idx ;
                              edtPRG_NFI_Internalname = "PRG_NFI_"+sGXsfl_26_idx ;
                              edtUSU_CNT_Internalname = "USU_CNT_"+sGXsfl_26_idx ;
                              edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_26_idx ;
                              edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_26_idx ;
                              edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_26_idx ;
                              edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_26_idx ;
                              edtPRS_UDE_Internalname = "PRS_UDE_"+sGXsfl_26_idx ;
                              edtPRS_ULNK_Internalname = "PRS_ULNK_"+sGXsfl_26_idx ;
                              AV14Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
                              AV15Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
                              A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                              A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
                              A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
                              A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                              A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
                              A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                              A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
                              A289PRG_NFI = StringUtil.Upper( cgiGet( edtPRG_NFI_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
                              A290USU_CNT = cgiGet( edtUSU_CNT_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
                              A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
                              A166PRS_INI = context.localUtil.CToT( cgiGet( edtPRS_INI_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
                              A404PRS_UOB = cgiGet( edtPRS_UOB_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
                              A165PRS_CAD = context.localUtil.CToT( cgiGet( edtPRS_CAD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
                              A405PRS_UDE = cgiGet( edtPRS_UDE_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
                              A406PRS_ULNK = cgiGet( edtPRS_ULNK_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12392 */
                                    E12392 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13392 */
                                    E13392 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14392 */
                                    E14392 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11392 */
                                    E11392 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Prs_ini Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPRS_INI")) != AV13PRS_INI )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
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

      protected void WE392( )
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

      protected void PA392( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavPrs_ini_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( short nRC_Grid ,
                                      short nGXsfl_26_idx ,
                                      String sGXsfl_26_idx ,
                                      String AV15Delete ,
                                      String AV14Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
         edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_26_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_26_idx ;
         edtPRG_NFI_Internalname = "PRG_NFI_"+sGXsfl_26_idx ;
         edtUSU_CNT_Internalname = "USU_CNT_"+sGXsfl_26_idx ;
         edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_26_idx ;
         edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_26_idx ;
         edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_26_idx ;
         edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_26_idx ;
         edtPRS_UDE_Internalname = "PRS_UDE_"+sGXsfl_26_idx ;
         edtPRS_ULNK_Internalname = "PRS_ULNK_"+sGXsfl_26_idx ;
         while ( nGXsfl_26_idx <= nRC_Grid )
         {
            sendrow_262( ) ;
            nGXsfl_26_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_26_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_26_idx+1)) ;
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
            edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_26_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_26_idx ;
            edtPRG_NFI_Internalname = "PRG_NFI_"+sGXsfl_26_idx ;
            edtUSU_CNT_Internalname = "USU_CNT_"+sGXsfl_26_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_26_idx ;
            edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_26_idx ;
            edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_26_idx ;
            edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_26_idx ;
            edtPRS_UDE_Internalname = "PRS_UDE_"+sGXsfl_26_idx ;
            edtPRS_ULNK_Internalname = "PRS_ULNK_"+sGXsfl_26_idx ;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int Grid_PageSize26 ,
                                       DateTime AV13PRS_INI ,
                                       String AV15Delete ,
                                       String AV14Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid_Rows = (short)(Grid_PageSize26) ;
         RF392( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF392( ) ;
         /* End function Refresh */
      }

      protected void RF392( )
      {
         GridContainer.PageSize = subGrid_Recordsperpage( ) ;
         wbStart = 26 ;
         nGXsfl_26_idx = 1 ;
         sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
         edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_26_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_26_idx ;
         edtPRG_NFI_Internalname = "PRG_NFI_"+sGXsfl_26_idx ;
         edtUSU_CNT_Internalname = "USU_CNT_"+sGXsfl_26_idx ;
         edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_26_idx ;
         edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_26_idx ;
         edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_26_idx ;
         edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_26_idx ;
         edtPRS_UDE_Internalname = "PRS_UDE_"+sGXsfl_26_idx ;
         edtPRS_ULNK_Internalname = "PRS_ULNK_"+sGXsfl_26_idx ;
         /* Execute user event: E13392 */
         E13392 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
            edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_26_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_26_idx ;
            edtPRG_NFI_Internalname = "PRG_NFI_"+sGXsfl_26_idx ;
            edtUSU_CNT_Internalname = "USU_CNT_"+sGXsfl_26_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_26_idx ;
            edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_26_idx ;
            edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_26_idx ;
            edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_26_idx ;
            edtPRS_UDE_Internalname = "PRS_UDE_"+sGXsfl_26_idx ;
            edtPRS_ULNK_Internalname = "PRS_ULNK_"+sGXsfl_26_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13PRS_INI ,
                                                 A166PRS_INI },
                                                 new int[] {
                                                 TypeConstants.DATE, TypeConstants.DATE
                                                 }
            });
            /* Using cursor H00392 */
            pr_default.execute(0, new Object[] {AV13PRS_INI});
            nGXsfl_26_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A406PRS_ULNK = H00392_A406PRS_ULNK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
               A405PRS_UDE = H00392_A405PRS_UDE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
               A165PRS_CAD = H00392_A165PRS_CAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
               A404PRS_UOB = H00392_A404PRS_UOB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
               A166PRS_INI = H00392_A166PRS_INI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               A118PRS_NRO = H00392_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A290USU_CNT = H00392_A290USU_CNT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
               A289PRG_NFI = H00392_A289PRG_NFI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
               A127PRG_DES = H00392_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A126PRG_COD = H00392_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A259SIS_DES = H00392_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A116SIS_COD = H00392_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A155USU_CLA = H00392_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
               A7USU_DES = H00392_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = H00392_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A289PRG_NFI = H00392_A289PRG_NFI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
               A127PRG_DES = H00392_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A259SIS_DES = H00392_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A155USU_CLA = H00392_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
               A7USU_DES = H00392_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A290USU_CNT = H00392_A290USU_CNT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
               /* Execute user event: E14392 */
               E14392 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 26 ;
            WB390( ) ;
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV13PRS_INI ,
                                              A166PRS_INI },
                                              new int[] {
                                              TypeConstants.DATE, TypeConstants.DATE
                                              }
         });
         /* Using cursor H00393 */
         pr_default.execute(1, new Object[] {AV13PRS_INI});
         GRID_nRecordCount = H00393_AGRID_nRecordCount[0] ;
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

      protected void STRUP390( )
      {
         /* Before Start, stand alone formulas. */
         AV18Pgmname = "WWTSEG006" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E12392 */
         E12392 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( context.localUtil.VCDateTime( cgiGet( edtavPrs_ini_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"PRS_ INI"}), 1, "vPRS_INI");
               GX_FocusControl = edtavPrs_ini_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV13PRS_INI = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PRS_INI", context.localUtil.TToC( AV13PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV13PRS_INI = context.localUtil.CToT( cgiGet( edtavPrs_ini_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PRS_INI", context.localUtil.TToC( AV13PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            }
            /* Read saved values. */
            nRC_Grid = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid"), ",", ".")) ;
            GRID_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", ".")) ;
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", ".")) ;
            subGrid_Rows = (short)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", ".")) ;
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
         /* Execute user event: E12392 */
         E12392 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12392( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV18Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV18Pgmname)) ;
         }
         subGrid_Rows = 10 ;
         AV14Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
         edtavUpdate_Tooltiptext = "Modifica" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
         AV15Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
         edtavDelete_Tooltiptext = "Eliminar" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
         Form.Caption = "Work With SESIONES POR USUARIOS" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: S122 */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13392( )
      {
         /* Refresh Routine */
         /* Execute user subroutine: S132 */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E14392( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("tseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A118PRS_NRO) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Link", edtavUpdate_Link);
         edtavDelete_Link = formatLink("tseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A118PRS_NRO) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Link", edtavDelete_Link);
         edtUSU_DES_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_DES_Internalname, "Link", edtUSU_DES_Link);
         edtPRS_INI_Link = formatLink("viewtseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A118PRS_NRO) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_INI_Internalname, "Link", edtPRS_INI_Link);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 26 ;
         }
         if ( ( subGrid_Islastpage == 1 ) || ( subGrid_Rows == 0 ) || ( ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage ) && ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) )
         {
            sendrow_262( ) ;
         }
         GRID_nCurrentRecord = (int)(GRID_nCurrentRecord+1) ;
      }

      protected void E11392( )
      {
         /* 'DoInsert' Routine */
         context.wjLoc = formatLink("tseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) ;
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV8HTTPRequest.Method, "GET") == 0 )
         {
            AV9GridState.FromXml(AV7Session.Get(AV18Pgmname+"GridState"), "");
            if ( AV9GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV13PRS_INI = context.localUtil.CToT( ((SdtGridState_FilterValue)AV9GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value, 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PRS_INI", context.localUtil.TToC( AV13PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            }
            if ( AV9GridState.gxTpr_Currentpage > 0 )
            {
               subgrid_gotopage( AV9GridState.gxTpr_Currentpage) ;
            }
         }
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV9GridState.FromXml(AV7Session.Get(AV18Pgmname+"GridState"), "");
         AV9GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( )) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9GridState", (Object)(AV9GridState));
         AV9GridState.gxTpr_Filtervalues.Clear();
         AV10GridStateFilterValue = new SdtGridState_FilterValue(context) ;
         AV10GridStateFilterValue.gxTpr_Value = context.localUtil.TToC( AV13PRS_INI, 8, 5, 0, 3, "/", ":", " ") ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridStateFilterValue", (Object)(AV10GridStateFilterValue));
         AV9GridState.gxTpr_Filtervalues.Add(AV10GridStateFilterValue, 0);
         AV7Session.Set(AV18Pgmname+"GridState", AV9GridState.ToXml(false, "GridState", "MarianoTesis"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context) ;
         AV11TrnContext.gxTpr_Callerobject = AV18Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerondelete = true ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Transactionname = "TSEG006" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV7Session.Set("TrnContext", AV11TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_392( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable_Internalname, tblTable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, 1, 1, 0, "Work With SESIONES POR USUARIOS", "", "", "", 0, lblTitletext_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_392( true) ;
         }
         else
         {
            wb_table2_8_392( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_392e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_19_392( true) ;
         }
         else
         {
            wb_table3_19_392( false) ;
         }
         return  ;
      }

      protected void wb_table3_19_392e( bool wbgen )
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
            wb_table1_2_392e( true) ;
         }
         else
         {
            wb_table1_2_392e( false) ;
         }
      }

      protected void wb_table3_19_392( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "PagingButtons" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, "E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_WWTSEG006.htm");
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "CONTRASEÑA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NOMBRE FISICO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CONEXION DE USUARIO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NRO DE SESION ASIGNADA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "MOMENTO DE INICIO SESION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ULTIMO OBJETO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "MOMENTO CADUCIDAD SESION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION ULTIMO OBJETO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ULTIMO LINK") ;
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
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV14Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV15Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A6USU_COD));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A7USU_DES));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtUSU_DES_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A155USU_CLA));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A259SIS_DES));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A127PRG_DES));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A289PRG_NFI));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A290USU_CNT));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtPRS_INI_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A404PRS_UOB));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A405PRS_UDE));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", A406PRS_ULNK);
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", "false");
               GridContainer.AddObjectProperty("Allowcollapsing", "false");
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 26 )
         {
            wbEnd = 0 ;
            nRC_Grid = (short)(nGXsfl_26_idx-1) ;
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", (Object)(GridContainer));
               GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_19_392e( true) ;
         }
         else
         {
            wb_table3_19_392e( false) ;
         }
      }

      protected void wb_table2_8_392( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablesearch_Internalname, tblTablesearch_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblFiltertextprs_ini_Internalname, 1, 1, 0, "MOMENTO DE INICIO SESION", "", "", "", 0, lblFiltertextprs_ini_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_26_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavPrs_ini_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPrs_ini_Internalname, context.localUtil.Format(AV13PRS_INI, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV13PRS_INI, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(13);\"", 0, edtavPrs_ini_Jsonclick, "", 0, 1, -1, true, "right", "HLP_WWTSEG006.htm");
            GxWebStd.gx_bitmap( context, edtavPrs_ini_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_WWTSEG006.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTableseparator_Internalname, 1, 1, 0, " ", "", "", "", 0, lblTableseparator_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_392e( true) ;
         }
         else
         {
            wb_table2_8_392e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA392( ) ;
         WS392( ) ;
         WE392( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11202617");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("wwtseg006.js", "?11202617");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_262( )
      {
         WB390( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_26_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
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
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1 ;
               if ( ((int)(nGXsfl_26_idx) % (2)) == 0 )
               {
                  subGrid_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
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
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV14Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavUpdate_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV15Delete,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavDelete_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_COD_Internalname,StringUtil.RTrim( A6USU_COD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")),(String)"",(short)0,(String)edtUSU_COD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_DES_Internalname,StringUtil.RTrim( A7USU_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtUSU_DES_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")),(String)"",(short)0,(String)edtUSU_DES_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_CLA_Internalname,StringUtil.RTrim( A155USU_CLA),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)0,(short)0,(short)0,(short)-1,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtUSU_CLA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"),(String)"",(short)0,(String)edtSIS_COD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_DES_Internalname,StringUtil.RTrim( A259SIS_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")),(String)"",(short)0,(String)edtSIS_DES_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"),(String)"",(short)0,(String)edtPRG_COD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_DES_Internalname,StringUtil.RTrim( A127PRG_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRG_DES_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_NFI_Internalname,StringUtil.RTrim( A289PRG_NFI),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A289PRG_NFI, "@!")),(String)"",(short)0,(String)edtPRG_NFI_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_CNT_Internalname,StringUtil.RTrim( A290USU_CNT),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A290USU_CNT, "X")),(String)"",(short)0,(String)edtUSU_CNT_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_NRO_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A118PRS_NRO), "ZZZZZZZ9"),(String)"",(short)0,(String)edtPRS_NRO_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_INI_Internalname,context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtPRS_INI_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A166PRS_INI, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRS_INI_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_UOB_Internalname,StringUtil.RTrim( A404PRS_UOB),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A404PRS_UOB, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRS_UOB_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_CAD_Internalname,context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A165PRS_CAD, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRS_CAD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_UDE_Internalname,StringUtil.RTrim( A405PRS_UDE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A405PRS_UDE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRS_UDE_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRS_ULNK_Internalname,(String)A406PRS_ULNK,(String)"",(short)0,(String)"px",(short)17,(String)"",(short)300,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,(String)A406PRS_ULNK,(String)"",(short)0,(String)edtPRS_ULNK_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            GridContainer.AddRow(GridRow);
            nGXsfl_26_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_26_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_26_idx+1)) ;
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
            edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_26_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_26_idx ;
            edtPRG_NFI_Internalname = "PRG_NFI_"+sGXsfl_26_idx ;
            edtUSU_CNT_Internalname = "USU_CNT_"+sGXsfl_26_idx ;
            edtPRS_NRO_Internalname = "PRS_NRO_"+sGXsfl_26_idx ;
            edtPRS_INI_Internalname = "PRS_INI_"+sGXsfl_26_idx ;
            edtPRS_UOB_Internalname = "PRS_UOB_"+sGXsfl_26_idx ;
            edtPRS_CAD_Internalname = "PRS_CAD_"+sGXsfl_26_idx ;
            edtPRS_UDE_Internalname = "PRS_UDE_"+sGXsfl_26_idx ;
            edtPRS_ULNK_Internalname = "PRS_ULNK_"+sGXsfl_26_idx ;
         }
         /* End function sendrow_262 */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT" ;
         lblFiltertextprs_ini_Internalname = "FILTERTEXTPRS_INI" ;
         edtavPrs_ini_Internalname = "vPRS_INI" ;
         lblTableseparator_Internalname = "TABLESEPARATOR" ;
         tblTablesearch_Internalname = "TABLESEARCH" ;
         imgInsert_Internalname = "INSERT" ;
         tblTablegridcontainer_Internalname = "TABLEGRIDCONTAINER" ;
         tblTable_Internalname = "TABLE" ;
         Form.Internalname = "FORM" ;
         subGrid_Internalname = "GRID" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtPRS_ULNK_Jsonclick = "" ;
         edtPRS_UDE_Jsonclick = "" ;
         edtPRS_CAD_Jsonclick = "" ;
         edtPRS_UOB_Jsonclick = "" ;
         edtPRS_INI_Jsonclick = "" ;
         edtPRS_NRO_Jsonclick = "" ;
         edtUSU_CNT_Jsonclick = "" ;
         edtPRG_NFI_Jsonclick = "" ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_COD_Jsonclick = "" ;
         edtUSU_CLA_Jsonclick = "" ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtavPrs_ini_Jsonclick = "" ;
         subGrid_Class = "WorkWith" ;
         subGrid_Backcolorstyle = 3 ;
         edtPRS_INI_Link = "" ;
         edtUSU_DES_Link = "" ;
         edtavDelete_Link = "" ;
         edtavUpdate_Link = "" ;
         subGrid_Rows = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Work With SESIONES POR USUARIO" ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         edtavDelete_Internalname = "" ;
         AV15Delete = "" ;
         edtavUpdate_Internalname = "" ;
         AV14Update = "" ;
         AV18Pgmname = "" ;
         AV13PRS_INI = (DateTime)(DateTime.MinValue) ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtUSU_COD_Internalname = "" ;
         edtUSU_DES_Internalname = "" ;
         edtUSU_CLA_Internalname = "" ;
         edtSIS_COD_Internalname = "" ;
         edtSIS_DES_Internalname = "" ;
         edtPRG_COD_Internalname = "" ;
         edtPRG_DES_Internalname = "" ;
         edtPRG_NFI_Internalname = "" ;
         edtUSU_CNT_Internalname = "" ;
         edtPRS_NRO_Internalname = "" ;
         edtPRS_INI_Internalname = "" ;
         edtPRS_UOB_Internalname = "" ;
         edtPRS_CAD_Internalname = "" ;
         edtPRS_UDE_Internalname = "" ;
         edtPRS_ULNK_Internalname = "" ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         A155USU_CLA = "" ;
         A259SIS_DES = "" ;
         A127PRG_DES = "" ;
         A289PRG_NFI = "" ;
         A290USU_CNT = "" ;
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         A404PRS_UOB = "" ;
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         A405PRS_UDE = "" ;
         A406PRS_ULNK = "" ;
         GridContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         H00392_A406PRS_ULNK = new String[] {""} ;
         H00392_A405PRS_UDE = new String[] {""} ;
         H00392_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         H00392_A404PRS_UOB = new String[] {""} ;
         H00392_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         H00392_A118PRS_NRO = new int[1] ;
         H00392_A290USU_CNT = new String[] {""} ;
         H00392_A289PRG_NFI = new String[] {""} ;
         H00392_A127PRG_DES = new String[] {""} ;
         H00392_A126PRG_COD = new short[1] ;
         H00392_A259SIS_DES = new String[] {""} ;
         H00392_A116SIS_COD = new short[1] ;
         H00392_A155USU_CLA = new String[] {""} ;
         H00392_A7USU_DES = new String[] {""} ;
         H00392_A6USU_COD = new String[] {""} ;
         H00393_AGRID_nRecordCount = new int[1] ;
         AV8HTTPRequest = new GxHttpRequest( context);
         AV9GridState = new SdtGridState(context);
         AV7Session = new GxWebSession( context);
         AV10GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11TrnContext = new SdtTransactionContext(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTitletext_Jsonclick = "" ;
         TempTags = "" ;
         imgInsert_Jsonclick = "" ;
         subGrid_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         GXt_char14 = "" ;
         GXt_char15 = "" ;
         GridColumn = new GXWebColumn();
         lblFiltertextprs_ini_Jsonclick = "" ;
         GXt_char17 = "" ;
         GXt_char16 = "" ;
         lblTableseparator_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         GridRow = new GXWebRow();
         ROClassString = "" ;
         GXt_char18 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwtseg006__default(),
            new Object[][] {
                new Object[] {
               H00392_A406PRS_ULNK, H00392_A405PRS_UDE, H00392_A165PRS_CAD, H00392_A404PRS_UOB, H00392_A166PRS_INI, H00392_A118PRS_NRO, H00392_A290USU_CNT, H00392_A289PRG_NFI, H00392_A127PRG_DES, H00392_A126PRG_COD,
               H00392_A259SIS_DES, H00392_A116SIS_COD, H00392_A155USU_CLA, H00392_A7USU_DES, H00392_A6USU_COD
               }
               , new Object[] {
               H00393_AGRID_nRecordCount
               }
            }
         );
         AV18Pgmname = "WWTSEG006" ;
         /* GeneXus formulas. */
         AV18Pgmname = "WWTSEG006" ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid ;
      private short nGXsfl_26_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID_nEOF ;
      private short subGrid_Rows ;
      private short wbEnd ;
      private short wbStart ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short nDonePA ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Grid_PageSize26 ;
      private int GRID_nFirstRecordOnPage ;
      private int A118PRS_NRO ;
      private int subGrid_Islastpage ;
      private int GRID_nCurrentRecord ;
      private int GRID_nRecordCount ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_26_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String AV18Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String edtUSU_CLA_Internalname ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_DES_Internalname ;
      private String edtPRG_NFI_Internalname ;
      private String edtUSU_CNT_Internalname ;
      private String edtPRS_NRO_Internalname ;
      private String edtPRS_INI_Internalname ;
      private String edtPRS_UOB_Internalname ;
      private String edtPRS_CAD_Internalname ;
      private String edtPRS_UDE_Internalname ;
      private String edtPRS_ULNK_Internalname ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A155USU_CLA ;
      private String A259SIS_DES ;
      private String A127PRG_DES ;
      private String A289PRG_NFI ;
      private String A290USU_CNT ;
      private String A404PRS_UOB ;
      private String A405PRS_UDE ;
      private String edtavPrs_ini_Internalname ;
      private String scmdbuf ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String edtUSU_DES_Link ;
      private String edtPRS_INI_Link ;
      private String sStyleString ;
      private String tblTable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String tblTablegridcontainer_Internalname ;
      private String TempTags ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String GXt_char14 ;
      private String GXt_char15 ;
      private String tblTablesearch_Internalname ;
      private String lblFiltertextprs_ini_Internalname ;
      private String lblFiltertextprs_ini_Jsonclick ;
      private String GXt_char17 ;
      private String edtavPrs_ini_Jsonclick ;
      private String GXt_char16 ;
      private String lblTableseparator_Internalname ;
      private String lblTableseparator_Jsonclick ;
      private String ROClassString ;
      private String edtUSU_COD_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
      private String edtUSU_CLA_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String edtSIS_DES_Jsonclick ;
      private String edtPRG_COD_Jsonclick ;
      private String edtPRG_DES_Jsonclick ;
      private String edtPRG_NFI_Jsonclick ;
      private String edtUSU_CNT_Jsonclick ;
      private String edtPRS_NRO_Jsonclick ;
      private String edtPRS_INI_Jsonclick ;
      private String edtPRS_UOB_Jsonclick ;
      private String edtPRS_CAD_Jsonclick ;
      private String edtPRS_UDE_Jsonclick ;
      private String edtPRS_ULNK_Jsonclick ;
      private String GXt_char18 ;
      private DateTime AV13PRS_INI ;
      private DateTime A166PRS_INI ;
      private DateTime A165PRS_CAD ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A406PRS_ULNK ;
      private String AV15Delete ;
      private String AV14Update ;
      private GxWebSession AV7Session ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00392_A406PRS_ULNK ;
      private String[] H00392_A405PRS_UDE ;
      private DateTime[] H00392_A165PRS_CAD ;
      private String[] H00392_A404PRS_UOB ;
      private DateTime[] H00392_A166PRS_INI ;
      private int[] H00392_A118PRS_NRO ;
      private String[] H00392_A290USU_CNT ;
      private String[] H00392_A289PRG_NFI ;
      private String[] H00392_A127PRG_DES ;
      private short[] H00392_A126PRG_COD ;
      private String[] H00392_A259SIS_DES ;
      private short[] H00392_A116SIS_COD ;
      private String[] H00392_A155USU_CLA ;
      private String[] H00392_A7USU_DES ;
      private String[] H00392_A6USU_COD ;
      private int[] H00393_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXWebForm Form ;
      private SdtGridState AV9GridState ;
      private SdtGridState_FilterValue AV10GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwtseg006__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00392( DateTime AV13PRS_INI ,
                                             DateTime A166PRS_INI )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int19 ;
         GXv_int19 = new short [1] ;
         Object[] GXv_Object20 ;
         GXv_Object20 = new Object [2] ;
         scmdbuf = "SELECT T1.[PRS_ULNK], T1.[PRS_UDE], T1.[PRS_CAD], T1.[PRS_UOB], T1.[PRS_INI], T1.[PRS_NRO], T5.[USU_CNT], T2.[PRG_NFI], T2.[PRG_DES], T1.[PRG_COD], T3.[SIS_DES], T1.[SIS_COD], T4.[USU_CLA], T4.[USU_DES], T1.[USU_COD] FROM (((([SEG006] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = T1.[SIS_COD]) INNER JOIN [SEG002] T4 WITH (NOLOCK) ON T4.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG004] T5 WITH (NOLOCK) ON T5.[USU_COD] = T1.[USU_COD] AND T5.[SIS_COD] = T1.[SIS_COD] AND T5.[PRG_COD] = T1.[PRG_COD])" ;
         if ( ! (DateTime.MinValue==AV13PRS_INI) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PRS_INI] >= @AV13PRS_INI)" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PRS_INI] >= @AV13PRS_INI)" ;
            }
         }
         else
         {
            GXv_int19[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[PRS_INI]" ;
         GXv_Object20[0] = scmdbuf ;
         GXv_Object20[1] = (Object)(GXv_int19) ;
         return GXv_Object20 ;
      }

      protected Object[] conditional_H00393( DateTime AV13PRS_INI ,
                                             DateTime A166PRS_INI )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int21 ;
         GXv_int21 = new short [1] ;
         Object[] GXv_Object22 ;
         GXv_Object22 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (((([SEG006] T1 WITH (NOLOCK) INNER JOIN [SEG001] T5 WITH (NOLOCK) ON T5.[PRG_COD] = T1.[PRG_COD]) INNER JOIN [SEG000] T4 WITH (NOLOCK) ON T4.[SIS_COD] = T1.[SIS_COD]) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG004] T3 WITH (NOLOCK) ON T3.[USU_COD] = T1.[USU_COD] AND T3.[SIS_COD] = T1.[SIS_COD] AND T3.[PRG_COD] = T1.[PRG_COD])" ;
         if ( ! (DateTime.MinValue==AV13PRS_INI) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PRS_INI] >= @AV13PRS_INI)" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PRS_INI] >= @AV13PRS_INI)" ;
            }
         }
         else
         {
            GXv_int21[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + "" ;
         GXv_Object22[0] = scmdbuf ;
         GXv_Object22[1] = (Object)(GXv_int21) ;
         return GXv_Object22 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00392( (DateTime)dynConstraints[0] , (DateTime)dynConstraints[1] );
               case 1 :
                     return conditional_H00393( (DateTime)dynConstraints[0] , (DateTime)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmH00392 ;
          prmH00392 = new Object[] {
          new Object[] {"@AV13PRS_INI",SqlDbType.DateTime,8,5}
          } ;
          Object[] prmH00393 ;
          prmH00393 = new Object[] {
          new Object[] {"@AV13PRS_INI",SqlDbType.DateTime,8,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00392", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00392,11,0,true,false )
             ,new CursorDef("H00393", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00393,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getLongVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 30) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 15) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 20) ;
                ((String[]) buf[13])[0] = rslt.getString(14, 50) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 16) ;
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
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[1]);
                }
                break;
             case 1 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[1]);
                }
                break;
       }
    }

 }

}
