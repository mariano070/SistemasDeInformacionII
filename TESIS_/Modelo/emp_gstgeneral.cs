/*
               File: EMP_GSTGeneral
        Description: EMP_ GSTGeneral
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:14.76
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
   public class emp_gstgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public emp_gstgeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("GeneXusX");
      }

      public emp_gstgeneral( IGxContext context )
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

      public void execute( int aP0_EmpGstCod )
      {
         this.A291EmpGstCod = aP0_EmpGstCod;
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
                  A291EmpGstCod = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(int)A291EmpGstCod});
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
         context.SetTheme("GeneXusX");
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
            PA142( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV14Pgmname = "EMP_GSTGeneral" ;
               context.Gx_err = 0 ;
               WS142( ) ;
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
            context.WriteHtmlText( "EMP_ GSTGeneral") ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("emp_gstgeneral.aspx") + "?" + UrlEncode("" +A291EmpGstCod)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm142( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA291EmpGstCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA291EmpGstCod), 8, 0, ",", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("emp_gstgeneral.js", "?19171479");
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

      protected void WB140( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "emp_gstgeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_142( true) ;
         }
         else
         {
            wb_table1_2_142( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_142e( bool wbgen )
      {
         if ( wbgen )
         {
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnupdate_Internalname, "Modifica", "Modifica", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnupdate_Jsonclick, sPrefix+"E\\'DOUPDATE\\'.", TempTags, "", "", "HLP_EMP_GSTGeneral.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtndelete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtndelete_Jsonclick, sPrefix+"E\\'DODELETE\\'.", TempTags, "", "", "HLP_EMP_GSTGeneral.htm");
         }
         wbLoad = true ;
      }

      protected void START142( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "EMP_ GSTGeneral", 0) ;
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
               STRUP140( ) ;
            }
         }
      }

      protected void WS142( )
      {
         START142( ) ;
         EVT142( ) ;
      }

      protected void EVT142( )
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
                                 STRUP140( ) ;
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
                                 STRUP140( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E11142 */
                                    E11142 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP140( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E12142 */
                                    E12142 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOUPDATE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP140( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E13142 */
                                    E13142 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DODELETE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP140( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E14142 */
                                    E14142 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP140( ) ;
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
                                 STRUP140( ) ;
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

      protected void WE142( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm142( ) ;
            }
         }
      }

      protected void PA142( )
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
         RF142( ) ;
         /* End function Refresh */
      }

      protected void RF142( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00142 */
            pr_default.execute(0, new Object[] {A291EmpGstCod});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A298GstEmpDes = H00142_A298GstEmpDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A298GstEmpDes", A298GstEmpDes);
               n298GstEmpDes = H00142_n298GstEmpDes[0] ;
               A297GstEmpCod = H00142_A297GstEmpCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A297GstEmpCod", A297GstEmpCod);
               A295EmpGstGpoCod = H00142_A295EmpGstGpoCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A295EmpGstGpoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A295EmpGstGpoCod), 4, 0)));
               A293EmpGstDes = H00142_A293EmpGstDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
               A298GstEmpDes = H00142_A298GstEmpDes[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A298GstEmpDes", A298GstEmpDes);
               n298GstEmpDes = H00142_n298GstEmpDes[0] ;
               /* Execute user event: E12142 */
               E12142 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB140( ) ;
         }
      }

      protected void STRUP140( )
      {
         /* Before Start, stand alone formulas. */
         AV14Pgmname = "EMP_GSTGeneral" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11142 */
         E11142 ();
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
               A291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( edtEmpGstCod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
            }
            A293EmpGstDes = (short)(context.localUtil.CToN( cgiGet( edtEmpGstDes_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
            A295EmpGstGpoCod = (short)(context.localUtil.CToN( cgiGet( edtEmpGstGpoCod_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A295EmpGstGpoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A295EmpGstGpoCod), 4, 0)));
            A297GstEmpCod = StringUtil.Upper( cgiGet( edtGstEmpCod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A297GstEmpCod", A297GstEmpCod);
            A298GstEmpDes = StringUtil.Upper( cgiGet( edtGstEmpDes_Internalname)) ;
            n298GstEmpDes = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A298GstEmpDes", A298GstEmpDes);
            /* Read saved values. */
            wcpOA291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA291EmpGstCod"), ",", ".")) ;
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
         /* Execute user event: E11142 */
         E11142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11142( )
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

      protected void E12142( )
      {
         /* Load Routine */
      }

      protected void E13142( )
      {
         /* 'DoUpdate' Routine */
         context.wjLoc = formatLink("emp_gst.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A291EmpGstCod) ;
      }

      protected void E14142( )
      {
         /* 'DoDelete' Routine */
         context.wjLoc = formatLink("emp_gst.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A291EmpGstCod) ;
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
         AV8TrnContext.gxTpr_Transactionname = "EMP_GST" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8TrnContext", (Object)(AV8TrnContext));
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV9TrnContextAtt.gxTpr_Attributename = "EmpGstCod" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV9TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7EmpGstCod), 8, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9TrnContextAtt", (Object)(AV9TrnContextAtt));
         AV8TrnContext.gxTpr_Attributes.Add(AV9TrnContextAtt, 0);
         AV10Session.Set("TrnContext", AV8TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_142( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockempgstcod_Internalname, 1, 1, 0, "Gst Cod", "", "", "", 0, lblTextblockempgstcod_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEmpGstCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A291EmpGstCod), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A291EmpGstCod), "ZZZZZZZ9"), "", 0, edtEmpGstCod_Jsonclick, "", 0, 1, 1, true, "right", "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockempgstdes_Internalname, 1, 1, 0, "Gst Des", "", "", "", 0, lblTextblockempgstdes_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEmpGstDes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A293EmpGstDes), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A293EmpGstDes), "ZZZ9"), "", 0, edtEmpGstDes_Jsonclick, "", 0, 1, 1, true, "right", "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockempgstgpocod_Internalname, 1, 1, 0, "Gpo Cod", "", "", "", 0, lblTextblockempgstgpocod_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEmpGstGpoCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A295EmpGstGpoCod), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A295EmpGstGpoCod), "ZZZ9"), "", 0, edtEmpGstGpoCod_Jsonclick, "", 0, 1, 1, true, "right", "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgstempcod_Internalname, 1, 1, 0, "Gestor", "", "", "", 0, lblTextblockgstempcod_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGstEmpCod_Internalname, StringUtil.RTrim( A297GstEmpCod), "", 15, "chr", 1, "row", 15, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A297GstEmpCod, "@!")), "", 0, edtGstEmpCod_Jsonclick, "", 0, 1, 1, true, "left", "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgstempdes_Internalname, 1, 1, 0, "Gestor", "", "", "", 0, lblTextblockgstempdes_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "ReadonlyAttribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGstEmpDes_Internalname, StringUtil.RTrim( A298GstEmpDes), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A298GstEmpDes, "@!")), "", 0, edtGstEmpDes_Jsonclick, "", 0, 1, 1, true, "left", "HLP_EMP_GSTGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_142e( true) ;
         }
         else
         {
            wb_table1_2_142e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A291EmpGstCod = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
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
         PA142( ) ;
         WS142( ) ;
         WE142( ) ;
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
         sCtrlA291EmpGstCod = (String)((String)getParm(obj,0)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA142( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "emp_gstgeneral");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA142( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A291EmpGstCod = Convert.ToInt32(getParm(obj,2)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
         }
         wcpOA291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA291EmpGstCod"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( A291EmpGstCod != wcpOA291EmpGstCod ) ) )
         {
            setjustcreated();
         }
         wcpOA291EmpGstCod = A291EmpGstCod ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA291EmpGstCod = cgiGet( sPrefix+"A291EmpGstCod_CTRL") ;
         if ( StringUtil.Len( sCtrlA291EmpGstCod) > 0 )
         {
            A291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( sCtrlA291EmpGstCod), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
         }
         else
         {
            A291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( sPrefix+"A291EmpGstCod_PARM"), ",", ".")) ;
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
         PA142( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS142( ) ;
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
         WS142( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A291EmpGstCod_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A291EmpGstCod), 8, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA291EmpGstCod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A291EmpGstCod_CTRL", StringUtil.RTrim( sCtrlA291EmpGstCod));
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
         WE142( ) ;
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
         AddThemeStyleSheetFile("", "GeneXusX.css", "?191514");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1917151");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("emp_gstgeneral.js", "?1917151");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockempgstcod_Internalname = sPrefix+"TEXTBLOCKEMPGSTCOD" ;
         edtEmpGstCod_Internalname = sPrefix+"EMPGSTCOD" ;
         lblTextblockempgstdes_Internalname = sPrefix+"TEXTBLOCKEMPGSTDES" ;
         edtEmpGstDes_Internalname = sPrefix+"EMPGSTDES" ;
         lblTextblockempgstgpocod_Internalname = sPrefix+"TEXTBLOCKEMPGSTGPOCOD" ;
         edtEmpGstGpoCod_Internalname = sPrefix+"EMPGSTGPOCOD" ;
         lblTextblockgstempcod_Internalname = sPrefix+"TEXTBLOCKGSTEMPCOD" ;
         edtGstEmpCod_Internalname = sPrefix+"GSTEMPCOD" ;
         lblTextblockgstempdes_Internalname = sPrefix+"TEXTBLOCKGSTEMPDES" ;
         edtGstEmpDes_Internalname = sPrefix+"GSTEMPDES" ;
         tblTbl2_Internalname = sPrefix+"TBL2" ;
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE" ;
         bttBtndelete_Internalname = sPrefix+"BTNDELETE" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtGstEmpDes_Jsonclick = "" ;
         edtGstEmpCod_Jsonclick = "" ;
         edtEmpGstGpoCod_Jsonclick = "" ;
         edtEmpGstDes_Jsonclick = "" ;
         edtEmpGstCod_Jsonclick = "" ;
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
         AV14Pgmname = "" ;
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
         scmdbuf = "" ;
         H00142_A291EmpGstCod = new int[1] ;
         H00142_A298GstEmpDes = new String[] {""} ;
         H00142_n298GstEmpDes = new bool[] {false} ;
         H00142_A297GstEmpCod = new String[] {""} ;
         H00142_A295EmpGstGpoCod = new short[1] ;
         H00142_A293EmpGstDes = new short[1] ;
         A298GstEmpDes = "" ;
         A297GstEmpCod = "" ;
         AV8TrnContext = new SdtTransactionContext(context);
         AV11HTTPRequest = new GxHttpRequest( context);
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV10Session = new GxWebSession( context);
         sStyleString = "" ;
         lblTextblockempgstcod_Jsonclick = "" ;
         lblTextblockempgstdes_Jsonclick = "" ;
         lblTextblockempgstgpocod_Jsonclick = "" ;
         lblTextblockgstempcod_Jsonclick = "" ;
         lblTextblockgstempdes_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA291EmpGstCod = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.emp_gstgeneral__default(),
            new Object[][] {
                new Object[] {
               H00142_A291EmpGstCod, H00142_A298GstEmpDes, H00142_n298GstEmpDes, H00142_A297GstEmpCod, H00142_A295EmpGstGpoCod, H00142_A293EmpGstDes
               }
            }
         );
         AV14Pgmname = "EMP_GSTGeneral" ;
         /* GeneXus formulas. */
         AV14Pgmname = "EMP_GSTGeneral" ;
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
      private short A295EmpGstGpoCod ;
      private short A293EmpGstDes ;
      private short nGXWrapped ;
      private int A291EmpGstCod ;
      private int wcpOA291EmpGstCod ;
      private int AV7EmpGstCod ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV14Pgmname ;
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
      private String scmdbuf ;
      private String A298GstEmpDes ;
      private String A297GstEmpCod ;
      private String edtEmpGstCod_Internalname ;
      private String edtEmpGstDes_Internalname ;
      private String edtEmpGstGpoCod_Internalname ;
      private String edtGstEmpCod_Internalname ;
      private String edtGstEmpDes_Internalname ;
      private String sStyleString ;
      private String tblTbl2_Internalname ;
      private String lblTextblockempgstcod_Internalname ;
      private String lblTextblockempgstcod_Jsonclick ;
      private String edtEmpGstCod_Jsonclick ;
      private String lblTextblockempgstdes_Internalname ;
      private String lblTextblockempgstdes_Jsonclick ;
      private String edtEmpGstDes_Jsonclick ;
      private String lblTextblockempgstgpocod_Internalname ;
      private String lblTextblockempgstgpocod_Jsonclick ;
      private String edtEmpGstGpoCod_Jsonclick ;
      private String lblTextblockgstempcod_Internalname ;
      private String lblTextblockgstempcod_Jsonclick ;
      private String edtGstEmpCod_Jsonclick ;
      private String lblTextblockgstempdes_Internalname ;
      private String lblTextblockgstempdes_Jsonclick ;
      private String edtGstEmpDes_Jsonclick ;
      private String sCtrlA291EmpGstCod ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n298GstEmpDes ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H00142_A291EmpGstCod ;
      private String[] H00142_A298GstEmpDes ;
      private bool[] H00142_n298GstEmpDes ;
      private String[] H00142_A297GstEmpCod ;
      private short[] H00142_A295EmpGstGpoCod ;
      private short[] H00142_A293EmpGstDes ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV11HTTPRequest ;
      private GxWebSession AV10Session ;
      private SdtTransactionContext AV8TrnContext ;
      private SdtTransactionContext_Attribute AV9TrnContextAtt ;
   }

   public class emp_gstgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00142 ;
          prmH00142 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00142", "SELECT T1.[EmpGstCod], T2.[USU_DES] AS GstEmpDes, T1.[GstEmpCod] AS GstEmpCod, T1.[EmpGstGpoCod], T1.[EmpGstDes] FROM ([EMP_GST] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[GstEmpCod]) WHERE T1.[EmpGstCod] = @EmpGstCod ORDER BY T1.[EmpGstCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00142,1,0,true,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 15) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
