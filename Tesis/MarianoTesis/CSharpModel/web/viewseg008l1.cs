/*
               File: ViewSEG008L1
        Description: View SEG008 L1
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:20:21.21
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
   public class viewseg008l1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public viewseg008l1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public viewseg008l1( IGxContext context )
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

      public void execute( short aP0_PRG_COD ,
                           int aP1_MNU_NIV ,
                           int aP2_MNU_SNI ,
                           String aP3_TabCode )
      {
         this.AV11PRG_COD = aP0_PRG_COD;
         this.AV12MNU_NIV = aP1_MNU_NIV;
         this.AV13MNU_SNI = aP2_MNU_SNI;
         this.AV7TabCode = aP3_TabCode;
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
               AV11PRG_COD = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11PRG_COD), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV12MNU_NIV = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12MNU_NIV), 6, 0)));
                  AV13MNU_SNI = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13MNU_SNI), 5, 0)));
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
         PA412( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START412( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("viewseg008l1.aspx") + "?" + UrlEncode("" +AV11PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV) + "," + UrlEncode("" +AV13MNU_SNI) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMNU_NIV", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12MNU_NIV), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMNU_SNI", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13MNU_SNI), 5, 0, ",", "")));
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
            WE412( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT412( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "ViewSEG008L1" ;
      }

      public override String GetPgmdesc( )
      {
         return "View SEG008 L1" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("viewseg008l1.aspx") + "?" + UrlEncode("" +AV11PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV) + "," + UrlEncode("" +AV13MNU_SNI) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode)) ;
      }

      protected void WB410( )
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
            wb_table1_2_412( true) ;
         }
         else
         {
            wb_table1_2_412( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_412e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START412( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "View SEG008 L1", 0) ;
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
         STRUP410( ) ;
      }

      protected void WS412( )
      {
         START412( ) ;
         EVT412( ) ;
      }

      protected void EVT412( )
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
                              /* Execute user event: E11412 */
                              E11412 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12412 */
                              E12412 ();
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

      protected void WE412( )
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

      protected void PA412( )
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
         RF412( ) ;
         /* End function Refresh */
      }

      protected void RF412( )
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
            /* Using cursor H00412 */
            pr_default.execute(0, new Object[] {AV11PRG_COD, AV12MNU_NIV, AV13MNU_SNI});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A130MNU_SNI = H00412_A130MNU_SNI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
               A361MNU_NIV = H00412_A361MNU_NIV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               A126PRG_COD = H00412_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A131MNU_DSN = H00412_A131MNU_DSN[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131MNU_DSN", A131MNU_DSN);
               /* Execute user event: E12412 */
               E12412 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB410( ) ;
         }
      }

      protected void STRUP410( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "ViewSEG008L1" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11412 */
         E11412 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A131MNU_DSN = cgiGet( edtMNU_DSN_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131MNU_DSN", A131MNU_DSN);
            /* Read saved values. */
            AV11PRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPRG_COD"), ",", ".")) ;
            AV12MNU_NIV = (int)(context.localUtil.CToN( cgiGet( "vMNU_NIV"), ",", ".")) ;
            AV13MNU_SNI = (int)(context.localUtil.CToN( cgiGet( "vMNU_SNI"), ",", ".")) ;
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
         /* Execute user event: E11412 */
         E11412 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11412( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV16Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)) ;
         }
         lblViewall_Link = formatLink("wwseg008l1.aspx")  ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblViewall_Internalname, "Link", lblViewall_Link);
         AV17GXLvl8 = 0 ;
         /* Using cursor H00413 */
         pr_default.execute(1, new Object[] {AV11PRG_COD, AV12MNU_NIV, AV13MNU_SNI});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A130MNU_SNI = H00413_A130MNU_SNI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
            A361MNU_NIV = H00413_A361MNU_NIV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            A126PRG_COD = H00413_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A131MNU_DSN = H00413_A131MNU_DSN[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131MNU_DSN", A131MNU_DSN);
            AV17GXLvl8 = 1 ;
            Form.Caption = A131MNU_DSN ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
            AV10Exists = true ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( AV17GXLvl8 == 0 )
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
         AV9Tab.gxTpr_Webcomponent = formatLink("seg008l1general.aspx") + "?" + UrlEncode("" +AV11PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV) + "," + UrlEncode("" +AV13MNU_SNI) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewseg008l1.aspx") + "?" + UrlEncode("" +AV11PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV) + "," + UrlEncode("" +AV13MNU_SNI) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
      }

      protected void nextLoad( )
      {
      }

      protected void E12412( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_412( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblViewtable_Internalname, tblViewtable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_412( true) ;
         }
         else
         {
            wb_table2_5_412( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_412e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_13_412( true) ;
         }
         else
         {
            wb_table3_13_412( false) ;
         }
         return  ;
      }

      protected void wb_table3_13_412e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblSpaceseparator_Internalname, 1, 1, 0, "", "", "", "", 0, lblSpaceseparator_Jsonclick, "", StyleString, ClassString, "HLP_ViewSEG008L1.htm");
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
            wb_table1_2_412e( true) ;
         }
         else
         {
            wb_table1_2_412e( false) ;
         }
      }

      protected void wb_table3_13_412( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblFixtextmnu_dsn_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblFixtextmnu_dsn_Jsonclick, "", StyleString, ClassString, "HLP_ViewSEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_DSN_Internalname, StringUtil.RTrim( A131MNU_DSN), "", 80, "chr", 1, "row", 100, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A131MNU_DSN, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtMNU_DSN_Jsonclick, "", 0, 1, 1, true, "left", "HLP_ViewSEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_13_412e( true) ;
         }
         else
         {
            wb_table3_13_412e( false) ;
         }
      }

      protected void wb_table2_5_412( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblViewtitle_Internalname, 1, 1, 0, "INFO MENUES X Information", "", "", "", 0, lblViewtitle_Jsonclick, "", StyleString, ClassString, "HLP_ViewSEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" colspan=\"1\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblViewall_Internalname, 1, 1, 0, "Work With INFO MENUES XS", "", lblViewall_Link, "", 0, lblViewall_Jsonclick, "", StyleString, ClassString, "HLP_ViewSEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_412e( true) ;
         }
         else
         {
            wb_table2_5_412e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11PRG_COD = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11PRG_COD), 4, 0)));
         AV12MNU_NIV = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12MNU_NIV), 6, 0)));
         AV13MNU_SNI = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13MNU_SNI), 5, 0)));
         AV7TabCode = (String)getParm(obj,3) ;
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
         PA412( ) ;
         WS412( ) ;
         WE412( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11202153");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("viewseg008l1.js", "?11202153");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblViewtitle_Internalname = "VIEWTITLE" ;
         lblViewall_Internalname = "VIEWALL" ;
         tblTitletable_Internalname = "TITLETABLE" ;
         lblFixtextmnu_dsn_Internalname = "FIXTEXTMNU_DSN" ;
         edtMNU_DSN_Internalname = "MNU_DSN" ;
         tblTable1_Internalname = "TABLE1" ;
         lblSpaceseparator_Internalname = "SPACESEPARATOR" ;
         tblViewtable_Internalname = "VIEWTABLE" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         lblViewall_Link = "" ;
         edtMNU_DSN_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "View SEG008 L1" ;
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
         H00412_A130MNU_SNI = new int[1] ;
         H00412_A361MNU_NIV = new int[1] ;
         H00412_A126PRG_COD = new short[1] ;
         H00412_A131MNU_DSN = new String[] {""} ;
         A131MNU_DSN = "" ;
         AV16Pgmname = "" ;
         H00413_A130MNU_SNI = new int[1] ;
         H00413_A361MNU_NIV = new int[1] ;
         H00413_A126PRG_COD = new short[1] ;
         H00413_A131MNU_DSN = new String[] {""} ;
         AV8Tabs = new GxObjectCollection( context, "TabOptions.TabOptionsItem", "MarianoTesis", "SdtTabOptions_TabOptionsItem", "GeneXus.Programs");
         AV9Tab = new SdtTabOptions_TabOptionsItem(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblSpaceseparator_Jsonclick = "" ;
         GXt_char2 = "" ;
         lblFixtextmnu_dsn_Jsonclick = "" ;
         lblViewtitle_Jsonclick = "" ;
         GXt_char3 = "" ;
         lblViewall_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.viewseg008l1__default(),
            new Object[][] {
                new Object[] {
               H00412_A130MNU_SNI, H00412_A361MNU_NIV, H00412_A126PRG_COD, H00412_A131MNU_DSN
               }
               , new Object[] {
               H00413_A130MNU_SNI, H00413_A361MNU_NIV, H00413_A126PRG_COD, H00413_A131MNU_DSN
               }
            }
         );
         WebComp_Tabbedview = new GeneXus.Http.GXNullWebComponent();
         AV16Pgmname = "ViewSEG008L1" ;
         /* GeneXus formulas. */
         AV16Pgmname = "ViewSEG008L1" ;
         context.Gx_err = 0 ;
      }

      private short AV11PRG_COD ;
      private short wcpOAV11PRG_COD ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short A126PRG_COD ;
      private short AV17GXLvl8 ;
      private short nGXWrapped ;
      private int AV12MNU_NIV ;
      private int AV13MNU_SNI ;
      private int wcpOAV12MNU_NIV ;
      private int wcpOAV13MNU_SNI ;
      private int A130MNU_SNI ;
      private int A361MNU_NIV ;
      private int idxLst ;
      private String AV7TabCode ;
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
      private String A131MNU_DSN ;
      private String AV16Pgmname ;
      private String edtMNU_DSN_Internalname ;
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
      private String lblFixtextmnu_dsn_Internalname ;
      private String lblFixtextmnu_dsn_Jsonclick ;
      private String edtMNU_DSN_Jsonclick ;
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
      private int[] H00412_A130MNU_SNI ;
      private int[] H00412_A361MNU_NIV ;
      private short[] H00412_A126PRG_COD ;
      private String[] H00412_A131MNU_DSN ;
      private int[] H00413_A130MNU_SNI ;
      private int[] H00413_A361MNU_NIV ;
      private short[] H00413_A126PRG_COD ;
      private String[] H00413_A131MNU_DSN ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtTabOptions_TabOptionsItem ))]
      private IGxCollection AV8Tabs ;
      private GXWebForm Form ;
      private SdtTabOptions_TabOptionsItem AV9Tab ;
   }

   public class viewseg008l1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00412 ;
          prmH00412 = new Object[] {
          new Object[] {"@AV11PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@AV13MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmH00413 ;
          prmH00413 = new Object[] {
          new Object[] {"@AV11PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@AV13MNU_SNI",SqlDbType.Int,5,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00412", "SELECT [MNU_SNI], [MNU_NIV], [PRG_COD], [MNU_DSN] FROM [SEG008L1] WITH (NOLOCK) WHERE [PRG_COD] = @AV11PRG_COD and [MNU_NIV] = @AV12MNU_NIV and [MNU_SNI] = @AV13MNU_SNI ORDER BY [PRG_COD], [MNU_NIV], [MNU_SNI] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00412,1,1,true,true )
             ,new CursorDef("H00413", "SELECT [MNU_SNI], [MNU_NIV], [PRG_COD], [MNU_DSN] FROM [SEG008L1] WITH (NOLOCK) WHERE ([PRG_COD] = @AV11PRG_COD and [MNU_NIV] = @AV12MNU_NIV and [MNU_SNI] = @AV13MNU_SNI) AND ([PRG_COD] = @AV11PRG_COD and [MNU_NIV] = @AV12MNU_NIV and [MNU_SNI] = @AV13MNU_SNI) ORDER BY [PRG_COD], [MNU_NIV], [MNU_SNI] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00413,1,1,false,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
