/*
               File: HSEG100
        Description: Actualización de Sistemas
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:29.79
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
   public class hseg100 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg100( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg100( IGxContext context )
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

      public void execute( ref String aP0_SISTEMA ,
                           ref String aP1_USUARIO )
      {
         this.AV8SISTEMA = aP0_SISTEMA;
         this.AV7USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV8SISTEMA;
         aP1_USUARIO=this.AV7USUARIO;
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
               nGXsfl_22_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_22_idx = GetNextPar( ) ;
               edtavDelete_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
               AV14Delete = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV14Delete));
               edtavUpdate_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
               AV13Update = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV13Update));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_22_idx, sGXsfl_22_idx, AV14Delete, AV13Update) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize22 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV15SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15SIS_COD), 3, 0)));
               AV5SISDES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISDES", AV5SISDES);
               edtavDelete_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
               AV14Delete = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV14Delete));
               edtavUpdate_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
               AV13Update = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV13Update));
               A123SIS_ICO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123SIS_ICO", A123SIS_ICO);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize22, AV15SIS_COD, AV5SISDES, AV14Delete, AV13Update, A123SIS_ICO) ;
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
               AV8SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV7USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUARIO", AV7USUARIO);
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
         PA4T2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4T2( ) ;
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg100.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vSISDES", StringUtil.RTrim( AV5SISDES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV8SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV7USUARIO));
         GxWebStd.gx_hidden_field( context, "SIS_ICO", StringUtil.RTrim( A123SIS_ICO));
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
            WE4T2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4T2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG100" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actualización de Sistemas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg100.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) ;
      }

      protected void WB4T0( )
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
            context.WriteHtmlText( "<pre>") ;
            wb_table1_3_4T2( true) ;
         }
         else
         {
            wb_table1_3_4T2( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_4T2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<center/>") ;
            context.WriteHtmlText( "</pre>") ;
         }
         wbLoad = true ;
      }

      protected void START4T2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Actualización de Sistemas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4T0( ) ;
      }

      protected void WS4T2( )
      {
         START4T2( ) ;
         EVT4T2( ) ;
      }

      protected void EVT4T2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vSIS_COD"), ",", ".") != Convert.ToDecimal( AV15SIS_COD )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vSISDES"), AV5SISDES) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
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
                           else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E114T2 */
                              E114T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PROGRAMAS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E124T2 */
                              E124T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'MODIFICA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "'PROGRAMAS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'MODIFICA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) )
                           {
                              nGXsfl_22_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
                              edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
                              edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_22_idx ;
                              edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
                              edtavIcono_Internalname = "vICONO_"+sGXsfl_22_idx ;
                              AV13Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV13Update));
                              AV14Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV14Delete));
                              A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                              A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
                              AV16ICONO = cgiGet( "GXimg"+edtavIcono_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavIcono_Internalname, "Bitmap", context.convertURL( AV16ICONO));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E134T2 */
                                    E134T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E114T2 */
                                    E114T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E144T2 */
                                    E144T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MODIFICA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E154T2 */
                                    E154T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'PROGRAMAS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E124T2 */
                                    E124T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E164T2 */
                                    E164T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Sis_cod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vSIS_COD"), ",", ".") != Convert.ToDecimal( AV15SIS_COD )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Sisdes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vSISDES"), AV5SISDES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
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

      protected void WE4T2( )
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

      protected void PA4T2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavSis_cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_22_idx ,
                                       String sGXsfl_22_idx ,
                                       String AV14Delete ,
                                       String AV13Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_22_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
         edtavIcono_Internalname = "vICONO_"+sGXsfl_22_idx ;
         while ( nGXsfl_22_idx <= nRC_Grid1 )
         {
            sendrow_222( ) ;
            nGXsfl_22_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_22_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_22_idx+1)) ;
            sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            edtavIcono_Internalname = "vICONO_"+sGXsfl_22_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize22 ,
                                        short AV15SIS_COD ,
                                        String AV5SISDES ,
                                        String AV14Delete ,
                                        String AV13Update ,
                                        String A123SIS_ICO )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize22) ;
         RF4T2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF4T2( ) ;
         /* End function Refresh */
      }

      protected void RF4T2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 22 ;
         nGXsfl_22_idx = 1 ;
         sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_22_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
         edtavIcono_Internalname = "vICONO_"+sGXsfl_22_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            edtavIcono_Internalname = "vICONO_"+sGXsfl_22_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV15SIS_COD ,
                                                 A116SIS_COD ,
                                                 A259SIS_DES ,
                                                 AV5SISDES },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING
                                                 }
            });
            lV5SISDES = StringUtil.PadR( StringUtil.RTrim( AV5SISDES), 15, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISDES", AV5SISDES);
            /* Using cursor H004T2 */
            pr_default.execute(0, new Object[] {lV5SISDES, AV15SIS_COD});
            nGXsfl_22_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 5 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A123SIS_ICO = H004T2_A123SIS_ICO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123SIS_ICO", A123SIS_ICO);
               A259SIS_DES = H004T2_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A116SIS_COD = H004T2_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               /* Execute user event: E164T2 */
               E164T2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 22 ;
            WB4T0( ) ;
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV15SIS_COD ,
                                              A116SIS_COD ,
                                              A259SIS_DES ,
                                              AV5SISDES },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING
                                              }
         });
         lV5SISDES = StringUtil.PadR( StringUtil.RTrim( AV5SISDES), 15, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISDES", AV5SISDES);
         /* Using cursor H004T3 */
         pr_default.execute(1, new Object[] {lV5SISDES, AV15SIS_COD});
         GRID1_nRecordCount = H004T3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 5 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(5*1) ;
            }
            else
            {
               return (int)(5) ;
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

      protected void STRUP4T0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E134T2 */
         E134T2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavSis_cod_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavSis_cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavSis_cod_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSIS_COD");
               GX_FocusControl = edtavSis_cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV15SIS_COD = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15SIS_COD), 3, 0)));
            }
            else
            {
               AV15SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtavSis_cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15SIS_COD), 3, 0)));
            }
            AV5SISDES = StringUtil.Upper( cgiGet( edtavSisdes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISDES", AV5SISDES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV8SISTEMA = cgiGet( "vSISTEMA") ;
            AV7USUARIO = cgiGet( "vUSUARIO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            nGXsfl_22_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            edtavIcono_Internalname = "vICONO_"+sGXsfl_22_idx ;
            if ( nGXsfl_22_idx > 0 )
            {
               AV13Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
               AV14Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
               A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               AV16ICONO = cgiGet( "GXimg"+edtavIcono_Internalname) ;
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
         /* Execute user event: E134T2 */
         E134T2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E134T2( )
      {
         /* Start Routine */
         AV13Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV13Update));
         edtavUpdate_Tooltiptext = "Modifica" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
         AV14Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV14Delete));
         edtavDelete_Tooltiptext = "Eliminar" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV7USUARIO)) )
         {
            AV7USUARIO = context.GetCookie( "USUARIO") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUARIO", AV7USUARIO);
         }
         else
         {
            AV11A = context.SetCookie( "USUARIO", AV7USUARIO, "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         AV12Habilitado = 1 ;
      }

      protected void E114T2( )
      {
         /* 'Alta' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) ;
         context.wjLoc = formatLink("tseg000.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E144T2( )
      {
         /* 'Baja' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A116SIS_COD) ;
         context.wjLoc = formatLink("tseg000.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E154T2( )
      {
         /* 'Modifica' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A116SIS_COD) ;
         context.wjLoc = formatLink("tseg000.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E124T2( )
      {
         /* 'Programas' Routine */
         context.wjLoc = formatLink("hseg101.aspx") + "?" + UrlEncode("" +A116SIS_COD) + "," + UrlEncode(StringUtil.RTrim(A259SIS_DES)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) ;
      }

      private void E164T2( )
      {
         /* Load Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A123SIS_ICO)) )
         {
            AV17LINK = "IMAGENES/BLANK.JPG" ;
         }
         else
         {
            AV17LINK = "Fisheye/images/" + A123SIS_ICO ;
         }
         AV16ICONO = AV17LINK ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavIcono_Internalname, "Bitmap", context.convertURL( AV16ICONO));
         if ( ( subGrid1_Islastpage == 1 ) || ( 5 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_222( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_3_4T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"4\" >") ;
            context.WriteHtmlText( "&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;") ;
            wb_table2_6_4T2( true) ;
         }
         else
         {
            wb_table2_6_4T2( false) ;
         }
         return  ;
      }

      protected void wb_table2_6_4T2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "PagingButtons" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, "E\\'ALTA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HSEG100.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Sistema") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "ICONO") ;
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
               Grid1Container.AddObjectProperty("Titlefont", StringUtil.RTrim( subGrid1_Titlefont));
               Grid1Container.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid1_Linesfont));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV13Update));
               Grid1Column.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV14Delete));
               Grid1Column.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A259SIS_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV16ICONO));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 22 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_22_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
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
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"4\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table3_30_4T2( true) ;
         }
         else
         {
            wb_table3_30_4T2( false) ;
         }
         return  ;
      }

      protected void wb_table3_30_4T2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_4T2e( true) ;
         }
         else
         {
            wb_table1_3_4T2e( false) ;
         }
      }

      protected void wb_table3_30_4T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton4_Internalname, "Programas", "Programas", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton4_Jsonclick, "E\\'PROGRAMAS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(22), 3, 0)+","+"null"+");", "", "HLP_HSEG100.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttButton3_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(22), 3, 0)+","+"null"+");", "", "HLP_HSEG100.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_30_4T2e( true) ;
         }
         else
         {
            wb_table3_30_4T2e( false) ;
         }
      }

      protected void wb_table2_6_4T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp;") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Código:", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HSEG100.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'" + sGXsfl_22_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavSis_cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV15SIS_COD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(10);\"", 0, edtavSis_cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HSEG100.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Descripción:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HSEG100.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'" + sGXsfl_22_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavSisdes_Internalname, StringUtil.RTrim( AV5SISDES), "", 15, "chr", 1, "row", 15, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV5SISDES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(15);\"", 0, edtavSisdes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG100.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBuscar_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 7, bttBuscar_Jsonclick, "'"+""+"'"+",false,"+"'"+"e174t2_client"+"'", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(22), 3, 0)+","+"null"+");", "", "HLP_HSEG100.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_6_4T2e( true) ;
         }
         else
         {
            wb_table2_6_4T2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
         AV7USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUARIO", AV7USUARIO);
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
         PA4T2( ) ;
         WS4T2( ) ;
         WE4T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11183026");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg100.js", "?11183026");
         /* End function include_jscripts */
      }

      protected void sendrow_222( )
      {
         WB4T0( ) ;
         if ( ( 5 * 1 == 0 ) || ( nGXsfl_22_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_22_idx) % (2)) == 0 )
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 23,'',false,'',22)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV13Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavUpdate_Jsonclick,"E\\'MODIFICA\\'."+sGXsfl_22_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 24,'',false,'',22)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV14Delete,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavDelete_Jsonclick,"E\\'BAJA\\'."+sGXsfl_22_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")),(String)"",(short)83,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"),(String)"",(short)0,(String)edtSIS_COD_Jsonclick,(String)"",(short)22,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_DES_Internalname,StringUtil.RTrim( A259SIS_DES),(String)"",(short)371,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")),(String)"",(short)0,(String)edtSIS_DES_Jsonclick,(String)"",(short)22,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavIcono_Internalname,(String)"",(String)AV16ICONO,(String)"Modern",(short)-1,(short)0,(String)"",(String)"",(short)0,(short)1,(short)0,(String)"px",(short)40,(String)"",(short)0,(short)0,(String)"",(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_22_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_22_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_22_idx+1)) ;
            sGXsfl_22_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_22_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_22_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_22_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_22_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_22_idx ;
            edtavIcono_Internalname = "vICONO_"+sGXsfl_22_idx ;
         }
         /* End function sendrow_222 */
      }

      protected void init_default_properties( )
      {
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavSis_cod_Internalname = "vSIS_COD" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavSisdes_Internalname = "vSISDES" ;
         bttBuscar_Internalname = "BUSCAR" ;
         tblTable3_Internalname = "TABLE3" ;
         imgInsert_Internalname = "INSERT" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton3_Internalname = "BUTTON3" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_COD_Jsonclick = "" ;
         edtavDelete_Jsonclick = "" ;
         edtavDelete_Visible = -1 ;
         edtavDelete_Enabled = 1 ;
         edtavUpdate_Jsonclick = "" ;
         edtavUpdate_Visible = -1 ;
         edtavUpdate_Enabled = 1 ;
         edtavSisdes_Jsonclick = "" ;
         edtavSis_cod_Jsonclick = "" ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Linesfont = "font-family:Courier New;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Arial;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "WorkWith" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Actualización de Sistemas" ;
         edtavUpdate_Tooltiptext = "" ;
         edtavDelete_Tooltiptext = "" ;
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
         wcpOAV8SISTEMA = "" ;
         wcpOAV7USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         edtavDelete_Internalname = "" ;
         AV14Delete = "" ;
         edtavUpdate_Internalname = "" ;
         AV13Update = "" ;
         AV5SISDES = "" ;
         A123SIS_ICO = "" ;
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
         edtavIcono_Internalname = "" ;
         A259SIS_DES = "" ;
         AV16ICONO = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV5SISDES = "" ;
         H004T2_A123SIS_ICO = new String[] {""} ;
         H004T2_A259SIS_DES = new String[] {""} ;
         H004T2_A116SIS_COD = new short[1] ;
         H004T3_AGRID1_nRecordCount = new int[1] ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         AV17LINK = "" ;
         sStyleString = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         imgInsert_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char4 = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         bttBuscar_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char5 = "" ;
         ROClassString = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg100__default(),
            new Object[][] {
                new Object[] {
               H004T2_A123SIS_ICO, H004T2_A259SIS_DES, H004T2_A116SIS_COD
               }
               , new Object[] {
               H004T3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_22_idx=1 ;
      private short AV15SIS_COD ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A116SIS_COD ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV11A ;
      private short AV12Habilitado ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize22 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Enabled ;
      private int edtavDelete_Visible ;
      private String AV8SISTEMA ;
      private String AV7USUARIO ;
      private String wcpOAV8SISTEMA ;
      private String wcpOAV7USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_22_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String AV5SISDES ;
      private String A123SIS_ICO ;
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
      private String edtavIcono_Internalname ;
      private String A259SIS_DES ;
      private String edtavSis_cod_Internalname ;
      private String scmdbuf ;
      private String lV5SISDES ;
      private String edtavSisdes_Internalname ;
      private String subGrid1_Internalname ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String AV17LINK ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String GXt_char4 ;
      private String tblTable4_Internalname ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavSis_cod_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavSisdes_Jsonclick ;
      private String bttBuscar_Internalname ;
      private String bttBuscar_Jsonclick ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String GXt_char5 ;
      private String ROClassString ;
      private String edtSIS_COD_Jsonclick ;
      private String edtSIS_DES_Jsonclick ;
      private String GXt_char6 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV14Delete ;
      private String AV13Update ;
      private String AV16ICONO ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] H004T2_A123SIS_ICO ;
      private String[] H004T2_A259SIS_DES ;
      private short[] H004T2_A116SIS_COD ;
      private int[] H004T3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hseg100__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H004T2( short AV15SIS_COD ,
                                             short A116SIS_COD ,
                                             String A259SIS_DES ,
                                             String AV5SISDES )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int7 ;
         GXv_int7 = new short [2] ;
         Object[] GXv_Object8 ;
         GXv_Object8 = new Object [2] ;
         scmdbuf = "SELECT [SIS_ICO], [SIS_DES], [SIS_COD] FROM [SEG000] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([SIS_DES] like '%' + @AV5SISDES)" ;
         if ( ! (0==AV15SIS_COD) )
         {
            sWhereString = sWhereString + " and ([SIS_COD] = @AV15SIS_COD)" ;
         }
         else
         {
            GXv_int7[1] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [SIS_DES]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 6)" ;
         GXv_Object8[0] = scmdbuf ;
         GXv_Object8[1] = (Object)(GXv_int7) ;
         return GXv_Object8 ;
      }

      protected Object[] conditional_H004T3( short AV15SIS_COD ,
                                             short A116SIS_COD ,
                                             String A259SIS_DES ,
                                             String AV5SISDES )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int9 ;
         GXv_int9 = new short [2] ;
         Object[] GXv_Object10 ;
         GXv_Object10 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [SEG000] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([SIS_DES] like '%' + @AV5SISDES)" ;
         if ( ! (0==AV15SIS_COD) )
         {
            sWhereString = sWhereString + " and ([SIS_COD] = @AV15SIS_COD)" ;
         }
         else
         {
            GXv_int9[1] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + "" ;
         GXv_Object10[0] = scmdbuf ;
         GXv_Object10[1] = (Object)(GXv_int9) ;
         return GXv_Object10 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H004T2( (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] );
               case 1 :
                     return conditional_H004T3( (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmH004T2 ;
          prmH004T2 = new Object[] {
          new Object[] {"@AV5SISDES",SqlDbType.Char,15,0} ,
          new Object[] {"@AV15SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH004T3 ;
          prmH004T3 = new Object[] {
          new Object[] {"@AV5SISDES",SqlDbType.Char,15,0} ,
          new Object[] {"@AV15SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004T2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004T2,6,1,true,false )
             ,new CursorDef("H004T3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004T3,1,1,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[3]);
                }
                break;
             case 1 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[3]);
                }
                break;
       }
    }

 }

}
