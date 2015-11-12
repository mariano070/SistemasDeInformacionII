/*
               File: TSEG006General
        Description: TSEG006 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:52.39
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
   public class tseg006general : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tseg006general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg006general( IGxContext context )
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
                           int aP3_PRS_NRO )
      {
         this.A6USU_COD = aP0_USU_COD;
         this.A116SIS_COD = aP1_SIS_COD;
         this.A126PRG_COD = aP2_PRG_COD;
         this.A118PRS_NRO = aP3_PRS_NRO;
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
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  A118PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)A6USU_COD,(short)A116SIS_COD,(short)A126PRG_COD,(int)A118PRS_NRO});
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
            PA442( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV17Pgmname = "TSEG006General" ;
               context.Gx_err = 0 ;
               /* Using cursor H00442 */
               pr_default.execute(0, new Object[] {A6USU_COD});
               A155USU_CLA = H00442_A155USU_CLA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
               A7USU_DES = H00442_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
               pr_default.close(0);
               /* Using cursor H00443 */
               pr_default.execute(1, new Object[] {A116SIS_COD});
               A259SIS_DES = H00443_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A259SIS_DES", A259SIS_DES);
               pr_default.close(1);
               /* Using cursor H00444 */
               pr_default.execute(2, new Object[] {A126PRG_COD});
               A289PRG_NFI = H00444_A289PRG_NFI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A289PRG_NFI", A289PRG_NFI);
               A127PRG_DES = H00444_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
               pr_default.close(2);
               /* Using cursor H00445 */
               pr_default.execute(3, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
               A290USU_CNT = H00445_A290USU_CNT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A290USU_CNT", A290USU_CNT);
               pr_default.close(3);
               WS442( ) ;
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
            context.WriteHtmlText( "TSEG006 General") ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg006general.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A118PRS_NRO)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm442( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA6USU_COD", StringUtil.RTrim( wcpOA6USU_COD));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA116SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA118PRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA118PRS_NRO), 8, 0, ",", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tseg006general.js", "?11195252");
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

      protected void WB440( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tseg006general.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_442( true) ;
         }
         else
         {
            wb_table1_2_442( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_442e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_TSEG006General.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_TSEG006General.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLA_Internalname, StringUtil.RTrim( A155USU_CLA), "", 20, "chr", 1, "row", 20, edtUSU_CLA_Visible, 0, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtUSU_CLA_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
         }
         wbLoad = true ;
      }

      protected void START442( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "TSEG006 General", 0) ;
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
               STRUP440( ) ;
            }
         }
      }

      protected void WS442( )
      {
         START442( ) ;
         EVT442( ) ;
      }

      protected void EVT442( )
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
                                 STRUP440( ) ;
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
                                 STRUP440( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E11442 */
                                    E11442 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP440( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E12442 */
                                    E12442 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP440( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E13442 */
                                    E13442 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP440( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E14442 */
                                    E14442 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP440( ) ;
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
                                 STRUP440( ) ;
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

      protected void WE442( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm442( ) ;
            }
         }
      }

      protected void PA442( )
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
         RF442( ) ;
         /* End function Refresh */
      }

      protected void RF442( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00446 */
            pr_default.execute(4, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A406PRS_ULNK = H00446_A406PRS_ULNK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A406PRS_ULNK", A406PRS_ULNK);
               A405PRS_UDE = H00446_A405PRS_UDE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A405PRS_UDE", A405PRS_UDE);
               A165PRS_CAD = H00446_A165PRS_CAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
               A404PRS_UOB = H00446_A404PRS_UOB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A404PRS_UOB", A404PRS_UOB);
               A166PRS_INI = H00446_A166PRS_INI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               /* Execute user event: E12442 */
               E12442 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
            WB440( ) ;
         }
      }

      protected void STRUP440( )
      {
         /* Before Start, stand alone formulas. */
         AV17Pgmname = "TSEG006General" ;
         context.Gx_err = 0 ;
         /* Using cursor H00447 */
         pr_default.execute(5, new Object[] {A6USU_COD});
         A155USU_CLA = H00447_A155USU_CLA[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
         A7USU_DES = H00447_A7USU_DES[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
         pr_default.close(5);
         /* Using cursor H00448 */
         pr_default.execute(6, new Object[] {A116SIS_COD});
         A259SIS_DES = H00448_A259SIS_DES[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A259SIS_DES", A259SIS_DES);
         pr_default.close(6);
         /* Using cursor H00449 */
         pr_default.execute(7, new Object[] {A126PRG_COD});
         A289PRG_NFI = H00449_A289PRG_NFI[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A289PRG_NFI", A289PRG_NFI);
         A127PRG_DES = H00449_A127PRG_DES[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
         pr_default.close(7);
         /* Using cursor H004410 */
         pr_default.execute(8, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         A290USU_CNT = H004410_A290USU_CNT[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A290USU_CNT", A290USU_CNT);
         pr_default.close(8);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11442 */
         E11442 ();
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            }
            A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = StringUtil.Upper( cgiGet( edtPRG_NFI_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A289PRG_NFI", A289PRG_NFI);
            A290USU_CNT = cgiGet( edtUSU_CNT_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A290USU_CNT", A290USU_CNT);
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            }
            A166PRS_INI = context.localUtil.CToT( cgiGet( edtPRS_INI_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            A404PRS_UOB = cgiGet( edtPRS_UOB_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A404PRS_UOB", A404PRS_UOB);
            A165PRS_CAD = context.localUtil.CToT( cgiGet( edtPRS_CAD_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
            A405PRS_UDE = cgiGet( edtPRS_UDE_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A405PRS_UDE", A405PRS_UDE);
            A406PRS_ULNK = cgiGet( edtPRS_ULNK_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A406PRS_ULNK", A406PRS_ULNK);
            A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155USU_CLA", A155USU_CLA);
            /* Read saved values. */
            wcpOA6USU_COD = cgiGet( sPrefix+"wcpOA6USU_COD") ;
            wcpOA116SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA116SIS_COD"), ",", ".")) ;
            wcpOA126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA126PRG_COD"), ",", ".")) ;
            wcpOA118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA118PRS_NRO"), ",", ".")) ;
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
         /* Execute user event: E11442 */
         E11442 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11442( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV17Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)) ;
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

      protected void E12442( )
      {
         /* Load Routine */
         edtUSU_DES_Link = formatLink("viewtseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUSU_DES_Internalname, "Link", edtUSU_DES_Link);
         edtUSU_CLA_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtUSU_CLA_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CLA_Visible), 5, 0)));
      }

      protected void E13442( )
      {
         /* 'DoUpdate' Routine */
         context.wjLoc = formatLink("tseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A118PRS_NRO) ;
      }

      protected void E14442( )
      {
         /* 'DoDelete' Routine */
         context.wjLoc = formatLink("tseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A118PRS_NRO) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context) ;
         AV11TrnContext.gxTpr_Callerobject = AV17Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerondelete = false ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerurl = AV14HTTPRequest.ScriptName+"?"+AV14HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Transactionname = "TSEG006" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "USU_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = AV7USU_COD ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "SIS_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8SIS_COD), 3, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "PRG_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV9PRG_COD), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV12TrnContextAtt.gxTpr_Attributename = "PRS_NRO" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV12TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV10PRS_NRO), 8, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12TrnContextAtt", (Object)(AV12TrnContextAtt));
         AV11TrnContext.gxTpr_Attributes.Add(AV12TrnContextAtt, 0);
         AV13Session.Set("TrnContext", AV11TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_442( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockusu_cod_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), "", 0, edtUSU_COD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockusu_des_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, edtUSU_DES_Link, "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksis_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblocksis_cod_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), "", 0, edtSIS_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksis_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblocksis_des_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), "", 0, edtPRG_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockprg_des_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_nfi_Internalname, 1, 1, 0, "NOMBRE FISICO", "", "", "", 0, lblTextblockprg_nfi_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_NFI_Internalname, StringUtil.RTrim( A289PRG_NFI), "", 8, "chr", 1, "row", 8, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A289PRG_NFI, "@!")), "", 0, edtPRG_NFI_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cnt_Internalname, 1, 1, 0, "CONEXION DE USUARIO", "", "", "", 0, lblTextblockusu_cnt_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CNT_Internalname, StringUtil.RTrim( A290USU_CNT), "", 1, "chr", 1, "row", 1, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A290USU_CNT, "X")), "", 0, edtUSU_CNT_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_nro_Internalname, 1, 1, 0, "NRO DE SESION ASIGNADA", "", "", "", 0, lblTextblockprs_nro_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_NRO_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A118PRS_NRO), "ZZZZZZZ9"), "", 0, edtPRS_NRO_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_ini_Internalname, 1, 1, 0, "MOMENTO DE INICIO SESION", "", "", "", 0, lblTextblockprs_ini_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRS_INI_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRS_INI_Internalname, context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A166PRS_INI, "99/99/99 99:99"), "", 0, edtPRS_INI_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006General.htm");
            GxWebStd.gx_bitmap( context, edtPRS_INI_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG006General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_uob_Internalname, 1, 1, 0, "ULTIMO OBJETO", "", "", "", 0, lblTextblockprs_uob_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_UOB_Internalname, StringUtil.RTrim( A404PRS_UOB), "", 20, "chr", 1, "row", 20, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A404PRS_UOB, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRS_UOB_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_cad_Internalname, 1, 1, 0, "MOMENTO CADUCIDAD SESION", "", "", "", 0, lblTextblockprs_cad_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRS_CAD_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRS_CAD_Internalname, context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A165PRS_CAD, "99/99/99 99:99"), "", 0, edtPRS_CAD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TSEG006General.htm");
            GxWebStd.gx_bitmap( context, edtPRS_CAD_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG006General.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_ude_Internalname, 1, 1, 0, "DESCRIPCION ULTIMO OBJETO", "", "", "", 0, lblTextblockprs_ude_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_UDE_Internalname, StringUtil.RTrim( A405PRS_UDE), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A405PRS_UDE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRS_UDE_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprs_ulnk_Internalname, 1, 1, 0, "ULTIMO LINK", "", "", "", 0, lblTextblockprs_ulnk_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtPRS_ULNK_Internalname, A406PRS_ULNK, 1, 0, 0, 80, "chr", 4, "row", StyleString, ClassString, "300", "", -1, 0, "", "", true, "HLP_TSEG006General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_442e( true) ;
         }
         else
         {
            wb_table1_2_442e( false) ;
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
         A126PRG_COD = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         A118PRS_NRO = Convert.ToInt32(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
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
         PA442( ) ;
         WS442( ) ;
         WE442( ) ;
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
         sCtrlA126PRG_COD = (String)((String)getParm(obj,2)) ;
         sCtrlA118PRS_NRO = (String)((String)getParm(obj,3)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA442( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "tseg006general");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA442( ) ;
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
            A126PRG_COD = Convert.ToInt16(getParm(obj,4)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = Convert.ToInt32(getParm(obj,5)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
         }
         wcpOA6USU_COD = cgiGet( sPrefix+"wcpOA6USU_COD") ;
         wcpOA116SIS_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA116SIS_COD"), ",", ".")) ;
         wcpOA126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA126PRG_COD"), ",", ".")) ;
         wcpOA118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA118PRS_NRO"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(A6USU_COD, wcpOA6USU_COD) != 0 ) || ( A116SIS_COD != wcpOA116SIS_COD ) || ( A126PRG_COD != wcpOA126PRG_COD ) || ( A118PRS_NRO != wcpOA118PRS_NRO ) ) )
         {
            setjustcreated();
         }
         wcpOA6USU_COD = A6USU_COD ;
         wcpOA116SIS_COD = A116SIS_COD ;
         wcpOA126PRG_COD = A126PRG_COD ;
         wcpOA118PRS_NRO = A118PRS_NRO ;
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
         sCtrlA126PRG_COD = cgiGet( sPrefix+"A126PRG_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlA126PRG_COD) > 0 )
         {
            A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sCtrlA126PRG_COD), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
         else
         {
            A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A126PRG_COD_PARM"), ",", ".")) ;
         }
         sCtrlA118PRS_NRO = cgiGet( sPrefix+"A118PRS_NRO_CTRL") ;
         if ( StringUtil.Len( sCtrlA118PRS_NRO) > 0 )
         {
            A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sCtrlA118PRS_NRO), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
         }
         else
         {
            A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( sPrefix+"A118PRS_NRO_PARM"), ",", ".")) ;
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
         PA442( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS442( ) ;
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
         WS442( ) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"A126PRG_COD_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA126PRG_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A126PRG_COD_CTRL", StringUtil.RTrim( sCtrlA126PRG_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A118PRS_NRO_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA118PRS_NRO)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A118PRS_NRO_CTRL", StringUtil.RTrim( sCtrlA118PRS_NRO));
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
         WE442( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11195318");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("tseg006general.js", "?11195318");
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
         lblTextblockprg_cod_Internalname = sPrefix+"TEXTBLOCKPRG_COD" ;
         edtPRG_COD_Internalname = sPrefix+"PRG_COD" ;
         lblTextblockprg_des_Internalname = sPrefix+"TEXTBLOCKPRG_DES" ;
         edtPRG_DES_Internalname = sPrefix+"PRG_DES" ;
         lblTextblockprg_nfi_Internalname = sPrefix+"TEXTBLOCKPRG_NFI" ;
         edtPRG_NFI_Internalname = sPrefix+"PRG_NFI" ;
         lblTextblockusu_cnt_Internalname = sPrefix+"TEXTBLOCKUSU_CNT" ;
         edtUSU_CNT_Internalname = sPrefix+"USU_CNT" ;
         lblTextblockprs_nro_Internalname = sPrefix+"TEXTBLOCKPRS_NRO" ;
         edtPRS_NRO_Internalname = sPrefix+"PRS_NRO" ;
         lblTextblockprs_ini_Internalname = sPrefix+"TEXTBLOCKPRS_INI" ;
         edtPRS_INI_Internalname = sPrefix+"PRS_INI" ;
         lblTextblockprs_uob_Internalname = sPrefix+"TEXTBLOCKPRS_UOB" ;
         edtPRS_UOB_Internalname = sPrefix+"PRS_UOB" ;
         lblTextblockprs_cad_Internalname = sPrefix+"TEXTBLOCKPRS_CAD" ;
         edtPRS_CAD_Internalname = sPrefix+"PRS_CAD" ;
         lblTextblockprs_ude_Internalname = sPrefix+"TEXTBLOCKPRS_UDE" ;
         edtPRS_UDE_Internalname = sPrefix+"PRS_UDE" ;
         lblTextblockprs_ulnk_Internalname = sPrefix+"TEXTBLOCKPRS_ULNK" ;
         edtPRS_ULNK_Internalname = sPrefix+"PRS_ULNK" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         edtUSU_CLA_Internalname = sPrefix+"USU_CLA" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtPRS_UDE_Jsonclick = "" ;
         edtPRS_CAD_Jsonclick = "" ;
         edtPRS_UOB_Jsonclick = "" ;
         edtPRS_INI_Jsonclick = "" ;
         edtPRS_NRO_Jsonclick = "" ;
         edtUSU_CNT_Jsonclick = "" ;
         edtPRG_NFI_Jsonclick = "" ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
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
         AV17Pgmname = "" ;
         scmdbuf = "" ;
         H00442_A155USU_CLA = new String[] {""} ;
         H00442_A7USU_DES = new String[] {""} ;
         A155USU_CLA = "" ;
         A7USU_DES = "" ;
         H00443_A259SIS_DES = new String[] {""} ;
         A259SIS_DES = "" ;
         H00444_A289PRG_NFI = new String[] {""} ;
         H00444_A127PRG_DES = new String[] {""} ;
         A289PRG_NFI = "" ;
         A127PRG_DES = "" ;
         H00445_A290USU_CNT = new String[] {""} ;
         A290USU_CNT = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
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
         H00446_A6USU_COD = new String[] {""} ;
         H00446_A116SIS_COD = new short[1] ;
         H00446_A126PRG_COD = new short[1] ;
         H00446_A118PRS_NRO = new int[1] ;
         H00446_A155USU_CLA = new String[] {""} ;
         H00446_A406PRS_ULNK = new String[] {""} ;
         H00446_A405PRS_UDE = new String[] {""} ;
         H00446_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         H00446_A404PRS_UOB = new String[] {""} ;
         H00446_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         H00446_A290USU_CNT = new String[] {""} ;
         H00446_A289PRG_NFI = new String[] {""} ;
         H00446_A127PRG_DES = new String[] {""} ;
         H00446_A259SIS_DES = new String[] {""} ;
         H00446_A7USU_DES = new String[] {""} ;
         A406PRS_ULNK = "" ;
         A405PRS_UDE = "" ;
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         A404PRS_UOB = "" ;
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         H00447_A155USU_CLA = new String[] {""} ;
         H00447_A7USU_DES = new String[] {""} ;
         H00448_A259SIS_DES = new String[] {""} ;
         H00449_A289PRG_NFI = new String[] {""} ;
         H00449_A127PRG_DES = new String[] {""} ;
         H004410_A290USU_CNT = new String[] {""} ;
         AV11TrnContext = new SdtTransactionContext(context);
         AV14HTTPRequest = new GxHttpRequest( context);
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7USU_COD = "" ;
         AV13Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockusu_cod_Jsonclick = "" ;
         lblTextblockusu_des_Jsonclick = "" ;
         lblTextblocksis_cod_Jsonclick = "" ;
         lblTextblocksis_des_Jsonclick = "" ;
         lblTextblockprg_cod_Jsonclick = "" ;
         lblTextblockprg_des_Jsonclick = "" ;
         lblTextblockprg_nfi_Jsonclick = "" ;
         lblTextblockusu_cnt_Jsonclick = "" ;
         lblTextblockprs_nro_Jsonclick = "" ;
         lblTextblockprs_ini_Jsonclick = "" ;
         lblTextblockprs_uob_Jsonclick = "" ;
         lblTextblockprs_cad_Jsonclick = "" ;
         lblTextblockprs_ude_Jsonclick = "" ;
         lblTextblockprs_ulnk_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA6USU_COD = "" ;
         sCtrlA116SIS_COD = "" ;
         sCtrlA126PRG_COD = "" ;
         sCtrlA118PRS_NRO = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg006general__default(),
            new Object[][] {
                new Object[] {
               H00442_A155USU_CLA, H00442_A7USU_DES
               }
               , new Object[] {
               H00443_A259SIS_DES
               }
               , new Object[] {
               H00444_A289PRG_NFI, H00444_A127PRG_DES
               }
               , new Object[] {
               H00445_A290USU_CNT
               }
               , new Object[] {
               H00446_A6USU_COD, H00446_A116SIS_COD, H00446_A126PRG_COD, H00446_A118PRS_NRO, H00446_A155USU_CLA, H00446_A406PRS_ULNK, H00446_A405PRS_UDE, H00446_A165PRS_CAD, H00446_A404PRS_UOB, H00446_A166PRS_INI,
               H00446_A290USU_CNT, H00446_A289PRG_NFI, H00446_A127PRG_DES, H00446_A259SIS_DES, H00446_A7USU_DES
               }
               , new Object[] {
               H00447_A155USU_CLA, H00447_A7USU_DES
               }
               , new Object[] {
               H00448_A259SIS_DES
               }
               , new Object[] {
               H00449_A289PRG_NFI, H00449_A127PRG_DES
               }
               , new Object[] {
               H004410_A290USU_CNT
               }
            }
         );
         AV17Pgmname = "TSEG006General" ;
         /* GeneXus formulas. */
         AV17Pgmname = "TSEG006General" ;
         context.Gx_err = 0 ;
      }

      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short wcpOA116SIS_COD ;
      private short wcpOA126PRG_COD ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short AV8SIS_COD ;
      private short AV9PRG_COD ;
      private short nGXWrapped ;
      private int A118PRS_NRO ;
      private int wcpOA118PRS_NRO ;
      private int edtUSU_CLA_Visible ;
      private int AV10PRS_NRO ;
      private int idxLst ;
      private String A6USU_COD ;
      private String wcpOA6USU_COD ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV17Pgmname ;
      private String scmdbuf ;
      private String A155USU_CLA ;
      private String A7USU_DES ;
      private String A259SIS_DES ;
      private String A289PRG_NFI ;
      private String A127PRG_DES ;
      private String A290USU_CNT ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
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
      private String A405PRS_UDE ;
      private String A404PRS_UOB ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_DES_Internalname ;
      private String edtPRG_NFI_Internalname ;
      private String edtUSU_CNT_Internalname ;
      private String edtPRS_NRO_Internalname ;
      private String edtPRS_INI_Internalname ;
      private String edtPRS_UOB_Internalname ;
      private String edtPRS_CAD_Internalname ;
      private String edtPRS_UDE_Internalname ;
      private String edtPRS_ULNK_Internalname ;
      private String edtUSU_DES_Link ;
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
      private String lblTextblockprg_cod_Internalname ;
      private String lblTextblockprg_cod_Jsonclick ;
      private String edtPRG_COD_Jsonclick ;
      private String lblTextblockprg_des_Internalname ;
      private String lblTextblockprg_des_Jsonclick ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblockprg_nfi_Internalname ;
      private String lblTextblockprg_nfi_Jsonclick ;
      private String edtPRG_NFI_Jsonclick ;
      private String lblTextblockusu_cnt_Internalname ;
      private String lblTextblockusu_cnt_Jsonclick ;
      private String edtUSU_CNT_Jsonclick ;
      private String lblTextblockprs_nro_Internalname ;
      private String lblTextblockprs_nro_Jsonclick ;
      private String edtPRS_NRO_Jsonclick ;
      private String lblTextblockprs_ini_Internalname ;
      private String lblTextblockprs_ini_Jsonclick ;
      private String edtPRS_INI_Jsonclick ;
      private String lblTextblockprs_uob_Internalname ;
      private String lblTextblockprs_uob_Jsonclick ;
      private String edtPRS_UOB_Jsonclick ;
      private String lblTextblockprs_cad_Internalname ;
      private String lblTextblockprs_cad_Jsonclick ;
      private String edtPRS_CAD_Jsonclick ;
      private String lblTextblockprs_ude_Internalname ;
      private String lblTextblockprs_ude_Jsonclick ;
      private String edtPRS_UDE_Jsonclick ;
      private String lblTextblockprs_ulnk_Internalname ;
      private String lblTextblockprs_ulnk_Jsonclick ;
      private String sCtrlA6USU_COD ;
      private String sCtrlA116SIS_COD ;
      private String sCtrlA126PRG_COD ;
      private String sCtrlA118PRS_NRO ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private DateTime A165PRS_CAD ;
      private DateTime A166PRS_INI ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A406PRS_ULNK ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00442_A155USU_CLA ;
      private String[] H00442_A7USU_DES ;
      private String[] H00443_A259SIS_DES ;
      private String[] H00444_A289PRG_NFI ;
      private String[] H00444_A127PRG_DES ;
      private String[] H00445_A290USU_CNT ;
      private String[] H00446_A6USU_COD ;
      private short[] H00446_A116SIS_COD ;
      private short[] H00446_A126PRG_COD ;
      private int[] H00446_A118PRS_NRO ;
      private String[] H00446_A155USU_CLA ;
      private String[] H00446_A406PRS_ULNK ;
      private String[] H00446_A405PRS_UDE ;
      private DateTime[] H00446_A165PRS_CAD ;
      private String[] H00446_A404PRS_UOB ;
      private DateTime[] H00446_A166PRS_INI ;
      private String[] H00446_A290USU_CNT ;
      private String[] H00446_A289PRG_NFI ;
      private String[] H00446_A127PRG_DES ;
      private String[] H00446_A259SIS_DES ;
      private String[] H00446_A7USU_DES ;
      private String[] H00447_A155USU_CLA ;
      private String[] H00447_A7USU_DES ;
      private String[] H00448_A259SIS_DES ;
      private String[] H00449_A289PRG_NFI ;
      private String[] H00449_A127PRG_DES ;
      private String[] H004410_A290USU_CNT ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV14HTTPRequest ;
      private GxWebSession AV13Session ;
      private SdtTransactionContext AV11TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class tseg006general__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00442 ;
          prmH00442 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH00443 ;
          prmH00443 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH00444 ;
          prmH00444 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00445 ;
          prmH00445 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00446 ;
          prmH00446 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmH00447 ;
          prmH00447 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH00448 ;
          prmH00448 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH00449 ;
          prmH00449 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH004410 ;
          prmH004410 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00442", "SELECT [USU_CLA], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00442,1,0,true,true )
             ,new CursorDef("H00443", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00443,1,1,true,true )
             ,new CursorDef("H00444", "SELECT [PRG_NFI], [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00444,1,1,true,true )
             ,new CursorDef("H00445", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00445,1,1,true,true )
             ,new CursorDef("H00446", "SELECT T1.[USU_COD], T1.[SIS_COD], T1.[PRG_COD], T1.[PRS_NRO], T2.[USU_CLA], T1.[PRS_ULNK], T1.[PRS_UDE], T1.[PRS_CAD], T1.[PRS_UOB], T1.[PRS_INI], T5.[USU_CNT], T4.[PRG_NFI], T4.[PRG_DES], T3.[SIS_DES], T2.[USU_DES] FROM (((([SEG006] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = T1.[SIS_COD]) INNER JOIN [SEG001] T4 WITH (NOLOCK) ON T4.[PRG_COD] = T1.[PRG_COD]) INNER JOIN [SEG004] T5 WITH (NOLOCK) ON T5.[USU_COD] = T1.[USU_COD] AND T5.[SIS_COD] = T1.[SIS_COD] AND T5.[PRG_COD] = T1.[PRG_COD]) WHERE T1.[USU_COD] = @USU_COD and T1.[SIS_COD] = @SIS_COD and T1.[PRG_COD] = @PRG_COD and T1.[PRS_NRO] = @PRS_NRO ORDER BY T1.[USU_COD], T1.[SIS_COD], T1.[PRG_COD], T1.[PRS_NRO] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00446,1,0,true,true )
             ,new CursorDef("H00447", "SELECT [USU_CLA], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00447,1,0,true,true )
             ,new CursorDef("H00448", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00448,1,1,true,true )
             ,new CursorDef("H00449", "SELECT [PRG_NFI], [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00449,1,1,true,true )
             ,new CursorDef("H004410", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004410,1,1,true,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 8) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 20) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(10) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 1) ;
                ((String[]) buf[11])[0] = rslt.getString(12, 8) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 30) ;
                ((String[]) buf[13])[0] = rslt.getString(14, 15) ;
                ((String[]) buf[14])[0] = rslt.getString(15, 50) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 8) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
