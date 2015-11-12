/*
               File: GPO_GESGeneral
        Description: GPO_ GESGeneral
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:20.28
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
   public class gpo_gesgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public gpo_gesgeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gpo_gesgeneral( IGxContext context )
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

      public void execute( short aP0_Grupo_Cod ,
                           String aP1_Ges_Cod )
      {
         this.A271Grupo_Cod = aP0_Grupo_Cod;
         this.A270Ges_Cod = aP1_Ges_Cod;
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
                  A271Grupo_Cod = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
                  A270Ges_Cod = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270Ges_Cod", A270Ges_Cod);
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A271Grupo_Cod,(String)A270Ges_Cod});
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
            PA112( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "GPO_GESGeneral" ;
               context.Gx_err = 0 ;
               /* Using cursor H00112 */
               pr_default.execute(0, new Object[] {A270Ges_Cod});
               A277Ges_Des = H00112_A277Ges_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A277Ges_Des", A277Ges_Des);
               n277Ges_Des = H00112_n277Ges_Des[0] ;
               pr_default.close(0);
               WS112( ) ;
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
            context.WriteHtmlText( "GPO_ GESGeneral") ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gpo_gesgeneral.aspx") + "?" + UrlEncode("" +A271Grupo_Cod) + "," + UrlEncode(StringUtil.RTrim(A270Ges_Cod))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm112( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA271Grupo_Cod", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA271Grupo_Cod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA270Ges_Cod", StringUtil.RTrim( wcpOA270Ges_Cod));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("gpo_gesgeneral.js", "?19172033");
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

      protected void WB110( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "gpo_gesgeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_112( true) ;
         }
         else
         {
            wb_table1_2_112( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_112e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_GPO_GESGeneral.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_GPO_GESGeneral.htm");
         }
         wbLoad = true ;
      }

      protected void START112( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "GPO_ GESGeneral", 0) ;
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
               STRUP110( ) ;
            }
         }
      }

      protected void WS112( )
      {
         START112( ) ;
         EVT112( ) ;
      }

      protected void EVT112( )
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
                                 STRUP110( ) ;
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
                                 STRUP110( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E11112 */
                                    E11112 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP110( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E12112 */
                                    E12112 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP110( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E13112 */
                                    E13112 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP110( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E14112 */
                                    E14112 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP110( ) ;
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
                                 STRUP110( ) ;
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

      protected void WE112( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm112( ) ;
            }
         }
      }

      protected void PA112( )
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
         RF112( ) ;
         /* End function Refresh */
      }

      protected void RF112( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00113 */
            pr_default.execute(1, new Object[] {A271Grupo_Cod, A270Ges_Cod});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A275Grupo_Tip = H00113_A275Grupo_Tip[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A275Grupo_Tip", A275Grupo_Tip);
               A273Grupo_Des = H00113_A273Grupo_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A273Grupo_Des", A273Grupo_Des);
               /* Execute user event: E12112 */
               E12112 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            WB110( ) ;
         }
      }

      protected void STRUP110( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "GPO_GESGeneral" ;
         context.Gx_err = 0 ;
         /* Using cursor H00114 */
         pr_default.execute(2, new Object[] {A270Ges_Cod});
         A277Ges_Des = H00114_A277Ges_Des[0] ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A277Ges_Des", A277Ges_Des);
         n277Ges_Des = H00114_n277Ges_Des[0] ;
         pr_default.close(2);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11112 */
         E11112 ();
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
               A271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( edtGrupo_Cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
            }
            A273Grupo_Des = cgiGet( edtGrupo_Des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A273Grupo_Des", A273Grupo_Des);
            A275Grupo_Tip = cgiGet( edtGrupo_Tip_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A275Grupo_Tip", A275Grupo_Tip);
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               A270Ges_Cod = StringUtil.Upper( cgiGet( edtGes_Cod_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270Ges_Cod", A270Ges_Cod);
            }
            A277Ges_Des = StringUtil.Upper( cgiGet( edtGes_Des_Internalname)) ;
            n277Ges_Des = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A277Ges_Des", A277Ges_Des);
            /* Read saved values. */
            wcpOA271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA271Grupo_Cod"), ",", ".")) ;
            wcpOA270Ges_Cod = cgiGet( sPrefix+"wcpOA270Ges_Cod") ;
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
         /* Execute user event: E11112 */
         E11112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11112( )
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

      protected void E12112( )
      {
         /* Load Routine */
      }

      protected void E13112( )
      {
         /* 'DoUpdate' Routine */
         context.wjLoc = formatLink("gpo_ges.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A271Grupo_Cod) + "," + UrlEncode(StringUtil.RTrim(A270Ges_Cod)) ;
      }

      protected void E14112( )
      {
         /* 'DoDelete' Routine */
         context.wjLoc = formatLink("gpo_ges.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A271Grupo_Cod) + "," + UrlEncode(StringUtil.RTrim(A270Ges_Cod)) ;
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
         AV9TrnContext.gxTpr_Transactionname = "GPO_GES" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContext", (Object)(AV9TrnContext));
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "Grupo_Cod" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7Grupo_Cod), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV10TrnContextAtt.gxTpr_Attributename = "Ges_Cod" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV10TrnContextAtt.gxTpr_Attributevalue = AV8Ges_Cod ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContextAtt", (Object)(AV10TrnContextAtt));
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_112( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_cod_Internalname, 1, 1, 0, "Cod", "", "", "", 0, lblTextblockgrupo_cod_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGrupo_Cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A271Grupo_Cod), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A271Grupo_Cod), "ZZZ9"), "", 0, edtGrupo_Cod_Jsonclick, "", 0, 1, 1, true, "right", "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_des_Internalname, 1, 1, 0, "Des", "", "", "", 0, lblTextblockgrupo_des_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGrupo_Des_Internalname, StringUtil.RTrim( A273Grupo_Des), "", 20, "chr", 1, "row", 20, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A273Grupo_Des, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtGrupo_Des_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_tip_Internalname, 1, 1, 0, "Tip", "", "", "", 0, lblTextblockgrupo_tip_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGrupo_Tip_Internalname, StringUtil.RTrim( A275Grupo_Tip), "", 1, "chr", 1, "row", 1, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A275Grupo_Tip, "X")), "", 0, edtGrupo_Tip_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockges_cod_Internalname, 1, 1, 0, "Ges_ Cod", "", "", "", 0, lblTextblockges_cod_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGes_Cod_Internalname, StringUtil.RTrim( A270Ges_Cod), "", 15, "chr", 1, "row", 15, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A270Ges_Cod, "@!")), "", 0, edtGes_Cod_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockges_des_Internalname, 1, 1, 0, "Des", "", "", "", 0, lblTextblockges_des_Jsonclick, "", StyleString, ClassString, "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGes_Des_Internalname, StringUtil.RTrim( A277Ges_Des), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A277Ges_Des, "@!")), "", 0, edtGes_Des_Jsonclick, "", 0, 1, 1, true, "left", "HLP_GPO_GESGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_112e( true) ;
         }
         else
         {
            wb_table1_2_112e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A271Grupo_Cod = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
         A270Ges_Cod = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270Ges_Cod", A270Ges_Cod);
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
         PA112( ) ;
         WS112( ) ;
         WE112( ) ;
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
         sCtrlA271Grupo_Cod = (String)((String)getParm(obj,0)) ;
         sCtrlA270Ges_Cod = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA112( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "gpo_gesgeneral");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA112( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A271Grupo_Cod = Convert.ToInt16(getParm(obj,2)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
            A270Ges_Cod = (String)getParm(obj,3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270Ges_Cod", A270Ges_Cod);
         }
         wcpOA271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA271Grupo_Cod"), ",", ".")) ;
         wcpOA270Ges_Cod = cgiGet( sPrefix+"wcpOA270Ges_Cod") ;
         if ( ! GetJustCreated( ) && ( ( A271Grupo_Cod != wcpOA271Grupo_Cod ) || ( StringUtil.StrCmp(A270Ges_Cod, wcpOA270Ges_Cod) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOA271Grupo_Cod = A271Grupo_Cod ;
         wcpOA270Ges_Cod = A270Ges_Cod ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA271Grupo_Cod = cgiGet( sPrefix+"A271Grupo_Cod_CTRL") ;
         if ( StringUtil.Len( sCtrlA271Grupo_Cod) > 0 )
         {
            A271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( sCtrlA271Grupo_Cod), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A271Grupo_Cod", StringUtil.LTrim( StringUtil.Str( (decimal)(A271Grupo_Cod), 4, 0)));
         }
         else
         {
            A271Grupo_Cod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A271Grupo_Cod_PARM"), ",", ".")) ;
         }
         sCtrlA270Ges_Cod = cgiGet( sPrefix+"A270Ges_Cod_CTRL") ;
         if ( StringUtil.Len( sCtrlA270Ges_Cod) > 0 )
         {
            A270Ges_Cod = cgiGet( sCtrlA270Ges_Cod) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270Ges_Cod", A270Ges_Cod);
         }
         else
         {
            A270Ges_Cod = cgiGet( sPrefix+"A270Ges_Cod_PARM") ;
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
         PA112( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS112( ) ;
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
         WS112( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A271Grupo_Cod_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A271Grupo_Cod), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA271Grupo_Cod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A271Grupo_Cod_CTRL", StringUtil.RTrim( sCtrlA271Grupo_Cod));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A270Ges_Cod_PARM", StringUtil.RTrim( A270Ges_Cod));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA270Ges_Cod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A270Ges_Cod_CTRL", StringUtil.RTrim( sCtrlA270Ges_Cod));
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
         WE112( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19172059");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("gpo_gesgeneral.js", "?19172059");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockgrupo_cod_Internalname = sPrefix+"TEXTBLOCKGRUPO_COD" ;
         edtGrupo_Cod_Internalname = sPrefix+"GRUPO_COD" ;
         lblTextblockgrupo_des_Internalname = sPrefix+"TEXTBLOCKGRUPO_DES" ;
         edtGrupo_Des_Internalname = sPrefix+"GRUPO_DES" ;
         lblTextblockgrupo_tip_Internalname = sPrefix+"TEXTBLOCKGRUPO_TIP" ;
         edtGrupo_Tip_Internalname = sPrefix+"GRUPO_TIP" ;
         lblTextblockges_cod_Internalname = sPrefix+"TEXTBLOCKGES_COD" ;
         edtGes_Cod_Internalname = sPrefix+"GES_COD" ;
         lblTextblockges_des_Internalname = sPrefix+"TEXTBLOCKGES_DES" ;
         edtGes_Des_Internalname = sPrefix+"GES_DES" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtGes_Des_Jsonclick = "" ;
         edtGes_Cod_Jsonclick = "" ;
         edtGrupo_Tip_Jsonclick = "" ;
         edtGrupo_Des_Jsonclick = "" ;
         edtGrupo_Cod_Jsonclick = "" ;
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
         wcpOA270Ges_Cod = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         AV15Pgmname = "" ;
         scmdbuf = "" ;
         H00112_A277Ges_Des = new String[] {""} ;
         H00112_n277Ges_Des = new bool[] {false} ;
         A277Ges_Des = "" ;
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
         H00113_A271Grupo_Cod = new short[1] ;
         H00113_A270Ges_Cod = new String[] {""} ;
         H00113_A277Ges_Des = new String[] {""} ;
         H00113_n277Ges_Des = new bool[] {false} ;
         H00113_A275Grupo_Tip = new String[] {""} ;
         H00113_A273Grupo_Des = new String[] {""} ;
         A275Grupo_Tip = "" ;
         A273Grupo_Des = "" ;
         H00114_A277Ges_Des = new String[] {""} ;
         H00114_n277Ges_Des = new bool[] {false} ;
         AV9TrnContext = new SdtTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8Ges_Cod = "" ;
         AV11Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockgrupo_cod_Jsonclick = "" ;
         lblTextblockgrupo_des_Jsonclick = "" ;
         lblTextblockgrupo_tip_Jsonclick = "" ;
         lblTextblockges_cod_Jsonclick = "" ;
         lblTextblockges_des_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA271Grupo_Cod = "" ;
         sCtrlA270Ges_Cod = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gpo_gesgeneral__default(),
            new Object[][] {
                new Object[] {
               H00112_A277Ges_Des, H00112_n277Ges_Des
               }
               , new Object[] {
               H00113_A271Grupo_Cod, H00113_A270Ges_Cod, H00113_A277Ges_Des, H00113_n277Ges_Des, H00113_A275Grupo_Tip, H00113_A273Grupo_Des
               }
               , new Object[] {
               H00114_A277Ges_Des, H00114_n277Ges_Des
               }
            }
         );
         AV15Pgmname = "GPO_GESGeneral" ;
         /* GeneXus formulas. */
         AV15Pgmname = "GPO_GESGeneral" ;
         context.Gx_err = 0 ;
      }

      private short A271Grupo_Cod ;
      private short wcpOA271Grupo_Cod ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short AV7Grupo_Cod ;
      private short nGXWrapped ;
      private int idxLst ;
      private String A270Ges_Cod ;
      private String wcpOA270Ges_Cod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV15Pgmname ;
      private String scmdbuf ;
      private String A277Ges_Des ;
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
      private String A275Grupo_Tip ;
      private String A273Grupo_Des ;
      private String edtGrupo_Cod_Internalname ;
      private String edtGrupo_Des_Internalname ;
      private String edtGrupo_Tip_Internalname ;
      private String edtGes_Cod_Internalname ;
      private String edtGes_Des_Internalname ;
      private String AV8Ges_Cod ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockgrupo_cod_Internalname ;
      private String lblTextblockgrupo_cod_Jsonclick ;
      private String edtGrupo_Cod_Jsonclick ;
      private String lblTextblockgrupo_des_Internalname ;
      private String lblTextblockgrupo_des_Jsonclick ;
      private String edtGrupo_Des_Jsonclick ;
      private String lblTextblockgrupo_tip_Internalname ;
      private String lblTextblockgrupo_tip_Jsonclick ;
      private String edtGrupo_Tip_Jsonclick ;
      private String lblTextblockges_cod_Internalname ;
      private String lblTextblockges_cod_Jsonclick ;
      private String edtGes_Cod_Jsonclick ;
      private String lblTextblockges_des_Internalname ;
      private String lblTextblockges_des_Jsonclick ;
      private String edtGes_Des_Jsonclick ;
      private String sCtrlA271Grupo_Cod ;
      private String sCtrlA270Ges_Cod ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool n277Ges_Des ;
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
      private String[] H00112_A277Ges_Des ;
      private bool[] H00112_n277Ges_Des ;
      private short[] H00113_A271Grupo_Cod ;
      private String[] H00113_A270Ges_Cod ;
      private String[] H00113_A277Ges_Des ;
      private bool[] H00113_n277Ges_Des ;
      private String[] H00113_A275Grupo_Tip ;
      private String[] H00113_A273Grupo_Des ;
      private String[] H00114_A277Ges_Des ;
      private bool[] H00114_n277Ges_Des ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private GxWebSession AV11Session ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class gpo_gesgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00112 ;
          prmH00112 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmH00113 ;
          prmH00113 = new Object[] {
          new Object[] {"@Grupo_Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          Object[] prmH00114 ;
          prmH00114 = new Object[] {
          new Object[] {"@Ges_Cod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00112", "SELECT [USU_DES] AS Ges_Des FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @Ges_Cod ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00112,1,0,true,true )
             ,new CursorDef("H00113", "SELECT T1.[Grupo_Cod], T1.[Ges_Cod] AS Ges_Cod, T2.[USU_DES] AS Ges_Des, T1.[Grupo_Tip], T1.[Grupo_Des] FROM ([GPO_GES] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[Ges_Cod]) WHERE T1.[Grupo_Cod] = @Grupo_Cod and T1.[Ges_Cod] = @Ges_Cod ORDER BY T1.[Grupo_Cod], T1.[Ges_Cod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00113,1,0,true,true )
             ,new CursorDef("H00114", "SELECT [USU_DES] AS Ges_Des FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @Ges_Cod ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00114,1,0,true,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[5])[0] = rslt.getString(5, 20) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
