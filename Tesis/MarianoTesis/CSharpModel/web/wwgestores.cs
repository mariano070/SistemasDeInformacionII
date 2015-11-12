/*
               File: WWGESTORES
        Description: Work With Gestores
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:19:9.6
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
   public class wwgestores : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wwgestores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public wwgestores( IGxContext context )
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
               nGXsfl_24_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_24_idx = GetNextPar( ) ;
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
               gxnrGrid_newrow( nRC_Grid, nGXsfl_24_idx, sGXsfl_24_idx, AV15Delete, AV14Update) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               /* GeneXus formulas. */
               AV18Pgmname = "WWGESTORES" ;
               context.Gx_err = 0 ;
               Grid_PageSize24 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV13GestorDes = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13GestorDes", AV13GestorDes);
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
               gxgrGrid_refresh( Grid_PageSize24, AV13GestorDes, AV15Delete, AV14Update) ;
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
         PA0V2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0V2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wwgestores.aspx") +"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vGESTORDES", StringUtil.RTrim( AV13GestorDes));
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
            WE0V2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0V2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "WWGESTORES" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With Gestores" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwgestores.aspx")  ;
      }

      protected void WB0V0( )
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
            wb_table1_2_0V2( true) ;
         }
         else
         {
            wb_table1_2_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0V2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0V2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Work With Gestores", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0V0( ) ;
      }

      protected void WS0V2( )
      {
         START0V2( ) ;
         EVT0V2( ) ;
      }

      protected void EVT0V2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vGESTORDES"), AV13GestorDes) != 0 )
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
                              /* Execute user event: E110V2 */
                              E110V2 ();
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
                              nGXsfl_24_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_24_idx ;
                              edtavDelete_Internalname = "vDELETE_"+sGXsfl_24_idx ;
                              edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_24_idx ;
                              edtGestorDes_Internalname = "GESTORDES_"+sGXsfl_24_idx ;
                              AV14Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
                              AV15Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
                              A260GestorCod = StringUtil.Upper( cgiGet( edtGestorCod_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
                              A269GestorDes = StringUtil.Upper( cgiGet( edtGestorDes_Internalname)) ;
                              n269GestorDes = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120V2 */
                                    E120V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E130V2 */
                                    E130V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E140V2 */
                                    E140V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110V2 */
                                    E110V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Gestordes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vGESTORDES"), AV13GestorDes) != 0 )
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

      protected void WE0V2( )
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

      protected void PA0V2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavGestordes_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( short nRC_Grid ,
                                      short nGXsfl_24_idx ,
                                      String sGXsfl_24_idx ,
                                      String AV15Delete ,
                                      String AV14Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_24_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_24_idx ;
         edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_24_idx ;
         edtGestorDes_Internalname = "GESTORDES_"+sGXsfl_24_idx ;
         while ( nGXsfl_24_idx <= nRC_Grid )
         {
            sendrow_242( ) ;
            nGXsfl_24_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_24_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_24_idx ;
            edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_24_idx ;
            edtGestorDes_Internalname = "GESTORDES_"+sGXsfl_24_idx ;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int Grid_PageSize24 ,
                                       String AV13GestorDes ,
                                       String AV15Delete ,
                                       String AV14Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid_Rows = (short)(Grid_PageSize24) ;
         RF0V2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF0V2( ) ;
         /* End function Refresh */
      }

      protected void RF0V2( )
      {
         GridContainer.PageSize = subGrid_Recordsperpage( ) ;
         wbStart = 24 ;
         nGXsfl_24_idx = 1 ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_24_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_24_idx ;
         edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_24_idx ;
         edtGestorDes_Internalname = "GESTORDES_"+sGXsfl_24_idx ;
         /* Execute user event: E130V2 */
         E130V2 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_24_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_24_idx ;
            edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_24_idx ;
            edtGestorDes_Internalname = "GESTORDES_"+sGXsfl_24_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13GestorDes ,
                                                 A269GestorDes },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            });
            lV13GestorDes = StringUtil.PadR( StringUtil.RTrim( AV13GestorDes), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13GestorDes", AV13GestorDes);
            /* Using cursor H000V2 */
            pr_default.execute(0, new Object[] {lV13GestorDes});
            nGXsfl_24_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A260GestorCod = H000V2_A260GestorCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
               A269GestorDes = H000V2_A269GestorDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
               n269GestorDes = H000V2_n269GestorDes[0] ;
               A269GestorDes = H000V2_A269GestorDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269GestorDes", A269GestorDes);
               n269GestorDes = H000V2_n269GestorDes[0] ;
               if ( StringUtil.StrCmp(A260GestorCod, "DTRINCHIERI") == 0 )
               {
                  edtavDelete_Visible = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)));
               }
               else
               {
                  if ( StringUtil.StrCmp(A260GestorCod, "DTRINCHIERI") != 0 )
                  {
                     edtavDelete_Visible = 1 ;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)));
                  }
               }
               /* Execute user event: E140V2 */
               E140V2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 24 ;
            WB0V0( ) ;
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
                                              AV13GestorDes ,
                                              A269GestorDes },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         });
         lV13GestorDes = StringUtil.PadR( StringUtil.RTrim( AV13GestorDes), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13GestorDes", AV13GestorDes);
         /* Using cursor H000V3 */
         pr_default.execute(1, new Object[] {lV13GestorDes});
         GRID_nRecordCount = H000V3_AGRID_nRecordCount[0] ;
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

      protected void STRUP0V0( )
      {
         /* Before Start, stand alone formulas. */
         AV18Pgmname = "WWGESTORES" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E120V2 */
         E120V2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV13GestorDes = StringUtil.Upper( cgiGet( edtavGestordes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13GestorDes", AV13GestorDes);
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
         /* Execute user event: E120V2 */
         E120V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E120V2( )
      {
         /* Start Routine */
         lblSeteo_Caption = "<style><!--A:link {text-decoration: underline; color:#708090}A:visited {color:#708090}A:hover {text-decoration:bold; color:#008B8B}--></style>" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblSeteo_Internalname, "Caption", lblSeteo_Caption);
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

      protected void E130V2( )
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

      private void E140V2( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("gestores.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A260GestorCod)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Link", edtavUpdate_Link);
         edtavDelete_Link = formatLink("gestores.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A260GestorCod)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Link", edtavDelete_Link);
         edtGestorDes_Link = formatLink("viewgestores.aspx") + "?" + UrlEncode(StringUtil.RTrim(A260GestorCod)) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGestorDes_Internalname, "Link", edtGestorDes_Link);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 24 ;
         }
         if ( ( subGrid_Islastpage == 1 ) || ( subGrid_Rows == 0 ) || ( ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage ) && ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) )
         {
            sendrow_242( ) ;
         }
         GRID_nCurrentRecord = (int)(GRID_nCurrentRecord+1) ;
      }

      protected void E110V2( )
      {
         /* 'DoInsert' Routine */
         context.wjLoc = formatLink("gestores.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim("")) ;
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV8HTTPRequest.Method, "GET") == 0 )
         {
            AV9GridState.FromXml(AV7Session.Get(AV18Pgmname+"GridState"), "");
            if ( AV9GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV13GestorDes = ((SdtGridState_FilterValue)AV9GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13GestorDes", AV13GestorDes);
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
         AV10GridStateFilterValue.gxTpr_Value = AV13GestorDes ;
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
         AV11TrnContext.gxTpr_Transactionname = "GESTORES" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV7Session.Set("TrnContext", AV11TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_0V2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable_Internalname, tblTable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0V2( true) ;
         }
         else
         {
            wb_table2_5_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_0V2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_17_0V2( true) ;
         }
         else
         {
            wb_table3_17_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table3_17_0V2e( bool wbgen )
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
            wb_table1_2_0V2e( true) ;
         }
         else
         {
            wb_table1_2_0V2e( false) ;
         }
      }

      protected void wb_table3_17_0V2( bool wbgen )
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "PagingButtons" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, "E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_WWGESTORES.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"background:#4682B4; font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal; color:#FFFFFF"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"background:#4682B4; font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal; color:#FFFFFF"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"background:#4682B4; font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal; color:#FFFFFF"+"\" "+">") ;
               context.SendWebValue( "Cod Gestor ") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"background:#4682B4; font-family:'Tahoma'; font-size:8.0pt; font-weight:bold; font-style:normal; color:#FFFFFF"+"\" "+">") ;
               context.SendWebValue( "Gestor") ;
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
               GridContainer.AddObjectProperty("Titlebackcolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Titlebackcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Titlefont", StringUtil.RTrim( subGrid_Titlefont));
               GridContainer.AddObjectProperty("Titleforecolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Titleforecolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid_Linesfont));
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
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A260GestorCod));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A269GestorDes));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtGestorDes_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", "false");
               GridContainer.AddObjectProperty("Allowcollapsing", "false");
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 24 )
         {
            wbEnd = 0 ;
            nRC_Grid = (short)(nGXsfl_24_idx-1) ;
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
            wb_table3_17_0V2e( true) ;
         }
         else
         {
            wb_table3_17_0V2e( false) ;
         }
      }

      protected void wb_table2_5_0V2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(29), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(373), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTablesearch_Internalname, tblTablesearch_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblFiltertextgestordes_Internalname, 1, 1, 0, "Gestor", "", "", "", 0, lblFiltertextgestordes_Jsonclick, "", StyleString, ClassString, "HLP_WWGESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtavGestordes_Internalname, StringUtil.RTrim( AV13GestorDes), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV13GestorDes, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(10);\"", 0, edtavGestordes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_WWGESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTableseparator_Internalname, 1, 1, 0, " ", "", "", "", 0, lblTableseparator_Jsonclick, "", StyleString, ClassString, "HLP_WWGESTORES.htm");
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblSeteo_Internalname, 1, 1, 1, lblSeteo_Caption, "", "", "", 0, lblSeteo_Jsonclick, "", StyleString, ClassString, "HLP_WWGESTORES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0V2e( true) ;
         }
         else
         {
            wb_table2_5_0V2e( false) ;
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
         PA0V2( ) ;
         WS0V2( ) ;
         WE0V2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?1915234");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1919954");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("wwgestores.js", "?1919954");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_242( )
      {
         WB0V0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_24_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_24_idx) % (2)) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0) ;
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
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV14Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavUpdate_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV15Delete,(String)"Modern",(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavDelete_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGestorCod_Internalname,StringUtil.RTrim( A260GestorCod),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A260GestorCod, "@!")),(String)"",(short)0,(String)edtGestorCod_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGestorDes_Internalname,StringUtil.RTrim( A269GestorDes),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtGestorDes_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A269GestorDes, "@!")),(String)"",(short)0,(String)edtGestorDes_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            GridContainer.AddRow(GridRow);
            nGXsfl_24_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_24_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_24_idx ;
            edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_24_idx ;
            edtGestorDes_Internalname = "GESTORDES_"+sGXsfl_24_idx ;
         }
         /* End function sendrow_242 */
      }

      protected void init_default_properties( )
      {
         lblFiltertextgestordes_Internalname = "FILTERTEXTGESTORDES" ;
         edtavGestordes_Internalname = "vGESTORDES" ;
         lblTableseparator_Internalname = "TABLESEPARATOR" ;
         lblSeteo_Internalname = "SETEO" ;
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
         edtGestorDes_Jsonclick = "" ;
         edtGestorCod_Jsonclick = "" ;
         edtavGestordes_Jsonclick = "" ;
         subGrid_Linesfont = "font-family:Verdana;font-size:8pt;" ;
         subGrid_Titleforecolor = (int)(0xFFFFFF) ;
         subGrid_Titlefont = "font-family:Tahoma;font-size:8pt;font-weight:bold;" ;
         subGrid_Titlebackcolor = (int)(0x4682B4) ;
         edtavDelete_Visible = -1 ;
         subGrid_Class = "WorkWith" ;
         subGrid_Backcolorstyle = 2 ;
         edtGestorDes_Link = "" ;
         edtavDelete_Link = "" ;
         edtavUpdate_Link = "" ;
         lblSeteo_Caption = "seteo" ;
         subGrid_Rows = 10 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Work With Gestores" ;
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
         AV13GestorDes = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtGestorCod_Internalname = "" ;
         edtGestorDes_Internalname = "" ;
         A260GestorCod = "" ;
         A269GestorDes = "" ;
         GridContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         lV13GestorDes = "" ;
         H000V2_A260GestorCod = new String[] {""} ;
         H000V2_A269GestorDes = new String[] {""} ;
         H000V2_n269GestorDes = new bool[] {false} ;
         H000V3_AGRID_nRecordCount = new int[1] ;
         AV8HTTPRequest = new GxHttpRequest( context);
         AV9GridState = new SdtGridState(context);
         AV7Session = new GxWebSession( context);
         AV10GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11TrnContext = new SdtTransactionContext(context);
         sStyleString = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         imgInsert_Jsonclick = "" ;
         subGrid_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         GridColumn = new GXWebColumn();
         GXt_char4 = "" ;
         lblFiltertextgestordes_Jsonclick = "" ;
         lblTableseparator_Jsonclick = "" ;
         lblSeteo_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         GridRow = new GXWebRow();
         ROClassString = "" ;
         GXt_char5 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwgestores__default(),
            new Object[][] {
                new Object[] {
               H000V2_A260GestorCod, H000V2_A269GestorDes, H000V2_n269GestorDes
               }
               , new Object[] {
               H000V3_AGRID_nRecordCount
               }
            }
         );
         AV18Pgmname = "WWGESTORES" ;
         /* GeneXus formulas. */
         AV18Pgmname = "WWGESTORES" ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid ;
      private short nGXsfl_24_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID_nEOF ;
      private short subGrid_Rows ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Grid_PageSize24 ;
      private int GRID_nFirstRecordOnPage ;
      private int subGrid_Islastpage ;
      private int GRID_nCurrentRecord ;
      private int edtavDelete_Visible ;
      private int GRID_nRecordCount ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Titleforecolor ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_24_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String AV18Pgmname ;
      private String AV13GestorDes ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtGestorCod_Internalname ;
      private String edtGestorDes_Internalname ;
      private String A260GestorCod ;
      private String A269GestorDes ;
      private String edtavGestordes_Internalname ;
      private String scmdbuf ;
      private String lV13GestorDes ;
      private String lblSeteo_Caption ;
      private String lblSeteo_Internalname ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String edtGestorDes_Link ;
      private String sStyleString ;
      private String tblTable_Internalname ;
      private String tblTablegridcontainer_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String subGrid_Titlefont ;
      private String subGrid_Linesfont ;
      private String GXt_char4 ;
      private String tblTablesearch_Internalname ;
      private String lblFiltertextgestordes_Internalname ;
      private String lblFiltertextgestordes_Jsonclick ;
      private String edtavGestordes_Jsonclick ;
      private String lblTableseparator_Internalname ;
      private String lblTableseparator_Jsonclick ;
      private String lblSeteo_Jsonclick ;
      private String ROClassString ;
      private String edtGestorCod_Jsonclick ;
      private String edtGestorDes_Jsonclick ;
      private String GXt_char5 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n269GestorDes ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
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
      private String[] H000V2_A260GestorCod ;
      private String[] H000V2_A269GestorDes ;
      private bool[] H000V2_n269GestorDes ;
      private int[] H000V3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXWebForm Form ;
      private SdtGridState AV9GridState ;
      private SdtGridState_FilterValue AV10GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwgestores__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000V2( String AV13GestorDes ,
                                             String A269GestorDes )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [1] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT T1.[GestorCod] AS GestorCod, T2.[USU_DES] AS GestorDes FROM ([GESTORES] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[GestorCod])" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13GestorDes)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER(T2.[USU_DES]) like '%' + UPPER(@AV13GestorDes))" ;
            }
            else
            {
               sWhereString = sWhereString + " (UPPER(T2.[USU_DES]) like '%' + UPPER(@AV13GestorDes))" ;
            }
         }
         else
         {
            GXv_int6[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[GestorCod]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object7[0] = scmdbuf ;
         GXv_Object7[1] = (Object)(GXv_int6) ;
         return GXv_Object7 ;
      }

      protected Object[] conditional_H000V3( String AV13GestorDes ,
                                             String A269GestorDes )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [1] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([GESTORES] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[GestorCod])" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13GestorDes)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER(T2.[USU_DES]) like '%' + UPPER(@AV13GestorDes))" ;
            }
            else
            {
               sWhereString = sWhereString + " (UPPER(T2.[USU_DES]) like '%' + UPPER(@AV13GestorDes))" ;
            }
         }
         else
         {
            GXv_int8[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + "" ;
         GXv_Object9[0] = scmdbuf ;
         GXv_Object9[1] = (Object)(GXv_int8) ;
         return GXv_Object9 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000V2( (String)dynConstraints[0] , (String)dynConstraints[1] );
               case 1 :
                     return conditional_H000V3( (String)dynConstraints[0] , (String)dynConstraints[1] );
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
          Object[] prmH000V2 ;
          prmH000V2 = new Object[] {
          new Object[] {"@AV13GestorDes",SqlDbType.Char,50,0}
          } ;
          Object[] prmH000V3 ;
          prmH000V3 = new Object[] {
          new Object[] {"@AV13GestorDes",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000V2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000V2,11,0,true,false )
             ,new CursorDef("H000V3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000V3,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
