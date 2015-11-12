/*
               File: ViewTSEG002
        Description: View TSEG002
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:20:21.68
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
   public class viewtseg002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public viewtseg002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public viewtseg002( IGxContext context )
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
                           String aP1_TabCode )
      {
         this.AV11USU_COD = aP0_USU_COD;
         this.AV7TabCode = aP1_TabCode;
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
         PA0O2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0O2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vUSU_COD", StringUtil.RTrim( AV11USU_COD));
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
            WE0O2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0O2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "ViewTSEG002" ;
      }

      public override String GetPgmdesc( )
      {
         return "View TSEG002" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV7TabCode)) ;
      }

      protected void WB0O0( )
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
            wb_table1_2_0O2( true) ;
         }
         else
         {
            wb_table1_2_0O2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0O2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0O2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "View TSEG002", 0) ;
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
         STRUP0O0( ) ;
      }

      protected void WS0O2( )
      {
         START0O2( ) ;
         EVT0O2( ) ;
      }

      protected void EVT0O2( )
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
                              /* Execute user event: E110O2 */
                              E110O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E120O2 */
                              E120O2 ();
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

      protected void WE0O2( )
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

      protected void PA0O2( )
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
         RF0O2( ) ;
         /* End function Refresh */
      }

      protected void RF0O2( )
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
            /* Using cursor H000O2 */
            pr_default.execute(0, new Object[] {AV11USU_COD});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A6USU_COD = H000O2_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = H000O2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               /* Execute user event: E120O2 */
               E120O2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0O0( ) ;
         }
      }

      protected void STRUP0O0( )
      {
         /* Before Start, stand alone formulas. */
         AV14Pgmname = "ViewTSEG002" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110O2 */
         E110O2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            /* Read saved values. */
            AV11USU_COD = cgiGet( "vUSU_COD") ;
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
         /* Execute user event: E110O2 */
         E110O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110O2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV14Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)) ;
         }
         lblViewall_Link = formatLink("wwtseg002.aspx")  ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblViewall_Internalname, "Link", lblViewall_Link);
         AV15GXLvl8 = 0 ;
         /* Using cursor H000O3 */
         pr_default.execute(1, new Object[] {AV11USU_COD});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A6USU_COD = H000O3_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H000O3_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV15GXLvl8 = 1 ;
            Form.Caption = A7USU_DES ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
            AV10Exists = true ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( AV15GXLvl8 == 0 )
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
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg002general.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
         AV9Tab = new SdtTabOptions_TabOptionsItem(context) ;
         AV9Tab.gxTpr_Code = "TSEG003" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Description = "ACT. USUARIO/SISTEMA" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg002tseg003wc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
         AV9Tab = new SdtTabOptions_TabOptionsItem(context) ;
         AV9Tab.gxTpr_Code = "TTBUS007" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Description = "Responsable de Posición" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg002ttbus007wc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
         AV9Tab = new SdtTabOptions_TabOptionsItem(context) ;
         AV9Tab.gxTpr_Code = "Permisos" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Description = "Usuario con acceso a posicion trazabilidad" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg002permisoswc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
         AV9Tab = new SdtTabOptions_TabOptionsItem(context) ;
         AV9Tab.gxTpr_Code = "TTBUS007_p" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Description = "Usuario con acceso a posicion trazabilidad" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg002ttbus007_pwc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
         AV9Tab = new SdtTabOptions_TabOptionsItem(context) ;
         AV9Tab.gxTpr_Code = "TPRM005" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Description = "Usuario" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Webcomponent = formatLink("tseg002tprm005wc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV9Tab.gxTpr_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV9Tab.gxTpr_Code)) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9Tab", (Object)(AV9Tab));
         AV8Tabs.Add(AV9Tab, 0);
      }

      protected void nextLoad( )
      {
      }

      protected void E120O2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_0O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblViewtable_Internalname, tblViewtable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0O2( true) ;
         }
         else
         {
            wb_table2_5_0O2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_0O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_13_0O2( true) ;
         }
         else
         {
            wb_table3_13_0O2( false) ;
         }
         return  ;
      }

      protected void wb_table3_13_0O2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblSpaceseparator_Internalname, 1, 1, 0, "", "", "", "", 0, lblSpaceseparator_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG002.htm");
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
            wb_table1_2_0O2e( true) ;
         }
         else
         {
            wb_table1_2_0O2e( false) ;
         }
      }

      protected void wb_table3_13_0O2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblFixtextusu_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblFixtextusu_des_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_ViewTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_13_0O2e( true) ;
         }
         else
         {
            wb_table3_13_0O2e( false) ;
         }
      }

      protected void wb_table2_5_0O2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblViewtitle_Internalname, 1, 1, 0, "ACT. USUARIOS Información", "", "", "", 0, lblViewtitle_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" colspan=\"1\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblViewall_Internalname, 1, 1, 0, "Trabajar con ACT. USUARIOS", "", lblViewall_Link, "", 0, lblViewall_Jsonclick, "", StyleString, ClassString, "HLP_ViewTSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0O2e( true) ;
         }
         else
         {
            wb_table2_5_0O2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11USU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USU_COD", AV11USU_COD);
         AV7TabCode = (String)getParm(obj,1) ;
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
         PA0O2( ) ;
         WS0O2( ) ;
         WE0O2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11202196");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("viewtseg002.js", "?11202196");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblViewtitle_Internalname = "VIEWTITLE" ;
         lblViewall_Internalname = "VIEWALL" ;
         tblTitletable_Internalname = "TITLETABLE" ;
         lblFixtextusu_des_Internalname = "FIXTEXTUSU_DES" ;
         edtUSU_DES_Internalname = "USU_DES" ;
         tblTable1_Internalname = "TABLE1" ;
         lblSpaceseparator_Internalname = "SPACESEPARATOR" ;
         tblViewtable_Internalname = "VIEWTABLE" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         lblViewall_Link = "" ;
         edtUSU_DES_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "View TSEG002" ;
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
         H000O2_A6USU_COD = new String[] {""} ;
         H000O2_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV14Pgmname = "" ;
         H000O3_A6USU_COD = new String[] {""} ;
         H000O3_A7USU_DES = new String[] {""} ;
         AV8Tabs = new GxObjectCollection( context, "TabOptions.TabOptionsItem", "MarianoTesis", "SdtTabOptions_TabOptionsItem", "GeneXus.Programs");
         AV9Tab = new SdtTabOptions_TabOptionsItem(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblSpaceseparator_Jsonclick = "" ;
         GXt_char2 = "" ;
         lblFixtextusu_des_Jsonclick = "" ;
         lblViewtitle_Jsonclick = "" ;
         GXt_char3 = "" ;
         lblViewall_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.viewtseg002__default(),
            new Object[][] {
                new Object[] {
               H000O2_A6USU_COD, H000O2_A7USU_DES
               }
               , new Object[] {
               H000O3_A6USU_COD, H000O3_A7USU_DES
               }
            }
         );
         WebComp_Tabbedview = new GeneXus.Http.GXNullWebComponent();
         AV14Pgmname = "ViewTSEG002" ;
         /* GeneXus formulas. */
         AV14Pgmname = "ViewTSEG002" ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short AV15GXLvl8 ;
      private short nGXWrapped ;
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
      private String A7USU_DES ;
      private String AV14Pgmname ;
      private String edtUSU_DES_Internalname ;
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
      private String lblFixtextusu_des_Internalname ;
      private String lblFixtextusu_des_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
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
      private String[] H000O2_A6USU_COD ;
      private String[] H000O2_A7USU_DES ;
      private String[] H000O3_A6USU_COD ;
      private String[] H000O3_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtTabOptions_TabOptionsItem ))]
      private IGxCollection AV8Tabs ;
      private GXWebForm Form ;
      private SdtTabOptions_TabOptionsItem AV9Tab ;
   }

   public class viewtseg002__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000O2 ;
          prmH000O2 = new Object[] {
          new Object[] {"@AV11USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH000O3 ;
          prmH000O3 = new Object[] {
          new Object[] {"@AV11USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000O2", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV11USU_COD ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000O2,1,0,true,true )
             ,new CursorDef("H000O3", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV11USU_COD ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000O3,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
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
