/*
               File: WWTSEG003
        Description: Work With ACT. USUARIO/SISTEMA
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:26.61
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
   public class wwtseg003 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wwtseg003( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public wwtseg003( IGxContext context )
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
               AV18Pgmname = "WWTSEG003" ;
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
         PA0Q2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0Q2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wwtseg003.aspx") +"\" class=\""+"Form"+"\">") ;
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
            WE0Q2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0Q2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "WWTSEG003" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With ACT. USUARIO/SISTEMA" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwtseg003.aspx")  ;
      }

      protected void WB0Q0( )
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
            wb_table1_2_0Q2( true) ;
         }
         else
         {
            wb_table1_2_0Q2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0Q2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0Q2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Work With ACT. USUARIO/SISTEMA", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0Q0( ) ;
      }

      protected void WS0Q2( )
      {
         START0Q2( ) ;
         EVT0Q2( ) ;
      }

      protected void EVT0Q2( )
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
                              /* Execute user event: E110Q2 */
                              E110Q2 ();
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
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120Q2 */
                                    E120Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E130Q2 */
                                    E130Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E140Q2 */
                                    E140Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110Q2 */
                                    E110Q2 ();
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

      protected void WE0Q2( )
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

      protected void PA0Q2( )
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
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
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
         RF0Q2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF0Q2( ) ;
         /* End function Refresh */
      }

      protected void RF0Q2( )
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
         /* Execute user event: E130Q2 */
         E130Q2 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_26_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_26_idx ;
            edtUSU_CLA_Internalname = "USU_CLA_"+sGXsfl_26_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_26_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_26_idx ;
            lV13USU_DES = StringUtil.PadR( StringUtil.RTrim( AV13USU_DES), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USU_DES", AV13USU_DES);
            /* Using cursor H000Q2 */
            pr_default.execute(0, new Object[] {lV13USU_DES});
            nGXsfl_26_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A259SIS_DES = H000Q2_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A116SIS_COD = H000Q2_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A155USU_CLA = H000Q2_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
               A7USU_DES = H000Q2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = H000Q2_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A259SIS_DES = H000Q2_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A155USU_CLA = H000Q2_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
               A7USU_DES = H000Q2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               /* Execute user event: E140Q2 */
               E140Q2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 26 ;
            WB0Q0( ) ;
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
         lV13USU_DES = StringUtil.PadR( StringUtil.RTrim( AV13USU_DES), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USU_DES", AV13USU_DES);
         /* Using cursor H000Q3 */
         pr_default.execute(1, new Object[] {lV13USU_DES});
         GRID_nRecordCount = H000Q3_AGRID_nRecordCount[0] ;
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

      protected void STRUP0Q0( )
      {
         /* Before Start, stand alone formulas. */
         AV18Pgmname = "WWTSEG003" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E120Q2 */
         E120Q2 ();
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
         /* Execute user event: E120Q2 */
         E120Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E120Q2( )
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
         Form.Caption = "Trabajar con ACT. USUARIO/SISTEMAS" ;
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

      protected void E130Q2( )
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

      private void E140Q2( )
      {
         /* Grid_Load Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) ;
         edtavUpdate_Link = formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Link", edtavUpdate_Link);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) ;
         edtavDelete_Link = formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
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

      protected void E110Q2( )
      {
         /* 'DoInsert' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode("" +0) ;
         context.wjLoc = formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
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
         AV11TrnContext.gxTpr_Transactionname = "TSEG003" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV7Session.Set("TrnContext", AV11TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_0Q2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, 1, 1, 0, "Trabajar con ACT. USUARIO/SISTEMAS", "", "", "", 0, lblTitletext_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_0Q2( true) ;
         }
         else
         {
            wb_table2_8_0Q2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_0Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_19_0Q2( true) ;
         }
         else
         {
            wb_table3_19_0Q2( false) ;
         }
         return  ;
      }

      protected void wb_table3_19_0Q2e( bool wbgen )
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
            wb_table1_2_0Q2e( true) ;
         }
         else
         {
            wb_table1_2_0Q2e( false) ;
         }
      }

      protected void wb_table3_19_0Q2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, "E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_WWTSEG003.htm");
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
            wb_table3_19_0Q2e( true) ;
         }
         else
         {
            wb_table3_19_0Q2e( false) ;
         }
      }

      protected void wb_table2_8_0Q2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblFiltertextusu_des_Internalname, 1, 1, 0, "USUARIO", "", "", "", 0, lblFiltertextusu_des_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_26_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_des_Internalname, StringUtil.RTrim( AV13USU_DES), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV13USU_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtavUsu_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_WWTSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTableseparator_Internalname, 1, 1, 0, " ", "", "", "", 0, lblTableseparator_Jsonclick, "", StyleString, ClassString, "HLP_WWTSEG003.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_0Q2e( true) ;
         }
         else
         {
            wb_table2_8_0Q2e( false) ;
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
         PA0Q2( ) ;
         WS0Q2( ) ;
         WE0Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1182716");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("wwtseg003.js", "?1182716");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_262( )
      {
         WB0Q0( ) ;
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
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_COD_Jsonclick = "" ;
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
         Form.Caption = "Work With ACT. USUARIO/SISTEMA" ;
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
         edtSIS_COD_Internalname = "" ;
         edtSIS_DES_Internalname = "" ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         A155USU_CLA = "" ;
         A259SIS_DES = "" ;
         GridContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         lV13USU_DES = "" ;
         H000Q2_A259SIS_DES = new String[] {""} ;
         H000Q2_A116SIS_COD = new short[1] ;
         H000Q2_A155USU_CLA = new String[] {""} ;
         H000Q2_A7USU_DES = new String[] {""} ;
         H000Q2_A6USU_COD = new String[] {""} ;
         H000Q3_AGRID_nRecordCount = new int[1] ;
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
         GridColumn = new GXWebColumn();
         GXt_char7 = "" ;
         lblFiltertextusu_des_Jsonclick = "" ;
         lblTableseparator_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         GridRow = new GXWebRow();
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwtseg003__default(),
            new Object[][] {
                new Object[] {
               H000Q2_A259SIS_DES, H000Q2_A116SIS_COD, H000Q2_A155USU_CLA, H000Q2_A7USU_DES, H000Q2_A6USU_COD
               }
               , new Object[] {
               H000Q3_AGRID_nRecordCount
               }
            }
         );
         AV18Pgmname = "WWTSEG003" ;
         /* GeneXus formulas. */
         AV18Pgmname = "WWTSEG003" ;
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
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Grid_PageSize26 ;
      private int GRID_nFirstRecordOnPage ;
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
      private String edtSIS_COD_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A155USU_CLA ;
      private String A259SIS_DES ;
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
      private String edtSIS_COD_Jsonclick ;
      private String edtSIS_DES_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
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
      private String[] H000Q2_A259SIS_DES ;
      private short[] H000Q2_A116SIS_COD ;
      private String[] H000Q2_A155USU_CLA ;
      private String[] H000Q2_A7USU_DES ;
      private String[] H000Q2_A6USU_COD ;
      private int[] H000Q3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXWebForm Form ;
      private SdtGridState AV9GridState ;
      private SdtGridState_FilterValue AV10GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwtseg003__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000Q2 ;
          prmH000Q2 = new Object[] {
          new Object[] {"@AV13USU_DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmH000Q3 ;
          prmH000Q3 = new Object[] {
          new Object[] {"@AV13USU_DES",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000Q2", "SELECT T2.[SIS_DES], T1.[SIS_COD], T3.[USU_CLA], T3.[USU_DES], T1.[USU_COD] FROM (([SEG003] T1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = T1.[SIS_COD]) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T1.[USU_COD]) WHERE T3.[USU_DES] like @AV13USU_DES ORDER BY T1.[USU_COD], T1.[SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Q2,11,0,true,false )
             ,new CursorDef("H000Q3", "SELECT COUNT(*) FROM (([SEG003] T1 WITH (NOLOCK) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = T1.[SIS_COD]) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) WHERE T2.[USU_DES] like @AV13USU_DES ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Q3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 16) ;
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
