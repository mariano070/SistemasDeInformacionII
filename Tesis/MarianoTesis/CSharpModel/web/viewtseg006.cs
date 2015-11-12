/*
               File: ViewTSEG006
        Description: View TSEG006
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:20:22.50
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
   public class viewtseg006 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public viewtseg006( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public viewtseg006( IGxContext context )
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

      public void execute( String aP0_USU_COD ,
                           short aP1_SIS_COD ,
                           short aP2_PRG_COD ,
                           int aP3_PRS_NRO ,
                           String aP4_TabCode )
      {
         this.AV11USU_COD = aP0_USU_COD;
         this.AV12SIS_COD = aP1_SIS_COD;
         this.AV13PRG_COD = aP2_PRG_COD;
         this.AV14PRS_NRO = aP3_PRS_NRO;
         this.AV7TabCode = aP4_TabCode;
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
               AV11USU_COD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USU_COD", AV11USU_COD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV12SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12SIS_COD), 3, 0)));
                  AV13PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PRG_COD), 4, 0)));
                  AV14PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14PRS_NRO), 8, 0)));
                  AV7TabCode = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TabCode", AV7TabCode);
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
         PA432( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START432( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("viewtseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode("" +AV12SIS_COD) + "," + UrlEncode("" +AV13PRG_COD) + "," + UrlEncode("" +AV14PRS_NRO) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vUSU_COD", StringUtil.RTrim( AV11USU_COD));
         GxWebStd.gx_hidden_field( context, "vSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14PRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV7TabCode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         if ( ! ( WebComp_Tabbedview == null ) )
         {
            WebComp_Tabbedview.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE432( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT432( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "ViewTSEG006" ;
      }

      public override String GetPgmdesc( )
      {
         return "View TSEG006" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("viewtseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode("" +AV12SIS_COD) + "," + UrlEncode("" +AV13PRG_COD) + "," + UrlEncode("" +AV14PRS_NRO) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode)) ;
      }

      protected void WB430( )
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
            wb_table1_2_432( true) ;
         }
         else
         {
            wb_table1_2_432( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_432e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START432( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "View TSEG006", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldTabbedview = cgiGet( "W0022") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Tabbedview_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldTabbedview)) )
            {
               WebComp_Tabbedview = getWebComponent(GetType(), "GeneXus.Programs", OldTabbedview, new Object[] {context} );
               WebComp_Tabbedview.ComponentInit();
               WebComp_Tabbedview.Name = "OldTabbedview";
               WebComp_Tabbedview_Component = OldTabbedview ;
               WebComp_Tabbedview.componentrestorestate("W0022", "");
            }
         }
         wbErr = false ;
         STRUP430( ) ;
      }

      protected void WS432( )
      {
         START432( ) ;
         EVT432( ) ;
      }

      protected void EVT432( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11432 */
                              E11432 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12432 */
                              E12432 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4) ;
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                        if ( nCmpId == 22 )
                        {
                           OldTabbedview = cgiGet( "W0022") ;
                           if ( ( StringUtil.Len( OldTabbedview) == 0 ) || ( StringUtil.StrCmp(OldTabbedview, WebComp_Tabbedview_Component) != 0 ) )
                           {
                              WebComp_Tabbedview = getWebComponent(GetType(), "GeneXus.Programs", OldTabbedview, new Object[] {context} );
                              WebComp_Tabbedview.ComponentInit();
                              WebComp_Tabbedview.Name = "OldTabbedview";
                              WebComp_Tabbedview_Component = OldTabbedview ;
                           }
                           if ( StringUtil.Len( WebComp_Tabbedview_Component) != 0 )
                           {
                              WebComp_Tabbedview.componentprocess("W0022", "", sEvt);
                           }
                           WebComp_Tabbedview_Component = OldTabbedview ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE432( )
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

      protected void PA432( )
      {
         if ( nDonePA == 0 )
         {
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF432( ) ;
         /* End function Refresh */
      }

      protected void RF432( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Tabbedview_Component) != 0 )
               {
                  WebComp_Tabbedview.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00432 */
            pr_default.execute(0, new Object[] {AV11USU_COD, AV12SIS_COD, AV13PRG_COD, AV14PRS_NRO});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A118PRS_NRO = H00432_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               A126PRG_COD = H00432_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A116SIS_COD = H00432_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A6USU_COD = H00432_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A166PRS_INI = H00432_A166PRS_INI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               /* Execute user event: E12432 */
               E12432 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB430( ) ;
         }
      }

      protected void STRUP430( )
      {
         /* Before Start, stand alone formulas. */
         AV17Pgmname = "ViewTSEG006" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11432 */
         E11432 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A166PRS_INI = context.localUtil.CToT( cgiGet( edtPRS_INI_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            /* Read saved values. */
            AV11USU_COD = cgiGet( "vUSU_COD") ;
            AV12SIS_COD = (short)(context.localUtil.CToN( cgiGet( "vSIS_COD"), ",", ".")) ;
            AV13PRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPRG_COD"), ",", ".")) ;
            AV14PRS_NRO = (int)(context.localUtil.CToN( cgiGet( "vPRS_NRO"), ",", ".")) ;
            AV7TabCode = cgiGet( "vTABCODE") ;
            OldTabbedview = cgiGet( "W0022") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Tabbedview_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldTabbedview)) )
            {
               WebComp_Tabbedview = getWebComponent(GetType(), "GeneXus.Programs", OldTabbedview, new Object[] {context} );
               WebComp_Tabbedview.ComponentInit();
               WebComp_Tabbedview.Name = "OldTabbedview";
               WebComp_Tabbedview_Component = OldTabbedview ;
               WebComp_Tabbedview.componentrestorestate("W0022", "");
            }
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
         /* Execute user event: E11432 */
         E11432 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11432( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV17Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)) ;
         }
         lblViewall_Link = formatLink("wwtseg006.aspx")  ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblViewall_Internalname, "Link", lblViewall_Link);
         AV18GXLvl8 = 0 ;
         /* Using cursor H00433 */
         pr_default.execute(1, new Object[] {AV11USU_COD, AV12SIS_COD, AV13PRG_COD, AV14PRS_NRO});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A118PRS_NRO = H00433_A118PRS_NRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            A126PRG_COD = H00433_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A116SIS_COD = H00433_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A6USU_COD = H00433_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A166PRS_INI = H00433_A166PRS_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            AV18GXLvl8 = 1 ;
            Form.Caption = context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " ") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
            AV10Exists = true ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( AV18GXLvl8 == 0 )
         {
            Form.Caption = "Record not found" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
            AV10Exists = false ;
         }
         if ( AV10Exists )
         {
            /* Execute user subroutine: S112 */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            /* Object Property */
            if ( StringUtil.StrCmp(WebComp_Tabbedview_Component, "TabbedView") != 0 )
            {
               WebComp_Tabbedview = getWebComponent(GetType(), "GeneXus.Programs", "tabbedview", new Object[] {context} );
               WebComp_Tabbedview.ComponentInit();
               WebComp_Tabbedview.Name = "TabbedView";
               WebComp_Tabbedview_Component = "TabbedView" ;
            }
            if ( StringUtil.StrCmp(OldTabbedview, WebComp_Tabbedview_Component) != 0 )
            {
               WebComp_Tabbedview.setjustcreated();
            }
            if ( StringUtil.Len( WebComp_Tabbedview_Component) != 0 )
            {
               WebComp_Tabbedview.componentprepare(new Object[] {(String)"W0022",(String)"",(IGxCollection)AV8Tabs,(String)AV7TabCode});
               WebComp_Tabbedview.componentbind(new Object[] {(String)"",(String)""});
            }
         }
      }

      protected void S112( )
      {
         /* 'LOADTABS' Routine */
         AV8Tabs = new GxObjectCollection( context, "TabOptions.TabOptionsItem", "MarianoTesis", "SdtTabOptions_TabOptionsItem", "GeneXus.Programs") ;
         AV9Tab = new SdtTabOptions_TabOptionsItem(context) ;
         AV9Tab.gxTpr_Code = "General" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Description = "General" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg006general.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode("" +AV12SIS_COD) + "," + UrlEncode("" +AV13PRG_COD) + "," + UrlEncode("" +AV14PRS_NRO) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode("" +AV12SIS_COD) + "," + UrlEncode("" +AV13PRG_COD) + "," + UrlEncode("" +AV14PRS_NRO) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
         AV9Tab = new SdtTabOptions_TabOptionsItem(context) ;
         AV9Tab.gxTpr_Code = "TSEG007" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Description = "PROGRAMAS ACCEDIDOS POR SESION" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg006tseg007wc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode("" +AV12SIS_COD) + "," + UrlEncode("" +AV13PRG_COD) + "," + UrlEncode("" +AV14PRS_NRO) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode("" +AV12SIS_COD) + "," + UrlEncode("" +AV13PRG_COD) + "," + UrlEncode("" +AV14PRS_NRO) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
      }

      protected void nextLoad( )
      {
      }

      protected void E12432( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_432( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblViewtable_Internalname, tblViewtable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_432( true) ;
         }
         else
         {
            wb_table2_5_432( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_432e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_13_432( true) ;
         }
         else
         {
            wb_table3_13_432( false) ;
         }
         return  ;
      }

      protected void wb_table3_13_432e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblSpaceseparator_Internalname, 1, 1, 0, "", "", "", "", 0, lblSpaceseparator_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr valign=\"bottom\" >") ;
            context.WriteHtmlText( "<td>") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0022"+"", StringUtil.RTrim( WebComp_Tabbedview_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0022"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Tabbedview_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldTabbedview, WebComp_Tabbedview_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0022"+"");
               }
               WebComp_Tabbedview.componentdraw();
               if ( StringUtil.StrCmp(OldTabbedview, WebComp_Tabbedview_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_432e( true) ;
         }
         else
         {
            wb_table1_2_432e( false) ;
         }
      }

      protected void wb_table3_13_432( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "Label" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblFixtextprs_ini_Internalname, 1, 1, 0, "MOMENTO DE INICIO SESION", "", "", "", 0, lblFixtextprs_ini_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRS_INI_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRS_INI_Internalname, context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A166PRS_INI, "99/99/99 99:99"), "", 0, edtPRS_INI_Jsonclick, "", 0, 1, 1, true, "right", "HLP_ViewTSEG006.htm");
            GxWebStd.gx_bitmap( context, edtPRS_INI_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_ViewTSEG006.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_13_432e( true) ;
         }
         else
         {
            wb_table3_13_432e( false) ;
         }
      }

      protected void wb_table2_5_432( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTitletable_Internalname, tblTitletable_Internalname, "", "Table100x100", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblViewtitle_Internalname, 1, 1, 0, "SESIONES POR USUARIO Information", "", "", "", 0, lblViewtitle_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" colspan=\"1\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblViewall_Internalname, 1, 1, 0, "Work With SESIONES POR USUARIOS", "", lblViewall_Link, "", 0, lblViewall_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_432e( true) ;
         }
         else
         {
            wb_table2_5_432e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11USU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USU_COD", AV11USU_COD);
         AV12SIS_COD = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12SIS_COD), 3, 0)));
         AV13PRG_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PRG_COD), 4, 0)));
         AV14PRS_NRO = Convert.ToInt32(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14PRS_NRO), 8, 0)));
         AV7TabCode = (String)getParm(obj,4) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TabCode", AV7TabCode);
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
         PA432( ) ;
         WS432( ) ;
         WE432( ) ;
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
         if ( ! ( WebComp_Tabbedview == null ) )
         {
            if ( StringUtil.Len( WebComp_Tabbedview_Component) != 0 )
            {
               WebComp_Tabbedview.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11202290");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("viewtseg006.js", "?11202290");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblViewtitle_Internalname = "VIEWTITLE" ;
         lblViewall_Internalname = "VIEWALL" ;
         tblTitletable_Internalname = "TITLETABLE" ;
         lblFixtextprs_ini_Internalname = "FIXTEXTPRS_INI" ;
         edtPRS_INI_Internalname = "PRS_INI" ;
         tblTable1_Internalname = "TABLE1" ;
         lblSpaceseparator_Internalname = "SPACESEPARATOR" ;
         tblViewtable_Internalname = "VIEWTABLE" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         lblViewall_Link = "" ;
         edtPRS_INI_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "View TSEG006" ;
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
         wcpOAV11USU_COD = "" ;
         wcpOAV7TabCode = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         OldTabbedview = "" ;
         WebComp_Tabbedview_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         scmdbuf = "" ;
         H00432_A118PRS_NRO = new int[1] ;
         H00432_A126PRG_COD = new short[1] ;
         H00432_A116SIS_COD = new short[1] ;
         H00432_A6USU_COD = new String[] {""} ;
         H00432_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         A6USU_COD = "" ;
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         AV17Pgmname = "" ;
         H00433_A118PRS_NRO = new int[1] ;
         H00433_A126PRG_COD = new short[1] ;
         H00433_A116SIS_COD = new short[1] ;
         H00433_A6USU_COD = new String[] {""} ;
         H00433_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         AV8Tabs = new GxObjectCollection( context, "TabOptions.TabOptionsItem", "MarianoTesis", "SdtTabOptions_TabOptionsItem", "GeneXus.Programs");
         AV9Tab = new SdtTabOptions_TabOptionsItem(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblSpaceseparator_Jsonclick = "" ;
         lblFixtextprs_ini_Jsonclick = "" ;
         GXt_char2 = "" ;
         lblViewtitle_Jsonclick = "" ;
         GXt_char3 = "" ;
         lblViewall_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.viewtseg006__default(),
            new Object[][] {
                new Object[] {
               H00432_A118PRS_NRO, H00432_A126PRG_COD, H00432_A116SIS_COD, H00432_A6USU_COD, H00432_A166PRS_INI
               }
               , new Object[] {
               H00433_A118PRS_NRO, H00433_A126PRG_COD, H00433_A116SIS_COD, H00433_A6USU_COD, H00433_A166PRS_INI
               }
            }
         );
         WebComp_Tabbedview = new GeneXus.Http.GXNullWebComponent();
         AV17Pgmname = "ViewTSEG006" ;
         /* GeneXus formulas. */
         AV17Pgmname = "ViewTSEG006" ;
         context.Gx_err = 0 ;
      }

      private short AV12SIS_COD ;
      private short AV13PRG_COD ;
      private short wcpOAV12SIS_COD ;
      private short wcpOAV13PRG_COD ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short A126PRG_COD ;
      private short A116SIS_COD ;
      private short AV18GXLvl8 ;
      private short nGXWrapped ;
      private int AV14PRS_NRO ;
      private int wcpOAV14PRS_NRO ;
      private int A118PRS_NRO ;
      private int idxLst ;
      private String AV11USU_COD ;
      private String AV7TabCode ;
      private String wcpOAV11USU_COD ;
      private String wcpOAV7TabCode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String OldTabbedview ;
      private String WebComp_Tabbedview_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String AV17Pgmname ;
      private String edtPRS_INI_Internalname ;
      private String lblViewall_Link ;
      private String lblViewall_Internalname ;
      private String sStyleString ;
      private String tblViewtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblSpaceseparator_Internalname ;
      private String lblSpaceseparator_Jsonclick ;
      private String tblTable1_Internalname ;
      private String lblFixtextprs_ini_Internalname ;
      private String lblFixtextprs_ini_Jsonclick ;
      private String edtPRS_INI_Jsonclick ;
      private String GXt_char2 ;
      private String tblTitletable_Internalname ;
      private String lblViewtitle_Internalname ;
      private String lblViewtitle_Jsonclick ;
      private String GXt_char3 ;
      private String lblViewall_Jsonclick ;
      private DateTime A166PRS_INI ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool AV10Exists ;
      private GXWebComponent WebComp_Tabbedview ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H00432_A118PRS_NRO ;
      private short[] H00432_A126PRG_COD ;
      private short[] H00432_A116SIS_COD ;
      private String[] H00432_A6USU_COD ;
      private DateTime[] H00432_A166PRS_INI ;
      private int[] H00433_A118PRS_NRO ;
      private short[] H00433_A126PRG_COD ;
      private short[] H00433_A116SIS_COD ;
      private String[] H00433_A6USU_COD ;
      private DateTime[] H00433_A166PRS_INI ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtTabOptions_TabOptionsItem ))]
      private IGxCollection AV8Tabs ;
      private GXWebForm Form ;
      private SdtTabOptions_TabOptionsItem AV9Tab ;
   }

   public class viewtseg006__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00432 ;
          prmH00432 = new Object[] {
          new Object[] {"@AV11USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV12SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV13PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmH00433 ;
          prmH00433 = new Object[] {
          new Object[] {"@AV11USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV12SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV13PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14PRS_NRO",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00432", "SELECT [PRS_NRO], [PRG_COD], [SIS_COD], [USU_COD], [PRS_INI] FROM [SEG006] WITH (NOLOCK) WHERE [USU_COD] = @AV11USU_COD and [SIS_COD] = @AV12SIS_COD and [PRG_COD] = @AV13PRG_COD and [PRS_NRO] = @AV14PRS_NRO ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00432,1,1,true,true )
             ,new CursorDef("H00433", "SELECT [PRS_NRO], [PRG_COD], [SIS_COD], [USU_COD], [PRS_INI] FROM [SEG006] WITH (NOLOCK) WHERE ([USU_COD] = @AV11USU_COD and [SIS_COD] = @AV12SIS_COD and [PRG_COD] = @AV13PRG_COD and [PRS_NRO] = @AV14PRS_NRO) AND ([USU_COD] = @AV11USU_COD and [SIS_COD] = @AV12SIS_COD and [PRG_COD] = @AV13PRG_COD and [PRS_NRO] = @AV14PRS_NRO) ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00433,1,1,false,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
