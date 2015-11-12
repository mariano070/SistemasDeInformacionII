/*
               File: Gx00H0
        Description: Selection List Gestores
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:29.42
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
   public class gx00h0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00h0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00h0( IGxContext context )
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

      public void execute( out String aP0_pGestorCod )
      {
         this.AV11pGestorCod = "" ;
         executePrivate();
         aP0_pGestorCod=this.AV11pGestorCod;
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
               nGXsfl_41_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_41_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_41_idx, sGXsfl_41_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize41 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cGestorCod = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cGestorCod", AV6cGestorCod);
               AV7cGestorRolCod = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cGestorRolCod), 4, 0)));
               AV8cGestorRolDes = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGestorRolDes", AV8cGestorRolDes);
               AV9cGestorRamoCod = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cGestorRamoCod), 2, 0)));
               AV10cGestorRamoDes = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cGestorRamoDes", AV10cGestorRamoDes);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize41, AV6cGestorCod, AV7cGestorRolCod, AV8cGestorRolDes, AV9cGestorRamoCod, AV10cGestorRamoDes) ;
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
               AV11pGestorCod = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pGestorCod", AV11pGestorCod);
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
         PA2L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2L2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00h0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11pGestorCod))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCGESTORCOD", StringUtil.RTrim( AV6cGestorCod));
         GxWebStd.gx_hidden_field( context, "GXH_vCGESTORROLCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cGestorRolCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCGESTORROLDES", StringUtil.RTrim( AV8cGestorRolDes));
         GxWebStd.gx_hidden_field( context, "GXH_vCGESTORRAMOCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cGestorRamoCod), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCGESTORRAMODES", StringUtil.RTrim( AV10cGestorRamoDes));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGESTORCOD", StringUtil.RTrim( AV11pGestorCod));
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
            WE2L2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2L2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00H0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Gestores" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00h0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11pGestorCod)) ;
      }

      protected void WB2L0( )
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
            wb_table1_2_2L2( true) ;
         }
         else
         {
            wb_table1_2_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2L2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2L2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List Gestores", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2L0( ) ;
      }

      protected void WS2L2( )
      {
         START2L2( ) ;
         EVT2L2( ) ;
      }

      protected void EVT2L2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGESTORCOD"), AV6cGestorCod) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGESTORROLCOD"), ",", ".") != Convert.ToDecimal( AV7cGestorRolCod )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGESTORROLDES"), AV8cGestorRolDes) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGESTORRAMOCOD"), ",", ".") != Convert.ToDecimal( AV9cGestorRamoCod )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGESTORRAMODES"), AV10cGestorRamoDes) != 0 )
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
                              nGXsfl_41_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
                              edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_41_idx ;
                              edtGestorRolCod_Internalname = "GESTORROLCOD_"+sGXsfl_41_idx ;
                              edtGestorRolDes_Internalname = "GESTORROLDES_"+sGXsfl_41_idx ;
                              edtGestorRamoCod_Internalname = "GESTORRAMOCOD_"+sGXsfl_41_idx ;
                              edtGestorRamoDes_Internalname = "GESTORRAMODES_"+sGXsfl_41_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A260GestorCod = StringUtil.Upper( cgiGet( edtGestorCod_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
                              A263GestorRolCod = (short)(context.localUtil.CToN( cgiGet( edtGestorRolCod_Internalname), ",", ".")) ;
                              n263GestorRolCod = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263GestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A263GestorRolCod), 4, 0)));
                              A261GestorRolDes = cgiGet( edtGestorRolDes_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261GestorRolDes", A261GestorRolDes);
                              A265GestorRamoCod = (short)(context.localUtil.CToN( cgiGet( edtGestorRamoCod_Internalname), ",", ".")) ;
                              n265GestorRamoCod = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265GestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A265GestorRamoCod), 2, 0)));
                              A267GestorRamoDes = cgiGet( edtGestorRamoDes_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267GestorRamoDes", A267GestorRamoDes);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112L2 */
                                    E112L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122L2 */
                                    E122L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cgestorcod Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGESTORCOD"), AV6cGestorCod) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgestorrolcod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGESTORROLCOD"), ",", ".") != Convert.ToDecimal( AV7cGestorRolCod )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgestorroldes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGESTORROLDES"), AV8cGestorRolDes) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgestorramocod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGESTORRAMOCOD"), ",", ".") != Convert.ToDecimal( AV9cGestorRamoCod )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgestorramodes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGESTORRAMODES"), AV10cGestorRamoDes) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132L2 */
                                          E132L2 ();
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

      protected void WE2L2( )
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

      protected void PA2L2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCgestorcod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_41_idx ,
                                       String sGXsfl_41_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_41_idx ;
         edtGestorRolCod_Internalname = "GESTORROLCOD_"+sGXsfl_41_idx ;
         edtGestorRolDes_Internalname = "GESTORROLDES_"+sGXsfl_41_idx ;
         edtGestorRamoCod_Internalname = "GESTORRAMOCOD_"+sGXsfl_41_idx ;
         edtGestorRamoDes_Internalname = "GESTORRAMODES_"+sGXsfl_41_idx ;
         while ( nGXsfl_41_idx <= nRC_Grid1 )
         {
            sendrow_412( ) ;
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_41_idx ;
            edtGestorRolCod_Internalname = "GESTORROLCOD_"+sGXsfl_41_idx ;
            edtGestorRolDes_Internalname = "GESTORROLDES_"+sGXsfl_41_idx ;
            edtGestorRamoCod_Internalname = "GESTORRAMOCOD_"+sGXsfl_41_idx ;
            edtGestorRamoDes_Internalname = "GESTORRAMODES_"+sGXsfl_41_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize41 ,
                                        String AV6cGestorCod ,
                                        short AV7cGestorRolCod ,
                                        String AV8cGestorRolDes ,
                                        short AV9cGestorRamoCod ,
                                        String AV10cGestorRamoDes )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize41) ;
         RF2L2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2L2( ) ;
         /* End function Refresh */
      }

      protected void RF2L2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 41 ;
         nGXsfl_41_idx = 1 ;
         sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_41_idx ;
         edtGestorRolCod_Internalname = "GESTORROLCOD_"+sGXsfl_41_idx ;
         edtGestorRolDes_Internalname = "GESTORROLDES_"+sGXsfl_41_idx ;
         edtGestorRamoCod_Internalname = "GESTORRAMOCOD_"+sGXsfl_41_idx ;
         edtGestorRamoDes_Internalname = "GESTORRAMODES_"+sGXsfl_41_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_41_idx ;
            edtGestorRolCod_Internalname = "GESTORROLCOD_"+sGXsfl_41_idx ;
            edtGestorRolDes_Internalname = "GESTORROLDES_"+sGXsfl_41_idx ;
            edtGestorRamoCod_Internalname = "GESTORRAMOCOD_"+sGXsfl_41_idx ;
            edtGestorRamoDes_Internalname = "GESTORRAMODES_"+sGXsfl_41_idx ;
            lV6cGestorCod = StringUtil.PadR( StringUtil.RTrim( AV6cGestorCod), 15, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cGestorCod", AV6cGestorCod);
            lV8cGestorRolDes = StringUtil.PadR( StringUtil.RTrim( AV8cGestorRolDes), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGestorRolDes", AV8cGestorRolDes);
            lV10cGestorRamoDes = StringUtil.PadR( StringUtil.RTrim( AV10cGestorRamoDes), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cGestorRamoDes", AV10cGestorRamoDes);
            /* Using cursor H002L2 */
            pr_default.execute(0, new Object[] {lV6cGestorCod, AV7cGestorRolCod, lV8cGestorRolDes, AV9cGestorRamoCod, lV10cGestorRamoDes});
            nGXsfl_41_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A267GestorRamoDes = H002L2_A267GestorRamoDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267GestorRamoDes", A267GestorRamoDes);
               A265GestorRamoCod = H002L2_A265GestorRamoCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265GestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A265GestorRamoCod), 2, 0)));
               n265GestorRamoCod = H002L2_n265GestorRamoCod[0] ;
               A261GestorRolDes = H002L2_A261GestorRolDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261GestorRolDes", A261GestorRolDes);
               A263GestorRolCod = H002L2_A263GestorRolCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263GestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A263GestorRolCod), 4, 0)));
               n263GestorRolCod = H002L2_n263GestorRolCod[0] ;
               A260GestorCod = H002L2_A260GestorCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260GestorCod", A260GestorCod);
               /* Execute user event: E122L2 */
               E122L2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 41 ;
            WB2L0( ) ;
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
         lV6cGestorCod = StringUtil.PadR( StringUtil.RTrim( AV6cGestorCod), 15, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cGestorCod", AV6cGestorCod);
         lV8cGestorRolDes = StringUtil.PadR( StringUtil.RTrim( AV8cGestorRolDes), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGestorRolDes", AV8cGestorRolDes);
         lV10cGestorRamoDes = StringUtil.PadR( StringUtil.RTrim( AV10cGestorRamoDes), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cGestorRamoDes", AV10cGestorRamoDes);
         /* Using cursor H002L3 */
         pr_default.execute(1, new Object[] {lV6cGestorCod, AV7cGestorRolCod, lV8cGestorRolDes, AV9cGestorRamoCod, lV10cGestorRamoDes});
         GRID1_nRecordCount = H002L3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112L2 */
         E112L2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cGestorCod = StringUtil.Upper( cgiGet( edtavCgestorcod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cGestorCod", AV6cGestorCod);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCgestorrolcod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCgestorrolcod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCgestorrolcod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCGESTORROLCOD");
               GX_FocusControl = edtavCgestorrolcod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cGestorRolCod = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cGestorRolCod), 4, 0)));
            }
            else
            {
               AV7cGestorRolCod = (short)(context.localUtil.CToN( cgiGet( edtavCgestorrolcod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGestorRolCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cGestorRolCod), 4, 0)));
            }
            AV8cGestorRolDes = cgiGet( edtavCgestorroldes_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cGestorRolDes", AV8cGestorRolDes);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCgestorramocod_Internalname), "Z9") || ( context.localUtil.CToN( cgiGet( edtavCgestorramocod_Internalname), ",", ".") < Convert.ToDecimal( -9 )) || ( ( context.localUtil.CToN( cgiGet( edtavCgestorramocod_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCGESTORRAMOCOD");
               GX_FocusControl = edtavCgestorramocod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cGestorRamoCod = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cGestorRamoCod), 2, 0)));
            }
            else
            {
               AV9cGestorRamoCod = (short)(context.localUtil.CToN( cgiGet( edtavCgestorramocod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cGestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cGestorRamoCod), 2, 0)));
            }
            AV10cGestorRamoDes = cgiGet( edtavCgestorramodes_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cGestorRamoDes", AV10cGestorRamoDes);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV11pGestorCod = cgiGet( "vPGESTORCOD") ;
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
         /* Execute user event: E112L2 */
         E112L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112L2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Gestores", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122L2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_412( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E132L2 */
         E132L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132L2( )
      {
         /* Enter Routine */
         AV11pGestorCod = A260GestorCod ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pGestorCod", AV11pGestorCod);
         context.setWebReturnParms(new Object[] {(String)AV11pGestorCod});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2L2( bool wbgen )
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
            wb_table2_9_2L2( true) ;
         }
         else
         {
            wb_table2_9_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2L2e( bool wbgen )
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
            wb_table3_38_2L2( true) ;
         }
         else
         {
            wb_table3_38_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table3_38_2L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2L2e( true) ;
         }
         else
         {
            wb_table1_2_2L2e( false) ;
         }
      }

      protected void wb_table3_38_2L2( bool wbgen )
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
               context.SendWebValue( "Gestor ") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Rol Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Rol") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ramo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ramo") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A260GestorCod));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A263GestorRolCod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A261GestorRolDes));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A265GestorRamoCod), 2, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A267GestorRamoDes));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 41 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_41_idx-1) ;
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
            wb_table4_50_2L2( true) ;
         }
         else
         {
            wb_table4_50_2L2( false) ;
         }
         return  ;
      }

      protected void wb_table4_50_2L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_38_2L2e( true) ;
         }
         else
         {
            wb_table3_38_2L2e( false) ;
         }
      }

      protected void wb_table4_50_2L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(41), 3, 0)+","+"null"+");", "", "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_50_2L2e( true) ;
         }
         else
         {
            wb_table4_50_2L2e( false) ;
         }
      }

      protected void wb_table2_9_2L2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockgestorcod_Internalname, 1, 1, 0, "Cod Gestor ", "", "", "", 0, lblTextblockgestorcod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgestorcod_Internalname, StringUtil.RTrim( AV6cGestorCod), "", 15, "chr", 1, "row", 15, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6cGestorCod, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(14);\"", 0, edtavCgestorcod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestorrolcod_Internalname, 1, 1, 0, "Gestor Rol Cod", "", "", "", 0, lblTextblockgestorrolcod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgestorrolcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cGestorRolCod), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cGestorRolCod), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCgestorrolcod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestorroldes_Internalname, 1, 1, 0, "Rol", "", "", "", 0, lblTextblockgestorroldes_Jsonclick, "", StyleString, ClassString, "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgestorroldes_Internalname, StringUtil.RTrim( AV8cGestorRolDes), "", 20, "chr", 1, "row", 20, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cGestorRolDes, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCgestorroldes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestorramocod_Internalname, 1, 1, 0, "Cod Ramo", "", "", "", 0, lblTextblockgestorramocod_Jsonclick, "", StyleString, ClassString, "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgestorramocod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cGestorRamoCod), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9cGestorRamoCod), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", 0, edtavCgestorramocod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestorramodes_Internalname, 1, 1, 0, "Ramo", "", "", "", 0, lblTextblockgestorramodes_Jsonclick, "", StyleString, ClassString, "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgestorramodes_Internalname, StringUtil.RTrim( AV10cGestorRamoDes), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10cGestorRamoDes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavCgestorramodes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00H0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2L2e( true) ;
         }
         else
         {
            wb_table2_9_2L2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11pGestorCod = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pGestorCod", AV11pGestorCod);
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
         PA2L2( ) ;
         WS2L2( ) ;
         WE2L2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19172997");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00h0.js", "?19172997");
         /* End function include_jscripts */
      }

      protected void sendrow_412( )
      {
         WB2L0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_41_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_41_idx) % (2)) == 0 )
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A260GestorCod))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGestorCod_Internalname,StringUtil.RTrim( A260GestorCod),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A260GestorCod, "@!")),(String)"",(short)0,(String)edtGestorCod_Jsonclick,(String)"",(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGestorRolCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A263GestorRolCod), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A263GestorRolCod), "ZZZ9"),(String)"",(short)0,(String)edtGestorRolCod_Jsonclick,(String)"",(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGestorRolDes_Internalname,StringUtil.RTrim( A261GestorRolDes),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A261GestorRolDes, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtGestorRolDes_Jsonclick,(String)"",(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGestorRamoCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A265GestorRamoCod), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A265GestorRamoCod), "Z9"),(String)"",(short)0,(String)edtGestorRamoCod_Jsonclick,(String)"",(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGestorRamoDes_Internalname,StringUtil.RTrim( A267GestorRamoDes),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A267GestorRamoDes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtGestorRamoDes_Jsonclick,(String)"",(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtGestorCod_Internalname = "GESTORCOD_"+sGXsfl_41_idx ;
            edtGestorRolCod_Internalname = "GESTORROLCOD_"+sGXsfl_41_idx ;
            edtGestorRolDes_Internalname = "GESTORROLDES_"+sGXsfl_41_idx ;
            edtGestorRamoCod_Internalname = "GESTORRAMOCOD_"+sGXsfl_41_idx ;
            edtGestorRamoDes_Internalname = "GESTORRAMODES_"+sGXsfl_41_idx ;
         }
         /* End function sendrow_412 */
      }

      protected void init_default_properties( )
      {
         lblTextblockgestorcod_Internalname = "TEXTBLOCKGESTORCOD" ;
         edtavCgestorcod_Internalname = "vCGESTORCOD" ;
         lblTextblockgestorrolcod_Internalname = "TEXTBLOCKGESTORROLCOD" ;
         edtavCgestorrolcod_Internalname = "vCGESTORROLCOD" ;
         lblTextblockgestorroldes_Internalname = "TEXTBLOCKGESTORROLDES" ;
         edtavCgestorroldes_Internalname = "vCGESTORROLDES" ;
         lblTextblockgestorramocod_Internalname = "TEXTBLOCKGESTORRAMOCOD" ;
         edtavCgestorramocod_Internalname = "vCGESTORRAMOCOD" ;
         lblTextblockgestorramodes_Internalname = "TEXTBLOCKGESTORRAMODES" ;
         edtavCgestorramodes_Internalname = "vCGESTORRAMODES" ;
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
         edtGestorRamoDes_Jsonclick = "" ;
         edtGestorRamoCod_Jsonclick = "" ;
         edtGestorRolDes_Jsonclick = "" ;
         edtGestorRolCod_Jsonclick = "" ;
         edtGestorCod_Jsonclick = "" ;
         edtavCgestorramodes_Jsonclick = "" ;
         edtavCgestorramocod_Jsonclick = "" ;
         edtavCgestorroldes_Jsonclick = "" ;
         edtavCgestorrolcod_Jsonclick = "" ;
         edtavCgestorcod_Jsonclick = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Gestores" ;
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
         AV6cGestorCod = "" ;
         AV8cGestorRolDes = "" ;
         AV10cGestorRamoDes = "" ;
         AV11pGestorCod = "" ;
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
         edtGestorCod_Internalname = "" ;
         edtGestorRolCod_Internalname = "" ;
         edtGestorRolDes_Internalname = "" ;
         edtGestorRamoCod_Internalname = "" ;
         edtGestorRamoDes_Internalname = "" ;
         AV5LinkSelection = "" ;
         A260GestorCod = "" ;
         A261GestorRolDes = "" ;
         A267GestorRamoDes = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cGestorCod = "" ;
         lV8cGestorRolDes = "" ;
         lV10cGestorRamoDes = "" ;
         H002L2_A267GestorRamoDes = new String[] {""} ;
         H002L2_A265GestorRamoCod = new short[1] ;
         H002L2_n265GestorRamoCod = new bool[] {false} ;
         H002L2_A261GestorRolDes = new String[] {""} ;
         H002L2_A263GestorRolCod = new short[1] ;
         H002L2_n263GestorRolCod = new bool[] {false} ;
         H002L2_A260GestorCod = new String[] {""} ;
         H002L3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockgestorcod_Jsonclick = "" ;
         lblTextblockgestorrolcod_Jsonclick = "" ;
         lblTextblockgestorroldes_Jsonclick = "" ;
         lblTextblockgestorramocod_Jsonclick = "" ;
         lblTextblockgestorramodes_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00h0__default(),
            new Object[][] {
                new Object[] {
               H002L2_A267GestorRamoDes, H002L2_A265GestorRamoCod, H002L2_n265GestorRamoCod, H002L2_A261GestorRolDes, H002L2_A263GestorRolCod, H002L2_n263GestorRolCod, H002L2_A260GestorCod
               }
               , new Object[] {
               H002L3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_41_idx=1 ;
      private short AV7cGestorRolCod ;
      private short AV9cGestorRamoCod ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A263GestorRolCod ;
      private short A265GestorRamoCod ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize41 ;
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
      private String sGXsfl_41_idx="0001" ;
      private String AV6cGestorCod ;
      private String AV8cGestorRolDes ;
      private String AV10cGestorRamoDes ;
      private String AV11pGestorCod ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtGestorCod_Internalname ;
      private String edtGestorRolCod_Internalname ;
      private String edtGestorRolDes_Internalname ;
      private String edtGestorRamoCod_Internalname ;
      private String edtGestorRamoDes_Internalname ;
      private String A260GestorCod ;
      private String A261GestorRolDes ;
      private String A267GestorRamoDes ;
      private String edtavCgestorcod_Internalname ;
      private String scmdbuf ;
      private String lV6cGestorCod ;
      private String lV8cGestorRolDes ;
      private String lV10cGestorRamoDes ;
      private String edtavCgestorrolcod_Internalname ;
      private String edtavCgestorroldes_Internalname ;
      private String edtavCgestorramocod_Internalname ;
      private String edtavCgestorramodes_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockgestorcod_Internalname ;
      private String lblTextblockgestorcod_Jsonclick ;
      private String edtavCgestorcod_Jsonclick ;
      private String lblTextblockgestorrolcod_Internalname ;
      private String lblTextblockgestorrolcod_Jsonclick ;
      private String edtavCgestorrolcod_Jsonclick ;
      private String lblTextblockgestorroldes_Internalname ;
      private String lblTextblockgestorroldes_Jsonclick ;
      private String edtavCgestorroldes_Jsonclick ;
      private String lblTextblockgestorramocod_Internalname ;
      private String lblTextblockgestorramocod_Jsonclick ;
      private String edtavCgestorramocod_Jsonclick ;
      private String lblTextblockgestorramodes_Internalname ;
      private String lblTextblockgestorramodes_Jsonclick ;
      private String edtavCgestorramodes_Jsonclick ;
      private String ROClassString ;
      private String edtGestorCod_Jsonclick ;
      private String edtGestorRolCod_Jsonclick ;
      private String edtGestorRolDes_Jsonclick ;
      private String edtGestorRamoCod_Jsonclick ;
      private String edtGestorRamoDes_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n263GestorRolCod ;
      private bool n265GestorRamoCod ;
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
      private String[] H002L2_A267GestorRamoDes ;
      private short[] H002L2_A265GestorRamoCod ;
      private bool[] H002L2_n265GestorRamoCod ;
      private String[] H002L2_A261GestorRolDes ;
      private short[] H002L2_A263GestorRolCod ;
      private bool[] H002L2_n263GestorRolCod ;
      private String[] H002L2_A260GestorCod ;
      private int[] H002L3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pGestorCod ;
      private GXWebForm Form ;
   }

   public class gx00h0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002L2 ;
          prmH002L2 = new Object[] {
          new Object[] {"@AV6cGestorCod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV7cGestorRolCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cGestorRolDes",SqlDbType.Char,20,0} ,
          new Object[] {"@AV9cGestorRamoCod",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10cGestorRamoDes",SqlDbType.Char,30,0}
          } ;
          Object[] prmH002L3 ;
          prmH002L3 = new Object[] {
          new Object[] {"@AV6cGestorCod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV7cGestorRolCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cGestorRolDes",SqlDbType.Char,20,0} ,
          new Object[] {"@AV9cGestorRamoCod",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10cGestorRamoDes",SqlDbType.Char,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002L2", "SELECT [GestorRamoDes], [GestorRamoCod], [GestorRolDes], [GestorRolCod], [GestorCod] FROM [GESTORES] WITH (NOLOCK) WHERE ([GestorCod] like @AV6cGestorCod) AND ([GestorRolCod] >= @AV7cGestorRolCod) AND ([GestorRolDes] like @AV8cGestorRolDes) AND ([GestorRamoCod] >= @AV9cGestorRamoCod) AND ([GestorRamoDes] like @AV10cGestorRamoDes) ORDER BY [GestorCod]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002L2,11,0,false,false )
             ,new CursorDef("H002L3", "SELECT COUNT(*) FROM [GESTORES] WITH (NOLOCK) WHERE ([GestorCod] like @AV6cGestorCod) AND ([GestorRolCod] >= @AV7cGestorRolCod) AND ([GestorRolDes] like @AV8cGestorRolDes) AND ([GestorRamoCod] >= @AV9cGestorRamoCod) AND ([GestorRamoDes] like @AV10cGestorRamoDes) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002L3,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 15) ;
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
       }
    }

 }

}
