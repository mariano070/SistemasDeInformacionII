/*
               File: HTBUS007
        Description: AdministraciÛn Responsables y Posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:40.50
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
   public class htbus007 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus007( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus007( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_SISTEMA ,
                           ref String aP1_USUARIO )
      {
         this.AV11SISTEMA = aP0_SISTEMA;
         this.AV15USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV11SISTEMA;
         aP1_USUARIO=this.AV15USUARIO;
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
               nGXsfl_38_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_38_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_38_idx, sGXsfl_38_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize38 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV17fTTBUS7_DesResp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17fTTBUS7_DesResp", AV17fTTBUS7_DesResp);
               AV23fTTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23fTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23fTTBUS7_Pos), 3, 0)));
               AV21fTTBUS7_Des = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21fTTBUS7_Des", AV21fTTBUS7_Des);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize38, AV17fTTBUS7_DesResp, AV23fTTBUS7_Pos, AV21fTTBUS7_Des) ;
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
               AV11SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SISTEMA", AV11SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV15USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15USUARIO", AV15USUARIO);
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA1L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1L2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus007.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV15USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vFTTBUS7_DESRESP", StringUtil.RTrim( AV17fTTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "GXH_vFTTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23fTTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vFTTBUS7_DES", StringUtil.RTrim( AV21fTTBUS7_Des));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV11SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV15USUARIO));
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
            WE1L2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1L2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS007" ;
      }

      public override String GetPgmdesc( )
      {
         return "AdministraciÛn Responsables y Posiciones" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus007.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV15USUARIO)) ;
      }

      protected void WB1L0( )
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
            wb_table1_2_1L2( true) ;
         }
         else
         {
            wb_table1_2_1L2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1L2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1L2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "AdministraciÛn Responsables y Posiciones", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1L0( ) ;
      }

      protected void WS1L2( )
      {
         START1L2( ) ;
         EVT1L2( ) ;
      }

      protected void EVT1L2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DESRESP"), AV17fTTBUS7_DesResp) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vFTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV23fTTBUS7_Pos )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DES"), AV21fTTBUS7_Des) != 0 )
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
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 /* Set Refresh If Fttbus7_desresp Changed */
                                 if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DESRESP"), AV17fTTBUS7_DesResp) != 0 )
                                 {
                                    Rfr0gs = true ;
                                 }
                                 /* Set Refresh If Fttbus7_pos Changed */
                                 if ( ( context.localUtil.CToN( cgiGet( "GXH_vFTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV23fTTBUS7_Pos )) )
                                 {
                                    Rfr0gs = true ;
                                 }
                                 /* Set Refresh If Fttbus7_des Changed */
                                 if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DES"), AV21fTTBUS7_Des) != 0 )
                                 {
                                    Rfr0gs = true ;
                                 }
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E111L2 */
                                    E111L2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121L2 */
                              E121L2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ATR·S'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131L2 */
                              E131L2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'ATR·S'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) )
                           {
                              nGXsfl_38_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
                              edtavBaja_Internalname = "vBAJA_"+sGXsfl_38_idx ;
                              edtavEdicion_Internalname = "vEDICION_"+sGXsfl_38_idx ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_38_idx ;
                              edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_38_idx ;
                              edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_38_idx ;
                              edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP_"+sGXsfl_38_idx ;
                              edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP_"+sGXsfl_38_idx ;
                              AV5baja = cgiGet( "GXimg"+edtavBaja_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
                              AV6edicion = cgiGet( "GXimg"+edtavEdicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV6edicion));
                              AV16visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV16visualizacion));
                              A33TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                              A34TTBUS7_Des = cgiGet( edtTTBUS7_Des_Internalname) ;
                              n34TTBUS7_Des = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                              A35TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtTTBUS7_CodResp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                              A36TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtTTBUS7_DesResp_Internalname)) ;
                              n36TTBUS7_DesResp = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141L2 */
                                    E141L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E151L2 */
                                    E151L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121L2 */
                                    E121L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E161L2 */
                                    E161L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'EDICION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E171L2 */
                                    E171L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E181L2 */
                                    E181L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ATR·S'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131L2 */
                                    E131L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Fttbus7_desresp Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DESRESP"), AV17fTTBUS7_DesResp) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Fttbus7_pos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vFTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV23fTTBUS7_Pos )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Fttbus7_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DES"), AV21fTTBUS7_Des) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E111L2 */
                                          E111L2 ();
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

      protected void WE1L2( )
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

      protected void PA1L2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavFttbus3_codresp_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_38_idx ,
                                       String sGXsfl_38_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_38_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_38_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_38_idx ;
         edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_38_idx ;
         edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_38_idx ;
         edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP_"+sGXsfl_38_idx ;
         edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP_"+sGXsfl_38_idx ;
         while ( nGXsfl_38_idx <= nRC_Grid1 )
         {
            sendrow_382( ) ;
            nGXsfl_38_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_38_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1)) ;
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_38_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_38_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_38_idx ;
            edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_38_idx ;
            edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_38_idx ;
            edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP_"+sGXsfl_38_idx ;
            edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP_"+sGXsfl_38_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize38 ,
                                        String AV17fTTBUS7_DesResp ,
                                        short AV23fTTBUS7_Pos ,
                                        String AV21fTTBUS7_Des )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize38) ;
         RF1L2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1L2( ) ;
         /* End function Refresh */
      }

      protected void RF1L2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 38 ;
         nGXsfl_38_idx = 1 ;
         sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_38_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_38_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_38_idx ;
         edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_38_idx ;
         edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_38_idx ;
         edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP_"+sGXsfl_38_idx ;
         edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP_"+sGXsfl_38_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_38_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_38_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_38_idx ;
            edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_38_idx ;
            edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_38_idx ;
            edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP_"+sGXsfl_38_idx ;
            edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP_"+sGXsfl_38_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV21fTTBUS7_Des ,
                                                 AV22fTTBUS7_CodResp ,
                                                 AV17fTTBUS7_DesResp ,
                                                 A34TTBUS7_Des ,
                                                 AV18TTBUS7_Des ,
                                                 A35TTBUS7_CodResp ,
                                                 AV19TTBUS7_CodResp ,
                                                 A36TTBUS7_DesResp ,
                                                 AV20TTBUS7_DesResp ,
                                                 A33TTBUS7_Pos ,
                                                 AV23fTTBUS7_Pos },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            });
            lV18TTBUS7_Des = StringUtil.PadR( StringUtil.RTrim( AV18TTBUS7_Des), 50, "%") ;
            lV19TTBUS7_CodResp = StringUtil.PadR( StringUtil.RTrim( AV19TTBUS7_CodResp), 16, "%") ;
            lV20TTBUS7_DesResp = StringUtil.PadR( StringUtil.RTrim( AV20TTBUS7_DesResp), 50, "%") ;
            /* Using cursor H001L2 */
            pr_default.execute(0, new Object[] {AV23fTTBUS7_Pos, lV18TTBUS7_Des, lV19TTBUS7_CodResp, lV20TTBUS7_DesResp});
            nGXsfl_38_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A36TTBUS7_DesResp = H001L2_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001L2_n36TTBUS7_DesResp[0] ;
               A35TTBUS7_CodResp = H001L2_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A34TTBUS7_Des = H001L2_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001L2_n34TTBUS7_Des[0] ;
               A33TTBUS7_Pos = H001L2_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A36TTBUS7_DesResp = H001L2_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001L2_n36TTBUS7_DesResp[0] ;
               A34TTBUS7_Des = H001L2_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001L2_n34TTBUS7_Des[0] ;
               /* Execute user event: E151L2 */
               E151L2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 38 ;
            WB1L0( ) ;
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
                                              AV21fTTBUS7_Des ,
                                              AV22fTTBUS7_CodResp ,
                                              AV17fTTBUS7_DesResp ,
                                              A34TTBUS7_Des ,
                                              AV18TTBUS7_Des ,
                                              A35TTBUS7_CodResp ,
                                              AV19TTBUS7_CodResp ,
                                              A36TTBUS7_DesResp ,
                                              AV20TTBUS7_DesResp ,
                                              A33TTBUS7_Pos ,
                                              AV23fTTBUS7_Pos },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         });
         lV18TTBUS7_Des = StringUtil.PadR( StringUtil.RTrim( AV18TTBUS7_Des), 50, "%") ;
         lV19TTBUS7_CodResp = StringUtil.PadR( StringUtil.RTrim( AV19TTBUS7_CodResp), 16, "%") ;
         lV20TTBUS7_DesResp = StringUtil.PadR( StringUtil.RTrim( AV20TTBUS7_DesResp), 50, "%") ;
         /* Using cursor H001L3 */
         pr_default.execute(1, new Object[] {AV23fTTBUS7_Pos, lV18TTBUS7_Des, lV19TTBUS7_CodResp, lV20TTBUS7_DesResp});
         GRID1_nRecordCount = H001L3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
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

      protected void STRUP1L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E141L2 */
         E141L2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV7fTTBUS3_CodResp = StringUtil.Upper( cgiGet( edtavFttbus3_codresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7fTTBUS3_CodResp", AV7fTTBUS3_CodResp);
            AV17fTTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavFttbus7_desresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17fTTBUS7_DesResp", AV17fTTBUS7_DesResp);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavFttbus7_pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavFttbus7_pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavFttbus7_pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vFTTBUS7_POS");
               GX_FocusControl = edtavFttbus7_pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV23fTTBUS7_Pos = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23fTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23fTTBUS7_Pos), 3, 0)));
            }
            else
            {
               AV23fTTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( edtavFttbus7_pos_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23fTTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23fTTBUS7_Pos), 3, 0)));
            }
            AV21fTTBUS7_Des = cgiGet( edtavFttbus7_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21fTTBUS7_Des", AV21fTTBUS7_Des);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV11SISTEMA = cgiGet( "vSISTEMA") ;
            AV15USUARIO = cgiGet( "vUSUARIO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
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
         /* Execute user event: E141L2 */
         E141L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E141L2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV25Context) ;
         AV15USUARIO = AV25Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15USUARIO", AV15USUARIO);
         new pseg102(context ).execute( ref  AV15USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15USUARIO", AV15USUARIO);
      }

      private void E151L2( )
      {
         /* Grid1_Load Routine */
         AV5baja = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
         AV6edicion = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV6edicion));
         AV16visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV16visualizacion));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 38 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_382( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E121L2( )
      {
         /* 'Alta' Routine */
         context.wjLoc = formatLink("ttbus007.aspx") + "?" + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV15USUARIO)) ;
      }

      protected void E161L2( )
      {
         /* 'Baja' Routine */
         context.wjLoc = formatLink("ttbus007.aspx") + "?" + UrlEncode("" +A33TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV15USUARIO)) ;
      }

      protected void E171L2( )
      {
         /* 'Edicion' Routine */
         context.wjLoc = formatLink("ttbus007.aspx") + "?" + UrlEncode("" +A33TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV15USUARIO)) ;
      }

      protected void E181L2( )
      {
         /* 'Visualizacion' Routine */
         context.wjLoc = formatLink("ttbus007.aspx") + "?" + UrlEncode("" +A33TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV15USUARIO)) ;
      }

      protected void E131L2( )
      {
         /* 'Atr·s' Routine */
         context.wjLoc = formatLink("htbus000_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV15USUARIO)) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E111L2 */
         E111L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111L2( )
      {
         /* Enter Routine */
         AV18TTBUS7_Des = "%" + StringUtil.Trim( StringUtil.Upper( AV21fTTBUS7_Des)) + "%" ;
         AV19TTBUS7_CodResp = "%" + StringUtil.Trim( StringUtil.Upper( AV22fTTBUS7_CodResp)) + "%" ;
         AV20TTBUS7_DesResp = "%" + StringUtil.Trim( StringUtil.Upper( AV17fTTBUS7_DesResp)) + "%" ;
      }

      protected void wb_table1_2_1L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(70), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(792), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_1L2( true) ;
         }
         else
         {
            wb_table2_8_1L2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_1L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Alta", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgImage1_Jsonclick, "E\\'ALTA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nro. Pos.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Desc. PosiciÛn") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CÛd. Responsable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Desc. Responsable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5baja));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV6edicion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV16visualizacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A34TTBUS7_Des));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A35TTBUS7_CodResp));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A36TTBUS7_DesResp));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 38 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_38_idx-1) ;
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
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Atr·s", "Atr·s", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'ATR·S\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 3, 0)+","+"null"+");", "", "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1L2e( true) ;
         }
         else
         {
            wb_table1_2_1L2e( false) ;
         }
      }

      protected void wb_table2_8_1L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockubi_tip_Internalname, 1, 1, 0, "C”D. RESPONSABLE:", "", "", "", 0, lblTextblockubi_tip_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_38_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus3_codresp_Internalname, StringUtil.RTrim( AV7fTTBUS3_CodResp), "", 15, "chr", 1, "row", 15, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7fTTBUS3_CodResp, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtavFttbus3_codresp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockubi_tip2_Internalname, 1, 1, 0, "DESC. RESPONSABLE:", "", "", "", 0, lblTextblockubi_tip2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'" + sGXsfl_38_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus7_desresp_Internalname, StringUtil.RTrim( AV17fTTBUS7_DesResp), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV17fTTBUS7_DesResp, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(18);\"", 0, edtavFttbus7_desresp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockubi_cod_Internalname, 1, 1, 0, "C”D. POSICI”N:", "", "", "", 0, lblTextblockubi_cod_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_38_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus7_pos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23fTTBUS7_Pos), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV23fTTBUS7_Pos), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(23);\"", 0, edtavFttbus7_pos_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockubi_des_Internalname, 1, 1, 0, "DESC. POSICI”N:", "", "", "", 0, lblTextblockubi_des_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_38_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus7_des_Internalname, StringUtil.RTrim( AV21fTTBUS7_Des), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV21fTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(28);\"", 0, edtavFttbus7_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "EENTER.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 3, 0)+","+"null"+");", "", "HLP_HTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_1L2e( true) ;
         }
         else
         {
            wb_table2_8_1L2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SISTEMA", AV11SISTEMA);
         AV15USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15USUARIO", AV15USUARIO);
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
         PA1L2( ) ;
         WS1L2( ) ;
         WE1L2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13224090");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus007.js", "?13224090");
         /* End function include_jscripts */
      }

      protected void sendrow_382( )
      {
         WB1L0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_38_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_38_idx) % (2)) == 0 )
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
            TempTags = " " + ((edtavBaja_Enabled!=0)&&(edtavBaja_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 39,'',false,'',38)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavBaja_Internalname,(String)"",(String)AV5baja,(String)"Modern",(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavBaja_Jsonclick,"E\\'BAJA\\'."+sGXsfl_38_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavEdicion_Enabled!=0)&&(edtavEdicion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 40,'',false,'',38)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavEdicion_Internalname,(String)"",(String)AV6edicion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavEdicion_Jsonclick,"E\\'EDICION\\'."+sGXsfl_38_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavVisualizacion_Enabled!=0)&&(edtavVisualizacion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 41,'',false,'',38)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV16visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACION\\'."+sGXsfl_38_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_Pos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A33TTBUS7_Pos), "ZZ9"),(String)"",(short)0,(String)edtTTBUS7_Pos_Jsonclick,(String)"",(short)38,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_Des_Internalname,StringUtil.RTrim( A34TTBUS7_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A34TTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS7_Des_Jsonclick,(String)"",(short)38,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_CodResp_Internalname,StringUtil.RTrim( A35TTBUS7_CodResp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A35TTBUS7_CodResp, "@!")),(String)"",(short)0,(String)edtTTBUS7_CodResp_Jsonclick,(String)"",(short)38,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_DesResp_Internalname,StringUtil.RTrim( A36TTBUS7_DesResp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A36TTBUS7_DesResp, "@!")),(String)"",(short)0,(String)edtTTBUS7_DesResp_Jsonclick,(String)"",(short)38,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_38_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_38_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1)) ;
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_38_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_38_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_38_idx ;
            edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_38_idx ;
            edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_38_idx ;
            edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP_"+sGXsfl_38_idx ;
            edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP_"+sGXsfl_38_idx ;
         }
         /* End function sendrow_382 */
      }

      protected void init_default_properties( )
      {
         lblTextblockubi_tip_Internalname = "TEXTBLOCKUBI_TIP" ;
         edtavFttbus3_codresp_Internalname = "vFTTBUS3_CODRESP" ;
         lblTextblockubi_tip2_Internalname = "TEXTBLOCKUBI_TIP2" ;
         edtavFttbus7_desresp_Internalname = "vFTTBUS7_DESRESP" ;
         lblTextblockubi_cod_Internalname = "TEXTBLOCKUBI_COD" ;
         edtavFttbus7_pos_Internalname = "vFTTBUS7_POS" ;
         lblTextblockubi_des_Internalname = "TEXTBLOCKUBI_DES" ;
         edtavFttbus7_des_Internalname = "vFTTBUS7_DES" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable2_Internalname = "TABLE2" ;
         imgImage1_Internalname = "IMAGE1" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS7_DesResp_Jsonclick = "" ;
         edtTTBUS7_CodResp_Jsonclick = "" ;
         edtTTBUS7_Des_Jsonclick = "" ;
         edtTTBUS7_Pos_Jsonclick = "" ;
         edtavVisualizacion_Jsonclick = "" ;
         edtavVisualizacion_Visible = -1 ;
         edtavVisualizacion_Enabled = 1 ;
         edtavEdicion_Jsonclick = "" ;
         edtavEdicion_Visible = -1 ;
         edtavEdicion_Enabled = 1 ;
         edtavBaja_Jsonclick = "" ;
         edtavBaja_Visible = -1 ;
         edtavBaja_Enabled = 1 ;
         edtavFttbus7_des_Jsonclick = "" ;
         edtavFttbus7_pos_Jsonclick = "" ;
         edtavFttbus7_desresp_Jsonclick = "" ;
         edtavFttbus3_codresp_Jsonclick = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "AdministraciÛn Responsables y Posiciones" ;
         context.GX_msglist.DisplayMode = 1 ;
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
         wcpOAV11SISTEMA = "" ;
         wcpOAV15USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV17fTTBUS7_DesResp = "" ;
         AV21fTTBUS7_Des = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavBaja_Internalname = "" ;
         edtavEdicion_Internalname = "" ;
         edtavVisualizacion_Internalname = "" ;
         edtTTBUS7_Pos_Internalname = "" ;
         edtTTBUS7_Des_Internalname = "" ;
         edtTTBUS7_CodResp_Internalname = "" ;
         edtTTBUS7_DesResp_Internalname = "" ;
         AV5baja = "" ;
         AV6edicion = "" ;
         AV16visualizacion = "" ;
         A34TTBUS7_Des = "" ;
         A35TTBUS7_CodResp = "" ;
         A36TTBUS7_DesResp = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         AV22fTTBUS7_CodResp = "" ;
         AV18TTBUS7_Des = "" ;
         AV19TTBUS7_CodResp = "" ;
         AV20TTBUS7_DesResp = "" ;
         lV18TTBUS7_Des = "" ;
         lV19TTBUS7_CodResp = "" ;
         lV20TTBUS7_DesResp = "" ;
         H001L2_A36TTBUS7_DesResp = new String[] {""} ;
         H001L2_n36TTBUS7_DesResp = new bool[] {false} ;
         H001L2_A35TTBUS7_CodResp = new String[] {""} ;
         H001L2_A34TTBUS7_Des = new String[] {""} ;
         H001L2_n34TTBUS7_Des = new bool[] {false} ;
         H001L2_A33TTBUS7_Pos = new short[1] ;
         H001L3_AGRID1_nRecordCount = new int[1] ;
         AV7fTTBUS3_CodResp = "" ;
         AV25Context = new SdtContext(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         imgImage1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         Grid1Column = new GXWebColumn();
         bttButton1_Jsonclick = "" ;
         lblTextblockubi_tip_Jsonclick = "" ;
         lblTextblockubi_tip2_Jsonclick = "" ;
         lblTextblockubi_cod_Jsonclick = "" ;
         lblTextblockubi_des_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus007__default(),
            new Object[][] {
                new Object[] {
               H001L2_A36TTBUS7_DesResp, H001L2_n36TTBUS7_DesResp, H001L2_A35TTBUS7_CodResp, H001L2_A34TTBUS7_Des, H001L2_n34TTBUS7_Des, H001L2_A33TTBUS7_Pos
               }
               , new Object[] {
               H001L3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_38_idx=1 ;
      private short AV23fTTBUS7_Pos ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A33TTBUS7_Pos ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize38 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavBaja_Enabled ;
      private int edtavBaja_Visible ;
      private int edtavEdicion_Enabled ;
      private int edtavEdicion_Visible ;
      private int edtavVisualizacion_Enabled ;
      private int edtavVisualizacion_Visible ;
      private String AV11SISTEMA ;
      private String AV15USUARIO ;
      private String wcpOAV11SISTEMA ;
      private String wcpOAV15USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_38_idx="0001" ;
      private String AV17fTTBUS7_DesResp ;
      private String AV21fTTBUS7_Des ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavBaja_Internalname ;
      private String edtavEdicion_Internalname ;
      private String edtavVisualizacion_Internalname ;
      private String edtTTBUS7_Pos_Internalname ;
      private String edtTTBUS7_Des_Internalname ;
      private String edtTTBUS7_CodResp_Internalname ;
      private String edtTTBUS7_DesResp_Internalname ;
      private String A34TTBUS7_Des ;
      private String A35TTBUS7_CodResp ;
      private String A36TTBUS7_DesResp ;
      private String edtavFttbus3_codresp_Internalname ;
      private String scmdbuf ;
      private String AV22fTTBUS7_CodResp ;
      private String AV18TTBUS7_Des ;
      private String AV19TTBUS7_CodResp ;
      private String AV20TTBUS7_DesResp ;
      private String lV18TTBUS7_Des ;
      private String lV19TTBUS7_CodResp ;
      private String lV20TTBUS7_DesResp ;
      private String AV7fTTBUS3_CodResp ;
      private String edtavFttbus7_desresp_Internalname ;
      private String edtavFttbus7_pos_Internalname ;
      private String edtavFttbus7_des_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String TempTags ;
      private String imgImage1_Internalname ;
      private String imgImage1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockubi_tip_Internalname ;
      private String lblTextblockubi_tip_Jsonclick ;
      private String edtavFttbus3_codresp_Jsonclick ;
      private String lblTextblockubi_tip2_Internalname ;
      private String lblTextblockubi_tip2_Jsonclick ;
      private String edtavFttbus7_desresp_Jsonclick ;
      private String lblTextblockubi_cod_Internalname ;
      private String lblTextblockubi_cod_Jsonclick ;
      private String edtavFttbus7_pos_Jsonclick ;
      private String lblTextblockubi_des_Internalname ;
      private String lblTextblockubi_des_Jsonclick ;
      private String edtavFttbus7_des_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String edtavBaja_Jsonclick ;
      private String edtavEdicion_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtTTBUS7_Pos_Jsonclick ;
      private String edtTTBUS7_Des_Jsonclick ;
      private String edtTTBUS7_CodResp_Jsonclick ;
      private String edtTTBUS7_DesResp_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n34TTBUS7_Des ;
      private bool n36TTBUS7_DesResp ;
      private bool returnInSub ;
      private String AV5baja ;
      private String AV6edicion ;
      private String AV16visualizacion ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] H001L2_A36TTBUS7_DesResp ;
      private bool[] H001L2_n36TTBUS7_DesResp ;
      private String[] H001L2_A35TTBUS7_CodResp ;
      private String[] H001L2_A34TTBUS7_Des ;
      private bool[] H001L2_n34TTBUS7_Des ;
      private short[] H001L2_A33TTBUS7_Pos ;
      private int[] H001L3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtContext AV25Context ;
   }

   public class htbus007__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001L2( String AV21fTTBUS7_Des ,
                                             String AV22fTTBUS7_CodResp ,
                                             String AV17fTTBUS7_DesResp ,
                                             String A34TTBUS7_Des ,
                                             String AV18TTBUS7_Des ,
                                             String A35TTBUS7_CodResp ,
                                             String AV19TTBUS7_CodResp ,
                                             String A36TTBUS7_DesResp ,
                                             String AV20TTBUS7_DesResp ,
                                             short A33TTBUS7_Pos ,
                                             short AV23fTTBUS7_Pos )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int9 ;
         GXv_int9 = new short [4] ;
         Object[] GXv_Object10 ;
         GXv_Object10 = new Object [2] ;
         scmdbuf = "SELECT T2.[USU_DES] AS TTBUS7_DesResp, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T3.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM (([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T3 WITH (NOLOCK) ON T3.[W53POS] = T1.[TTBUS7_Pos])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS7_Pos] >= @AV23fTTBUS7_Pos)" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS7_Pos] <> 998)" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS7_Pos] <> 999)" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV21fTTBUS7_Des), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T3.[W53DES]) like @AV18TTBUS7_Des)" ;
         }
         else
         {
            GXv_int9[1] = 1 ;
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV22fTTBUS7_CodResp), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T1.[TTBUS7_CodResp]) like @AV19TTBUS7_CodResp)" ;
         }
         else
         {
            GXv_int9[2] = 1 ;
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV17fTTBUS7_DesResp), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T2.[USU_DES]) like @AV20TTBUS7_DesResp)" ;
         }
         else
         {
            GXv_int9[3] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS7_Pos]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object10[0] = scmdbuf ;
         GXv_Object10[1] = (Object)(GXv_int9) ;
         return GXv_Object10 ;
      }

      protected Object[] conditional_H001L3( String AV21fTTBUS7_Des ,
                                             String AV22fTTBUS7_CodResp ,
                                             String AV17fTTBUS7_DesResp ,
                                             String A34TTBUS7_Des ,
                                             String AV18TTBUS7_Des ,
                                             String A35TTBUS7_CodResp ,
                                             String AV19TTBUS7_CodResp ,
                                             String A36TTBUS7_DesResp ,
                                             String AV20TTBUS7_DesResp ,
                                             short A33TTBUS7_Pos ,
                                             short AV23fTTBUS7_Pos )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int11 ;
         GXv_int11 = new short [4] ;
         Object[] GXv_Object12 ;
         GXv_Object12 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T1.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS7_Pos] >= @AV23fTTBUS7_Pos)" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS7_Pos] <> 998)" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS7_Pos] <> 999)" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV21fTTBUS7_Des), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T2.[W53DES]) like @AV18TTBUS7_Des)" ;
         }
         else
         {
            GXv_int11[1] = 1 ;
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV22fTTBUS7_CodResp), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T1.[TTBUS7_CodResp]) like @AV19TTBUS7_CodResp)" ;
         }
         else
         {
            GXv_int11[2] = 1 ;
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV17fTTBUS7_DesResp), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T3.[USU_DES]) like @AV20TTBUS7_DesResp)" ;
         }
         else
         {
            GXv_int11[3] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + "" ;
         GXv_Object12[0] = scmdbuf ;
         GXv_Object12[1] = (Object)(GXv_int11) ;
         return GXv_Object12 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H001L2( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H001L3( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
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
          Object[] prmH001L2 ;
          prmH001L2 = new Object[] {
          new Object[] {"@AV23fTTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV18TTBUS7_Des",SqlDbType.Char,50,0} ,
          new Object[] {"@AV19TTBUS7_CodResp",SqlDbType.Char,16,0} ,
          new Object[] {"@AV20TTBUS7_DesResp",SqlDbType.Char,50,0}
          } ;
          Object[] prmH001L3 ;
          prmH001L3 = new Object[] {
          new Object[] {"@AV23fTTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV18TTBUS7_Des",SqlDbType.Char,50,0} ,
          new Object[] {"@AV19TTBUS7_CodResp",SqlDbType.Char,16,0} ,
          new Object[] {"@AV20TTBUS7_DesResp",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001L2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001L2,11,0,true,false )
             ,new CursorDef("H001L3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001L3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
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
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                break;
             case 1 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                break;
       }
    }

 }

}
