/*
               File: Gx00D0
        Description: Selection List Mensajes de Administrador de Cambio de Posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:59.40
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
   public class gx00d0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00d0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00d0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pTTBUS20_IdBien )
      {
         this.AV12pTTBUS20_IdBien = 0 ;
         executePrivate();
         aP0_pTTBUS20_IdBien=this.AV12pTTBUS20_IdBien;
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
               nGXsfl_46_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_46_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_46_idx, sGXsfl_46_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize46 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cTTBUS20_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS20_IdBien), 8, 0)));
               AV7cTTBUS20_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS20_Descripcion", AV7cTTBUS20_Descripcion);
               AV8cTTBUS20_MotivoEnvio = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS20_MotivoEnvio", AV8cTTBUS20_MotivoEnvio);
               AV9cTTBUS20_Estacion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS20_Estacion", AV9cTTBUS20_Estacion);
               AV10cTTBUS20_Usuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS20_Usuario", AV10cTTBUS20_Usuario);
               AV11cTTBUS20_PlazoRecepcion = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS20_PlazoRecepcion", context.localUtil.Format(AV11cTTBUS20_PlazoRecepcion, "99/99/9999"));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize46, AV6cTTBUS20_IdBien, AV7cTTBUS20_Descripcion, AV8cTTBUS20_MotivoEnvio, AV9cTTBUS20_Estacion, AV10cTTBUS20_Usuario, AV11cTTBUS20_PlazoRecepcion) ;
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
               AV12pTTBUS20_IdBien = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTTBUS20_IdBien), 8, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA2Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2Y2( ) ;
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
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00d0.aspx") + "?" + UrlEncode("" +AV12pTTBUS20_IdBien)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS20_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS20_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS20_DESCRIPCION", StringUtil.RTrim( AV7cTTBUS20_Descripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS20_MOTIVOENVIO", StringUtil.RTrim( AV8cTTBUS20_MotivoEnvio));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS20_ESTACION", StringUtil.RTrim( AV9cTTBUS20_Estacion));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS20_USUARIO", StringUtil.RTrim( AV10cTTBUS20_Usuario));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS20_PLAZORECEPCION", context.localUtil.Format(AV11cTTBUS20_PlazoRecepcion, "99/99/9999"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS20_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pTTBUS20_IdBien), 8, 0, ",", "")));
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
            WE2Y2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2Y2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00D0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Mensajes de Administrador de Cambio de Posiciones" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00d0.aspx") + "?" + UrlEncode("" +AV12pTTBUS20_IdBien) ;
      }

      protected void WB2Y0( )
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
            wb_table1_2_2Y2( true) ;
         }
         else
         {
            wb_table1_2_2Y2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2Y2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2Y2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List Mensajes de Administrador de Cambio de Posiciones", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2Y0( ) ;
      }

      protected void WS2Y2( )
      {
         START2Y2( ) ;
         EVT2Y2( ) ;
      }

      protected void EVT2Y2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS20_IDBIEN"), ",", ".") != Convert.ToDecimal( AV6cTTBUS20_IdBien )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_DESCRIPCION"), AV7cTTBUS20_Descripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_MOTIVOENVIO"), AV8cTTBUS20_MotivoEnvio) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_ESTACION"), AV9cTTBUS20_Estacion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_USUARIO"), AV10cTTBUS20_Usuario) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCTTBUS20_PLAZORECEPCION"), 4) != AV11cTTBUS20_PlazoRecepcion )
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_46_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
                              edtTTBUS20_IdBien_Internalname = "TTBUS20_IDBIEN_"+sGXsfl_46_idx ;
                              edtTTBUS20_Descripcion_Internalname = "TTBUS20_DESCRIPCION_"+sGXsfl_46_idx ;
                              edtTTBUS20_Estacion_Internalname = "TTBUS20_ESTACION_"+sGXsfl_46_idx ;
                              edtTTBUS20_Usuario_Internalname = "TTBUS20_USUARIO_"+sGXsfl_46_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A223TTBUS20_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS20_IdBien_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
                              A224TTBUS20_Descripcion = cgiGet( edtTTBUS20_Descripcion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TTBUS20_Descripcion", A224TTBUS20_Descripcion);
                              A219TTBUS20_Estacion = cgiGet( edtTTBUS20_Estacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TTBUS20_Estacion", A219TTBUS20_Estacion);
                              A225TTBUS20_Usuario = cgiGet( edtTTBUS20_Usuario_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225TTBUS20_Usuario", A225TTBUS20_Usuario);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112Y2 */
                                    E112Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122Y2 */
                                    E122Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cttbus20_idbien Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS20_IDBIEN"), ",", ".") != Convert.ToDecimal( AV6cTTBUS20_IdBien )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus20_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_DESCRIPCION"), AV7cTTBUS20_Descripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus20_motivoenvio Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_MOTIVOENVIO"), AV8cTTBUS20_MotivoEnvio) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus20_estacion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_ESTACION"), AV9cTTBUS20_Estacion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus20_usuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS20_USUARIO"), AV10cTTBUS20_Usuario) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus20_plazorecepcion Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCTTBUS20_PLAZORECEPCION"), 4) != AV11cTTBUS20_PlazoRecepcion )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132Y2 */
                                          E132Y2 ();
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

      protected void WE2Y2( )
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

      protected void PA2Y2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCttbus20_idbien_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_46_idx ,
                                       String sGXsfl_46_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtTTBUS20_IdBien_Internalname = "TTBUS20_IDBIEN_"+sGXsfl_46_idx ;
         edtTTBUS20_Descripcion_Internalname = "TTBUS20_DESCRIPCION_"+sGXsfl_46_idx ;
         edtTTBUS20_Estacion_Internalname = "TTBUS20_ESTACION_"+sGXsfl_46_idx ;
         edtTTBUS20_Usuario_Internalname = "TTBUS20_USUARIO_"+sGXsfl_46_idx ;
         while ( nGXsfl_46_idx <= nRC_Grid1 )
         {
            sendrow_462( ) ;
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtTTBUS20_IdBien_Internalname = "TTBUS20_IDBIEN_"+sGXsfl_46_idx ;
            edtTTBUS20_Descripcion_Internalname = "TTBUS20_DESCRIPCION_"+sGXsfl_46_idx ;
            edtTTBUS20_Estacion_Internalname = "TTBUS20_ESTACION_"+sGXsfl_46_idx ;
            edtTTBUS20_Usuario_Internalname = "TTBUS20_USUARIO_"+sGXsfl_46_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize46 ,
                                        int AV6cTTBUS20_IdBien ,
                                        String AV7cTTBUS20_Descripcion ,
                                        String AV8cTTBUS20_MotivoEnvio ,
                                        String AV9cTTBUS20_Estacion ,
                                        String AV10cTTBUS20_Usuario ,
                                        DateTime AV11cTTBUS20_PlazoRecepcion )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize46) ;
         RF2Y2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2Y2( ) ;
         /* End function Refresh */
      }

      protected void RF2Y2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 46 ;
         nGXsfl_46_idx = 1 ;
         sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtTTBUS20_IdBien_Internalname = "TTBUS20_IDBIEN_"+sGXsfl_46_idx ;
         edtTTBUS20_Descripcion_Internalname = "TTBUS20_DESCRIPCION_"+sGXsfl_46_idx ;
         edtTTBUS20_Estacion_Internalname = "TTBUS20_ESTACION_"+sGXsfl_46_idx ;
         edtTTBUS20_Usuario_Internalname = "TTBUS20_USUARIO_"+sGXsfl_46_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtTTBUS20_IdBien_Internalname = "TTBUS20_IDBIEN_"+sGXsfl_46_idx ;
            edtTTBUS20_Descripcion_Internalname = "TTBUS20_DESCRIPCION_"+sGXsfl_46_idx ;
            edtTTBUS20_Estacion_Internalname = "TTBUS20_ESTACION_"+sGXsfl_46_idx ;
            edtTTBUS20_Usuario_Internalname = "TTBUS20_USUARIO_"+sGXsfl_46_idx ;
            lV7cTTBUS20_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV7cTTBUS20_Descripcion), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS20_Descripcion", AV7cTTBUS20_Descripcion);
            lV8cTTBUS20_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( AV8cTTBUS20_MotivoEnvio), 100, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS20_MotivoEnvio", AV8cTTBUS20_MotivoEnvio);
            lV9cTTBUS20_Estacion = StringUtil.PadR( StringUtil.RTrim( AV9cTTBUS20_Estacion), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS20_Estacion", AV9cTTBUS20_Estacion);
            lV10cTTBUS20_Usuario = StringUtil.PadR( StringUtil.RTrim( AV10cTTBUS20_Usuario), 16, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS20_Usuario", AV10cTTBUS20_Usuario);
            /* Using cursor H002Y2 */
            pr_default.execute(0, new Object[] {AV6cTTBUS20_IdBien, lV7cTTBUS20_Descripcion, lV8cTTBUS20_MotivoEnvio, lV9cTTBUS20_Estacion, lV10cTTBUS20_Usuario, AV11cTTBUS20_PlazoRecepcion});
            nGXsfl_46_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A220TTBUS20_MotivoEnvio = H002Y2_A220TTBUS20_MotivoEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TTBUS20_MotivoEnvio", A220TTBUS20_MotivoEnvio);
               A222TTBUS20_PlazoRecepcion = H002Y2_A222TTBUS20_PlazoRecepcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TTBUS20_PlazoRecepcion", context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999"));
               n222TTBUS20_PlazoRecepcion = H002Y2_n222TTBUS20_PlazoRecepcion[0] ;
               A225TTBUS20_Usuario = H002Y2_A225TTBUS20_Usuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225TTBUS20_Usuario", A225TTBUS20_Usuario);
               A219TTBUS20_Estacion = H002Y2_A219TTBUS20_Estacion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TTBUS20_Estacion", A219TTBUS20_Estacion);
               A224TTBUS20_Descripcion = H002Y2_A224TTBUS20_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TTBUS20_Descripcion", A224TTBUS20_Descripcion);
               A223TTBUS20_IdBien = H002Y2_A223TTBUS20_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
               /* Execute user event: E122Y2 */
               E122Y2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 46 ;
            WB2Y0( ) ;
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
         lV7cTTBUS20_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV7cTTBUS20_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS20_Descripcion", AV7cTTBUS20_Descripcion);
         lV8cTTBUS20_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( AV8cTTBUS20_MotivoEnvio), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS20_MotivoEnvio", AV8cTTBUS20_MotivoEnvio);
         lV9cTTBUS20_Estacion = StringUtil.PadR( StringUtil.RTrim( AV9cTTBUS20_Estacion), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS20_Estacion", AV9cTTBUS20_Estacion);
         lV10cTTBUS20_Usuario = StringUtil.PadR( StringUtil.RTrim( AV10cTTBUS20_Usuario), 16, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS20_Usuario", AV10cTTBUS20_Usuario);
         /* Using cursor H002Y3 */
         pr_default.execute(1, new Object[] {AV6cTTBUS20_IdBien, lV7cTTBUS20_Descripcion, lV8cTTBUS20_MotivoEnvio, lV9cTTBUS20_Estacion, lV10cTTBUS20_Usuario, AV11cTTBUS20_PlazoRecepcion});
         GRID1_nRecordCount = H002Y3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112Y2 */
         E112Y2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus20_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus20_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus20_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS20_IDBIEN");
               GX_FocusControl = edtavCttbus20_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cTTBUS20_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS20_IdBien), 8, 0)));
            }
            else
            {
               AV6cTTBUS20_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavCttbus20_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS20_IdBien), 8, 0)));
            }
            AV7cTTBUS20_Descripcion = cgiGet( edtavCttbus20_descripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS20_Descripcion", AV7cTTBUS20_Descripcion);
            AV8cTTBUS20_MotivoEnvio = cgiGet( edtavCttbus20_motivoenvio_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS20_MotivoEnvio", AV8cTTBUS20_MotivoEnvio);
            AV9cTTBUS20_Estacion = cgiGet( edtavCttbus20_estacion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS20_Estacion", AV9cTTBUS20_Estacion);
            AV10cTTBUS20_Usuario = cgiGet( edtavCttbus20_usuario_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS20_Usuario", AV10cTTBUS20_Usuario);
            if ( context.localUtil.VCDate( cgiGet( edtavCttbus20_plazorecepcion_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Plazo límite recepción de un bien"}), 1, "vCTTBUS20_PLAZORECEPCION");
               GX_FocusControl = edtavCttbus20_plazorecepcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV11cTTBUS20_PlazoRecepcion = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS20_PlazoRecepcion", context.localUtil.Format(AV11cTTBUS20_PlazoRecepcion, "99/99/9999"));
            }
            else
            {
               AV11cTTBUS20_PlazoRecepcion = context.localUtil.CToD( cgiGet( edtavCttbus20_plazorecepcion_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS20_PlazoRecepcion", context.localUtil.Format(AV11cTTBUS20_PlazoRecepcion, "99/99/9999"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV12pTTBUS20_IdBien = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS20_IDBIEN"), ",", ".")) ;
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
         /* Execute user event: E112Y2 */
         E112Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112Y2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Mensajes de Administrador de Cambio de Posiciones", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122Y2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_462( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E132Y2 */
         E132Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132Y2( )
      {
         /* Enter Routine */
         AV12pTTBUS20_IdBien = A223TTBUS20_IdBien ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTTBUS20_IdBien), 8, 0)));
         context.setWebReturnParms(new Object[] {(int)AV12pTTBUS20_IdBien});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2Y2( bool wbgen )
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
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_2Y2( true) ;
         }
         else
         {
            wb_table2_9_2Y2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_43_2Y2( true) ;
         }
         else
         {
            wb_table3_43_2Y2( false) ;
         }
         return  ;
      }

      protected void wb_table3_43_2Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2Y2e( true) ;
         }
         else
         {
            wb_table1_2_2Y2e( false) ;
         }
      }

      protected void wb_table3_43_2Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de trabajo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario") ;
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
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TTBUS20_IdBien), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A224TTBUS20_Descripcion));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTTBUS20_Descripcion_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A219TTBUS20_Estacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A225TTBUS20_Usuario));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 46 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_46_idx-1) ;
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_54_2Y2( true) ;
         }
         else
         {
            wb_table4_54_2Y2( false) ;
         }
         return  ;
      }

      protected void wb_table4_54_2Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_43_2Y2e( true) ;
         }
         else
         {
            wb_table3_43_2Y2e( false) ;
         }
      }

      protected void wb_table4_54_2Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(46), 3, 0)+","+"null"+");", "", "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_54_2Y2e( true) ;
         }
         else
         {
            wb_table4_54_2Y2e( false) ;
         }
      }

      protected void wb_table2_9_2Y2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_idbien_Internalname, 1, 1, 0, "Nº de bien de uso", "", "", "", 0, lblTextblockttbus20_idbien_Jsonclick, "", StyleString, ClassString, "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus20_idbien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS20_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cTTBUS20_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCttbus20_idbien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_descripcion_Internalname, 1, 1, 0, "Descripción de bien de uso", "", "", "", 0, lblTextblockttbus20_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus20_descripcion_Internalname, StringUtil.RTrim( AV7cTTBUS20_Descripcion), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7cTTBUS20_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", 0, edtavCttbus20_descripcion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_motivoenvio_Internalname, 1, 1, 0, "Motivo de envío", "", "", "", 0, lblTextblockttbus20_motivoenvio_Jsonclick, "", StyleString, ClassString, "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus20_motivoenvio_Internalname, StringUtil.RTrim( AV8cTTBUS20_MotivoEnvio), "", 80, "chr", 1, "row", 100, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cTTBUS20_MotivoEnvio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCttbus20_motivoenvio_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_estacion_Internalname, 1, 1, 0, "Estación de trabajo", "", "", "", 0, lblTextblockttbus20_estacion_Jsonclick, "", StyleString, ClassString, "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus20_estacion_Internalname, StringUtil.RTrim( AV9cTTBUS20_Estacion), "", 20, "chr", 1, "row", 20, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9cTTBUS20_Estacion, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtavCttbus20_estacion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_usuario_Internalname, 1, 1, 0, "Usuario", "", "", "", 0, lblTextblockttbus20_usuario_Jsonclick, "", StyleString, ClassString, "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus20_usuario_Internalname, StringUtil.RTrim( AV10cTTBUS20_Usuario), "", 16, "chr", 1, "row", 16, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10cTTBUS20_Usuario, "XXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavCttbus20_usuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_plazorecepcion_Internalname, 1, 1, 0, "Plazo límite recepción de un bien", "", "", "", 0, lblTextblockttbus20_plazorecepcion_Jsonclick, "", StyleString, ClassString, "HLP_Gx00D0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCttbus20_plazorecepcion_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus20_plazorecepcion_Internalname, context.localUtil.Format(AV11cTTBUS20_PlazoRecepcion, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV11cTTBUS20_PlazoRecepcion, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(39);\"", 0, edtavCttbus20_plazorecepcion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00D0.htm");
            GxWebStd.gx_bitmap( context, edtavCttbus20_plazorecepcion_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00D0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2Y2e( true) ;
         }
         else
         {
            wb_table2_9_2Y2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pTTBUS20_IdBien = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTTBUS20_IdBien), 8, 0)));
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
         PA2Y2( ) ;
         WS2Y2( ) ;
         WE2Y2( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11465979");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00d0.js", "?11465979");
         /* End function include_jscripts */
      }

      protected void sendrow_462( )
      {
         WB2Y0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_46_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_46_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
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
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TTBUS20_IdBien), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS20_IdBien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TTBUS20_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A223TTBUS20_IdBien), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS20_IdBien_Jsonclick,(String)"",(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTTBUS20_Descripcion_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TTBUS20_IdBien), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_Descripcion_Internalname, "Link", edtTTBUS20_Descripcion_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS20_Descripcion_Internalname,StringUtil.RTrim( A224TTBUS20_Descripcion),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtTTBUS20_Descripcion_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A224TTBUS20_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS20_Descripcion_Jsonclick,(String)"",(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS20_Estacion_Internalname,StringUtil.RTrim( A219TTBUS20_Estacion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A219TTBUS20_Estacion, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS20_Estacion_Jsonclick,(String)"",(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS20_Usuario_Internalname,StringUtil.RTrim( A225TTBUS20_Usuario),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A225TTBUS20_Usuario, "XXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS20_Usuario_Jsonclick,(String)"",(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtTTBUS20_IdBien_Internalname = "TTBUS20_IDBIEN_"+sGXsfl_46_idx ;
            edtTTBUS20_Descripcion_Internalname = "TTBUS20_DESCRIPCION_"+sGXsfl_46_idx ;
            edtTTBUS20_Estacion_Internalname = "TTBUS20_ESTACION_"+sGXsfl_46_idx ;
            edtTTBUS20_Usuario_Internalname = "TTBUS20_USUARIO_"+sGXsfl_46_idx ;
         }
         /* End function sendrow_462 */
      }

      protected void init_default_properties( )
      {
         lblTextblockttbus20_idbien_Internalname = "TEXTBLOCKTTBUS20_IDBIEN" ;
         edtavCttbus20_idbien_Internalname = "vCTTBUS20_IDBIEN" ;
         lblTextblockttbus20_descripcion_Internalname = "TEXTBLOCKTTBUS20_DESCRIPCION" ;
         edtavCttbus20_descripcion_Internalname = "vCTTBUS20_DESCRIPCION" ;
         lblTextblockttbus20_motivoenvio_Internalname = "TEXTBLOCKTTBUS20_MOTIVOENVIO" ;
         edtavCttbus20_motivoenvio_Internalname = "vCTTBUS20_MOTIVOENVIO" ;
         lblTextblockttbus20_estacion_Internalname = "TEXTBLOCKTTBUS20_ESTACION" ;
         edtavCttbus20_estacion_Internalname = "vCTTBUS20_ESTACION" ;
         lblTextblockttbus20_usuario_Internalname = "TEXTBLOCKTTBUS20_USUARIO" ;
         edtavCttbus20_usuario_Internalname = "vCTTBUS20_USUARIO" ;
         lblTextblockttbus20_plazorecepcion_Internalname = "TEXTBLOCKTTBUS20_PLAZORECEPCION" ;
         edtavCttbus20_plazorecepcion_Internalname = "vCTTBUS20_PLAZORECEPCION" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS20_Usuario_Jsonclick = "" ;
         edtTTBUS20_Estacion_Jsonclick = "" ;
         edtTTBUS20_Descripcion_Jsonclick = "" ;
         edtTTBUS20_IdBien_Jsonclick = "" ;
         edtavCttbus20_plazorecepcion_Jsonclick = "" ;
         edtavCttbus20_usuario_Jsonclick = "" ;
         edtavCttbus20_estacion_Jsonclick = "" ;
         edtavCttbus20_motivoenvio_Jsonclick = "" ;
         edtavCttbus20_descripcion_Jsonclick = "" ;
         edtavCttbus20_idbien_Jsonclick = "" ;
         edtTTBUS20_Descripcion_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Mensajes de Administrador de Cambio de Posiciones" ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV7cTTBUS20_Descripcion = "" ;
         AV8cTTBUS20_MotivoEnvio = "" ;
         AV9cTTBUS20_Estacion = "" ;
         AV10cTTBUS20_Usuario = "" ;
         AV11cTTBUS20_PlazoRecepcion = DateTime.MinValue ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtTTBUS20_IdBien_Internalname = "" ;
         edtTTBUS20_Descripcion_Internalname = "" ;
         edtTTBUS20_Estacion_Internalname = "" ;
         edtTTBUS20_Usuario_Internalname = "" ;
         AV5LinkSelection = "" ;
         A224TTBUS20_Descripcion = "" ;
         A219TTBUS20_Estacion = "" ;
         A225TTBUS20_Usuario = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7cTTBUS20_Descripcion = "" ;
         lV8cTTBUS20_MotivoEnvio = "" ;
         lV9cTTBUS20_Estacion = "" ;
         lV10cTTBUS20_Usuario = "" ;
         H002Y2_A220TTBUS20_MotivoEnvio = new String[] {""} ;
         H002Y2_A222TTBUS20_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         H002Y2_n222TTBUS20_PlazoRecepcion = new bool[] {false} ;
         H002Y2_A225TTBUS20_Usuario = new String[] {""} ;
         H002Y2_A219TTBUS20_Estacion = new String[] {""} ;
         H002Y2_A224TTBUS20_Descripcion = new String[] {""} ;
         H002Y2_A223TTBUS20_IdBien = new int[1] ;
         A220TTBUS20_MotivoEnvio = "" ;
         A222TTBUS20_PlazoRecepcion = DateTime.MinValue ;
         H002Y3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockttbus20_idbien_Jsonclick = "" ;
         lblTextblockttbus20_descripcion_Jsonclick = "" ;
         lblTextblockttbus20_motivoenvio_Jsonclick = "" ;
         lblTextblockttbus20_estacion_Jsonclick = "" ;
         lblTextblockttbus20_usuario_Jsonclick = "" ;
         lblTextblockttbus20_plazorecepcion_Jsonclick = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00d0__default(),
            new Object[][] {
                new Object[] {
               H002Y2_A220TTBUS20_MotivoEnvio, H002Y2_A222TTBUS20_PlazoRecepcion, H002Y2_n222TTBUS20_PlazoRecepcion, H002Y2_A225TTBUS20_Usuario, H002Y2_A219TTBUS20_Estacion, H002Y2_A224TTBUS20_Descripcion, H002Y2_A223TTBUS20_IdBien
               }
               , new Object[] {
               H002Y3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_46_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize46 ;
      private int AV6cTTBUS20_IdBien ;
      private int AV12pTTBUS20_IdBien ;
      private int GRID1_nFirstRecordOnPage ;
      private int A223TTBUS20_IdBien ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_46_idx="0001" ;
      private String AV7cTTBUS20_Descripcion ;
      private String AV9cTTBUS20_Estacion ;
      private String AV10cTTBUS20_Usuario ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtTTBUS20_IdBien_Internalname ;
      private String edtTTBUS20_Descripcion_Internalname ;
      private String edtTTBUS20_Estacion_Internalname ;
      private String edtTTBUS20_Usuario_Internalname ;
      private String A224TTBUS20_Descripcion ;
      private String A219TTBUS20_Estacion ;
      private String A225TTBUS20_Usuario ;
      private String edtavCttbus20_idbien_Internalname ;
      private String scmdbuf ;
      private String lV7cTTBUS20_Descripcion ;
      private String lV9cTTBUS20_Estacion ;
      private String lV10cTTBUS20_Usuario ;
      private String edtavCttbus20_descripcion_Internalname ;
      private String edtavCttbus20_motivoenvio_Internalname ;
      private String edtavCttbus20_estacion_Internalname ;
      private String edtavCttbus20_usuario_Internalname ;
      private String edtavCttbus20_plazorecepcion_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String edtavLinkselection_Link ;
      private String edtTTBUS20_Descripcion_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus20_idbien_Internalname ;
      private String lblTextblockttbus20_idbien_Jsonclick ;
      private String edtavCttbus20_idbien_Jsonclick ;
      private String lblTextblockttbus20_descripcion_Internalname ;
      private String lblTextblockttbus20_descripcion_Jsonclick ;
      private String edtavCttbus20_descripcion_Jsonclick ;
      private String lblTextblockttbus20_motivoenvio_Internalname ;
      private String lblTextblockttbus20_motivoenvio_Jsonclick ;
      private String edtavCttbus20_motivoenvio_Jsonclick ;
      private String lblTextblockttbus20_estacion_Internalname ;
      private String lblTextblockttbus20_estacion_Jsonclick ;
      private String edtavCttbus20_estacion_Jsonclick ;
      private String lblTextblockttbus20_usuario_Internalname ;
      private String lblTextblockttbus20_usuario_Jsonclick ;
      private String edtavCttbus20_usuario_Jsonclick ;
      private String lblTextblockttbus20_plazorecepcion_Internalname ;
      private String lblTextblockttbus20_plazorecepcion_Jsonclick ;
      private String GXt_char5 ;
      private String edtavCttbus20_plazorecepcion_Jsonclick ;
      private String GXt_char4 ;
      private String ROClassString ;
      private String edtTTBUS20_IdBien_Jsonclick ;
      private String edtTTBUS20_Descripcion_Jsonclick ;
      private String edtTTBUS20_Estacion_Jsonclick ;
      private String edtTTBUS20_Usuario_Jsonclick ;
      private String GXt_char6 ;
      private DateTime AV11cTTBUS20_PlazoRecepcion ;
      private DateTime A222TTBUS20_PlazoRecepcion ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n222TTBUS20_PlazoRecepcion ;
      private bool returnInSub ;
      private String AV8cTTBUS20_MotivoEnvio ;
      private String lV8cTTBUS20_MotivoEnvio ;
      private String A220TTBUS20_MotivoEnvio ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002Y2_A220TTBUS20_MotivoEnvio ;
      private DateTime[] H002Y2_A222TTBUS20_PlazoRecepcion ;
      private bool[] H002Y2_n222TTBUS20_PlazoRecepcion ;
      private String[] H002Y2_A225TTBUS20_Usuario ;
      private String[] H002Y2_A219TTBUS20_Estacion ;
      private String[] H002Y2_A224TTBUS20_Descripcion ;
      private int[] H002Y2_A223TTBUS20_IdBien ;
      private int[] H002Y3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pTTBUS20_IdBien ;
      private GXWebForm Form ;
   }

   public class gx00d0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002Y2 ;
          prmH002Y2 = new Object[] {
          new Object[] {"@AV6cTTBUS20_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV7cTTBUS20_Descripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@AV8cTTBUS20_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV9cTTBUS20_Estacion",SqlDbType.Char,20,0} ,
          new Object[] {"@AV10cTTBUS20_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@AV11cTTBUS20_PlazoRecepcion",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmH002Y3 ;
          prmH002Y3 = new Object[] {
          new Object[] {"@AV6cTTBUS20_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV7cTTBUS20_Descripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@AV8cTTBUS20_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV9cTTBUS20_Estacion",SqlDbType.Char,20,0} ,
          new Object[] {"@AV10cTTBUS20_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@AV11cTTBUS20_PlazoRecepcion",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002Y2", "SELECT [TTBUS20_MotivoEnvio], [TTBUS20_PlazoRecepcion], [TTBUS20_Usuario], [TTBUS20_Estacion], [TTBUS20_Descripcion], [TTBUS20_IdBien] FROM [TTBUS020] WITH (NOLOCK) WHERE ([TTBUS20_IdBien] >= @AV6cTTBUS20_IdBien) AND ([TTBUS20_Descripcion] like @AV7cTTBUS20_Descripcion) AND ([TTBUS20_MotivoEnvio] like @AV8cTTBUS20_MotivoEnvio) AND ([TTBUS20_Estacion] like @AV9cTTBUS20_Estacion) AND ([TTBUS20_Usuario] like @AV10cTTBUS20_Usuario) AND ([TTBUS20_PlazoRecepcion] >= @AV11cTTBUS20_PlazoRecepcion) ORDER BY [TTBUS20_IdBien]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y2,11,0,false,false )
             ,new CursorDef("H002Y3", "SELECT COUNT(*) FROM [TTBUS020] WITH (NOLOCK) WHERE ([TTBUS20_IdBien] >= @AV6cTTBUS20_IdBien) AND ([TTBUS20_Descripcion] like @AV7cTTBUS20_Descripcion) AND ([TTBUS20_MotivoEnvio] like @AV8cTTBUS20_MotivoEnvio) AND ([TTBUS20_Estacion] like @AV9cTTBUS20_Estacion) AND ([TTBUS20_Usuario] like @AV10cTTBUS20_Usuario) AND ([TTBUS20_PlazoRecepcion] >= @AV11cTTBUS20_PlazoRecepcion) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y3,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 16) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[5])[0] = rslt.getString(5, 50) ;
                ((int[]) buf[6])[0] = rslt.getInt(6) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                break;
       }
    }

 }

}
