/*
               File: WCSEGURIDAD
        Description: Confirmación de Usuario y Contraseña
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:30:12.35
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
   public class wcseguridad : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wcseguridad( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public wcseguridad( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_PRG_WEB )
      {
         this.AV8PRG_WEB = aP0_PRG_WEB;
         executePrivate();
         aP0_PRG_WEB=this.AV8PRG_WEB;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  nDynComponent = 1 ;
                  sCompPrefix = GetNextPar( ) ;
                  sSFPrefix = GetNextPar( ) ;
                  AV8PRG_WEB = GetNextPar( ) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV8PRG_WEB});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
                  AV8PRG_WEB = gxfirstwebparm ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8PRG_WEB", AV8PRG_WEB);
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
            PA252( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS252( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE252( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.WriteHtmlText( "<title>") ;
            context.WriteHtmlText( "Confirmación de Usuario y Contraseña") ;
            context.WriteHtmlTextNl( "</title>") ;
            if ( StringUtil.Len( sDynURL) > 0 )
            {
               context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
            }
            define_styles( ) ;
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+"captionexpression=\"<Tokens />\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wcseguridad.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8PRG_WEB))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm252( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8PRG_WEB", StringUtil.RTrim( wcpOAV8PRG_WEB));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPRG_WEB", StringUtil.RTrim( AV8PRG_WEB));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("wcseguridad.js", "?19301239");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            context.WriteHtmlTextNl( "</form>") ;
            include_jscripts( ) ;
            if ( ! ( WebComp_Wc_seguridad == null ) )
            {
               WebComp_Wc_seguridad.componentjscripts();
            }
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
         }
      }

      protected void WB250( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wcseguridad.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_252( true) ;
         }
         else
         {
            wb_table1_2_252( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_252e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START252( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "Confirmación de Usuario y Contraseña", 0) ;
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
            context.wbHandled = 0 ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName") ;
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
                  OldWc_seguridad = cgiGet( sPrefix+"W0019") ;
                  if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_seguridad_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_seguridad)) )
                  {
                     WebComp_Wc_seguridad = getWebComponent(GetType(), "GeneXus.Programs", OldWc_seguridad, new Object[] {context} );
                     WebComp_Wc_seguridad.ComponentInit();
                     WebComp_Wc_seguridad.Name = "OldWc_seguridad";
                     WebComp_Wc_seguridad_Component = OldWc_seguridad ;
                     WebComp_Wc_seguridad.componentrestorestate(sPrefix+"W0019", "");
                  }
               }
            }
         }
         wbErr = false ;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP250( ) ;
            }
         }
      }

      protected void WS252( )
      {
         START252( ) ;
         EVT252( ) ;
      }

      protected void EVT252( )
      {
         sXEvt = cgiGet( "_EventName") ;
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName") ;
                     EvtGridId = cgiGet( "_EventGridId") ;
                     EvtRowId = cgiGet( "_EventRowId") ;
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1) ;
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP250( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP250( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E11252 */
                                    E11252 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP250( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E12252 */
                                          E12252 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP250( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E13252 */
                                    E13252 ();
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP250( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavUsuario_Internalname ;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
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
                        if ( nCmpId == 19 )
                        {
                           OldWc_seguridad = cgiGet( sPrefix+"W0019") ;
                           if ( ( StringUtil.Len( OldWc_seguridad) == 0 ) || ( StringUtil.StrCmp(OldWc_seguridad, WebComp_Wc_seguridad_Component) != 0 ) )
                           {
                              WebComp_Wc_seguridad = getWebComponent(GetType(), "GeneXus.Programs", OldWc_seguridad, new Object[] {context} );
                              WebComp_Wc_seguridad.ComponentInit();
                              WebComp_Wc_seguridad.Name = "OldWc_seguridad";
                              WebComp_Wc_seguridad_Component = OldWc_seguridad ;
                           }
                           if ( StringUtil.Len( WebComp_Wc_seguridad_Component) != 0 )
                           {
                              WebComp_Wc_seguridad.componentprocess(sPrefix+"W0019", "", sEvt);
                           }
                           WebComp_Wc_seguridad_Component = OldWc_seguridad ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE252( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm252( ) ;
            }
         }
      }

      protected void PA252( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            GX_FocusControl = edtavUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF252( ) ;
         /* End function Refresh */
      }

      protected void RF252( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Wc_seguridad_Component, "") == 0 )
            {
               WebComp_Wc_seguridad = getWebComponent(GetType(), "GeneXus.Programs", "hsi_habilitado", new Object[] {context} );
               WebComp_Wc_seguridad.ComponentInit();
               WebComp_Wc_seguridad.Name = "HSI_HABILITADO";
               WebComp_Wc_seguridad_Component = "HSI_HABILITADO" ;
            }
            if ( ( StringUtil.StrCmp(OldWc_seguridad, WebComp_Wc_seguridad_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_seguridad_Component, "HSI_HABILITADO") == 0 ) )
            {
               WebComp_Wc_seguridad.setjustcreated();
            }
            if ( ( StringUtil.Len( WebComp_Wc_seguridad_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_seguridad_Component, "HSI_HABILITADO") == 0 ) )
            {
               WebComp_Wc_seguridad.componentprepare(new Object[] {(String)sPrefix+"W0019",(String)"",(String)AV6USUARIO});
               WebComp_Wc_seguridad.componentbind(new Object[] {(String)sPrefix+"vUSUARIO"});
            }
            if ( WebComp_Wc_seguridad_Visible != 0 )
            {
               if ( StringUtil.Len( WebComp_Wc_seguridad_Component) != 0 )
               {
                  WebComp_Wc_seguridad.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E13252 */
            E13252 ();
            WB250( ) ;
         }
      }

      protected void STRUP250( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11252 */
         E11252 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6USUARIO = cgiGet( edtavUsuario_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6USUARIO", AV6USUARIO);
            AV7USU_CLA = cgiGet( edtavUsu_cla_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_CLA", AV7USU_CLA);
            /* Read saved values. */
            wcpOAV8PRG_WEB = cgiGet( sPrefix+"wcpOAV8PRG_WEB") ;
            AV8PRG_WEB = cgiGet( sPrefix+"vPRG_WEB") ;
            OldWc_seguridad = cgiGet( sPrefix+"W0019") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_seguridad_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_seguridad)) )
            {
               WebComp_Wc_seguridad = getWebComponent(GetType(), "GeneXus.Programs", OldWc_seguridad, new Object[] {context} );
               WebComp_Wc_seguridad.ComponentInit();
               WebComp_Wc_seguridad.Name = "OldWc_seguridad";
               WebComp_Wc_seguridad_Component = OldWc_seguridad ;
               WebComp_Wc_seguridad.componentrestorestate(sPrefix+"W0019", "");
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
         /* Execute user event: E11252 */
         E11252 ();
         if (returnInSub) return;
      }

      protected void E11252( )
      {
         /* Start Routine */
         WebComp_Wc_seguridad_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"gxHTMLWrpW0019"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wc_seguridad_Visible), 5, 0)));
         new loadcontext(context ).execute( out  AV19context) ;
         AV6USUARIO = StringUtil.Upper( AV19context.gxTpr_User) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6USUARIO", AV6USUARIO);
      }

      public void GXEnter( )
      {
         /* Execute user event: E12252 */
         E12252 ();
         if (returnInSub) return;
      }

      protected void E12252( )
      {
         /* Enter Routine */
         AV10USU_HABIL = 0 ;
         AV6USUARIO = StringUtil.Upper( AV6USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6USUARIO", AV6USUARIO);
         /* Using cursor H00252 */
         pr_default.execute(0, new Object[] {AV6USUARIO});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6USU_COD = H00252_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H00252_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = H00252_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
            if ( StringUtil.StrCmp(StringUtil.Upper( A155USU_CLA), StringUtil.Upper( AV7USU_CLA)) == 0 )
            {
               AV10USU_HABIL = 1 ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV10USU_HABIL == 1 )
         {
            AV10USU_HABIL = 2 ;
            /* Using cursor H00253 */
            pr_default.execute(1, new Object[] {AV8PRG_WEB});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A117PRG_WEB = H00253_A117PRG_WEB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A117PRG_WEB", A117PRG_WEB);
               A127PRG_DES = H00253_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
               A126PRG_COD = H00253_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A164PRG_SIS = H00253_A164PRG_SIS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
               AV15PRG_COD = A126PRG_COD ;
               AV16SIS_COD = A164PRG_SIS ;
               /* Using cursor H00254 */
               pr_default.execute(2, new Object[] {AV6USUARIO, AV16SIS_COD, AV15PRG_COD});
               while ( (pr_default.getStatus(2) != 101) )
               {
                  A126PRG_COD = H00254_A126PRG_COD[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  A116SIS_COD = H00254_A116SIS_COD[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                  A569USU_COD_ = H00254_A569USU_COD_[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A569USU_COD_", A569USU_COD_);
                  AV10USU_HABIL = 1 ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(2);
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         if ( AV10USU_HABIL == 1 )
         {
            AV11PRS_NRO = (int)(NumberUtil.Val( AV9SESION.Get("SESION"), ".")) ;
            AV12NOM_COOKIE = "KEY_" + StringUtil.Trim( AV8PRG_WEB) + "_" + StringUtil.Trim( AV6USUARIO) ;
            AV13A = context.SetCookie( AV12NOM_COOKIE, StringUtil.Str( (decimal)(AV11PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
            AV9SESION.Set("USUARIO", AV6USUARIO);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6USUARIO", AV6USUARIO);
            AV9SESION.Set("SEG_CADUCA", StringUtil.Str( (decimal)(30), 10, 0));
            AV7USU_CLA = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_CLA", AV7USU_CLA);
            WebComp_Wc_seguridad_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"gxHTMLWrpW0019"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wc_seguridad_Visible), 5, 0)));
            /* Object Property */
            if ( StringUtil.StrCmp(WebComp_Wc_seguridad_Component, "HSI_HABILITADO") != 0 )
            {
               WebComp_Wc_seguridad = getWebComponent(GetType(), "GeneXus.Programs", "hsi_habilitado", new Object[] {context} );
               WebComp_Wc_seguridad.ComponentInit();
               WebComp_Wc_seguridad.Name = "HSI_HABILITADO";
               WebComp_Wc_seguridad_Component = "HSI_HABILITADO" ;
            }
            if ( StringUtil.StrCmp(OldWc_seguridad, WebComp_Wc_seguridad_Component) != 0 )
            {
               WebComp_Wc_seguridad.setjustcreated();
            }
            if ( StringUtil.Len( WebComp_Wc_seguridad_Component) != 0 )
            {
               WebComp_Wc_seguridad.componentprepare(new Object[] {(String)sPrefix+"W0019",(String)"",(String)AV6USUARIO});
               WebComp_Wc_seguridad.componentbind(new Object[] {(String)sPrefix+"vUSUARIO"});
            }
            AV19context.gxTpr_User = StringUtil.Trim( AV6USUARIO) ;
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19context", (Object)(AV19context));
            new setcontext(context ).execute(  AV19context) ;
            context.DoAjaxRefresh();
         }
         else
         {
            WebComp_Wc_seguridad_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"gxHTMLWrpW0019"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wc_seguridad_Visible), 5, 0)));
            /* Object Property */
            if ( StringUtil.StrCmp(WebComp_Wc_seguridad_Component, "HNO_HABILITADO") != 0 )
            {
               WebComp_Wc_seguridad = getWebComponent(GetType(), "GeneXus.Programs", "hno_habilitado", new Object[] {context} );
               WebComp_Wc_seguridad.ComponentInit();
               WebComp_Wc_seguridad.Name = "HNO_HABILITADO";
               WebComp_Wc_seguridad_Component = "HNO_HABILITADO" ;
            }
            if ( StringUtil.StrCmp(OldWc_seguridad, WebComp_Wc_seguridad_Component) != 0 )
            {
               WebComp_Wc_seguridad.setjustcreated();
            }
            if ( StringUtil.Len( WebComp_Wc_seguridad_Component) != 0 )
            {
               WebComp_Wc_seguridad.componentprepare(new Object[] {(String)sPrefix+"W0019",(String)"",(String)AV6USUARIO});
               WebComp_Wc_seguridad.componentbind(new Object[] {(String)sPrefix+"vUSUARIO"});
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E13252( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_252( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + "background-color: " + context.BuildHTMLColor( (int)(0xDCDCDC)) + ";" ;
            if ( StringUtil.StrCmp(context.BuildHTMLColor( (int)(0x000000))+";", "") != 0 )
            {
               sStyleString = sStyleString + " border-color: " + context.BuildHTMLColor( (int)(0x000000)) + ";" ;
            }
            sStyleString = sStyleString + "border:" + StringUtil.Str( (decimal)(2), 3, 0) + "px solid;" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(112), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(22), 10, 0)) + ".1%" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 2, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_252( true) ;
         }
         else
         {
            wb_table2_5_252( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_252e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_252e( true) ;
         }
         else
         {
            wb_table1_2_252e( false) ;
         }
      }

      protected void wb_table2_5_252( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + "background-color: " + context.BuildHTMLColor( (int)(0xDCDCDC)) + ";" ;
            sStyleString = sStyleString + " border-color: " + "Transparent;" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(70), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTabla_sistemas_Internalname, tblTabla_sistemas_Internalname, "", "Table95", 0, "center", "", 1, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<caption>") ;
            /* Text block */
            ClassString = "Title" ;
            StyleString = "color:#FF0000; background:#DCDCDC" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Confirme su Identificación", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_WCSEGURIDAD.htm");
            context.WriteHtmlText( "</caption>") ;
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+";height:28px;width:65px\">") ;
            /* Text block */
            ClassString = "TextTable" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, 1, 1, 0, "Usuario:", "", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "HLP_WCSEGURIDAD.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsuario_Internalname, StringUtil.RTrim( AV6USUARIO), "", 16, "chr", 1, "row", 16, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6USUARIO, "XXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(11);\"", 0, edtavUsuario_Jsonclick, "", 0, 0, -1, true, "left", "HLP_WCSEGURIDAD.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+";height:27px\">") ;
            /* Text block */
            ClassString = "TextTable" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, 1, 1, 0, "Contraseña:", "", "", "", 0, lblTextblock11_Jsonclick, "", StyleString, ClassString, "HLP_WCSEGURIDAD.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_cla_Internalname, StringUtil.RTrim( AV7USU_CLA), "", 20, "chr", 1, "row", 20, 1, 1, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(16);\"", 0, edtavUsu_cla_Jsonclick, "", 0, 0, -1, true, "left", "HLP_WCSEGURIDAD.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, sPrefix+"W0019"+"", StringUtil.RTrim( WebComp_Wc_seguridad_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+sPrefix+"gxHTMLWrpW0019"+""+"\""+((WebComp_Wc_seguridad_Visible==1) ? "" : " style=\"display:none;\"")) ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Wc_seguridad_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWc_seguridad, WebComp_Wc_seguridad_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix+"gxHTMLWrpW0019"+"");
               }
               WebComp_Wc_seguridad.componentdraw();
               if ( StringUtil.StrCmp(OldWc_seguridad, WebComp_Wc_seguridad_Component) != 0 )
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
            wb_table2_5_252e( true) ;
         }
         else
         {
            wb_table2_5_252e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8PRG_WEB = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8PRG_WEB", AV8PRG_WEB);
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
         PA252( ) ;
         WS252( ) ;
         WE252( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV8PRG_WEB = (String)((String)getParm(obj,0)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA252( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "wcseguridad");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA252( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8PRG_WEB = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8PRG_WEB", AV8PRG_WEB);
         }
         wcpOAV8PRG_WEB = cgiGet( sPrefix+"wcpOAV8PRG_WEB") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV8PRG_WEB, wcpOAV8PRG_WEB) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV8PRG_WEB = AV8PRG_WEB ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8PRG_WEB = cgiGet( sPrefix+"AV8PRG_WEB_CTRL") ;
         if ( StringUtil.Len( sCtrlAV8PRG_WEB) > 0 )
         {
            AV8PRG_WEB = cgiGet( sCtrlAV8PRG_WEB) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8PRG_WEB", AV8PRG_WEB);
         }
         else
         {
            AV8PRG_WEB = cgiGet( sPrefix+"AV8PRG_WEB_PARM") ;
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix ;
         sSFPrefix = sPSFPrefix ;
         sPrefix = sCompPrefix + sSFPrefix ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         INITWEB( ) ;
         nDraw = 0 ;
         PA252( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS252( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1 ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WS252( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8PRG_WEB_PARM", StringUtil.RTrim( AV8PRG_WEB));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8PRG_WEB)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8PRG_WEB_CTRL", StringUtil.RTrim( sCtrlAV8PRG_WEB));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WCParametersSet( ) ;
         WE252( ) ;
         this.cleanup();
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1) ;
         }
         else
         {
            sCtrlName = sGXControl ;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
         if ( ! ( WebComp_Wc_seguridad == null ) )
         {
            WebComp_Wc_seguridad.componentjscripts();
         }
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         if ( StringUtil.StrCmp(WebComp_Wc_seguridad_Component, "") == 0 )
         {
            WebComp_Wc_seguridad = getWebComponent(GetType(), "GeneXus.Programs", "hsi_habilitado", new Object[] {context} );
            WebComp_Wc_seguridad.ComponentInit();
            WebComp_Wc_seguridad.Name = "HSI_HABILITADO";
            WebComp_Wc_seguridad_Component = "HSI_HABILITADO" ;
         }
         if ( ! ( WebComp_Wc_seguridad == null ) )
         {
            if ( StringUtil.Len( WebComp_Wc_seguridad_Component) != 0 )
            {
               WebComp_Wc_seguridad.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19301259");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("wcseguridad.js", "?19301259");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = sPrefix+"TEXTBLOCK1" ;
         lblTextblock10_Internalname = sPrefix+"TEXTBLOCK10" ;
         edtavUsuario_Internalname = sPrefix+"vUSUARIO" ;
         lblTextblock11_Internalname = sPrefix+"TEXTBLOCK11" ;
         edtavUsu_cla_Internalname = sPrefix+"vUSU_CLA" ;
         tblTabla_sistemas_Internalname = sPrefix+"TABLA_SISTEMAS" ;
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavUsu_cla_Jsonclick = "" ;
         edtavUsuario_Jsonclick = "" ;
         WebComp_Wc_seguridad_Visible = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"gxHTMLWrpW0019"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wc_seguridad_Visible), 5, 0)));
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
         wcpOAV8PRG_WEB = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         OldWc_seguridad = "" ;
         WebComp_Wc_seguridad_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV6USUARIO = "" ;
         AV7USU_CLA = "" ;
         AV19context = new SdtContext(context);
         scmdbuf = "" ;
         H00252_A6USU_COD = new String[] {""} ;
         H00252_A7USU_DES = new String[] {""} ;
         H00252_A155USU_CLA = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         A155USU_CLA = "" ;
         H00253_A117PRG_WEB = new String[] {""} ;
         H00253_A127PRG_DES = new String[] {""} ;
         H00253_A126PRG_COD = new short[1] ;
         H00253_A164PRG_SIS = new short[1] ;
         A117PRG_WEB = "" ;
         A127PRG_DES = "" ;
         H00254_A126PRG_COD = new short[1] ;
         H00254_A116SIS_COD = new short[1] ;
         H00254_A569USU_COD_ = new String[] {""} ;
         A569USU_COD_ = "" ;
         AV9SESION = new GxWebSession( context);
         AV12NOM_COOKIE = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         TempTags = "" ;
         lblTextblock11_Jsonclick = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8PRG_WEB = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wcseguridad__default(),
            new Object[][] {
                new Object[] {
               H00252_A6USU_COD, H00252_A7USU_DES, H00252_A155USU_CLA
               }
               , new Object[] {
               H00253_A117PRG_WEB, H00253_A127PRG_DES, H00253_A126PRG_COD, H00253_A164PRG_SIS
               }
               , new Object[] {
               H00254_A126PRG_COD, H00254_A116SIS_COD, H00254_A569USU_COD_
               }
            }
         );
         WebComp_Wc_seguridad = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short AV10USU_HABIL ;
      private short A126PRG_COD ;
      private short A164PRG_SIS ;
      private short AV15PRG_COD ;
      private short AV16SIS_COD ;
      private short A116SIS_COD ;
      private short AV13A ;
      private short nGXWrapped ;
      private int WebComp_Wc_seguridad_Visible ;
      private int AV11PRS_NRO ;
      private int idxLst ;
      private String AV8PRG_WEB ;
      private String wcpOAV8PRG_WEB ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String OldWc_seguridad ;
      private String WebComp_Wc_seguridad_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUsuario_Internalname ;
      private String AV6USUARIO ;
      private String AV7USU_CLA ;
      private String edtavUsu_cla_Internalname ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A155USU_CLA ;
      private String A117PRG_WEB ;
      private String A127PRG_DES ;
      private String A569USU_COD_ ;
      private String AV12NOM_COOKIE ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String tblTabla_sistemas_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String TempTags ;
      private String edtavUsuario_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavUsu_cla_Jsonclick ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String sCtrlAV8PRG_WEB ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GxWebSession AV9SESION ;
      private GXWebComponent WebComp_Wc_seguridad ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private String aP0_PRG_WEB ;
      private IDataStoreProvider pr_default ;
      private String[] H00252_A6USU_COD ;
      private String[] H00252_A7USU_DES ;
      private String[] H00252_A155USU_CLA ;
      private String[] H00253_A117PRG_WEB ;
      private String[] H00253_A127PRG_DES ;
      private short[] H00253_A126PRG_COD ;
      private short[] H00253_A164PRG_SIS ;
      private short[] H00254_A126PRG_COD ;
      private short[] H00254_A116SIS_COD ;
      private String[] H00254_A569USU_COD_ ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private SdtContext AV19context ;
   }

   public class wcseguridad__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00252 ;
          prmH00252 = new Object[] {
          new Object[] {"@AV6USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH00253 ;
          prmH00253 = new Object[] {
          new Object[] {"@AV8PRG_WEB",SqlDbType.Char,30,0}
          } ;
          Object[] prmH00254 ;
          prmH00254 = new Object[] {
          new Object[] {"@AV6USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV16SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV15PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00252", "SELECT [USU_COD], [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV6USUARIO ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00252,1,0,false,true )
             ,new CursorDef("H00253", "SELECT [PRG_WEB], [PRG_DES], [PRG_COD], [PRG_SIS] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_WEB] = @AV8PRG_WEB ORDER BY [PRG_WEB] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00253,100,1,true,false )
             ,new CursorDef("H00254", "SELECT [PRG_COD], [SIS_COD], [USU_COD_] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD_] = @AV6USUARIO and [SIS_COD] = @AV16SIS_COD and [PRG_COD] = @AV15PRG_COD ORDER BY [USU_COD_], [SIS_COD], [PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00254,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
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
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
