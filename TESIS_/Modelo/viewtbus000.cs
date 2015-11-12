/*
               File: ViewTBUS000
        Description: View TBUS000
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:2.66
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
   public class viewtbus000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public viewtbus000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public viewtbus000( IGxContext context )
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

      public void execute( String aP0_BUS_EMP ,
                           short aP1_BUS_RUB ,
                           short aP2_BUS_COD ,
                           short aP3_BUS_PAR ,
                           String aP4_TabCode )
      {
         this.AV11BUS_EMP = aP0_BUS_EMP;
         this.AV12BUS_RUB = aP1_BUS_RUB;
         this.AV13BUS_COD = aP2_BUS_COD;
         this.AV14BUS_PAR = aP3_BUS_PAR;
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
               AV11BUS_EMP = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11BUS_EMP", AV11BUS_EMP);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV12BUS_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BUS_RUB), 4, 0)));
                  AV13BUS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13BUS_COD), 4, 0)));
                  AV14BUS_PAR = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14BUS_PAR), 2, 0)));
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
         PA2C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2C2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("viewtbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11BUS_EMP)) + "," + UrlEncode("" +AV12BUS_RUB) + "," + UrlEncode("" +AV13BUS_COD) + "," + UrlEncode("" +AV14BUS_PAR) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vBUS_EMP", StringUtil.RTrim( AV11BUS_EMP));
         GxWebStd.gx_hidden_field( context, "vBUS_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BUS_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vBUS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BUS_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vBUS_PAR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14BUS_PAR), 2, 0, ",", "")));
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
            WE2C2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "ViewTBUS000" ;
      }

      public override String GetPgmdesc( )
      {
         return "View TBUS000" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("viewtbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11BUS_EMP)) + "," + UrlEncode("" +AV12BUS_RUB) + "," + UrlEncode("" +AV13BUS_COD) + "," + UrlEncode("" +AV14BUS_PAR) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode)) ;
      }

      protected void WB2C0( )
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
            wb_table1_2_2C2( true) ;
         }
         else
         {
            wb_table1_2_2C2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2C2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2C2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "View TBUS000", 0) ;
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
         STRUP2C0( ) ;
      }

      protected void WS2C2( )
      {
         START2C2( ) ;
         EVT2C2( ) ;
      }

      protected void EVT2C2( )
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
                              /* Execute user event: E112C2 */
                              E112C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E122C2 */
                              E122C2 ();
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

      protected void WE2C2( )
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

      protected void PA2C2( )
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
         RF2C2( ) ;
         /* End function Refresh */
      }

      protected void RF2C2( )
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
            /* Using cursor H002C2 */
            pr_default.execute(0, new Object[] {AV11BUS_EMP, AV12BUS_RUB, AV13BUS_COD, AV14BUS_PAR});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A4BUS_PAR = H002C2_A4BUS_PAR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               A3BUS_COD = H002C2_A3BUS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               A1BUS_RUB = H002C2_A1BUS_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               A8BUS_EMP = H002C2_A8BUS_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               A54BUS_DES = H002C2_A54BUS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
               /* Execute user event: E122C2 */
               E122C2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB2C0( ) ;
         }
      }

      protected void STRUP2C0( )
      {
         /* Before Start, stand alone formulas. */
         AV17Pgmname = "ViewTBUS000" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112C2 */
         E112C2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A54BUS_DES = StringUtil.Upper( cgiGet( edtBUS_DES_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            /* Read saved values. */
            AV11BUS_EMP = cgiGet( "vBUS_EMP") ;
            AV12BUS_RUB = (short)(context.localUtil.CToN( cgiGet( "vBUS_RUB"), ",", ".")) ;
            AV13BUS_COD = (short)(context.localUtil.CToN( cgiGet( "vBUS_COD"), ",", ".")) ;
            AV14BUS_PAR = (short)(context.localUtil.CToN( cgiGet( "vBUS_PAR"), ",", ".")) ;
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
         /* Execute user event: E112C2 */
         E112C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112C2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV17Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)) ;
         }
         lblViewall_Link = formatLink("wwtbus000.aspx")  ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblViewall_Internalname, "Link", lblViewall_Link);
         AV18GXLvl8 = 0 ;
         /* Using cursor H002C3 */
         pr_default.execute(1, new Object[] {AV11BUS_EMP, AV12BUS_RUB, AV13BUS_COD, AV14BUS_PAR});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A4BUS_PAR = H002C3_A4BUS_PAR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
            A3BUS_COD = H002C3_A3BUS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
            A1BUS_RUB = H002C3_A1BUS_RUB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            A8BUS_EMP = H002C3_A8BUS_EMP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
            A54BUS_DES = H002C3_A54BUS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
            AV18GXLvl8 = 1 ;
            Form.Caption = A54BUS_DES ;
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
         AV9Tab.gxTpr_Webcomponent = formatLink("tbus000general.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11BUS_EMP)) + "," + UrlEncode("" +AV12BUS_RUB) + "," + UrlEncode("" +AV13BUS_COD) + "," + UrlEncode("" +AV14BUS_PAR) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11BUS_EMP)) + "," + UrlEncode("" +AV12BUS_RUB) + "," + UrlEncode("" +AV13BUS_COD) + "," + UrlEncode("" +AV14BUS_PAR) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
      }

      protected void nextLoad( )
      {
      }

      protected void E122C2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_2C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblViewtable_Internalname, tblViewtable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_2C2( true) ;
         }
         else
         {
            wb_table2_5_2C2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_2C2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_13_2C2( true) ;
         }
         else
         {
            wb_table3_13_2C2( false) ;
         }
         return  ;
      }

      protected void wb_table3_13_2C2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblSpaceseparator_Internalname, 1, 1, 0, "", "", "", "", 0, lblSpaceseparator_Jsonclick, "", StyleString, ClassString, "HLP_ViewTBUS000.htm");
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
            wb_table1_2_2C2e( true) ;
         }
         else
         {
            wb_table1_2_2C2e( false) ;
         }
      }

      protected void wb_table3_13_2C2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblFixtextbus_des_Internalname, 1, 1, 0, "DESCRIPCION DEL BIEN", "", "", "", 0, lblFixtextbus_des_Jsonclick, "", StyleString, ClassString, "HLP_ViewTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_DES_Internalname, StringUtil.RTrim( A54BUS_DES), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A54BUS_DES, "@!")), "", 0, edtBUS_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_ViewTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_13_2C2e( true) ;
         }
         else
         {
            wb_table3_13_2C2e( false) ;
         }
      }

      protected void wb_table2_5_2C2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblViewtitle_Internalname, 1, 1, 0, "ACT. DE BIENES DE USO Información", "", "", "", 0, lblViewtitle_Jsonclick, "", StyleString, ClassString, "HLP_ViewTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" colspan=\"1\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblViewall_Internalname, 1, 1, 0, "Trabajar con DE BIENES DE USO", "", lblViewall_Link, "", 0, lblViewall_Jsonclick, "", StyleString, ClassString, "HLP_ViewTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_2C2e( true) ;
         }
         else
         {
            wb_table2_5_2C2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11BUS_EMP = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11BUS_EMP", AV11BUS_EMP);
         AV12BUS_RUB = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BUS_RUB), 4, 0)));
         AV13BUS_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13BUS_COD), 4, 0)));
         AV14BUS_PAR = Convert.ToInt16(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14BUS_PAR), 2, 0)));
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
         PA2C2( ) ;
         WS2C2( ) ;
         WE2C2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11834");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("viewtbus000.js", "?11834");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblViewtitle_Internalname = "VIEWTITLE" ;
         lblViewall_Internalname = "VIEWALL" ;
         tblTitletable_Internalname = "TITLETABLE" ;
         lblFixtextbus_des_Internalname = "FIXTEXTBUS_DES" ;
         edtBUS_DES_Internalname = "BUS_DES" ;
         tblTable1_Internalname = "TABLE1" ;
         lblSpaceseparator_Internalname = "SPACESEPARATOR" ;
         tblViewtable_Internalname = "VIEWTABLE" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         lblViewall_Link = "" ;
         edtBUS_DES_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "View TBUS000" ;
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
         wcpOAV11BUS_EMP = "" ;
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
         H002C2_A4BUS_PAR = new short[1] ;
         H002C2_A3BUS_COD = new short[1] ;
         H002C2_A1BUS_RUB = new short[1] ;
         H002C2_A8BUS_EMP = new String[] {""} ;
         H002C2_A54BUS_DES = new String[] {""} ;
         A8BUS_EMP = "" ;
         A54BUS_DES = "" ;
         AV17Pgmname = "" ;
         H002C3_A4BUS_PAR = new short[1] ;
         H002C3_A3BUS_COD = new short[1] ;
         H002C3_A1BUS_RUB = new short[1] ;
         H002C3_A8BUS_EMP = new String[] {""} ;
         H002C3_A54BUS_DES = new String[] {""} ;
         AV8Tabs = new GxObjectCollection( context, "TabOptions.TabOptionsItem", "MarianoTesis", "SdtTabOptions_TabOptionsItem", "GeneXus.Programs");
         AV9Tab = new SdtTabOptions_TabOptionsItem(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblSpaceseparator_Jsonclick = "" ;
         GXt_char2 = "" ;
         lblFixtextbus_des_Jsonclick = "" ;
         lblViewtitle_Jsonclick = "" ;
         GXt_char3 = "" ;
         lblViewall_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.viewtbus000__default(),
            new Object[][] {
                new Object[] {
               H002C2_A4BUS_PAR, H002C2_A3BUS_COD, H002C2_A1BUS_RUB, H002C2_A8BUS_EMP, H002C2_A54BUS_DES
               }
               , new Object[] {
               H002C3_A4BUS_PAR, H002C3_A3BUS_COD, H002C3_A1BUS_RUB, H002C3_A8BUS_EMP, H002C3_A54BUS_DES
               }
            }
         );
         WebComp_Tabbedview = new GeneXus.Http.GXNullWebComponent();
         AV17Pgmname = "ViewTBUS000" ;
         /* GeneXus formulas. */
         AV17Pgmname = "ViewTBUS000" ;
         context.Gx_err = 0 ;
      }

      private short AV12BUS_RUB ;
      private short AV13BUS_COD ;
      private short AV14BUS_PAR ;
      private short wcpOAV12BUS_RUB ;
      private short wcpOAV13BUS_COD ;
      private short wcpOAV14BUS_PAR ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short A4BUS_PAR ;
      private short A3BUS_COD ;
      private short A1BUS_RUB ;
      private short AV18GXLvl8 ;
      private short nGXWrapped ;
      private int idxLst ;
      private String AV11BUS_EMP ;
      private String AV7TabCode ;
      private String wcpOAV11BUS_EMP ;
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
      private String A8BUS_EMP ;
      private String A54BUS_DES ;
      private String AV17Pgmname ;
      private String edtBUS_DES_Internalname ;
      private String lblViewall_Link ;
      private String lblViewall_Internalname ;
      private String sStyleString ;
      private String tblViewtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblSpaceseparator_Internalname ;
      private String lblSpaceseparator_Jsonclick ;
      private String GXt_char2 ;
      private String tblTable1_Internalname ;
      private String lblFixtextbus_des_Internalname ;
      private String lblFixtextbus_des_Jsonclick ;
      private String edtBUS_DES_Jsonclick ;
      private String tblTitletable_Internalname ;
      private String lblViewtitle_Internalname ;
      private String lblViewtitle_Jsonclick ;
      private String GXt_char3 ;
      private String lblViewall_Jsonclick ;
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
      private short[] H002C2_A4BUS_PAR ;
      private short[] H002C2_A3BUS_COD ;
      private short[] H002C2_A1BUS_RUB ;
      private String[] H002C2_A8BUS_EMP ;
      private String[] H002C2_A54BUS_DES ;
      private short[] H002C3_A4BUS_PAR ;
      private short[] H002C3_A3BUS_COD ;
      private short[] H002C3_A1BUS_RUB ;
      private String[] H002C3_A8BUS_EMP ;
      private String[] H002C3_A54BUS_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtTabOptions_TabOptionsItem ))]
      private IGxCollection AV8Tabs ;
      private GXWebForm Form ;
      private SdtTabOptions_TabOptionsItem AV9Tab ;
   }

   public class viewtbus000__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002C2 ;
          prmH002C2 = new Object[] {
          new Object[] {"@AV11BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV12BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmH002C3 ;
          prmH002C3 = new Object[] {
          new Object[] {"@AV11BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV12BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002C2", "SELECT [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP], [BUS_DES] FROM [BUS000] WITH (NOLOCK) WHERE [BUS_EMP] = @AV11BUS_EMP and [BUS_RUB] = @AV12BUS_RUB and [BUS_COD] = @AV13BUS_COD and [BUS_PAR] = @AV14BUS_PAR ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002C2,1,0,true,true )
             ,new CursorDef("H002C3", "SELECT [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP], [BUS_DES] FROM [BUS000] WITH (NOLOCK) WHERE ([BUS_EMP] = @AV11BUS_EMP and [BUS_RUB] = @AV12BUS_RUB and [BUS_COD] = @AV13BUS_COD and [BUS_PAR] = @AV14BUS_PAR) AND ([BUS_EMP] = @AV11BUS_EMP and [BUS_RUB] = @AV12BUS_RUB and [BUS_COD] = @AV13BUS_COD and [BUS_PAR] = @AV14BUS_PAR) ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002C3,1,0,false,true )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 50) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 50) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
       }
    }

 }

}
