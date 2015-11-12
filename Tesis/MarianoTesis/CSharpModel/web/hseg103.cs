/*
               File: HSEG103
        Description: Act. Usuarios/Sistemas
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:32.33
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
   public class hseg103 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg103( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg103( IGxContext context )
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

      public void execute( ref String aP0_USUCOD ,
                           ref String aP1_USUDES ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV5USUCOD = aP0_USUCOD;
         this.AV6USUDES = aP1_USUDES;
         this.AV13SISTEMA = aP2_SISTEMA;
         this.AV14USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_USUCOD=this.AV5USUCOD;
         aP1_USUDES=this.AV6USUDES;
         aP2_SISTEMA=this.AV13SISTEMA;
         aP3_USUARIO=this.AV14USUARIO;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_12_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_12_idx, sGXsfl_12_idx) ;
               return  ;
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
               AV5USUCOD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6USUDES = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUDES", AV6USUDES);
                  AV13SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SISTEMA", AV13SISTEMA);
                  AV14USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14USUARIO", AV14USUARIO);
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
         PA4Z2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4Z2( ) ;
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
         context.WriteHtmlText( " "+"backgroundgx=\"NULL\""+" "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg103.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode(StringUtil.RTrim(AV6USUDES)) + "," + UrlEncode(StringUtil.RTrim(AV13SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV14USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV13SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV14USUARIO));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE4Z2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4Z2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG103" ;
      }

      public override String GetPgmdesc( )
      {
         return "Act. Usuarios/Sistemas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg103.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode(StringUtil.RTrim(AV6USUDES)) + "," + UrlEncode(StringUtil.RTrim(AV13SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV14USUARIO)) ;
      }

      protected void WB4Z0( )
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
            context.WriteHtmlText( "<p>") ;
            wb_table1_3_4Z2( true) ;
         }
         else
         {
            wb_table1_3_4Z2( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_4Z2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true ;
      }

      protected void START4Z2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Act. Usuarios/Sistemas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4Z0( ) ;
      }

      protected void WS4Z2( )
      {
         START4Z2( ) ;
         EVT4Z2( ) ;
      }

      protected void EVT4Z2( )
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
                  /* Check if conditions changed and reset current page numbers */
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
                           else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E114Z2 */
                              E114Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E124Z2 */
                              E124Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E134Z2 */
                              E134Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E144Z2 */
                              E144Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'AGREGA SISTEMAS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E154Z2 */
                              E154Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E164Z2 */
                              E164Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PROGRAMAS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E174Z2 */
                              E174Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CERRAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E184Z2 */
                              E184Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "'PROGRAMAS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "'AGREGA SISTEMAS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'FIRST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'PREVIOUS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'NEXT'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'LAST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'CERRAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
                              edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
                              edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
                              edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_12_idx ;
                              edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_12_idx ;
                              A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                              A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
                              A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                              A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E194Z2 */
                                    E194Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E204Z2 */
                                    E204Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E164Z2 */
                                    E164Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'PROGRAMAS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E174Z2 */
                                    E174Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'AGREGA SISTEMAS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E154Z2 */
                                    E154Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E114Z2 */
                                    E114Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E124Z2 */
                                    E124Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E134Z2 */
                                    E134Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E144Z2 */
                                    E144Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CERRAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E184Z2 */
                                    E184Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E214Z2 */
                                    E214Z2 ();
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
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
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
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE4Z2( )
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

      protected void PA4Z2( )
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

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_12_idx ,
                                       String sGXsfl_12_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_12_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_12_idx ;
         while ( nGXsfl_12_idx <= nRC_Grid1 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_12_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_12_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF4Z2( ) ;
         /* End function Refresh */
      }

      protected void RF4Z2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 12 ;
         nGXsfl_12_idx = 1 ;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_12_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_12_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_12_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_12_idx ;
            /* Using cursor H004Z2 */
            pr_default.execute(0, new Object[] {AV5USUCOD});
            nGXsfl_12_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 9 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A7USU_DES = H004Z2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = H004Z2_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A259SIS_DES = H004Z2_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A116SIS_COD = H004Z2_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A7USU_DES = H004Z2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A259SIS_DES = H004Z2_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               /* Execute user event: E214Z2 */
               E214Z2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 12 ;
            WB4Z0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         /* Using cursor H004Z3 */
         pr_default.execute(1, new Object[] {AV5USUCOD});
         GRID1_nRecordCount = H004Z3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 9 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(9*1) ;
            }
            else
            {
               return (int)(9) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid1_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP4Z0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E194Z2 */
         E194Z2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5USUCOD = StringUtil.Upper( cgiGet( edtavUsucod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
            AV6USUDES = StringUtil.Upper( cgiGet( edtavUsudes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUDES", AV6USUDES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13SISTEMA = cgiGet( "vSISTEMA") ;
            AV14USUARIO = cgiGet( "vUSUARIO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            nGXsfl_12_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_12_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_12_idx ;
            if ( nGXsfl_12_idx > 0 )
            {
               A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E194Z2 */
         E194Z2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E194Z2( )
      {
         /* Start Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV14USUARIO)) )
         {
            AV14USUARIO = context.GetCookie( "USUARIO") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14USUARIO", AV14USUARIO);
         }
         else
         {
            AV8A = context.SetCookie( "USUARIO", AV14USUARIO, "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         AV7HABILITADO = 1 ;
         if ( AV7HABILITADO == 1 )
         {
            bttBtn_alta_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_alta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_alta_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_alta_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_alta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_alta_Enabled), 5, 0)));
         }
      }

      protected void E204Z2( )
      {
         /* 'Alta' Routine */
         AV15SISCOD = 0 ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV5USUCOD)) + "," + UrlEncode("" +AV15SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV13SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV14USUARIO)) + "," + UrlEncode(StringUtil.RTrim("INS")) ;
         context.wjLoc = formatLink("tseg003.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E164Z2( )
      {
         /* 'Baja' Routine */
         new pseg001(context ).execute( ref  A6USU_COD, ref  A116SIS_COD) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
      }

      protected void E174Z2( )
      {
         /* 'Programas' Routine */
         if ( A116SIS_COD != 0 )
         {
            context.wjLoc = formatLink("hseg104.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) + "," + UrlEncode(StringUtil.RTrim(A7USU_DES)) + "," + UrlEncode("" +A116SIS_COD) + "," + UrlEncode(StringUtil.RTrim(A259SIS_DES)) + "," + UrlEncode(StringUtil.RTrim(AV13SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV14USUARIO)) ;
         }
      }

      protected void E154Z2( )
      {
         /* 'Agrega Sistemas' Routine */
         context.wjLoc = formatLink("hseg001.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5USUCOD)) ;
      }

      protected void E114Z2( )
      {
         /* 'First' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E124Z2( )
      {
         /* 'Previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E134Z2( )
      {
         /* 'Next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E144Z2( )
      {
         /* 'Last' Routine */
         subgrid1_lastpage( ) ;
      }

      protected void E184Z2( )
      {
         /* 'Cerrar' Routine */
         context.wjLoc = formatLink("hseg102.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV14USUARIO)) ;
      }

      private void E214Z2( )
      {
         /* Load Routine */
         if ( ( subGrid1_Islastpage == 1 ) || ( 9 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_122( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_3_4Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 1, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Usuario:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HSEG103.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsucod_Internalname, StringUtil.RTrim( AV5USUCOD), "", 16, "chr", 1, "row", 16, 1, edtavUsucod_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV5USUCOD, "@!")), "", 0, edtavUsucod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG103.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavUsudes_Internalname, StringUtil.RTrim( AV6USUDES), "", 50, "chr", 1, "row", 50, 1, edtavUsudes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6USUDES, "@!")), "", 0, edtavUsudes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG103.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"top\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "WorkWith");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A259SIS_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A6USU_COD));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A7USU_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 12 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_12_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_first_Internalname, "|<", "|<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_first_Jsonclick, "E\\'FIRST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_previous_Internalname, "<", "<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_previous_Jsonclick, "E\\'PREVIOUS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_next_Internalname, ">", ">", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_next_Jsonclick, "E\\'NEXT\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_last_Internalname, ">|", ">|", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_last_Jsonclick, "E\\'LAST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            wb_table2_23_4Z2( true) ;
         }
         else
         {
            wb_table2_23_4Z2( false) ;
         }
         return  ;
      }

      protected void wb_table2_23_4Z2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_4Z2e( true) ;
         }
         else
         {
            wb_table1_3_4Z2e( false) ;
         }
      }

      protected void wb_table2_23_4Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_alta_Internalname, "Agrega Sistemas", "Agrega Sistemas", "", StyleString, ClassString, 1, bttBtn_alta_Enabled, "rounded", 5, bttBtn_alta_Jsonclick, "E\\'AGREGA SISTEMAS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Baja", "Baja", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "E\\'BAJA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"(Unknown)\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Programas", "Programas", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, "E\\'PROGRAMAS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"(Unknown)\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Cerrar", "Cerrar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'CERRAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG103.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_23_4Z2e( true) ;
         }
         else
         {
            wb_table2_23_4Z2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5USUCOD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUCOD", AV5USUCOD);
         AV6USUDES = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUDES", AV6USUDES);
         AV13SISTEMA = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SISTEMA", AV13SISTEMA);
         AV14USUARIO = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14USUARIO", AV14USUARIO);
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
         PA4Z2( ) ;
         WS4Z2( ) ;
         WE4Z2( ) ;
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
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11183280");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg103.js", "?11183280");
         /* End function include_jscripts */
      }

      protected void sendrow_122( )
      {
         WB4Z0( ) ;
         if ( ( 9 * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_12_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"),(String)"",(short)0,(String)edtSIS_COD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_DES_Internalname,StringUtil.RTrim( A259SIS_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")),(String)"",(short)0,(String)edtSIS_DES_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_COD_Internalname,StringUtil.RTrim( A6USU_COD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")),(String)"",(short)0,(String)edtUSU_COD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_DES_Internalname,StringUtil.RTrim( A7USU_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")),(String)"",(short)0,(String)edtUSU_DES_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_12_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_12_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_12_idx ;
         }
         /* End function sendrow_122 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavUsucod_Internalname = "vUSUCOD" ;
         edtavUsudes_Internalname = "vUSUDES" ;
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttBtn_alta_Internalname = "BTN_ALTA" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         tblTable2_Internalname = "TABLE2" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_COD_Jsonclick = "" ;
         bttBtn_alta_Enabled = 1 ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Class = "WorkWith" ;
         subGrid1_Backcolorstyle = 3 ;
         edtavUsudes_Jsonclick = "" ;
         edtavUsudes_Backstyle = -1 ;
         edtavUsudes_Backcolor = (int)(0xFFFFFF) ;
         edtavUsudes_Enabled = 0 ;
         edtavUsucod_Jsonclick = "" ;
         edtavUsucod_Backstyle = -1 ;
         edtavUsucod_Backcolor = (int)(0xFFFFFF) ;
         edtavUsucod_Enabled = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Act. Usuarios/Sistemas" ;
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
         wcpOAV5USUCOD = "" ;
         wcpOAV6USUDES = "" ;
         wcpOAV13SISTEMA = "" ;
         wcpOAV14USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtSIS_COD_Internalname = "" ;
         edtSIS_DES_Internalname = "" ;
         edtUSU_COD_Internalname = "" ;
         edtUSU_DES_Internalname = "" ;
         A259SIS_DES = "" ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H004Z2_A7USU_DES = new String[] {""} ;
         H004Z2_A6USU_COD = new String[] {""} ;
         H004Z2_A259SIS_DES = new String[] {""} ;
         H004Z2_A116SIS_COD = new short[1] ;
         H004Z3_AGRID1_nRecordCount = new int[1] ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char4 = "" ;
         TempTags = "" ;
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttBtn_alta_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char5 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg103__default(),
            new Object[][] {
                new Object[] {
               H004Z2_A7USU_DES, H004Z2_A6USU_COD, H004Z2_A259SIS_DES, H004Z2_A116SIS_COD
               }
               , new Object[] {
               H004Z3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_12_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A116SIS_COD ;
      private short nDonePA ;
      private short AV8A ;
      private short AV7HABILITADO ;
      private short AV15SISCOD ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private short edtavUsudes_Backstyle ;
      private short edtavUsucod_Backstyle ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int bttBtn_alta_Enabled ;
      private int edtavUsucod_Enabled ;
      private int edtavUsudes_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavUsudes_Backcolor ;
      private int edtavUsucod_Backcolor ;
      private String AV5USUCOD ;
      private String AV6USUDES ;
      private String AV13SISTEMA ;
      private String AV14USUARIO ;
      private String wcpOAV5USUCOD ;
      private String wcpOAV6USUDES ;
      private String wcpOAV13SISTEMA ;
      private String wcpOAV14USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String A259SIS_DES ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String scmdbuf ;
      private String edtavUsucod_Internalname ;
      private String edtavUsudes_Internalname ;
      private String subGrid1_Internalname ;
      private String bttBtn_alta_Internalname ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String sStyleString ;
      private String tblTable2_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavUsucod_Jsonclick ;
      private String edtavUsudes_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String tblTable1_Internalname ;
      private String bttBtn_alta_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String ROClassString ;
      private String edtSIS_COD_Jsonclick ;
      private String edtSIS_DES_Jsonclick ;
      private String edtUSU_COD_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
      private String GXt_char5 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private String aP1_USUDES ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] H004Z2_A7USU_DES ;
      private String[] H004Z2_A6USU_COD ;
      private String[] H004Z2_A259SIS_DES ;
      private short[] H004Z2_A116SIS_COD ;
      private int[] H004Z3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hseg103__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH004Z2 ;
          prmH004Z2 = new Object[] {
          new Object[] {"@AV5USUCOD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH004Z3 ;
          prmH004Z3 = new Object[] {
          new Object[] {"@AV5USUCOD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004Z2", "SELECT T2.[USU_DES], T1.[USU_COD], T3.[SIS_DES], T1.[SIS_COD] FROM (([SEG003] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = T1.[SIS_COD]) WHERE T1.[USU_COD] = @AV5USUCOD ORDER BY T1.[USU_COD], T1.[SIS_COD]  OPTION (FAST 10)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004Z2,10,0,true,false )
             ,new CursorDef("H004Z3", "SELECT COUNT(*) FROM (([SEG003] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = T1.[SIS_COD]) WHERE T1.[USU_COD] = @AV5USUCOD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004Z3,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
