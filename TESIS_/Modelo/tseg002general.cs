/*
               File: TSEG002General
        Description: TSEG002 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:23.1
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
   public class tseg002general : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tseg002general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg002general( IGxContext context )
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

      public void execute( String aP0_USU_COD )
      {
         this.A6USU_COD = aP0_USU_COD;
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
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A6USU_COD});
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
            PA0G2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV14Pgmname = "TSEG002General" ;
               context.Gx_err = 0 ;
               WS0G2( ) ;
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
            context.WriteHtmlText( "TSEG002 General") ;
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
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg002general.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm0G2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA6USU_COD", StringUtil.RTrim( wcpOA6USU_COD));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tseg002general.js", "?118235");
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

      protected void WB0G0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tseg002general.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_0G2( true) ;
         }
         else
         {
            wb_table1_2_0G2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0G2e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_TSEG002General.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_TSEG002General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLA_Internalname, StringUtil.RTrim( A155USU_CLA), "", 20, "chr", 1, "row", 20, edtUSU_CLA_Visible, 0, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtUSU_CLA_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
         }
         wbLoad = true ;
      }

      protected void START0G2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "TSEG002 General", 0) ;
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
               STRUP0G0( ) ;
            }
         }
      }

      protected void WS0G2( )
      {
         START0G2( ) ;
         EVT0G2( ) ;
      }

      protected void EVT0G2( )
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
                                 STRUP0G0( ) ;
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
                                 STRUP0G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E110G2 */
                                    E110G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E120G2 */
                                    E120G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E130G2 */
                                    E130G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E140G2 */
                                    E140G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0G0( ) ;
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
                                 STRUP0G0( ) ;
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

      protected void WE0G2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0G2( ) ;
            }
         }
      }

      protected void PA0G2( )
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
         RF0G2( ) ;
         /* End function Refresh */
      }

      protected void RF0G2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000G2 */
            pr_default.execute(0, new Object[] {A6USU_COD});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A155USU_CLA = H000G2_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
               A258USU_ERR = H000G2_A258USU_ERR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A258USU_ERR", StringUtil.LTrim( StringUtil.Str( (decimal)(A258USU_ERR), 4, 0)));
               A257USU_ACTIV = H000G2_A257USU_ACTIV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A257USU_ACTIV", context.localUtil.TToC( A257USU_ACTIV, 8, 5, 0, 3, "/", ":", " "));
               A256USU_STS = H000G2_A256USU_STS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A256USU_STS", StringUtil.LTrim( StringUtil.Str( (decimal)(A256USU_STS), 2, 0)));
               A255USU_NROW = H000G2_A255USU_NROW[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A255USU_NROW", StringUtil.LTrim( StringUtil.Str( (decimal)(A255USU_NROW), 11, 0)));
               A254USU_TIPW = H000G2_A254USU_TIPW[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A254USU_TIPW", A254USU_TIPW);
               A249USU_MAIW = H000G2_A249USU_MAIW[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A249USU_MAIW", A249USU_MAIW);
               n249USU_MAIW = H000G2_n249USU_MAIW[0] ;
               A253USU_CLAK = H000G2_A253USU_CLAK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A253USU_CLAK", A253USU_CLAK);
               n253USU_CLAK = H000G2_n253USU_CLAK[0] ;
               A180USU_INT = H000G2_A180USU_INT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180USU_INT", A180USU_INT);
               A252USU_LEG = H000G2_A252USU_LEG[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A252USU_LEG", StringUtil.LTrim( StringUtil.Str( (decimal)(A252USU_LEG), 5, 0)));
               A251USU_EMP = H000G2_A251USU_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A251USU_EMP", A251USU_EMP);
               A250USU_CDA = H000G2_A250USU_CDA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A250USU_CDA", A250USU_CDA);
               A156USU_FEC = H000G2_A156USU_FEC[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A156USU_FEC", context.localUtil.Format(A156USU_FEC, "99/99/9999"));
               A7USU_DES = H000G2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
               /* Execute user event: E120G2 */
               E120G2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0G0( ) ;
         }
      }

      protected void STRUP0G0( )
      {
         /* Before Start, stand alone formulas. */
         AV14Pgmname = "TSEG002General" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110G2 */
         E110G2 ();
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
            A156USU_FEC = context.localUtil.CToD( cgiGet( edtUSU_FEC_Internalname), 4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A156USU_FEC", context.localUtil.Format(A156USU_FEC, "99/99/9999"));
            A250USU_CDA = StringUtil.Upper( cgiGet( edtUSU_CDA_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A250USU_CDA", A250USU_CDA);
            A251USU_EMP = cgiGet( edtUSU_EMP_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A251USU_EMP", A251USU_EMP);
            A252USU_LEG = (int)(context.localUtil.CToN( cgiGet( edtUSU_LEG_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A252USU_LEG", StringUtil.LTrim( StringUtil.Str( (decimal)(A252USU_LEG), 5, 0)));
            A180USU_INT = cgiGet( edtUSU_INT_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180USU_INT", A180USU_INT);
            A253USU_CLAK = cgiGet( edtUSU_CLAK_Internalname) ;
            n253USU_CLAK = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A253USU_CLAK", A253USU_CLAK);
            A249USU_MAIW = cgiGet( edtUSU_MAIW_Internalname) ;
            n249USU_MAIW = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A249USU_MAIW", A249USU_MAIW);
            A254USU_TIPW = cgiGet( edtUSU_TIPW_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A254USU_TIPW", A254USU_TIPW);
            A255USU_NROW = (long)(context.localUtil.CToN( cgiGet( edtUSU_NROW_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A255USU_NROW", StringUtil.LTrim( StringUtil.Str( (decimal)(A255USU_NROW), 11, 0)));
            A256USU_STS = (short)(context.localUtil.CToN( cgiGet( edtUSU_STS_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A256USU_STS", StringUtil.LTrim( StringUtil.Str( (decimal)(A256USU_STS), 2, 0)));
            A257USU_ACTIV = context.localUtil.CToT( cgiGet( edtUSU_ACTIV_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A257USU_ACTIV", context.localUtil.TToC( A257USU_ACTIV, 8, 5, 0, 3, "/", ":", " "));
            A258USU_ERR = (short)(context.localUtil.CToN( cgiGet( edtUSU_ERR_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A258USU_ERR", StringUtil.LTrim( StringUtil.Str( (decimal)(A258USU_ERR), 4, 0)));
            A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
            /* Read saved values. */
            wcpOA6USU_COD = cgiGet( sPrefix+"wcpOA6USU_COD") ;
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
         /* Execute user event: E110G2 */
         E110G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110G2( )
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

      protected void E120G2( )
      {
         /* Load Routine */
         edtUSU_CLA_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUSU_CLA_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CLA_Visible), 5, 0)));
      }

      protected void E130G2( )
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
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) ;
         context.wjLoc = formatLink("tseg002.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E140G2( )
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
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) ;
         context.wjLoc = formatLink("tseg002.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
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
         AV8TrnContext.gxTpr_Transactionname = "TSEG002" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV9TrnContextAtt.gxTpr_Attributename = "USU_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV9TrnContextAtt.gxTpr_Attributevalue = AV7USU_COD ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV8TrnContext.gxTpr_Attributes.Add(AV9TrnContextAtt, 0);
         AV10Session.Set("TrnContext", AV8TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_0G2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockusu_cod_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), "", 0, edtUSU_COD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockusu_des_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_fec_Internalname, 1, 1, 0, "FECHA DE CONTRASEÑA", "", "", "", 0, lblTextblockusu_fec_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtUSU_FEC_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtUSU_FEC_Internalname, context.localUtil.Format(A156USU_FEC, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A156USU_FEC, "99/99/9999"), "", 0, edtUSU_FEC_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG002General.htm");
            GxWebStd.gx_bitmap( context, edtUSU_FEC_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG002General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cda_Internalname, 1, 1, 0, "CODIGO ANTERIOR", "", "", "", 0, lblTextblockusu_cda_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CDA_Internalname, StringUtil.RTrim( A250USU_CDA), "", 8, "chr", 1, "row", 8, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A250USU_CDA, "@!")), "", 0, edtUSU_CDA_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_emp_Internalname, 1, 1, 0, "EMPRESA", "", "", "", 0, lblTextblockusu_emp_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_EMP_Internalname, StringUtil.RTrim( A251USU_EMP), "", 3, "chr", 1, "row", 3, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A251USU_EMP, "XXX")), "", 0, edtUSU_EMP_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_leg_Internalname, 1, 1, 0, "NUMERO DE LEGAJO RHM", "", "", "", 0, lblTextblockusu_leg_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_LEG_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A252USU_LEG), 5, 0, ",", "")), "", 5, "chr", 1, "row", 5, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A252USU_LEG), "ZZZZ9"), "", 0, edtUSU_LEG_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_int_Internalname, 1, 1, 0, "NRO. TELEFONO INTERNO", "", "", "", 0, lblTextblockusu_int_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_INT_Internalname, StringUtil.RTrim( A180USU_INT), "", 10, "chr", 1, "row", 10, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A180USU_INT, "XXXXXXXXXX")), "", 0, edtUSU_INT_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_clak_Internalname, 1, 1, 0, "A ENCRIPTADA", "", "", "", 0, lblTextblockusu_clak_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLAK_Internalname, StringUtil.RTrim( A253USU_CLAK), "", 32, "chr", 1, "row", 32, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A253USU_CLAK, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtUSU_CLAK_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_maiw_Internalname, 1, 1, 0, "EN WEB", "", "", "", 0, lblTextblockusu_maiw_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtUSU_MAIW_Internalname, StringUtil.RTrim( A249USU_MAIW), 1, 0, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", "", -1, 0, "", "", true, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_tipw_Internalname, 1, 1, 0, "USUARIO WEB", "", "", "", 0, lblTextblockusu_tipw_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_TIPW_Internalname, StringUtil.RTrim( A254USU_TIPW), "", 1, "chr", 1, "row", 1, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A254USU_TIPW, "X")), "", 0, edtUSU_TIPW_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_nrow_Internalname, 1, 1, 0, "PRESTADOR/ ENTIDAD", "", "", "", 0, lblTextblockusu_nrow_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_NROW_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A255USU_NROW), 11, 0, ",", "")), "", 11, "chr", 1, "row", 11, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A255USU_NROW), "ZZZZZZZZZZ9"), "", 0, edtUSU_NROW_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_sts_Internalname, 1, 1, 0, "EN WEB", "", "", "", 0, lblTextblockusu_sts_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_STS_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A256USU_STS), 2, 0, ",", "")), "", 2, "chr", 1, "row", 2, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A256USU_STS), "Z9"), "", 0, edtUSU_STS_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_activ_Internalname, 1, 1, 0, "ACTIVACION", "", "", "", 0, lblTextblockusu_activ_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtUSU_ACTIV_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtUSU_ACTIV_Internalname, context.localUtil.Format(A257USU_ACTIV, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A257USU_ACTIV, "99/99/99 99:99"), "", 0, edtUSU_ACTIV_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG002General.htm");
            GxWebStd.gx_bitmap( context, edtUSU_ACTIV_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG002General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_err_Internalname, 1, 1, 0, "CLAVE", "", "", "", 0, lblTextblockusu_err_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_ERR_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A258USU_ERR), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A258USU_ERR), "ZZZ9"), "", 0, edtUSU_ERR_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG002General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0G2e( true) ;
         }
         else
         {
            wb_table1_2_0G2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A6USU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
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
         PA0G2( ) ;
         WS0G2( ) ;
         WE0G2( ) ;
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
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA0G2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "tseg002general");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0G2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A6USU_COD = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
         }
         wcpOA6USU_COD = cgiGet( sPrefix+"wcpOA6USU_COD") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A6USU_COD, wcpOA6USU_COD) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOA6USU_COD = A6USU_COD ;
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
         PA0G2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS0G2( ) ;
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
         WS0G2( ) ;
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
         WE0G2( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1182356");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("tseg002general.js", "?1182357");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockusu_cod_Internalname = sPrefix+"TEXTBLOCKUSU_COD" ;
         edtUSU_COD_Internalname = sPrefix+"USU_COD" ;
         lblTextblockusu_des_Internalname = sPrefix+"TEXTBLOCKUSU_DES" ;
         edtUSU_DES_Internalname = sPrefix+"USU_DES" ;
         lblTextblockusu_fec_Internalname = sPrefix+"TEXTBLOCKUSU_FEC" ;
         edtUSU_FEC_Internalname = sPrefix+"USU_FEC" ;
         lblTextblockusu_cda_Internalname = sPrefix+"TEXTBLOCKUSU_CDA" ;
         edtUSU_CDA_Internalname = sPrefix+"USU_CDA" ;
         lblTextblockusu_emp_Internalname = sPrefix+"TEXTBLOCKUSU_EMP" ;
         edtUSU_EMP_Internalname = sPrefix+"USU_EMP" ;
         lblTextblockusu_leg_Internalname = sPrefix+"TEXTBLOCKUSU_LEG" ;
         edtUSU_LEG_Internalname = sPrefix+"USU_LEG" ;
         lblTextblockusu_int_Internalname = sPrefix+"TEXTBLOCKUSU_INT" ;
         edtUSU_INT_Internalname = sPrefix+"USU_INT" ;
         lblTextblockusu_clak_Internalname = sPrefix+"TEXTBLOCKUSU_CLAK" ;
         edtUSU_CLAK_Internalname = sPrefix+"USU_CLAK" ;
         lblTextblockusu_maiw_Internalname = sPrefix+"TEXTBLOCKUSU_MAIW" ;
         edtUSU_MAIW_Internalname = sPrefix+"USU_MAIW" ;
         lblTextblockusu_tipw_Internalname = sPrefix+"TEXTBLOCKUSU_TIPW" ;
         edtUSU_TIPW_Internalname = sPrefix+"USU_TIPW" ;
         lblTextblockusu_nrow_Internalname = sPrefix+"TEXTBLOCKUSU_NROW" ;
         edtUSU_NROW_Internalname = sPrefix+"USU_NROW" ;
         lblTextblockusu_sts_Internalname = sPrefix+"TEXTBLOCKUSU_STS" ;
         edtUSU_STS_Internalname = sPrefix+"USU_STS" ;
         lblTextblockusu_activ_Internalname = sPrefix+"TEXTBLOCKUSU_ACTIV" ;
         edtUSU_ACTIV_Internalname = sPrefix+"USU_ACTIV" ;
         lblTextblockusu_err_Internalname = sPrefix+"TEXTBLOCKUSU_ERR" ;
         edtUSU_ERR_Internalname = sPrefix+"USU_ERR" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         edtUSU_CLA_Internalname = sPrefix+"USU_CLA" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtUSU_ERR_Jsonclick = "" ;
         edtUSU_ACTIV_Jsonclick = "" ;
         edtUSU_STS_Jsonclick = "" ;
         edtUSU_NROW_Jsonclick = "" ;
         edtUSU_TIPW_Jsonclick = "" ;
         edtUSU_CLAK_Jsonclick = "" ;
         edtUSU_INT_Jsonclick = "" ;
         edtUSU_LEG_Jsonclick = "" ;
         edtUSU_EMP_Jsonclick = "" ;
         edtUSU_CDA_Jsonclick = "" ;
         edtUSU_FEC_Jsonclick = "" ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
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
         AV14Pgmname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GX_FocusControl = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtnupdate_Jsonclick = "" ;
         bttBtndelete_Jsonclick = "" ;
         A155USU_CLA = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         scmdbuf = "" ;
         H000G2_A6USU_COD = new String[] {""} ;
         H000G2_A155USU_CLA = new String[] {""} ;
         H000G2_A258USU_ERR = new short[1] ;
         H000G2_A257USU_ACTIV = new DateTime[] {DateTime.MinValue} ;
         H000G2_A256USU_STS = new short[1] ;
         H000G2_A255USU_NROW = new long[1] ;
         H000G2_A254USU_TIPW = new String[] {""} ;
         H000G2_A249USU_MAIW = new String[] {""} ;
         H000G2_n249USU_MAIW = new bool[] {false} ;
         H000G2_A253USU_CLAK = new String[] {""} ;
         H000G2_n253USU_CLAK = new bool[] {false} ;
         H000G2_A180USU_INT = new String[] {""} ;
         H000G2_A252USU_LEG = new int[1] ;
         H000G2_A251USU_EMP = new String[] {""} ;
         H000G2_A250USU_CDA = new String[] {""} ;
         H000G2_A156USU_FEC = new DateTime[] {DateTime.MinValue} ;
         H000G2_A7USU_DES = new String[] {""} ;
         A257USU_ACTIV = (DateTime)(DateTime.MinValue) ;
         A254USU_TIPW = "" ;
         A249USU_MAIW = "" ;
         A253USU_CLAK = "" ;
         A180USU_INT = "" ;
         A251USU_EMP = "" ;
         A250USU_CDA = "" ;
         A156USU_FEC = DateTime.MinValue ;
         A7USU_DES = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         AV8TrnContext = new SdtTransactionContext(context);
         AV11HTTPRequest = new GxHttpRequest( context);
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7USU_COD = "" ;
         AV10Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockusu_cod_Jsonclick = "" ;
         lblTextblockusu_des_Jsonclick = "" ;
         lblTextblockusu_fec_Jsonclick = "" ;
         lblTextblockusu_cda_Jsonclick = "" ;
         lblTextblockusu_emp_Jsonclick = "" ;
         lblTextblockusu_leg_Jsonclick = "" ;
         lblTextblockusu_int_Jsonclick = "" ;
         lblTextblockusu_clak_Jsonclick = "" ;
         lblTextblockusu_maiw_Jsonclick = "" ;
         lblTextblockusu_tipw_Jsonclick = "" ;
         lblTextblockusu_nrow_Jsonclick = "" ;
         lblTextblockusu_sts_Jsonclick = "" ;
         lblTextblockusu_activ_Jsonclick = "" ;
         GXt_char2 = "" ;
         lblTextblockusu_err_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA6USU_COD = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg002general__default(),
            new Object[][] {
                new Object[] {
               H000G2_A6USU_COD, H000G2_A155USU_CLA, H000G2_A258USU_ERR, H000G2_A257USU_ACTIV, H000G2_A256USU_STS, H000G2_A255USU_NROW, H000G2_A254USU_TIPW, H000G2_A249USU_MAIW, H000G2_n249USU_MAIW, H000G2_A253USU_CLAK,
               H000G2_n253USU_CLAK, H000G2_A180USU_INT, H000G2_A252USU_LEG, H000G2_A251USU_EMP, H000G2_A250USU_CDA, H000G2_A156USU_FEC, H000G2_A7USU_DES
               }
            }
         );
         AV14Pgmname = "TSEG002General" ;
         /* GeneXus formulas. */
         AV14Pgmname = "TSEG002General" ;
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
      private short A258USU_ERR ;
      private short A256USU_STS ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtUSU_CLA_Visible ;
      private int A252USU_LEG ;
      private int idxLst ;
      private long A255USU_NROW ;
      private String A6USU_COD ;
      private String wcpOA6USU_COD ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV14Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GX_FocusControl ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String edtUSU_CLA_Internalname ;
      private String A155USU_CLA ;
      private String edtUSU_CLA_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String A254USU_TIPW ;
      private String A253USU_CLAK ;
      private String A180USU_INT ;
      private String A251USU_EMP ;
      private String A250USU_CDA ;
      private String A7USU_DES ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String edtUSU_FEC_Internalname ;
      private String edtUSU_CDA_Internalname ;
      private String edtUSU_EMP_Internalname ;
      private String edtUSU_LEG_Internalname ;
      private String edtUSU_INT_Internalname ;
      private String edtUSU_CLAK_Internalname ;
      private String edtUSU_MAIW_Internalname ;
      private String edtUSU_TIPW_Internalname ;
      private String edtUSU_NROW_Internalname ;
      private String edtUSU_STS_Internalname ;
      private String edtUSU_ACTIV_Internalname ;
      private String edtUSU_ERR_Internalname ;
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
      private String lblTextblockusu_fec_Internalname ;
      private String lblTextblockusu_fec_Jsonclick ;
      private String edtUSU_FEC_Jsonclick ;
      private String lblTextblockusu_cda_Internalname ;
      private String lblTextblockusu_cda_Jsonclick ;
      private String edtUSU_CDA_Jsonclick ;
      private String lblTextblockusu_emp_Internalname ;
      private String lblTextblockusu_emp_Jsonclick ;
      private String edtUSU_EMP_Jsonclick ;
      private String lblTextblockusu_leg_Internalname ;
      private String lblTextblockusu_leg_Jsonclick ;
      private String edtUSU_LEG_Jsonclick ;
      private String lblTextblockusu_int_Internalname ;
      private String lblTextblockusu_int_Jsonclick ;
      private String edtUSU_INT_Jsonclick ;
      private String lblTextblockusu_clak_Internalname ;
      private String lblTextblockusu_clak_Jsonclick ;
      private String edtUSU_CLAK_Jsonclick ;
      private String lblTextblockusu_maiw_Internalname ;
      private String lblTextblockusu_maiw_Jsonclick ;
      private String lblTextblockusu_tipw_Internalname ;
      private String lblTextblockusu_tipw_Jsonclick ;
      private String edtUSU_TIPW_Jsonclick ;
      private String lblTextblockusu_nrow_Internalname ;
      private String lblTextblockusu_nrow_Jsonclick ;
      private String edtUSU_NROW_Jsonclick ;
      private String lblTextblockusu_sts_Internalname ;
      private String lblTextblockusu_sts_Jsonclick ;
      private String edtUSU_STS_Jsonclick ;
      private String lblTextblockusu_activ_Internalname ;
      private String lblTextblockusu_activ_Jsonclick ;
      private String edtUSU_ACTIV_Jsonclick ;
      private String GXt_char2 ;
      private String lblTextblockusu_err_Internalname ;
      private String lblTextblockusu_err_Jsonclick ;
      private String edtUSU_ERR_Jsonclick ;
      private String sCtrlA6USU_COD ;
      private String GXt_char3 ;
      private DateTime A257USU_ACTIV ;
      private DateTime A156USU_FEC ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n249USU_MAIW ;
      private bool n253USU_CLAK ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A249USU_MAIW ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000G2_A6USU_COD ;
      private String[] H000G2_A155USU_CLA ;
      private short[] H000G2_A258USU_ERR ;
      private DateTime[] H000G2_A257USU_ACTIV ;
      private short[] H000G2_A256USU_STS ;
      private long[] H000G2_A255USU_NROW ;
      private String[] H000G2_A254USU_TIPW ;
      private String[] H000G2_A249USU_MAIW ;
      private bool[] H000G2_n249USU_MAIW ;
      private String[] H000G2_A253USU_CLAK ;
      private bool[] H000G2_n253USU_CLAK ;
      private String[] H000G2_A180USU_INT ;
      private int[] H000G2_A252USU_LEG ;
      private String[] H000G2_A251USU_EMP ;
      private String[] H000G2_A250USU_CDA ;
      private DateTime[] H000G2_A156USU_FEC ;
      private String[] H000G2_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV11HTTPRequest ;
      private GxWebSession AV10Session ;
      private SdtTransactionContext AV8TrnContext ;
      private SdtTransactionContext_Attribute AV9TrnContextAtt ;
   }

   public class tseg002general__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000G2 ;
          prmH000G2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000G2", "SELECT [USU_COD], [USU_CLA], [USU_ERR], [USU_ACTIV], [USU_STS], [USU_NROW], [USU_TIPW], [USU_MAIW], [USU_CLAK], [USU_INT], [USU_LEG], [USU_EMP], [USU_CDA], [USU_FEC], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000G2,1,0,true,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((String[]) buf[9])[0] = rslt.getString(9, 32) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((String[]) buf[11])[0] = rslt.getString(10, 10) ;
                ((int[]) buf[12])[0] = rslt.getInt(11) ;
                ((String[]) buf[13])[0] = rslt.getString(12, 3) ;
                ((String[]) buf[14])[0] = rslt.getString(13, 8) ;
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(14) ;
                ((String[]) buf[16])[0] = rslt.getString(15, 50) ;
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
       }
    }

 }

}
