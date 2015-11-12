/*
               File: SEG008L1General
        Description: SEG008 L1 General
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:20.50
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
   public class seg008l1general : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public seg008l1general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public seg008l1general( IGxContext context )
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
                           int aP2_MNU_SNI )
      {
         this.A126PRG_COD = aP0_PRG_COD;
         this.A361MNU_NIV = aP1_MNU_NIV;
         this.A130MNU_SNI = aP2_MNU_SNI;
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
                  A130MNU_SNI = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A126PRG_COD,(int)A361MNU_NIV,(int)A130MNU_SNI});
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
            PA422( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "SEG008L1General" ;
               context.Gx_err = 0 ;
               /* Using cursor H00422 */
               pr_default.execute(0, new Object[] {A126PRG_COD});
               A127PRG_DES = H00422_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
               pr_default.close(0);
               /* Using cursor H00423 */
               pr_default.execute(1, new Object[] {A126PRG_COD, A361MNU_NIV});
               A362MNU_LINK = H00423_A362MNU_LINK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A362MNU_LINK", A362MNU_LINK);
               A129MNU_NID = H00423_A129MNU_NID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A129MNU_NID", A129MNU_NID);
               pr_default.close(1);
               WS422( ) ;
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
            context.WriteHtmlText( "SEG008 L1 General") ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("seg008l1general.aspx") + "?" + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A361MNU_NIV) + "," + UrlEncode("" +A130MNU_SNI)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm422( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA361MNU_NIV", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA361MNU_NIV), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA130MNU_SNI", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA130MNU_SNI), 5, 0, ",", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("seg008l1general.js", "?11192059");
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

      protected void WB420( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "seg008l1general.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_422( true) ;
         }
         else
         {
            wb_table1_2_422( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_422e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_SEG008L1General.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_SEG008L1General.htm");
         }
         wbLoad = true ;
      }

      protected void START422( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "SEG008 L1 General", 0) ;
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
               STRUP420( ) ;
            }
         }
      }

      protected void WS422( )
      {
         START422( ) ;
         EVT422( ) ;
      }

      protected void EVT422( )
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
                                 STRUP420( ) ;
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
                                 STRUP420( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E11422 */
                                    E11422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E12422 */
                                    E12422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E13422 */
                                    E13422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E14422 */
                                    E14422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
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
                                 STRUP420( ) ;
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

      protected void WE422( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm422( ) ;
            }
         }
      }

      protected void PA422( )
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
         RF422( ) ;
         /* End function Refresh */
      }

      protected void RF422( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00424 */
            pr_default.execute(2, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A132MNU_SLINK = H00424_A132MNU_SLINK[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A132MNU_SLINK", A132MNU_SLINK);
               A131MNU_DSN = H00424_A131MNU_DSN[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A131MNU_DSN", A131MNU_DSN);
               /* Execute user event: E12422 */
               E12422 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            WB420( ) ;
         }
      }

      protected void STRUP420( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "SEG008L1General" ;
         context.Gx_err = 0 ;
         /* Using cursor H00425 */
         pr_default.execute(3, new Object[] {A126PRG_COD});
         A127PRG_DES = H00425_A127PRG_DES[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127PRG_DES", A127PRG_DES);
         pr_default.close(3);
         /* Using cursor H00426 */
         pr_default.execute(4, new Object[] {A126PRG_COD, A361MNU_NIV});
         A362MNU_LINK = H00426_A362MNU_LINK[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A362MNU_LINK", A362MNU_LINK);
         A129MNU_NID = H00426_A129MNU_NID[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A129MNU_NID", A129MNU_NID);
         pr_default.close(4);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11422 */
         E11422 ();
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A130MNU_SNI = (int)(context.localUtil.CToN( cgiGet( edtMNU_SNI_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
            }
            A131MNU_DSN = cgiGet( edtMNU_DSN_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A131MNU_DSN", A131MNU_DSN);
            A132MNU_SLINK = cgiGet( edtMNU_SLINK_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A132MNU_SLINK", A132MNU_SLINK);
            /* Read saved values. */
            wcpOA126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA126PRG_COD"), ",", ".")) ;
            wcpOA361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA361MNU_NIV"), ",", ".")) ;
            wcpOA130MNU_SNI = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA130MNU_SNI"), ",", ".")) ;
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
         /* Execute user event: E11422 */
         E11422 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11422( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV16Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)) ;
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

      protected void E12422( )
      {
         /* Load Routine */
         edtMNU_NID_Link = formatLink("viewseg008.aspx") + "?" + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A361MNU_NIV) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtMNU_NID_Internalname, "Link", edtMNU_NID_Link);
      }

      protected void E13422( )
      {
         /* 'DoUpdate' Routine */
         context.wjLoc = formatLink("seg008l1.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A361MNU_NIV) + "," + UrlEncode("" +A130MNU_SNI) ;
      }

      protected void E14422( )
      {
         /* 'DoDelete' Routine */
         context.wjLoc = formatLink("seg008l1.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode("" +A361MNU_NIV) + "," + UrlEncode("" +A130MNU_SNI) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new SdtTransactionContext(context) ;
         AV10TrnContext.gxTpr_Callerobject = AV16Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Callerondelete = false ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Callerurl = AV13HTTPRequest.ScriptName+"?"+AV13HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Transactionname = "SEG008L1" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV11TrnContextAtt.gxTpr_Attributename = "PRG_COD" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7PRG_COD), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV11TrnContextAtt.gxTpr_Attributename = "MNU_NIV" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8MNU_NIV), 6, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV11TrnContextAtt.gxTpr_Attributename = "MNU_SNI" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV9MNU_SNI), 5, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV12Session.Set("TrnContext", AV10TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_422( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), "", 0, edtPRG_COD_Jsonclick, "", 0, 1, 1, true, "right", "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockprg_des_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_niv_Internalname, 1, 1, 0, "NIVEL", "", "", "", 0, lblTextblockmnu_niv_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NIV_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A361MNU_NIV), 6, 0, ",", "")), "", 6, "chr", 1, "row", 6, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A361MNU_NIV), "ZZZZZ9"), "", 0, edtMNU_NIV_Jsonclick, "", 0, 1, 1, true, "right", "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_nid_Internalname, 1, 1, 0, "TITULO", "", "", "", 0, lblTextblockmnu_nid_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NID_Internalname, StringUtil.RTrim( A129MNU_NID), "", 80, "chr", 1, "row", 100, 1, 0, 0, 0, 0, edtMNU_NID_Link, "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A129MNU_NID, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtMNU_NID_Jsonclick, "", 0, 1, 1, true, "left", "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_link_Internalname, 1, 1, 0, "LINK", "", "", "", 0, lblTextblockmnu_link_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMNU_LINK_Internalname, StringUtil.RTrim( A362MNU_LINK), 1, 0, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", "", -1, 0, "", "", true, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_sni_Internalname, 1, 1, 0, "SUB_NIVEL", "", "", "", 0, lblTextblockmnu_sni_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_SNI_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A130MNU_SNI), 5, 0, ",", "")), "", 5, "chr", 1, "row", 5, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A130MNU_SNI), "ZZZZ9"), "", 0, edtMNU_SNI_Jsonclick, "", 0, 1, 1, true, "right", "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_dsn_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockmnu_dsn_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_DSN_Internalname, StringUtil.RTrim( A131MNU_DSN), "", 80, "chr", 1, "row", 100, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A131MNU_DSN, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtMNU_DSN_Jsonclick, "", 0, 1, 1, true, "left", "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_slink_Internalname, 1, 1, 0, "LINK", "", "", "", 0, lblTextblockmnu_slink_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMNU_SLINK_Internalname, StringUtil.RTrim( A132MNU_SLINK), 1, 0, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", "", -1, 0, "", "", true, "HLP_SEG008L1General.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_422e( true) ;
         }
         else
         {
            wb_table1_2_422e( false) ;
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
         A130MNU_SNI = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
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
         PA422( ) ;
         WS422( ) ;
         WE422( ) ;
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
         sCtrlA130MNU_SNI = (String)((String)getParm(obj,2)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA422( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "seg008l1general");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA422( ) ;
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
            A130MNU_SNI = Convert.ToInt32(getParm(obj,4)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
         }
         wcpOA126PRG_COD = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA126PRG_COD"), ",", ".")) ;
         wcpOA361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA361MNU_NIV"), ",", ".")) ;
         wcpOA130MNU_SNI = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA130MNU_SNI"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( A126PRG_COD != wcpOA126PRG_COD ) || ( A361MNU_NIV != wcpOA361MNU_NIV ) || ( A130MNU_SNI != wcpOA130MNU_SNI ) ) )
         {
            setjustcreated();
         }
         wcpOA126PRG_COD = A126PRG_COD ;
         wcpOA361MNU_NIV = A361MNU_NIV ;
         wcpOA130MNU_SNI = A130MNU_SNI ;
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
         sCtrlA130MNU_SNI = cgiGet( sPrefix+"A130MNU_SNI_CTRL") ;
         if ( StringUtil.Len( sCtrlA130MNU_SNI) > 0 )
         {
            A130MNU_SNI = (int)(context.localUtil.CToN( cgiGet( sCtrlA130MNU_SNI), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
         }
         else
         {
            A130MNU_SNI = (int)(context.localUtil.CToN( cgiGet( sPrefix+"A130MNU_SNI_PARM"), ",", ".")) ;
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
         PA422( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS422( ) ;
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
         WS422( ) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"A130MNU_SNI_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A130MNU_SNI), 5, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA130MNU_SNI)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A130MNU_SNI_CTRL", StringUtil.RTrim( sCtrlA130MNU_SNI));
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
         WE422( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11192098");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("seg008l1general.js", "?11192098");
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
         lblTextblockmnu_link_Internalname = sPrefix+"TEXTBLOCKMNU_LINK" ;
         edtMNU_LINK_Internalname = sPrefix+"MNU_LINK" ;
         lblTextblockmnu_sni_Internalname = sPrefix+"TEXTBLOCKMNU_SNI" ;
         edtMNU_SNI_Internalname = sPrefix+"MNU_SNI" ;
         lblTextblockmnu_dsn_Internalname = sPrefix+"TEXTBLOCKMNU_DSN" ;
         edtMNU_DSN_Internalname = sPrefix+"MNU_DSN" ;
         lblTextblockmnu_slink_Internalname = sPrefix+"TEXTBLOCKMNU_SLINK" ;
         edtMNU_SLINK_Internalname = sPrefix+"MNU_SLINK" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtMNU_DSN_Jsonclick = "" ;
         edtMNU_SNI_Jsonclick = "" ;
         edtMNU_NID_Jsonclick = "" ;
         edtMNU_NIV_Jsonclick = "" ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtMNU_NID_Link = "" ;
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
         AV16Pgmname = "" ;
         scmdbuf = "" ;
         H00422_A127PRG_DES = new String[] {""} ;
         A127PRG_DES = "" ;
         H00423_A362MNU_LINK = new String[] {""} ;
         H00423_A129MNU_NID = new String[] {""} ;
         A362MNU_LINK = "" ;
         A129MNU_NID = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
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
         H00424_A126PRG_COD = new short[1] ;
         H00424_A361MNU_NIV = new int[1] ;
         H00424_A130MNU_SNI = new int[1] ;
         H00424_A132MNU_SLINK = new String[] {""} ;
         H00424_A131MNU_DSN = new String[] {""} ;
         H00424_A362MNU_LINK = new String[] {""} ;
         H00424_A129MNU_NID = new String[] {""} ;
         H00424_A127PRG_DES = new String[] {""} ;
         A132MNU_SLINK = "" ;
         A131MNU_DSN = "" ;
         H00425_A127PRG_DES = new String[] {""} ;
         H00426_A362MNU_LINK = new String[] {""} ;
         H00426_A129MNU_NID = new String[] {""} ;
         AV10TrnContext = new SdtTransactionContext(context);
         AV13HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV12Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockprg_cod_Jsonclick = "" ;
         lblTextblockprg_des_Jsonclick = "" ;
         lblTextblockmnu_niv_Jsonclick = "" ;
         lblTextblockmnu_nid_Jsonclick = "" ;
         lblTextblockmnu_link_Jsonclick = "" ;
         lblTextblockmnu_sni_Jsonclick = "" ;
         lblTextblockmnu_dsn_Jsonclick = "" ;
         lblTextblockmnu_slink_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA126PRG_COD = "" ;
         sCtrlA361MNU_NIV = "" ;
         sCtrlA130MNU_SNI = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg008l1general__default(),
            new Object[][] {
                new Object[] {
               H00422_A127PRG_DES
               }
               , new Object[] {
               H00423_A362MNU_LINK, H00423_A129MNU_NID
               }
               , new Object[] {
               H00424_A126PRG_COD, H00424_A361MNU_NIV, H00424_A130MNU_SNI, H00424_A132MNU_SLINK, H00424_A131MNU_DSN, H00424_A362MNU_LINK, H00424_A129MNU_NID, H00424_A127PRG_DES
               }
               , new Object[] {
               H00425_A127PRG_DES
               }
               , new Object[] {
               H00426_A362MNU_LINK, H00426_A129MNU_NID
               }
            }
         );
         AV16Pgmname = "SEG008L1General" ;
         /* GeneXus formulas. */
         AV16Pgmname = "SEG008L1General" ;
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
      private int A130MNU_SNI ;
      private int wcpOA361MNU_NIV ;
      private int wcpOA130MNU_SNI ;
      private int AV8MNU_NIV ;
      private int AV9MNU_SNI ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV16Pgmname ;
      private String scmdbuf ;
      private String A127PRG_DES ;
      private String A129MNU_NID ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
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
      private String A131MNU_DSN ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_DES_Internalname ;
      private String edtMNU_NIV_Internalname ;
      private String edtMNU_NID_Internalname ;
      private String edtMNU_LINK_Internalname ;
      private String edtMNU_SNI_Internalname ;
      private String edtMNU_DSN_Internalname ;
      private String edtMNU_SLINK_Internalname ;
      private String edtMNU_NID_Link ;
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
      private String lblTextblockmnu_link_Internalname ;
      private String lblTextblockmnu_link_Jsonclick ;
      private String lblTextblockmnu_sni_Internalname ;
      private String lblTextblockmnu_sni_Jsonclick ;
      private String edtMNU_SNI_Jsonclick ;
      private String lblTextblockmnu_dsn_Internalname ;
      private String lblTextblockmnu_dsn_Jsonclick ;
      private String edtMNU_DSN_Jsonclick ;
      private String lblTextblockmnu_slink_Internalname ;
      private String lblTextblockmnu_slink_Jsonclick ;
      private String sCtrlA126PRG_COD ;
      private String sCtrlA361MNU_NIV ;
      private String sCtrlA130MNU_SNI ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A362MNU_LINK ;
      private String A132MNU_SLINK ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00422_A127PRG_DES ;
      private String[] H00423_A362MNU_LINK ;
      private String[] H00423_A129MNU_NID ;
      private short[] H00424_A126PRG_COD ;
      private int[] H00424_A361MNU_NIV ;
      private int[] H00424_A130MNU_SNI ;
      private String[] H00424_A132MNU_SLINK ;
      private String[] H00424_A131MNU_DSN ;
      private String[] H00424_A362MNU_LINK ;
      private String[] H00424_A129MNU_NID ;
      private String[] H00424_A127PRG_DES ;
      private String[] H00425_A127PRG_DES ;
      private String[] H00426_A362MNU_LINK ;
      private String[] H00426_A129MNU_NID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV13HTTPRequest ;
      private GxWebSession AV12Session ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class seg008l1general__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00422 ;
          prmH00422 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00423 ;
          prmH00423 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmH00424 ;
          prmH00424 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmH00425 ;
          prmH00425 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00426 ;
          prmH00426 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00422", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00422,1,1,true,true )
             ,new CursorDef("H00423", "SELECT [MNU_LINK], [MNU_NID] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00423,1,1,true,true )
             ,new CursorDef("H00424", "SELECT T1.[PRG_COD], T1.[MNU_NIV], T1.[MNU_SNI], T1.[MNU_SLINK], T1.[MNU_DSN], T3.[MNU_LINK], T3.[MNU_NID], T2.[PRG_DES] FROM (([SEG008L1] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) INNER JOIN [SEG008] T3 WITH (NOLOCK) ON T3.[PRG_COD] = T1.[PRG_COD] AND T3.[MNU_NIV] = T1.[MNU_NIV]) WHERE T1.[PRG_COD] = @PRG_COD and T1.[MNU_NIV] = @MNU_NIV and T1.[MNU_SNI] = @MNU_SNI ORDER BY T1.[PRG_COD], T1.[MNU_NIV], T1.[MNU_SNI] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00424,1,1,true,true )
             ,new CursorDef("H00425", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00425,1,1,true,true )
             ,new CursorDef("H00426", "SELECT [MNU_LINK], [MNU_NID] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00426,1,1,true,true )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 100) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 30) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
