/*
               File: SEG008General
        Description: SEG008 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:17.67
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
   public class seg008general : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public seg008general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public seg008general( IGxContext context )
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
                           int aP1_MNU_NIV )
      {
         this.A126PRG_COD = aP0_PRG_COD;
         this.A361MNU_NIV = aP1_MNU_NIV;
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
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  A361MNU_NIV = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A126PRG_COD,(int)A361MNU_NIV});
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
            PA3Z2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "SEG008General" ;
               context.Gx_err = 0 ;
               /* Using cursor H003Z2 */
               pr_default.execute(0, new Object[] {A126PRG_COD});
               A127PRG_DES = H003Z2_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
               pr_default.close(0);
               WS3Z2( ) ;
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
            context.WriteHtmlText( "SEG008 General") ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("seg008general.aspx") + "?" + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A361MNU_NIV)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm3Z2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA361MNU_NIV", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA361MNU_NIV), 6, 0, ",", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("seg008general.js", "?11191772");
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

      protected void WB3Z0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "seg008general.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_3Z2( true) ;
         }
         else
         {
            wb_table1_2_3Z2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_3Z2e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_SEG008General.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_SEG008General.htm");
            /* Multiple line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMNU_LINK_Internalname, StringUtil.RTrim( A362MNU_LINK), edtMNU_LINK_Visible, 0, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", "", -1, 0, "", "", true, "HLP_SEG008General.htm");
         }
         wbLoad = true ;
      }

      protected void START3Z2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "SEG008 General", 0) ;
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
               STRUP3Z0( ) ;
            }
         }
      }

      protected void WS3Z2( )
      {
         START3Z2( ) ;
         EVT3Z2( ) ;
      }

      protected void EVT3Z2( )
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
                                 STRUP3Z0( ) ;
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
                                 STRUP3Z0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E113Z2 */
                                    E113Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Z0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E123Z2 */
                                    E123Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Z0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E133Z2 */
                                    E133Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Z0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E143Z2 */
                                    E143Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Z0( ) ;
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
                                 STRUP3Z0( ) ;
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

      protected void WE3Z2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3Z2( ) ;
            }
         }
      }

      protected void PA3Z2( )
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
         RF3Z2( ) ;
         /* End function Refresh */
      }

      protected void RF3Z2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H003Z3 */
            pr_default.execute(1, new Object[] {A126PRG_COD, A361MNU_NIV});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A362MNU_LINK = H003Z3_A362MNU_LINK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A362MNU_LINK", A362MNU_LINK);
               A129MNU_NID = H003Z3_A129MNU_NID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A129MNU_NID", A129MNU_NID);
               /* Execute user event: E123Z2 */
               E123Z2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            WB3Z0( ) ;
         }
      }

      protected void STRUP3Z0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "SEG008General" ;
         context.Gx_err = 0 ;
         /* Using cursor H003Z4 */
         pr_default.execute(2, new Object[] {A126PRG_COD});
         A127PRG_DES = H003Z4_A127PRG_DES[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
         pr_default.close(2);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E113Z2 */
         E113Z2 ();
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
               A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            }
            A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( edtMNU_NIV_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            }
            A129MNU_NID = cgiGet( edtMNU_NID_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = cgiGet( edtMNU_LINK_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A362MNU_LINK", A362MNU_LINK);
            /* Read saved values. */
            wcpOA126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA126PRG_COD"), ",", ".")) ;
            wcpOA361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA361MNU_NIV"), ",", ".")) ;
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
         /* Execute user event: E113Z2 */
         E113Z2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113Z2( )
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

      protected void E123Z2( )
      {
         /* Load Routine */
         edtMNU_LINK_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtMNU_LINK_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_LINK_Visible), 5, 0)));
      }

      protected void E133Z2( )
      {
         /* 'DoUpdate' Routine */
         context.wjLoc = formatLink("seg008.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A361MNU_NIV) ;
      }

      protected void E143Z2( )
      {
         /* 'DoDelete' Routine */
         context.wjLoc = formatLink("seg008.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A361MNU_NIV) ;
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
         AV9TrnContext.gxTpr_Transactionname = "SEG008" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "PRG_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7PRG_COD), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "MNU_NIV" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8MNU_NIV), 6, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_3Z2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), "", 0, edtPRG_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockprg_des_Jsonclick, "", StyleString, ClassString, "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_niv_Internalname, 1, 1, 0, "NIVEL", "", "", "", 0, lblTextblockmnu_niv_Jsonclick, "", StyleString, ClassString, "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NIV_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A361MNU_NIV), 6, 0, ",", "")), "", 6, "chr", 1, "row", 6, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A361MNU_NIV), "ZZZZZ9"), "", 0, edtMNU_NIV_Jsonclick, "", 0, 1, 1, true, "right", "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_nid_Internalname, 1, 1, 0, "TITULO", "", "", "", 0, lblTextblockmnu_nid_Jsonclick, "", StyleString, ClassString, "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NID_Internalname, StringUtil.RTrim( A129MNU_NID), "", 80, "chr", 1, "row", 100, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A129MNU_NID, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtMNU_NID_Jsonclick, "", 0, 1, 1, true, "left", "HLP_SEG008General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_3Z2e( true) ;
         }
         else
         {
            wb_table1_2_3Z2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A126PRG_COD = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         A361MNU_NIV = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
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
         PA3Z2( ) ;
         WS3Z2( ) ;
         WE3Z2( ) ;
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
         sCtrlA126PRG_COD = (String)((String)getParm(obj,0)) ;
         sCtrlA361MNU_NIV = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA3Z2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "seg008general");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA3Z2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A126PRG_COD = Convert.ToInt16(getParm(obj,2)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = Convert.ToInt32(getParm(obj,3)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
         }
         wcpOA126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA126PRG_COD"), ",", ".")) ;
         wcpOA361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA361MNU_NIV"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( A126PRG_COD != wcpOA126PRG_COD ) || ( A361MNU_NIV != wcpOA361MNU_NIV ) ) )
         {
            setjustcreated();
         }
         wcpOA126PRG_COD = A126PRG_COD ;
         wcpOA361MNU_NIV = A361MNU_NIV ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
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
         sCtrlA361MNU_NIV = cgiGet( sPrefix+"A361MNU_NIV_CTRL") ;
         if ( StringUtil.Len( sCtrlA361MNU_NIV) > 0 )
         {
            A361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( sCtrlA361MNU_NIV), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
         }
         else
         {
            A361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( sPrefix+"A361MNU_NIV_PARM"), ",", ".")) ;
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
         PA3Z2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS3Z2( ) ;
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
         WS3Z2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A126PRG_COD_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA126PRG_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A126PRG_COD_CTRL", StringUtil.RTrim( sCtrlA126PRG_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A361MNU_NIV_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A361MNU_NIV), 6, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA361MNU_NIV)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A361MNU_NIV_CTRL", StringUtil.RTrim( sCtrlA361MNU_NIV));
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
         WE3Z2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11191797");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("seg008general.js", "?11191797");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockprg_cod_Internalname = sPrefix+"TEXTBLOCKPRG_COD" ;
         edtPRG_COD_Internalname = sPrefix+"PRG_COD" ;
         lblTextblockprg_des_Internalname = sPrefix+"TEXTBLOCKPRG_DES" ;
         edtPRG_DES_Internalname = sPrefix+"PRG_DES" ;
         lblTextblockmnu_niv_Internalname = sPrefix+"TEXTBLOCKMNU_NIV" ;
         edtMNU_NIV_Internalname = sPrefix+"MNU_NIV" ;
         lblTextblockmnu_nid_Internalname = sPrefix+"TEXTBLOCKMNU_NID" ;
         edtMNU_NID_Internalname = sPrefix+"MNU_NID" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         edtMNU_LINK_Internalname = sPrefix+"MNU_LINK" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtMNU_NID_Jsonclick = "" ;
         edtMNU_NIV_Jsonclick = "" ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtMNU_LINK_Visible = 1 ;
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
         sPrefix = "" ;
         AV15Pgmname = "" ;
         scmdbuf = "" ;
         H003Z2_A127PRG_DES = new String[] {""} ;
         A127PRG_DES = "" ;
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
         A362MNU_LINK = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         H003Z3_A126PRG_COD = new short[1] ;
         H003Z3_A361MNU_NIV = new int[1] ;
         H003Z3_A362MNU_LINK = new String[] {""} ;
         H003Z3_A129MNU_NID = new String[] {""} ;
         H003Z3_A127PRG_DES = new String[] {""} ;
         A129MNU_NID = "" ;
         H003Z4_A127PRG_DES = new String[] {""} ;
         AV9TrnContext = new SdtTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockprg_cod_Jsonclick = "" ;
         lblTextblockprg_des_Jsonclick = "" ;
         lblTextblockmnu_niv_Jsonclick = "" ;
         lblTextblockmnu_nid_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA126PRG_COD = "" ;
         sCtrlA361MNU_NIV = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg008general__default(),
            new Object[][] {
                new Object[] {
               H003Z2_A127PRG_DES
               }
               , new Object[] {
               H003Z3_A126PRG_COD, H003Z3_A361MNU_NIV, H003Z3_A362MNU_LINK, H003Z3_A129MNU_NID, H003Z3_A127PRG_DES
               }
               , new Object[] {
               H003Z4_A127PRG_DES
               }
            }
         );
         AV15Pgmname = "SEG008General" ;
         /* GeneXus formulas. */
         AV15Pgmname = "SEG008General" ;
         context.Gx_err = 0 ;
      }

      private short A126PRG_COD ;
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
      private short AV7PRG_COD ;
      private short nGXWrapped ;
      private int A361MNU_NIV ;
      private int wcpOA361MNU_NIV ;
      private int edtMNU_LINK_Visible ;
      private int AV8MNU_NIV ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV15Pgmname ;
      private String scmdbuf ;
      private String A127PRG_DES ;
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
      private String edtMNU_LINK_Internalname ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String A129MNU_NID ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_DES_Internalname ;
      private String edtMNU_NIV_Internalname ;
      private String edtMNU_NID_Internalname ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockprg_cod_Internalname ;
      private String lblTextblockprg_cod_Jsonclick ;
      private String edtPRG_COD_Jsonclick ;
      private String lblTextblockprg_des_Internalname ;
      private String lblTextblockprg_des_Jsonclick ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblockmnu_niv_Internalname ;
      private String lblTextblockmnu_niv_Jsonclick ;
      private String edtMNU_NIV_Jsonclick ;
      private String lblTextblockmnu_nid_Internalname ;
      private String lblTextblockmnu_nid_Jsonclick ;
      private String edtMNU_NID_Jsonclick ;
      private String sCtrlA126PRG_COD ;
      private String sCtrlA361MNU_NIV ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A362MNU_LINK ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H003Z2_A127PRG_DES ;
      private short[] H003Z3_A126PRG_COD ;
      private int[] H003Z3_A361MNU_NIV ;
      private String[] H003Z3_A362MNU_LINK ;
      private String[] H003Z3_A129MNU_NID ;
      private String[] H003Z3_A127PRG_DES ;
      private String[] H003Z4_A127PRG_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private GxWebSession AV11Session ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class seg008general__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH003Z2 ;
          prmH003Z2 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH003Z3 ;
          prmH003Z3 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmH003Z4 ;
          prmH003Z4 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003Z2", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003Z2,1,1,true,true )
             ,new CursorDef("H003Z3", "SELECT T1.[PRG_COD], T1.[MNU_NIV], T1.[MNU_LINK], T1.[MNU_NID], T2.[PRG_DES] FROM ([SEG008] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE T1.[PRG_COD] = @PRG_COD and T1.[MNU_NIV] = @MNU_NIV ORDER BY T1.[PRG_COD], T1.[MNU_NIV] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003Z3,1,1,true,true )
             ,new CursorDef("H003Z4", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003Z4,1,1,true,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
