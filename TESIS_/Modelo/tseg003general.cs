/*
               File: TSEG003General
        Description: TSEG003 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:43.88
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
   public class tseg003general : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tseg003general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg003general( IGxContext context )
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
                           short aP1_SIS_COD )
      {
         this.A6USU_COD = aP0_USU_COD;
         this.A116SIS_COD = aP1_SIS_COD;
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
                  A6USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
                  A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A6USU_COD,(short)A116SIS_COD});
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
            PA0R2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "TSEG003General" ;
               context.Gx_err = 0 ;
               /* Using cursor H000R2 */
               pr_default.execute(0, new Object[] {A6USU_COD});
               A155USU_CLA = H000R2_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
               A7USU_DES = H000R2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
               pr_default.close(0);
               /* Using cursor H000R3 */
               pr_default.execute(1, new Object[] {A116SIS_COD});
               A259SIS_DES = H000R3_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A259SIS_DES", A259SIS_DES);
               pr_default.close(1);
               WS0R2( ) ;
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
            context.WriteHtmlText( "TSEG003 General") ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg003general.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm0R2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA6USU_COD", StringUtil.RTrim( wcpOA6USU_COD));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA116SIS_COD), 3, 0, ",", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tseg003general.js", "?11194395");
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

      protected void WB0R0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tseg003general.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_0R2( true) ;
         }
         else
         {
            wb_table1_2_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_TSEG003General.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_TSEG003General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLA_Internalname, StringUtil.RTrim( A155USU_CLA), "", 20, "chr", 1, "row", 20, edtUSU_CLA_Visible, 0, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtUSU_CLA_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG003General.htm");
         }
         wbLoad = true ;
      }

      protected void START0R2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "TSEG003 General", 0) ;
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
               STRUP0R0( ) ;
            }
         }
      }

      protected void WS0R2( )
      {
         START0R2( ) ;
         EVT0R2( ) ;
      }

      protected void EVT0R2( )
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
                                 STRUP0R0( ) ;
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
                                 STRUP0R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E110R2 */
                                    E110R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E120R2 */
                                    E120R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E130R2 */
                                    E130R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E140R2 */
                                    E140R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
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
                                 STRUP0R0( ) ;
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

      protected void WE0R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0R2( ) ;
            }
         }
      }

      protected void PA0R2( )
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
         RF0R2( ) ;
         /* End function Refresh */
      }

      protected void RF0R2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000R4 */
            pr_default.execute(2, new Object[] {A6USU_COD, A116SIS_COD});
            while ( (pr_default.getStatus(2) != 101) )
            {
               /* Execute user event: E120R2 */
               E120R2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            WB0R0( ) ;
         }
      }

      protected void STRUP0R0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "TSEG003General" ;
         context.Gx_err = 0 ;
         /* Using cursor H000R5 */
         pr_default.execute(3, new Object[] {A6USU_COD});
         A155USU_CLA = H000R5_A155USU_CLA[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
         A7USU_DES = H000R5_A7USU_DES[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
         pr_default.close(3);
         /* Using cursor H000R6 */
         pr_default.execute(4, new Object[] {A116SIS_COD});
         A259SIS_DES = H000R6_A259SIS_DES[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A259SIS_DES", A259SIS_DES);
         pr_default.close(4);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110R2 */
         E110R2 ();
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
               A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
            }
            A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            }
            A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A259SIS_DES", A259SIS_DES);
            A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
            /* Read saved values. */
            wcpOA6USU_COD = cgiGet( sPrefix+"wcpOA6USU_COD") ;
            wcpOA116SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA116SIS_COD"), ",", ".")) ;
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
         /* Execute user event: E110R2 */
         E110R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110R2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV15Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)) ;
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

      protected void E120R2( )
      {
         /* Load Routine */
         edtUSU_DES_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUSU_DES_Internalname, "Link", edtUSU_DES_Link);
         edtUSU_CLA_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUSU_CLA_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CLA_Visible), 5, 0)));
      }

      protected void E130R2( )
      {
         /* 'DoUpdate' Routine */
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) ;
         context.wjLoc = formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E140R2( )
      {
         /* 'DoDelete' Routine */
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) ;
         context.wjLoc = formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new SdtTransactionContext(context) ;
         AV9TrnContext.gxTpr_Callerobject = AV15Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV9TrnContext.gxTpr_Callerondelete = false ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV9TrnContext.gxTpr_Transactionname = "TSEG003" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "USU_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = AV7USU_COD ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "SIS_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8SIS_COD), 3, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_0R2( bool wbgen )
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
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockusu_cod_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), "", 0, edtUSU_COD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockusu_des_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, edtUSU_DES_Link, "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksis_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblocksis_cod_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), "", 0, edtSIS_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksis_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblocksis_des_Jsonclick, "", StyleString, ClassString, "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG003General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0R2e( true) ;
         }
         else
         {
            wb_table1_2_0R2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A6USU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
         A116SIS_COD = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
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
         PA0R2( ) ;
         WS0R2( ) ;
         WE0R2( ) ;
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
         sCtrlA6USU_COD = (String)((String)getParm(obj,0)) ;
         sCtrlA116SIS_COD = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA0R2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "tseg003general");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0R2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A6USU_COD = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = Convert.ToInt16(getParm(obj,3)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
         wcpOA6USU_COD = cgiGet( sPrefix+"wcpOA6USU_COD") ;
         wcpOA116SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA116SIS_COD"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A6USU_COD, wcpOA6USU_COD) != 0 ) || ( A116SIS_COD != wcpOA116SIS_COD ) ) )
         {
            setjustcreated();
         }
         wcpOA6USU_COD = A6USU_COD ;
         wcpOA116SIS_COD = A116SIS_COD ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA6USU_COD = cgiGet( sPrefix+"A6USU_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlA6USU_COD) > 0 )
         {
            A6USU_COD = cgiGet( sCtrlA6USU_COD) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
         }
         else
         {
            A6USU_COD = cgiGet( sPrefix+"A6USU_COD_PARM") ;
         }
         sCtrlA116SIS_COD = cgiGet( sPrefix+"A116SIS_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlA116SIS_COD) > 0 )
         {
            A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( sCtrlA116SIS_COD), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
         else
         {
            A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A116SIS_COD_PARM"), ",", ".")) ;
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
         PA0R2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS0R2( ) ;
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
         WS0R2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A6USU_COD_PARM", StringUtil.RTrim( A6USU_COD));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA6USU_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A6USU_COD_CTRL", StringUtil.RTrim( sCtrlA6USU_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A116SIS_COD_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA116SIS_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A116SIS_COD_CTRL", StringUtil.RTrim( sCtrlA116SIS_COD));
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
         WE0R2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11194423");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("tseg003general.js", "?11194423");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockusu_cod_Internalname = sPrefix+"TEXTBLOCKUSU_COD" ;
         edtUSU_COD_Internalname = sPrefix+"USU_COD" ;
         lblTextblockusu_des_Internalname = sPrefix+"TEXTBLOCKUSU_DES" ;
         edtUSU_DES_Internalname = sPrefix+"USU_DES" ;
         lblTextblocksis_cod_Internalname = sPrefix+"TEXTBLOCKSIS_COD" ;
         edtSIS_COD_Internalname = sPrefix+"SIS_COD" ;
         lblTextblocksis_des_Internalname = sPrefix+"TEXTBLOCKSIS_DES" ;
         edtSIS_DES_Internalname = sPrefix+"SIS_DES" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         edtUSU_CLA_Internalname = sPrefix+"USU_CLA" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_COD_Jsonclick = "" ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtUSU_DES_Link = "" ;
         edtUSU_CLA_Jsonclick = "" ;
         edtUSU_CLA_Visible = 1 ;
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
         wcpOA6USU_COD = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         AV15Pgmname = "" ;
         scmdbuf = "" ;
         H000R2_A155USU_CLA = new String[] {""} ;
         H000R2_A7USU_DES = new String[] {""} ;
         A155USU_CLA = "" ;
         A7USU_DES = "" ;
         H000R3_A259SIS_DES = new String[] {""} ;
         A259SIS_DES = "" ;
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
         H000R4_A6USU_COD = new String[] {""} ;
         H000R4_A116SIS_COD = new short[1] ;
         H000R4_A155USU_CLA = new String[] {""} ;
         H000R4_A259SIS_DES = new String[] {""} ;
         H000R4_A7USU_DES = new String[] {""} ;
         H000R5_A155USU_CLA = new String[] {""} ;
         H000R5_A7USU_DES = new String[] {""} ;
         H000R6_A259SIS_DES = new String[] {""} ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         AV9TrnContext = new SdtTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7USU_COD = "" ;
         AV11Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockusu_cod_Jsonclick = "" ;
         lblTextblockusu_des_Jsonclick = "" ;
         lblTextblocksis_cod_Jsonclick = "" ;
         lblTextblocksis_des_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA6USU_COD = "" ;
         sCtrlA116SIS_COD = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg003general__default(),
            new Object[][] {
                new Object[] {
               H000R2_A155USU_CLA, H000R2_A7USU_DES
               }
               , new Object[] {
               H000R3_A259SIS_DES
               }
               , new Object[] {
               H000R4_A6USU_COD, H000R4_A116SIS_COD, H000R4_A155USU_CLA, H000R4_A259SIS_DES, H000R4_A7USU_DES
               }
               , new Object[] {
               H000R5_A155USU_CLA, H000R5_A7USU_DES
               }
               , new Object[] {
               H000R6_A259SIS_DES
               }
            }
         );
         AV15Pgmname = "TSEG003General" ;
         /* GeneXus formulas. */
         AV15Pgmname = "TSEG003General" ;
         context.Gx_err = 0 ;
      }

      private short A116SIS_COD ;
      private short wcpOA116SIS_COD ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV8SIS_COD ;
      private short nGXWrapped ;
      private int edtUSU_CLA_Visible ;
      private int idxLst ;
      private String A6USU_COD ;
      private String wcpOA6USU_COD ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV15Pgmname ;
      private String scmdbuf ;
      private String A155USU_CLA ;
      private String A7USU_DES ;
      private String A259SIS_DES ;
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
      private String edtUSU_CLA_Internalname ;
      private String edtUSU_CLA_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String edtUSU_DES_Link ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String AV7USU_COD ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockusu_cod_Internalname ;
      private String lblTextblockusu_cod_Jsonclick ;
      private String edtUSU_COD_Jsonclick ;
      private String lblTextblockusu_des_Internalname ;
      private String lblTextblockusu_des_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
      private String lblTextblocksis_cod_Internalname ;
      private String lblTextblocksis_cod_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String lblTextblocksis_des_Internalname ;
      private String lblTextblocksis_des_Jsonclick ;
      private String edtSIS_DES_Jsonclick ;
      private String sCtrlA6USU_COD ;
      private String sCtrlA116SIS_COD ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000R2_A155USU_CLA ;
      private String[] H000R2_A7USU_DES ;
      private String[] H000R3_A259SIS_DES ;
      private String[] H000R4_A6USU_COD ;
      private short[] H000R4_A116SIS_COD ;
      private String[] H000R4_A155USU_CLA ;
      private String[] H000R4_A259SIS_DES ;
      private String[] H000R4_A7USU_DES ;
      private String[] H000R5_A155USU_CLA ;
      private String[] H000R5_A7USU_DES ;
      private String[] H000R6_A259SIS_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private GxWebSession AV11Session ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class tseg003general__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000R2 ;
          prmH000R2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH000R3 ;
          prmH000R3 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH000R4 ;
          prmH000R4 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH000R5 ;
          prmH000R5 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH000R6 ;
          prmH000R6 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000R2", "SELECT [USU_CLA], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R2,1,0,true,true )
             ,new CursorDef("H000R3", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R3,1,1,true,true )
             ,new CursorDef("H000R4", "SELECT T1.[USU_COD], T1.[SIS_COD], T2.[USU_CLA], T3.[SIS_DES], T2.[USU_DES] FROM (([SEG003] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = T1.[SIS_COD]) WHERE T1.[USU_COD] = @USU_COD and T1.[SIS_COD] = @SIS_COD ORDER BY T1.[USU_COD], T1.[SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R4,1,0,true,true )
             ,new CursorDef("H000R5", "SELECT [USU_CLA], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R5,1,0,true,true )
             ,new CursorDef("H000R6", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R6,1,1,true,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 50) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
