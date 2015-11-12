/*
               File: WWTSEG002
        Description: Work With ACT. USUARIOS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:21.45
       Program type: Main program
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
   public class wwtseg002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wwtseg002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public wwtseg002( IGxContext context )
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
               AV18Pgmname = "WWTSEG002" ;
               context.Gx_err = 0 ;
               Grid_PageSize26 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV13USU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USU_DES", AV13USU_DES);
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
               gxgrGrid_refresh( Grid_PageSize26, AV13USU_DES, AV15Delete, AV14Update) ;
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
         PA0F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0F2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wwtseg002.aspx") +"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vUSU_DES", StringUtil.RTrim( AV13USU_DES));
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
            WE0F2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0F2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "WWTSEG002" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With ACT. USUARIOS" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwtseg002.aspx")  ;
      }

      protected void WB0F0( )
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
            wb_table1_2_0F2( true) ;
         }
         else
         {
            wb_table1_2_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0F2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Work With ACT. USUARIOS", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0F0( ) ;
      }

      protected void WS0F2( )
      {
         START0F2( ) ;
         EVT0F2( ) ;
      }

      protected void EVT0F2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vUSU_DES"), AV13USU_DES) != 0 )
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
                              /* Execute user event: E110F2 */
                              E110F2 ();
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
                              edtUSU_FEC_Internalname = "USU_FEC_"+sGXsfl_26_idx ;
                              edtUSU_CDA_Internalname = "USU_CDA_"+sGXsfl_26_idx ;
                              edtUSU_EMP_Internalname = "USU_EMP_"+sGXsfl_26_idx ;
                              edtUSU_LEG_Internalname = "USU_LEG_"+sGXsfl_26_idx ;
                              edtUSU_INT_Internalname = "USU_INT_"+sGXsfl_26_idx ;
                              edtUSU_CLAK_Internalname = "USU_CLAK_"+sGXsfl_26_idx ;
                              edtUSU_MAIW_Internalname = "USU_MAIW_"+sGXsfl_26_idx ;
                              edtUSU_TIPW_Internalname = "USU_TIPW_"+sGXsfl_26_idx ;
                              edtUSU_NROW_Internalname = "USU_NROW_"+sGXsfl_26_idx ;
                              edtUSU_STS_Internalname = "USU_STS_"+sGXsfl_26_idx ;
                              edtUSU_ACTIV_Internalname = "USU_ACTIV_"+sGXsfl_26_idx ;
                              edtUSU_ERR_Internalname = "USU_ERR_"+sGXsfl_26_idx ;
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
                              A156USU_FEC = context.localUtil.CToD( cgiGet( edtUSU_FEC_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156USU_FEC", context.localUtil.Format(A156USU_FEC, "99/99/9999"));
                              A250USU_CDA = StringUtil.Upper( cgiGet( edtUSU_CDA_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A250USU_CDA", A250USU_CDA);
                              A251USU_EMP = cgiGet( edtUSU_EMP_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A251USU_EMP", A251USU_EMP);
                              A252USU_LEG = (int)(context.localUtil.CToN( cgiGet( edtUSU_LEG_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252USU_LEG", StringUtil.LTrim( StringUtil.Str( (decimal)(A252USU_LEG), 5, 0)));
                              A180USU_INT = cgiGet( edtUSU_INT_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180USU_INT", A180USU_INT);
                              A253USU_CLAK = cgiGet( edtUSU_CLAK_Internalname) ;
                              n253USU_CLAK = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253USU_CLAK", A253USU_CLAK);
                              A249USU_MAIW = cgiGet( edtUSU_MAIW_Internalname) ;
                              n249USU_MAIW = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249USU_MAIW", A249USU_MAIW);
                              A254USU_TIPW = cgiGet( edtUSU_TIPW_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254USU_TIPW", A254USU_TIPW);
                              A255USU_NROW = (long)(context.localUtil.CToN( cgiGet( edtUSU_NROW_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255USU_NROW", StringUtil.LTrim( StringUtil.Str( (decimal)(A255USU_NROW), 11, 0)));
                              A256USU_STS = (short)(context.localUtil.CToN( cgiGet( edtUSU_STS_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256USU_STS", StringUtil.LTrim( StringUtil.Str( (decimal)(A256USU_STS), 2, 0)));
                              A257USU_ACTIV = context.localUtil.CToT( cgiGet( edtUSU_ACTIV_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257USU_ACTIV", context.localUtil.TToC( A257USU_ACTIV, 8, 5, 0, 3, "/", ":", " "));
                              A258USU_ERR = (short)(context.localUtil.CToN( cgiGet( edtUSU_ERR_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258USU_ERR", StringUtil.LTrim( StringUtil.Str( (decimal)(A258USU_ERR), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120F2 */
                                    E120F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E130F2 */
                                    E130F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E140F2 */
                                    E140F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110F2 */
                                    E110F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Usu_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vUSU_DES"), AV13USU_DES) != 0 )
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

      protected void WE0F2( )
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

      protected void PA0F2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavUsu_des_Internalname ;
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
         edtUSU_FEC_Internalname = "USU_FEC_"+sGXsfl_26_idx ;
         edtUSU_CDA_Internalname = "USU_CDA_"+sGXsfl_26_idx ;
         edtUSU_EMP_Internalname = "USU_EMP_"+sGXsfl_26_idx ;
         edtUSU_LEG_Internalname = "USU_LEG_"+sGXsfl_26_idx ;
         edtUSU_INT_Internalname = "USU_INT_"+sGXsfl_26_idx ;
         edtUSU_CLAK_Internalname = "USU_CLAK_"+sGXsfl_26_idx ;
         edtUSU_MAIW_Internalname = "USU_MAIW_"+sGXsfl_26_idx ;
         edtUSU_TIPW_Internalname = "USU_TIPW_"+sGXsfl_26_idx ;
         edtUSU_NROW_Internalname = "USU_NROW_"+sGXsfl_26_idx ;
         edtUSU_STS_Internalname = "USU_STS_"+sGXsfl_26_idx ;
         edtUSU_ACTIV_Internalname = "USU_ACTIV_"+sGXsfl_26_idx ;
         edtUSU_ERR_Internalname = "USU_ERR_"+sGXsfl_26_idx ;
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
            edtUSU_FEC_Internalname = "USU_FEC_"+sGXsfl_26_idx ;
            edtUSU_CDA_Internalname = "USU_CDA_"+sGXsfl_26_idx ;
            edtUSU_EMP_Internalname = "USU_EMP_"+sGXsfl_26_idx ;
            edtUSU_LEG_Internalname = "USU_LEG_"+sGXsfl_26_idx ;
            edtUSU_INT_Internalname = "USU_INT_"+sGXsfl_26_idx ;
            edtUSU_CLAK_Internalname = "USU_CLAK_"+sGXsfl_26_idx ;
            edtUSU_MAIW_Internalname = "USU_MAIW_"+sGXsfl_26_idx ;
            edtUSU_TIPW_Internalname = "USU_TIPW_"+sGXsfl_26_idx ;
            edtUSU_NROW_Internalname = "USU_NROW_"+sGXsfl_26_idx ;
            edtUSU_STS_Internalname = "USU_STS_"+sGXsfl_26_idx ;
            edtUSU_ACTIV_Internalname = "USU_ACTIV_"+sGXsfl_26_idx ;
            edtUSU_ERR_Internalname = "USU_ERR_"+sGXsfl_26_idx ;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int Grid_PageSize26 ,
                                       String AV13USU_DES ,
                                       String AV15Delete ,
                                       String AV14Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid_Rows = (short)(Grid_PageSize26) ;
         RF0F2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF0F2( ) ;
         /* End function Refresh */
      }

      protected void RF0F2( )
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
         edtUSU_FEC_Internalname = "USU_FEC_"+sGXsfl_26_idx ;
         edtUSU_CDA_Internalname = "USU_CDA_"+sGXsfl_26_idx ;
         edtUSU_EMP_Internalname = "USU_EMP_"+sGXsfl_26_idx ;
         edtUSU_LEG_Internalname = "USU_LEG_"+sGXsfl_26_idx ;
         edtUSU_INT_Internalname = "USU_INT_"+sGXsfl_26_idx ;
         edtUSU_CLAK_Internalname = "USU_CLAK_"+sGXsfl_26_idx ;
         edtUSU_MAIW_Internalname = "USU_MAIW_"+sGXsfl_26_idx ;
         edtUSU_TIPW_Internalname = "USU_TIPW_"+sGXsfl_26_idx ;
         edtUSU_NROW_Internalname = "USU_NROW_"+sGXsfl_26_idx ;
         edtUSU_STS_Internalname = "USU_STS_"+sGXsfl_26_idx ;
         edtUSU_ACTIV_Internalname = "USU_ACTIV_"+sGXsfl_26_idx ;
         edtUSU_ERR_Internalname = "USU_ERR_"+sGXsfl_26_idx ;
         /* Execute user event: E130F2 */
         E130F2 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
            edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
            edtUSU_FEC_Internalname = "USU_FEC_"+sGXsfl_26_idx ;
            edtUSU_CDA_Internalname = "USU_CDA_"+sGXsfl_26_idx ;
            edtUSU_EMP_Internalname = "USU_EMP_"+sGXsfl_26_idx ;
            edtUSU_LEG_Internalname = "USU_LEG_"+sGXsfl_26_idx ;
            edtUSU_INT_Internalname = "USU_INT_"+sGXsfl_26_idx ;
            edtUSU_CLAK_Internalname = "USU_CLAK_"+sGXsfl_26_idx ;
            edtUSU_MAIW_Internalname = "USU_MAIW_"+sGXsfl_26_idx ;
            edtUSU_TIPW_Internalname = "USU_TIPW_"+sGXsfl_26_idx ;
            edtUSU_NROW_Internalname = "USU_NROW_"+sGXsfl_26_idx ;
            edtUSU_STS_Internalname = "USU_STS_"+sGXsfl_26_idx ;
            edtUSU_ACTIV_Internalname = "USU_ACTIV_"+sGXsfl_26_idx ;
            edtUSU_ERR_Internalname = "USU_ERR_"+sGXsfl_26_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13USU_DES ,
                                                 A7USU_DES ,
                                                 A251USU_EMP },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                                 }
            });
            lV13USU_DES = StringUtil.PadR( StringUtil.RTrim( AV13USU_DES), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USU_DES", AV13USU_DES);
            /* Using cursor H000F2 */
            pr_default.execute(0, new Object[] {lV13USU_DES});
            nGXsfl_26_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A258USU_ERR = H000F2_A258USU_ERR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A258USU_ERR", StringUtil.LTrim( StringUtil.Str( (decimal)(A258USU_ERR), 4, 0)));
               A257USU_ACTIV = H000F2_A257USU_ACTIV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A257USU_ACTIV", context.localUtil.TToC( A257USU_ACTIV, 8, 5, 0, 3, "/", ":", " "));
               A256USU_STS = H000F2_A256USU_STS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A256USU_STS", StringUtil.LTrim( StringUtil.Str( (decimal)(A256USU_STS), 2, 0)));
               A255USU_NROW = H000F2_A255USU_NROW[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255USU_NROW", StringUtil.LTrim( StringUtil.Str( (decimal)(A255USU_NROW), 11, 0)));
               A254USU_TIPW = H000F2_A254USU_TIPW[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A254USU_TIPW", A254USU_TIPW);
               A249USU_MAIW = H000F2_A249USU_MAIW[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249USU_MAIW", A249USU_MAIW);
               n249USU_MAIW = H000F2_n249USU_MAIW[0] ;
               A253USU_CLAK = H000F2_A253USU_CLAK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A253USU_CLAK", A253USU_CLAK);
               n253USU_CLAK = H000F2_n253USU_CLAK[0] ;
               A180USU_INT = H000F2_A180USU_INT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180USU_INT", A180USU_INT);
               A252USU_LEG = H000F2_A252USU_LEG[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A252USU_LEG", StringUtil.LTrim( StringUtil.Str( (decimal)(A252USU_LEG), 5, 0)));
               A251USU_EMP = H000F2_A251USU_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A251USU_EMP", A251USU_EMP);
               A250USU_CDA = H000F2_A250USU_CDA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A250USU_CDA", A250USU_CDA);
               A156USU_FEC = H000F2_A156USU_FEC[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156USU_FEC", context.localUtil.Format(A156USU_FEC, "99/99/9999"));
               A155USU_CLA = H000F2_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
               A7USU_DES = H000F2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = H000F2_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               /* Execute user event: E140F2 */
               E140F2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 26 ;
            WB0F0( ) ;
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
                                              AV13USU_DES ,
                                              A7USU_DES ,
                                              A251USU_EMP },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         });
         lV13USU_DES = StringUtil.PadR( StringUtil.RTrim( AV13USU_DES), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USU_DES", AV13USU_DES);
         /* Using cursor H000F3 */
         pr_default.execute(1, new Object[] {lV13USU_DES});
         GRID_nRecordCount = H000F3_AGRID_nRecordCount[0] ;
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

      protected void STRUP0F0( )
      {
         /* Before Start, stand alone formulas. */
         AV18Pgmname = "WWTSEG002" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E120F2 */
         E120F2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV13USU_DES = StringUtil.Upper( cgiGet( edtavUsu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USU_DES", AV13USU_DES);
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
         /* Execute user event: E120F2 */
         E120F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E120F2( )
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
         Form.Caption = "Trabajar con ACT. USUARIOS" ;
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

      protected void E130F2( )
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

      private void E140F2( )
      {
         /* Grid_Load Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) ;
         edtavUpdate_Link = formatLink("tseg002.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Link", edtavUpdate_Link);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) ;
         edtavDelete_Link = formatLink("tseg002.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Link", edtavDelete_Link);
         edtUSU_DES_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_DES_Internalname, "Link", edtUSU_DES_Link);
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

      protected void E110F2( )
      {
         /* 'DoInsert' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.wjLoc = formatLink("tseg002.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV8HTTPRequest.Method, "GET") == 0 )
         {
            AV9GridState.FromXml(AV7Session.Get(AV18Pgmname+"GridState"), "");
            if ( AV9GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV13USU_DES = ((SdtGridState_FilterValue)AV9GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USU_DES", AV13USU_DES);
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
         AV10GridStateFilterValue.gxTpr_Value = AV13USU_DES ;
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
         AV11TrnContext.gxTpr_Transactionname = "TSEG002" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV7Session.Set("TrnContext", AV11TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_0F2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, 1, 1, 0, "Trabajar con ACT. USUARIOS", "", "", "", 0, lblTitletext_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_0F2( true) ;
         }
         else
         {
            wb_table2_8_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_19_0F2( true) ;
         }
         else
         {
            wb_table3_19_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table3_19_0F2e( bool wbgen )
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
            wb_table1_2_0F2e( true) ;
         }
         else
         {
            wb_table1_2_0F2e( false) ;
         }
      }

      protected void wb_table3_19_0F2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, "E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_WWTSEG002.htm");
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
               context.SendWebValue( "FECHA DE CONTRASEÑA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO ANTERIOR") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "EMPRESA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DE LEGAJO RHM") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NRO. TELEFONO INTERNO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "A ENCRIPTADA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "EN WEB") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "USUARIO WEB") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "PRESTADOR/ ENTIDAD") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "EN WEB") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ACTIVACION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CLAVE") ;
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
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A156USU_FEC, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A250USU_CDA));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A251USU_EMP));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A252USU_LEG), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A180USU_INT));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A253USU_CLAK));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A249USU_MAIW));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A254USU_TIPW));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A255USU_NROW), 11, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A256USU_STS), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A257USU_ACTIV, "99/99/99 99:99"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A258USU_ERR), 4, 0, ".", "")));
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
            wb_table3_19_0F2e( true) ;
         }
         else
         {
            wb_table3_19_0F2e( false) ;
         }
      }

      protected void wb_table2_8_0F2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblFiltertextusu_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblFiltertextusu_des_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_26_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_des_Internalname, StringUtil.RTrim( AV13USU_DES), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV13USU_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtavUsu_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_WWTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTableseparator_Internalname, 1, 1, 0, " ", "", "", "", 0, lblTableseparator_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_0F2e( true) ;
         }
         else
         {
            wb_table2_8_0F2e( false) ;
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
         PA0F2( ) ;
         WS0F2( ) ;
         WE0F2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1182225");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("wwtseg002.js", "?1182225");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_262( )
      {
         WB0F0( ) ;
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_FEC_Internalname,context.localUtil.Format(A156USU_FEC, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A156USU_FEC, "99/99/9999"),(String)"",(short)0,(String)edtUSU_FEC_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_CDA_Internalname,StringUtil.RTrim( A250USU_CDA),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A250USU_CDA, "@!")),(String)"",(short)0,(String)edtUSU_CDA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_EMP_Internalname,StringUtil.RTrim( A251USU_EMP),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A251USU_EMP, "XXX")),(String)"",(short)0,(String)edtUSU_EMP_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_LEG_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A252USU_LEG), 5, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)5,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A252USU_LEG), "ZZZZ9"),(String)"",(short)0,(String)edtUSU_LEG_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_INT_Internalname,StringUtil.RTrim( A180USU_INT),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A180USU_INT, "XXXXXXXXXX")),(String)"",(short)0,(String)edtUSU_INT_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_CLAK_Internalname,StringUtil.RTrim( A253USU_CLAK),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)32,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A253USU_CLAK, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtUSU_CLAK_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_MAIW_Internalname,StringUtil.RTrim( A249USU_MAIW),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)256,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A249USU_MAIW, "")),(String)"",(short)0,(String)edtUSU_MAIW_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_TIPW_Internalname,StringUtil.RTrim( A254USU_TIPW),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A254USU_TIPW, "X")),(String)"",(short)0,(String)edtUSU_TIPW_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_NROW_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A255USU_NROW), 11, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)11,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A255USU_NROW), "ZZZZZZZZZZ9"),(String)"",(short)0,(String)edtUSU_NROW_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_STS_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A256USU_STS), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A256USU_STS), "Z9"),(String)"",(short)0,(String)edtUSU_STS_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_ACTIV_Internalname,context.localUtil.Format(A257USU_ACTIV, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A257USU_ACTIV, "99/99/99 99:99"),(String)"",(short)0,(String)edtUSU_ACTIV_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_ERR_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A258USU_ERR), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A258USU_ERR), "ZZZ9"),(String)"",(short)0,(String)edtUSU_ERR_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            GridContainer.AddRow(GridRow);
            nGXsfl_26_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_26_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_26_idx+1)) ;
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
            edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
            edtUSU_FEC_Internalname = "USU_FEC_"+sGXsfl_26_idx ;
            edtUSU_CDA_Internalname = "USU_CDA_"+sGXsfl_26_idx ;
            edtUSU_EMP_Internalname = "USU_EMP_"+sGXsfl_26_idx ;
            edtUSU_LEG_Internalname = "USU_LEG_"+sGXsfl_26_idx ;
            edtUSU_INT_Internalname = "USU_INT_"+sGXsfl_26_idx ;
            edtUSU_CLAK_Internalname = "USU_CLAK_"+sGXsfl_26_idx ;
            edtUSU_MAIW_Internalname = "USU_MAIW_"+sGXsfl_26_idx ;
            edtUSU_TIPW_Internalname = "USU_TIPW_"+sGXsfl_26_idx ;
            edtUSU_NROW_Internalname = "USU_NROW_"+sGXsfl_26_idx ;
            edtUSU_STS_Internalname = "USU_STS_"+sGXsfl_26_idx ;
            edtUSU_ACTIV_Internalname = "USU_ACTIV_"+sGXsfl_26_idx ;
            edtUSU_ERR_Internalname = "USU_ERR_"+sGXsfl_26_idx ;
         }
         /* End function sendrow_262 */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT" ;
         lblFiltertextusu_des_Internalname = "FILTERTEXTUSU_DES" ;
         edtavUsu_des_Internalname = "vUSU_DES" ;
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
         edtUSU_ERR_Jsonclick = "" ;
         edtUSU_ACTIV_Jsonclick = "" ;
         edtUSU_STS_Jsonclick = "" ;
         edtUSU_NROW_Jsonclick = "" ;
         edtUSU_TIPW_Jsonclick = "" ;
         edtUSU_MAIW_Jsonclick = "" ;
         edtUSU_CLAK_Jsonclick = "" ;
         edtUSU_INT_Jsonclick = "" ;
         edtUSU_LEG_Jsonclick = "" ;
         edtUSU_EMP_Jsonclick = "" ;
         edtUSU_CDA_Jsonclick = "" ;
         edtUSU_FEC_Jsonclick = "" ;
         edtUSU_CLA_Jsonclick = "" ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtavUsu_des_Jsonclick = "" ;
         subGrid_Class = "WorkWith" ;
         subGrid_Backcolorstyle = 3 ;
         edtUSU_DES_Link = "" ;
         edtavDelete_Link = "" ;
         edtavUpdate_Link = "" ;
         subGrid_Rows = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Work With ACT. USUARIOS" ;
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
         AV13USU_DES = "" ;
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
         edtUSU_FEC_Internalname = "" ;
         edtUSU_CDA_Internalname = "" ;
         edtUSU_EMP_Internalname = "" ;
         edtUSU_LEG_Internalname = "" ;
         edtUSU_INT_Internalname = "" ;
         edtUSU_CLAK_Internalname = "" ;
         edtUSU_MAIW_Internalname = "" ;
         edtUSU_TIPW_Internalname = "" ;
         edtUSU_NROW_Internalname = "" ;
         edtUSU_STS_Internalname = "" ;
         edtUSU_ACTIV_Internalname = "" ;
         edtUSU_ERR_Internalname = "" ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         A155USU_CLA = "" ;
         A156USU_FEC = DateTime.MinValue ;
         A250USU_CDA = "" ;
         A251USU_EMP = "" ;
         A180USU_INT = "" ;
         A253USU_CLAK = "" ;
         A249USU_MAIW = "" ;
         A254USU_TIPW = "" ;
         A257USU_ACTIV = (DateTime)(DateTime.MinValue) ;
         GridContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         lV13USU_DES = "" ;
         H000F2_A258USU_ERR = new short[1] ;
         H000F2_A257USU_ACTIV = new DateTime[] {DateTime.MinValue} ;
         H000F2_A256USU_STS = new short[1] ;
         H000F2_A255USU_NROW = new long[1] ;
         H000F2_A254USU_TIPW = new String[] {""} ;
         H000F2_A249USU_MAIW = new String[] {""} ;
         H000F2_n249USU_MAIW = new bool[] {false} ;
         H000F2_A253USU_CLAK = new String[] {""} ;
         H000F2_n253USU_CLAK = new bool[] {false} ;
         H000F2_A180USU_INT = new String[] {""} ;
         H000F2_A252USU_LEG = new int[1] ;
         H000F2_A251USU_EMP = new String[] {""} ;
         H000F2_A250USU_CDA = new String[] {""} ;
         H000F2_A156USU_FEC = new DateTime[] {DateTime.MinValue} ;
         H000F2_A155USU_CLA = new String[] {""} ;
         H000F2_A7USU_DES = new String[] {""} ;
         H000F2_A6USU_COD = new String[] {""} ;
         H000F3_AGRID_nRecordCount = new int[1] ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
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
         GXt_char16 = "" ;
         GridColumn = new GXWebColumn();
         GXt_char17 = "" ;
         lblFiltertextusu_des_Jsonclick = "" ;
         lblTableseparator_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         GridRow = new GXWebRow();
         ROClassString = "" ;
         GXt_char18 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwtseg002__default(),
            new Object[][] {
                new Object[] {
               H000F2_A258USU_ERR, H000F2_A257USU_ACTIV, H000F2_A256USU_STS, H000F2_A255USU_NROW, H000F2_A254USU_TIPW, H000F2_A249USU_MAIW, H000F2_n249USU_MAIW, H000F2_A253USU_CLAK, H000F2_n253USU_CLAK, H000F2_A180USU_INT,
               H000F2_A252USU_LEG, H000F2_A251USU_EMP, H000F2_A250USU_CDA, H000F2_A156USU_FEC, H000F2_A155USU_CLA, H000F2_A7USU_DES, H000F2_A6USU_COD
               }
               , new Object[] {
               H000F3_AGRID_nRecordCount
               }
            }
         );
         AV18Pgmname = "WWTSEG002" ;
         /* GeneXus formulas. */
         AV18Pgmname = "WWTSEG002" ;
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
      private short A256USU_STS ;
      private short A258USU_ERR ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Grid_PageSize26 ;
      private int GRID_nFirstRecordOnPage ;
      private int A252USU_LEG ;
      private int subGrid_Islastpage ;
      private int GRID_nCurrentRecord ;
      private int GRID_nRecordCount ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long A255USU_NROW ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_26_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String AV18Pgmname ;
      private String AV13USU_DES ;
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
      private String edtUSU_FEC_Internalname ;
      private String edtUSU_CDA_Internalname ;
      private String edtUSU_EMP_Internalname ;
      private String edtUSU_LEG_Internalname ;
      private String edtUSU_INT_Internalname ;
      private String edtUSU_CLAK_Internalname ;
      private String edtUSU_MAIW_Internalname ;
      private String edtUSU_TIPW_Internalname ;
      private String edtUSU_NROW_Internalname ;
      private String edtUSU_STS_Internalname ;
      private String edtUSU_ACTIV_Internalname ;
      private String edtUSU_ERR_Internalname ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A155USU_CLA ;
      private String A250USU_CDA ;
      private String A251USU_EMP ;
      private String A180USU_INT ;
      private String A253USU_CLAK ;
      private String A254USU_TIPW ;
      private String edtavUsu_des_Internalname ;
      private String scmdbuf ;
      private String lV13USU_DES ;
      private String edtavUpdate_Link ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String edtavDelete_Link ;
      private String edtUSU_DES_Link ;
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
      private String GXt_char16 ;
      private String GXt_char17 ;
      private String tblTablesearch_Internalname ;
      private String lblFiltertextusu_des_Internalname ;
      private String lblFiltertextusu_des_Jsonclick ;
      private String edtavUsu_des_Jsonclick ;
      private String lblTableseparator_Internalname ;
      private String lblTableseparator_Jsonclick ;
      private String ROClassString ;
      private String edtUSU_COD_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
      private String edtUSU_CLA_Jsonclick ;
      private String edtUSU_FEC_Jsonclick ;
      private String edtUSU_CDA_Jsonclick ;
      private String edtUSU_EMP_Jsonclick ;
      private String edtUSU_LEG_Jsonclick ;
      private String edtUSU_INT_Jsonclick ;
      private String edtUSU_CLAK_Jsonclick ;
      private String edtUSU_MAIW_Jsonclick ;
      private String edtUSU_TIPW_Jsonclick ;
      private String edtUSU_NROW_Jsonclick ;
      private String edtUSU_STS_Jsonclick ;
      private String edtUSU_ACTIV_Jsonclick ;
      private String edtUSU_ERR_Jsonclick ;
      private String GXt_char18 ;
      private DateTime A257USU_ACTIV ;
      private DateTime A156USU_FEC ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n253USU_CLAK ;
      private bool n249USU_MAIW ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A249USU_MAIW ;
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
      private short[] H000F2_A258USU_ERR ;
      private DateTime[] H000F2_A257USU_ACTIV ;
      private short[] H000F2_A256USU_STS ;
      private long[] H000F2_A255USU_NROW ;
      private String[] H000F2_A254USU_TIPW ;
      private String[] H000F2_A249USU_MAIW ;
      private bool[] H000F2_n249USU_MAIW ;
      private String[] H000F2_A253USU_CLAK ;
      private bool[] H000F2_n253USU_CLAK ;
      private String[] H000F2_A180USU_INT ;
      private int[] H000F2_A252USU_LEG ;
      private String[] H000F2_A251USU_EMP ;
      private String[] H000F2_A250USU_CDA ;
      private DateTime[] H000F2_A156USU_FEC ;
      private String[] H000F2_A155USU_CLA ;
      private String[] H000F2_A7USU_DES ;
      private String[] H000F2_A6USU_COD ;
      private int[] H000F3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXWebForm Form ;
      private SdtGridState AV9GridState ;
      private SdtGridState_FilterValue AV10GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwtseg002__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000F2( String AV13USU_DES ,
                                             String A7USU_DES ,
                                             String A251USU_EMP )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int19 ;
         GXv_int19 = new short [1] ;
         Object[] GXv_Object20 ;
         GXv_Object20 = new Object [2] ;
         scmdbuf = "SELECT [USU_ERR], [USU_ACTIV], [USU_STS], [USU_NROW], [USU_TIPW], [USU_MAIW], [USU_CLAK], [USU_INT], [USU_LEG], [USU_EMP], [USU_CDA], [USU_FEC], [USU_CLA], [USU_DES], [USU_COD] FROM [SEG002] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([USU_EMP] = 'INT')" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13USU_DES)) )
         {
            sWhereString = sWhereString + " and ([USU_DES] like @AV13USU_DES)" ;
         }
         else
         {
            GXv_int19[0] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [USU_DES]" ;
         GXv_Object20[0] = scmdbuf ;
         GXv_Object20[1] = (Object)(GXv_int19) ;
         return GXv_Object20 ;
      }

      protected Object[] conditional_H000F3( String AV13USU_DES ,
                                             String A7USU_DES ,
                                             String A251USU_EMP )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int21 ;
         GXv_int21 = new short [1] ;
         Object[] GXv_Object22 ;
         GXv_Object22 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [SEG002] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([USU_EMP] = 'INT')" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13USU_DES)) )
         {
            sWhereString = sWhereString + " and ([USU_DES] like @AV13USU_DES)" ;
         }
         else
         {
            GXv_int21[0] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
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
                     return conditional_H000F2( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
               case 1 :
                     return conditional_H000F3( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
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
          Object[] prmH000F2 ;
          prmH000F2 = new Object[] {
          new Object[] {"@AV13USU_DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmH000F3 ;
          prmH000F3 = new Object[] {
          new Object[] {"@AV13USU_DES",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F2,11,0,true,false )
             ,new CursorDef("H000F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F3,1,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 32) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getString(8, 10) ;
                ((int[]) buf[10])[0] = rslt.getInt(9) ;
                ((String[]) buf[11])[0] = rslt.getString(10, 3) ;
                ((String[]) buf[12])[0] = rslt.getString(11, 8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(12) ;
                ((String[]) buf[14])[0] = rslt.getString(13, 20) ;
                ((String[]) buf[15])[0] = rslt.getString(14, 50) ;
                ((String[]) buf[16])[0] = rslt.getString(15, 16) ;
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
                   stmt.SetParameter(sIdx, (String)parms[1]);
                }
                break;
             case 1 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[1]);
                }
                break;
       }
    }

 }

}
