/*
               File: HBUS002
        Description: ABM de Rubros
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:35.68
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
   public class hbus002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hbus002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hbus002( IGxContext context )
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
         this.AV12USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV11SISTEMA;
         aP1_USUARIO=this.AV12USUARIO;
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
               nGXsfl_25_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_25_idx = GetNextPar( ) ;
               edtavEdicion_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
               edtavBaja_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_25_idx, sGXsfl_25_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize25 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cRBR_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cRBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cRBR_COD), 4, 0)));
               AV7cRBR_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cRBR_DES", AV7cRBR_DES);
               edtavEdicion_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
               edtavBaja_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize25, AV6cRBR_COD, AV7cRBR_DES) ;
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
                  AV12USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12USUARIO", AV12USUARIO);
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
         PA5A2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5A2( ) ;
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
         FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hbus002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV12USUARIO))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCRBR_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cRBR_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCRBR_DES", StringUtil.RTrim( AV7cRBR_DES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV11SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV12USUARIO));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE5A2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5A2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HBUS002" ;
      }

      public override String GetPgmdesc( )
      {
         return "ABM de Rubros" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hbus002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV12USUARIO)) ;
      }

      protected void WB5A0( )
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
            wb_table1_2_5A2( true) ;
         }
         else
         {
            wb_table1_2_5A2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_5A2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START5A2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ABM de Rubros", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP5A0( ) ;
      }

      protected void WS5A2( )
      {
         START5A2( ) ;
         EVT5A2( ) ;
      }

      protected void EVT5A2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRBR_COD"), ",", ".") != Convert.ToDecimal( AV6cRBR_COD )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCRBR_DES"), AV7cRBR_DES) != 0 )
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
                              /* Execute user event: E115A2 */
                              E115A2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICIÛN'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACIÛN'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICIÛN'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACIÛN'") == 0 ) )
                           {
                              nGXsfl_25_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0") ;
                              edtavBaja_Internalname = "vBAJA_"+sGXsfl_25_idx ;
                              edtavEdicion_Internalname = "vEDICION_"+sGXsfl_25_idx ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_25_idx ;
                              edtRBR_COD_Internalname = "RBR_COD_"+sGXsfl_25_idx ;
                              edtRBR_DES_Internalname = "RBR_DES_"+sGXsfl_25_idx ;
                              AV13baja = cgiGet( "GXimg"+edtavBaja_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV13baja));
                              AV14edicion = cgiGet( "GXimg"+edtavEdicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV14edicion));
                              AV15visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV15visualizacion));
                              A2RBR_COD = (short)(context.localUtil.CToN( cgiGet( edtRBR_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
                              A19RBR_DES = cgiGet( edtRBR_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19RBR_DES", A19RBR_DES);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E125A2 */
                                    E125A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E135A2 */
                                    E135A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E115A2 */
                                    E115A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E145A2 */
                                    E145A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'EDICIÛN'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E155A2 */
                                    E155A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACIÛN'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E165A2 */
                                    E165A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Crbr_cod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRBR_COD"), ",", ".") != Convert.ToDecimal( AV6cRBR_COD )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Crbr_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCRBR_DES"), AV7cRBR_DES) != 0 )
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

      protected void WE5A2( )
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

      protected void PA5A2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCrbr_cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_25_idx ,
                                       String sGXsfl_25_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_25_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_25_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_25_idx ;
         edtRBR_COD_Internalname = "RBR_COD_"+sGXsfl_25_idx ;
         edtRBR_DES_Internalname = "RBR_DES_"+sGXsfl_25_idx ;
         while ( nGXsfl_25_idx <= nRC_Grid1 )
         {
            sendrow_252( ) ;
            nGXsfl_25_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_25_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_25_idx+1)) ;
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_25_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_25_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_25_idx ;
            edtRBR_COD_Internalname = "RBR_COD_"+sGXsfl_25_idx ;
            edtRBR_DES_Internalname = "RBR_DES_"+sGXsfl_25_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize25 ,
                                        short AV6cRBR_COD ,
                                        String AV7cRBR_DES )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize25) ;
         RF5A2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF5A2( ) ;
         /* End function Refresh */
      }

      protected void RF5A2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 25 ;
         nGXsfl_25_idx = 1 ;
         sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0") ;
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_25_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_25_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_25_idx ;
         edtRBR_COD_Internalname = "RBR_COD_"+sGXsfl_25_idx ;
         edtRBR_DES_Internalname = "RBR_DES_"+sGXsfl_25_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_25_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_25_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_25_idx ;
            edtRBR_COD_Internalname = "RBR_COD_"+sGXsfl_25_idx ;
            edtRBR_DES_Internalname = "RBR_DES_"+sGXsfl_25_idx ;
            lV7cRBR_DES = StringUtil.PadR( StringUtil.RTrim( AV7cRBR_DES), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cRBR_DES", AV7cRBR_DES);
            /* Using cursor H005A2 */
            pr_default.execute(0, new Object[] {AV6cRBR_COD, lV7cRBR_DES});
            nGXsfl_25_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A19RBR_DES = H005A2_A19RBR_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19RBR_DES", A19RBR_DES);
               A2RBR_COD = H005A2_A2RBR_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
               /* Execute user event: E135A2 */
               E135A2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 25 ;
            WB5A0( ) ;
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
         lV7cRBR_DES = StringUtil.PadR( StringUtil.RTrim( AV7cRBR_DES), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cRBR_DES", AV7cRBR_DES);
         /* Using cursor H005A3 */
         pr_default.execute(1, new Object[] {AV6cRBR_COD, lV7cRBR_DES});
         GRID1_nRecordCount = H005A3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP5A0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E125A2 */
         E125A2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCrbr_cod_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCrbr_cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCrbr_cod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCRBR_COD");
               GX_FocusControl = edtavCrbr_cod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cRBR_COD = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cRBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cRBR_COD), 4, 0)));
            }
            else
            {
               AV6cRBR_COD = (short)(context.localUtil.CToN( cgiGet( edtavCrbr_cod_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cRBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cRBR_COD), 4, 0)));
            }
            AV7cRBR_DES = cgiGet( edtavCrbr_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cRBR_DES", AV7cRBR_DES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV11SISTEMA = cgiGet( "vSISTEMA") ;
            AV12USUARIO = cgiGet( "vUSUARIO") ;
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
         /* Execute user event: E125A2 */
         E125A2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E125A2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV16Context) ;
         AV12USUARIO = AV16Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12USUARIO", AV12USUARIO);
         AV17usu_permiso = 1 ;
         if ( StringUtil.StrCmp(AV12USUARIO, "SUPERVISOR") == 0 )
         {
            AV17usu_permiso = 0 ;
         }
         if ( AV17usu_permiso == 1 )
         {
            /* Using cursor H005A4 */
            pr_default.execute(2, new Object[] {AV12USUARIO});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A40TTBUS8_CodUsuario = H005A4_A40TTBUS8_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               AV17usu_permiso = 0 ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
         }
         if ( AV17usu_permiso == 1 )
         {
            imgImg_alta_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgImg_alta_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgImg_alta_Visible), 5, 0)));
            edtavBaja_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
            edtavEdicion_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
         }
         else
         {
            imgImg_alta_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgImg_alta_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgImg_alta_Visible), 5, 0)));
            edtavBaja_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
            edtavEdicion_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
         }
      }

      private void E135A2( )
      {
         /* Grid1_Load Routine */
         AV13baja = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV13baja));
         AV14edicion = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV14edicion));
         AV15visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV15visualizacion));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 25 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_252( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E115A2( )
      {
         /* 'Alta' Routine */
         context.wjLoc = formatLink("tbus002.aspx") + "?" + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV12USUARIO)) ;
      }

      protected void E145A2( )
      {
         /* 'Baja' Routine */
         context.wjLoc = formatLink("tbus002.aspx") + "?" + UrlEncode("" +A2RBR_COD) + "," + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV12USUARIO)) ;
      }

      protected void E155A2( )
      {
         /* 'EdiciÛn' Routine */
         context.wjLoc = formatLink("tbus002.aspx") + "?" + UrlEncode("" +A2RBR_COD) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV12USUARIO)) ;
      }

      protected void E165A2( )
      {
         /* 'VisualizaciÛn' Routine */
         context.wjLoc = formatLink("tbus002.aspx") + "?" + UrlEncode("" +A2RBR_COD) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV12USUARIO)) ;
      }

      protected void wb_table1_2_5A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
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
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filtros"+"</legend>") ;
            wb_table2_9_5A2( true) ;
         }
         else
         {
            wb_table2_9_5A2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_5A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImg_alta_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", imgImg_alta_Visible, 1, "", "Alta", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgImg_alta_Jsonclick, "E\\'ALTA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HBUS002.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((edtavBaja_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((edtavEdicion_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO DE RUBRO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION DEL RUBRO") ;
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
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV13baja));
               Grid1Column.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBaja_Visible), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV14edicion));
               Grid1Column.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEdicion_Visible), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV15visualizacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2RBR_COD), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A19RBR_DES));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtRBR_DES_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 25 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_25_idx-1) ;
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
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_5A2e( true) ;
         }
         else
         {
            wb_table1_2_5A2e( false) ;
         }
      }

      protected void wb_table2_9_5A2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockrbr_cod_Internalname, 1, 1, 0, "CODIGO DE RUBRO", "", "", "", 0, lblTextblockrbr_cod_Jsonclick, "", StyleString, ClassString, "HLP_HBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_25_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCrbr_cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cRBR_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cRBR_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCrbr_cod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbr_des_Internalname, 1, 1, 0, "DESCRIPCION DEL RUBRO", "", "", "", 0, lblTextblockrbr_des_Jsonclick, "", StyleString, ClassString, "HLP_HBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_25_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCrbr_des_Internalname, StringUtil.RTrim( AV7cRBR_DES), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7cRBR_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", 0, edtavCrbr_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_5A2e( true) ;
         }
         else
         {
            wb_table2_9_5A2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SISTEMA", AV11SISTEMA);
         AV12USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12USUARIO", AV12USUARIO);
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
         PA5A2( ) ;
         WS5A2( ) ;
         WE5A2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13223599");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("hbus002.js", "?13223599");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_252( )
      {
         WB5A0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_25_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_25_idx) % (2)) == 0 )
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBaja_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavBaja_Enabled!=0)&&(edtavBaja_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'',false,'',25)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavBaja_Internalname,(String)"",(String)AV13baja,(String)"Modern",(int)edtavBaja_Visible,(short)1,(String)"",(String)"Baja",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavBaja_Jsonclick,"E\\'BAJA\\'."+sGXsfl_25_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavEdicion_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavEdicion_Enabled!=0)&&(edtavEdicion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 27,'',false,'',25)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavEdicion_Internalname,(String)"",(String)AV14edicion,(String)"Modern",(int)edtavEdicion_Visible,(short)1,(String)"",(String)"EdiciÛn",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavEdicion_Jsonclick,"E\\'EDICIÛN\\'."+sGXsfl_25_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavVisualizacion_Enabled!=0)&&(edtavVisualizacion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 28,'',false,'',25)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV15visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"VisualizaciÛn",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACIÛN\\'."+sGXsfl_25_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtRBR_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2RBR_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A2RBR_COD), "ZZZ9"),(String)"",(short)0,(String)edtRBR_COD_Jsonclick,(String)"",(short)25,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtRBR_DES_Link = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBR_DES_Internalname, "Link", edtRBR_DES_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtRBR_DES_Internalname,StringUtil.RTrim( A19RBR_DES),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtRBR_DES_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A19RBR_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtRBR_DES_Jsonclick,(String)"",(short)25,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_25_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_25_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_25_idx+1)) ;
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_25_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_25_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_25_idx ;
            edtRBR_COD_Internalname = "RBR_COD_"+sGXsfl_25_idx ;
            edtRBR_DES_Internalname = "RBR_DES_"+sGXsfl_25_idx ;
         }
         /* End function sendrow_252 */
      }

      protected void init_default_properties( )
      {
         lblTextblockrbr_cod_Internalname = "TEXTBLOCKRBR_COD" ;
         edtavCrbr_cod_Internalname = "vCRBR_COD" ;
         lblTextblockrbr_des_Internalname = "TEXTBLOCKRBR_DES" ;
         edtavCrbr_des_Internalname = "vCRBR_DES" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         imgImg_alta_Internalname = "IMG_ALTA" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtRBR_DES_Jsonclick = "" ;
         edtRBR_COD_Jsonclick = "" ;
         edtavVisualizacion_Jsonclick = "" ;
         edtavVisualizacion_Visible = -1 ;
         edtavVisualizacion_Enabled = 1 ;
         edtavEdicion_Jsonclick = "" ;
         edtavEdicion_Enabled = 1 ;
         edtavBaja_Jsonclick = "" ;
         edtavBaja_Enabled = 1 ;
         edtavCrbr_des_Jsonclick = "" ;
         edtavCrbr_cod_Jsonclick = "" ;
         edtRBR_DES_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         imgImg_alta_Visible = 1 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ABM de Rubros" ;
         edtavBaja_Visible = -1 ;
         edtavEdicion_Visible = -1 ;
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
         wcpOAV12USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         edtavEdicion_Internalname = "" ;
         edtavBaja_Internalname = "" ;
         AV7cRBR_DES = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavVisualizacion_Internalname = "" ;
         edtRBR_COD_Internalname = "" ;
         edtRBR_DES_Internalname = "" ;
         AV13baja = "" ;
         AV14edicion = "" ;
         AV15visualizacion = "" ;
         A19RBR_DES = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7cRBR_DES = "" ;
         H005A2_A19RBR_DES = new String[] {""} ;
         H005A2_A2RBR_COD = new short[1] ;
         H005A3_AGRID1_nRecordCount = new int[1] ;
         AV16Context = new SdtContext(context);
         H005A4_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         imgImg_alta_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         lblTextblockrbr_cod_Jsonclick = "" ;
         lblTextblockrbr_des_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char5 = "" ;
         ROClassString = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hbus002__default(),
            new Object[][] {
                new Object[] {
               H005A2_A19RBR_DES, H005A2_A2RBR_COD
               }
               , new Object[] {
               H005A3_AGRID1_nRecordCount
               }
               , new Object[] {
               H005A4_A40TTBUS8_CodUsuario
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_25_idx=1 ;
      private short AV6cRBR_COD ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A2RBR_COD ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV17usu_permiso ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int edtavEdicion_Visible ;
      private int edtavBaja_Visible ;
      private int Grid1_PageSize25 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int imgImg_alta_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavBaja_Enabled ;
      private int edtavEdicion_Enabled ;
      private int edtavVisualizacion_Enabled ;
      private int edtavVisualizacion_Visible ;
      private String AV11SISTEMA ;
      private String AV12USUARIO ;
      private String wcpOAV11SISTEMA ;
      private String wcpOAV12USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_25_idx="0001" ;
      private String edtavEdicion_Internalname ;
      private String edtavBaja_Internalname ;
      private String AV7cRBR_DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavVisualizacion_Internalname ;
      private String edtRBR_COD_Internalname ;
      private String edtRBR_DES_Internalname ;
      private String A19RBR_DES ;
      private String edtavCrbr_cod_Internalname ;
      private String scmdbuf ;
      private String lV7cRBR_DES ;
      private String edtavCrbr_des_Internalname ;
      private String A40TTBUS8_CodUsuario ;
      private String imgImg_alta_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String TempTags ;
      private String imgImg_alta_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String edtRBR_DES_Link ;
      private String tblTable2_Internalname ;
      private String lblTextblockrbr_cod_Internalname ;
      private String lblTextblockrbr_cod_Jsonclick ;
      private String edtavCrbr_cod_Jsonclick ;
      private String lblTextblockrbr_des_Internalname ;
      private String lblTextblockrbr_des_Jsonclick ;
      private String edtavCrbr_des_Jsonclick ;
      private String edtavBaja_Jsonclick ;
      private String edtavEdicion_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String GXt_char5 ;
      private String ROClassString ;
      private String edtRBR_COD_Jsonclick ;
      private String edtRBR_DES_Jsonclick ;
      private String GXt_char6 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV13baja ;
      private String AV14edicion ;
      private String AV15visualizacion ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] H005A2_A19RBR_DES ;
      private short[] H005A2_A2RBR_COD ;
      private int[] H005A3_AGRID1_nRecordCount ;
      private String[] H005A4_A40TTBUS8_CodUsuario ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtContext AV16Context ;
   }

   public class hbus002__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005A2 ;
          prmH005A2 = new Object[] {
          new Object[] {"@AV6cRBR_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cRBR_DES",SqlDbType.Char,30,0}
          } ;
          Object[] prmH005A3 ;
          prmH005A3 = new Object[] {
          new Object[] {"@AV6cRBR_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cRBR_DES",SqlDbType.Char,30,0}
          } ;
          Object[] prmH005A4 ;
          prmH005A4 = new Object[] {
          new Object[] {"@AV12USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005A2", "SELECT [RBR_DES], [RBR_COD] FROM [BUS002] WITH (NOLOCK) WHERE ([RBR_COD] >= @AV6cRBR_COD) AND ([RBR_DES] like @AV7cRBR_DES) ORDER BY [RBR_COD]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005A2,11,0,true,false )
             ,new CursorDef("H005A3", "SELECT COUNT(*) FROM [BUS002] WITH (NOLOCK) WHERE ([RBR_COD] >= @AV6cRBR_COD) AND ([RBR_DES] like @AV7cRBR_DES) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005A3,1,0,true,false )
             ,new CursorDef("H005A4", "SELECT TOP 1 [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV12USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005A4,1,0,false,true )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
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
                stmt.SetParameter(2, (String)parms[1]);
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
