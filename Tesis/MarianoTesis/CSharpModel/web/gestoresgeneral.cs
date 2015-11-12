/*
               File: GESTORESGeneral
        Description: GESTORESGeneral
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:17.29
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
   public class gestoresgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public gestoresgeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gestoresgeneral( IGxContext context )
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

      public void execute( String aP0_GestorCod )
      {
         this.A260GestorCod = aP0_GestorCod;
         executePrivate();
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
                  A260GestorCod = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A260GestorCod", A260GestorCod);
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A260GestorCod});
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
            PA0W2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV14Pgmname = "GESTORESGeneral" ;
               context.Gx_err = 0 ;
               /* Using cursor H000W2 */
               pr_default.execute(0, new Object[] {A260GestorCod});
               A269GestorDes = H000W2_A269GestorDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A269GestorDes", A269GestorDes);
               n269GestorDes = H000W2_n269GestorDes[0] ;
               pr_default.close(0);
               WS0W2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
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
            context.WriteHtmlText( "GESTORESGeneral") ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gestoresgeneral.aspx") + "?" + UrlEncode(StringUtil.RTrim(A260GestorCod))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm0W2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA260GestorCod", StringUtil.RTrim( wcpOA260GestorCod));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("gestoresgeneral.js", "?19171733");
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
         }
      }

      protected void WB0W0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "gestoresgeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_0W2( true) ;
         }
         else
         {
            wb_table1_2_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_GESTORESGeneral.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_GESTORESGeneral.htm");
         }
         wbLoad = true ;
      }

      protected void START0W2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "GESTORESGeneral", 0) ;
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
            context.wbHandled = 0 ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName") ;
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false ;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP0W0( ) ;
            }
         }
      }

      protected void WS0W2( )
      {
         START0W2( ) ;
         EVT0W2( ) ;
      }

      protected void EVT0W2( )
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
                                 STRUP0W0( ) ;
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
                                 STRUP0W0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E110W2 */
                                    E110W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E120W2 */
                                    E120W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E130W2 */
                                    E130W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E140W2 */
                                    E140W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
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
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
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
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE0W2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0W2( ) ;
            }
         }
      }

      protected void PA0W2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF0W2( ) ;
         /* End function Refresh */
      }

      protected void RF0W2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000W3 */
            pr_default.execute(1, new Object[] {A260GestorCod});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A267GestorRamoDes = H000W3_A267GestorRamoDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A267GestorRamoDes", A267GestorRamoDes);
               A265GestorRamoCod = H000W3_A265GestorRamoCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A265GestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A265GestorRamoCod), 2, 0)));
               n265GestorRamoCod = H000W3_n265GestorRamoCod[0] ;
               /* Execute user event: E120W2 */
               E120W2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            WB0W0( ) ;
         }
      }

      protected void STRUP0W0( )
      {
         /* Before Start, stand alone formulas. */
         AV14Pgmname = "GESTORESGeneral" ;
         context.Gx_err = 0 ;
         /* Using cursor H000W4 */
         pr_default.execute(2, new Object[] {A260GestorCod});
         A269GestorDes = H000W4_A269GestorDes[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A269GestorDes", A269GestorDes);
         n269GestorDes = H000W4_n269GestorDes[0] ;
         pr_default.close(2);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110W2 */
         E110W2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A260GestorCod = StringUtil.Upper( cgiGet( edtGestorCod_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A260GestorCod", A260GestorCod);
            }
            A269GestorDes = StringUtil.Upper( cgiGet( edtGestorDes_Internalname)) ;
            n269GestorDes = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A269GestorDes", A269GestorDes);
            A265GestorRamoCod = (short)(context.localUtil.CToN( cgiGet( edtGestorRamoCod_Internalname), ",", ".")) ;
            n265GestorRamoCod = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A265GestorRamoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A265GestorRamoCod), 2, 0)));
            A267GestorRamoDes = cgiGet( edtGestorRamoDes_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A267GestorRamoDes", A267GestorRamoDes);
            /* Read saved values. */
            wcpOA260GestorCod = cgiGet( sPrefix+"wcpOA260GestorCod") ;
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
         /* Execute user event: E110W2 */
         E110W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110W2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV14Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)) ;
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E120W2( )
      {
         /* Load Routine */
      }

      protected void E130W2( )
      {
         /* 'DoUpdate' Routine */
         context.wjLoc = formatLink("gestores.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A260GestorCod)) ;
      }

      protected void E140W2( )
      {
         /* 'DoDelete' Routine */
         context.wjLoc = formatLink("gestores.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A260GestorCod)) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new SdtTransactionContext(context) ;
         AV8TrnContext.gxTpr_Callerobject = AV14Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV8TrnContext.gxTpr_Callerondelete = false ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV8TrnContext.gxTpr_Callerurl = AV11HTTPRequest.ScriptName+"?"+AV11HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV8TrnContext.gxTpr_Transactionname = "GESTORES" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV9TrnContextAtt.gxTpr_Attributename = "GestorCod" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV9TrnContextAtt.gxTpr_Attributevalue = AV7GestorCod ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV8TrnContext.gxTpr_Attributes.Add(AV9TrnContextAtt, 0);
         AV10Session.Set("TrnContext", AV8TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTbl2_Internalname, tblTbl2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestorcod_Internalname, 1, 1, 0, "Cod Gestor ", "", "", "", 0, lblTextblockgestorcod_Jsonclick, "", StyleString, ClassString, "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGestorCod_Internalname, StringUtil.RTrim( A260GestorCod), "", 15, "chr", 1, "row", 15, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A260GestorCod, "@!")), "", 0, edtGestorCod_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgestordes_Internalname, 1, 1, 0, "Gestor", "", "", "", 0, lblTextblockgestordes_Jsonclick, "", StyleString, ClassString, "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGestorDes_Internalname, StringUtil.RTrim( A269GestorDes), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A269GestorDes, "@!")), "", 0, edtGestorDes_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Cod Ramo", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "color:#747474" ;
            GxWebStd.gx_single_line_edit( context, edtGestorRamoCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A265GestorRamoCod), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A265GestorRamoCod), "Z9"), "", 0, edtGestorRamoCod_Jsonclick, "", 0, 1, 1, true, "right", "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Ramo", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "color:#747474" ;
            GxWebStd.gx_single_line_edit( context, edtGestorRamoDes_Internalname, StringUtil.RTrim( A267GestorRamoDes), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A267GestorRamoDes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtGestorRamoDes_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GESTORESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0W2e( true) ;
         }
         else
         {
            wb_table1_2_0W2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A260GestorCod = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A260GestorCod", A260GestorCod);
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
         PA0W2( ) ;
         WS0W2( ) ;
         WE0W2( ) ;
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
         sCtrlA260GestorCod = (String)((String)getParm(obj,0)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA0W2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "gestoresgeneral");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0W2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A260GestorCod = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A260GestorCod", A260GestorCod);
         }
         wcpOA260GestorCod = cgiGet( sPrefix+"wcpOA260GestorCod") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A260GestorCod, wcpOA260GestorCod) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOA260GestorCod = A260GestorCod ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA260GestorCod = cgiGet( sPrefix+"A260GestorCod_CTRL") ;
         if ( StringUtil.Len( sCtrlA260GestorCod) > 0 )
         {
            A260GestorCod = cgiGet( sCtrlA260GestorCod) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A260GestorCod", A260GestorCod);
         }
         else
         {
            A260GestorCod = cgiGet( sPrefix+"A260GestorCod_PARM") ;
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
         PA0W2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS0W2( ) ;
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
         WS0W2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A260GestorCod_PARM", StringUtil.RTrim( A260GestorCod));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA260GestorCod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A260GestorCod_CTRL", StringUtil.RTrim( sCtrlA260GestorCod));
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
         WE0W2( ) ;
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
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?1915234");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19171754");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("gestoresgeneral.js", "?19171754");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockgestorcod_Internalname = sPrefix+"TEXTBLOCKGESTORCOD" ;
         edtGestorCod_Internalname = sPrefix+"GESTORCOD" ;
         lblTextblockgestordes_Internalname = sPrefix+"TEXTBLOCKGESTORDES" ;
         edtGestorDes_Internalname = sPrefix+"GESTORDES" ;
         lblTextblock1_Internalname = sPrefix+"TEXTBLOCK1" ;
         edtGestorRamoCod_Internalname = sPrefix+"GESTORRAMOCOD" ;
         lblTextblock2_Internalname = sPrefix+"TEXTBLOCK2" ;
         edtGestorRamoDes_Internalname = sPrefix+"GESTORRAMODES" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtGestorRamoDes_Jsonclick = "" ;
         edtGestorRamoCod_Jsonclick = "" ;
         edtGestorDes_Jsonclick = "" ;
         edtGestorCod_Jsonclick = "" ;
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
         wcpOA260GestorCod = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         AV14Pgmname = "" ;
         scmdbuf = "" ;
         H000W2_A269GestorDes = new String[] {""} ;
         H000W2_n269GestorDes = new bool[] {false} ;
         A269GestorDes = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GX_FocusControl = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtnupdate_Jsonclick = "" ;
         bttBtndelete_Jsonclick = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         H000W3_A260GestorCod = new String[] {""} ;
         H000W3_A267GestorRamoDes = new String[] {""} ;
         H000W3_A265GestorRamoCod = new short[1] ;
         H000W3_n265GestorRamoCod = new bool[] {false} ;
         H000W3_A269GestorDes = new String[] {""} ;
         H000W3_n269GestorDes = new bool[] {false} ;
         A267GestorRamoDes = "" ;
         H000W4_A269GestorDes = new String[] {""} ;
         H000W4_n269GestorDes = new bool[] {false} ;
         AV8TrnContext = new SdtTransactionContext(context);
         AV11HTTPRequest = new GxHttpRequest( context);
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7GestorCod = "" ;
         AV10Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockgestorcod_Jsonclick = "" ;
         lblTextblockgestordes_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA260GestorCod = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gestoresgeneral__default(),
            new Object[][] {
                new Object[] {
               H000W2_A269GestorDes, H000W2_n269GestorDes
               }
               , new Object[] {
               H000W3_A260GestorCod, H000W3_A267GestorRamoDes, H000W3_A265GestorRamoCod, H000W3_n265GestorRamoCod, H000W3_A269GestorDes, H000W3_n269GestorDes
               }
               , new Object[] {
               H000W4_A269GestorDes, H000W4_n269GestorDes
               }
            }
         );
         AV14Pgmname = "GESTORESGeneral" ;
         /* GeneXus formulas. */
         AV14Pgmname = "GESTORESGeneral" ;
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
      private short nDonePA ;
      private short A265GestorRamoCod ;
      private short nGXWrapped ;
      private int idxLst ;
      private String A260GestorCod ;
      private String wcpOA260GestorCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV14Pgmname ;
      private String scmdbuf ;
      private String A269GestorDes ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GX_FocusControl ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String A267GestorRamoDes ;
      private String edtGestorCod_Internalname ;
      private String edtGestorDes_Internalname ;
      private String edtGestorRamoCod_Internalname ;
      private String edtGestorRamoDes_Internalname ;
      private String AV7GestorCod ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockgestorcod_Internalname ;
      private String lblTextblockgestorcod_Jsonclick ;
      private String edtGestorCod_Jsonclick ;
      private String lblTextblockgestordes_Internalname ;
      private String lblTextblockgestordes_Jsonclick ;
      private String edtGestorDes_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtGestorRamoCod_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtGestorRamoDes_Jsonclick ;
      private String sCtrlA260GestorCod ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool n269GestorDes ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n265GestorRamoCod ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000W2_A269GestorDes ;
      private bool[] H000W2_n269GestorDes ;
      private String[] H000W3_A260GestorCod ;
      private String[] H000W3_A267GestorRamoDes ;
      private short[] H000W3_A265GestorRamoCod ;
      private bool[] H000W3_n265GestorRamoCod ;
      private String[] H000W3_A269GestorDes ;
      private bool[] H000W3_n269GestorDes ;
      private String[] H000W4_A269GestorDes ;
      private bool[] H000W4_n269GestorDes ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV11HTTPRequest ;
      private GxWebSession AV10Session ;
      private SdtTransactionContext AV8TrnContext ;
      private SdtTransactionContext_Attribute AV9TrnContextAtt ;
   }

   public class gestoresgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000W2 ;
          prmH000W2 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmH000W3 ;
          prmH000W3 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmH000W4 ;
          prmH000W4 = new Object[] {
          new Object[] {"@GestorCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000W2", "SELECT [USU_DES] AS GestorDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GestorCod ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W2,1,0,true,true )
             ,new CursorDef("H000W3", "SELECT T1.[GestorCod] AS GestorCod, T1.[GestorRamoDes], T1.[GestorRamoCod], T2.[USU_DES] AS GestorDes FROM ([GESTORES] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[GestorCod]) WHERE T1.[GestorCod] = @GestorCod ORDER BY T1.[GestorCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W3,1,0,true,true )
             ,new CursorDef("H000W4", "SELECT [USU_DES] AS GestorDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GestorCod ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W4,1,0,true,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                break;
       }
    }

 }

}
