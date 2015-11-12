/*
               File: HTBUS008
        Description: Actualización de Administradores de Trazabilidad de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:41.87
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
   public class htbus008 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus008( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus008( IGxContext context )
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
         this.AV10SISTEMA = aP0_SISTEMA;
         this.AV11USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV10SISTEMA;
         aP1_USUARIO=this.AV11USUARIO;
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
               nGXsfl_23_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_23_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_23_idx, sGXsfl_23_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize23 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV9fTTBUS8_DesUsuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9fTTBUS8_DesUsuario", AV9fTTBUS8_DesUsuario);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize23, AV9fTTBUS8_DesUsuario) ;
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
               AV10SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISTEMA", AV10SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
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
         PA1J2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1J2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vFTTBUS8_DESUSUARIO", StringUtil.RTrim( AV9fTTBUS8_DesUsuario));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV10SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV11USUARIO));
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
            WE1J2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1J2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS008" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actualización de Administradores de Trazabilidad de Bienes de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO)) ;
      }

      protected void WB1J0( )
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
            wb_table1_2_1J2( true) ;
         }
         else
         {
            wb_table1_2_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1J2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Actualización de Administradores de Trazabilidad de Bienes de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1J0( ) ;
      }

      protected void WS1J2( )
      {
         START1J2( ) ;
         EVT1J2( ) ;
      }

      protected void EVT1J2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS8_DESUSUARIO"), AV9fTTBUS8_DesUsuario) != 0 )
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
                           else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111J2 */
                              E111J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121J2 */
                              E121J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ATRáS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131J2 */
                              E131J2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'ATRáS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BUSCAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) )
                           {
                              nGXsfl_23_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
                              edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
                              edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
                              edtTTBUS8_CodUsuario_Internalname = "TTBUS8_CODUSUARIO_"+sGXsfl_23_idx ;
                              edtTTBUS8_DesUsuario_Internalname = "TTBUS8_DESUSUARIO_"+sGXsfl_23_idx ;
                              AV5baja = cgiGet( "GXimg"+edtavBaja_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
                              AV6edicion = cgiGet( "GXimg"+edtavEdicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV6edicion));
                              AV7visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV7visualizacion));
                              A40TTBUS8_CodUsuario = StringUtil.Upper( cgiGet( edtTTBUS8_CodUsuario_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
                              A200TTBUS8_DesUsuario = StringUtil.Upper( cgiGet( edtTTBUS8_DesUsuario_Internalname)) ;
                              n200TTBUS8_DesUsuario = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141J2 */
                                    E141J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E151J2 */
                                    E151J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121J2 */
                                    E121J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E161J2 */
                                    E161J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'EDICION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E171J2 */
                                    E171J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E181J2 */
                                    E181J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ATRáS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131J2 */
                                    E131J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111J2 */
                                    E111J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Fttbus8_desusuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS8_DESUSUARIO"), AV9fTTBUS8_DesUsuario) != 0 )
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

      protected void WE1J2( )
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

      protected void PA1J2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavFttbus8_desusuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_23_idx ,
                                       String sGXsfl_23_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
         edtTTBUS8_CodUsuario_Internalname = "TTBUS8_CODUSUARIO_"+sGXsfl_23_idx ;
         edtTTBUS8_DesUsuario_Internalname = "TTBUS8_DESUSUARIO_"+sGXsfl_23_idx ;
         while ( nGXsfl_23_idx <= nRC_Grid1 )
         {
            sendrow_232( ) ;
            nGXsfl_23_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_23_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_23_idx+1)) ;
            sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
            edtTTBUS8_CodUsuario_Internalname = "TTBUS8_CODUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS8_DesUsuario_Internalname = "TTBUS8_DESUSUARIO_"+sGXsfl_23_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize23 ,
                                        String AV9fTTBUS8_DesUsuario )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize23) ;
         RF1J2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1J2( ) ;
         /* End function Refresh */
      }

      protected void RF1J2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 23 ;
         nGXsfl_23_idx = 1 ;
         sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
         edtTTBUS8_CodUsuario_Internalname = "TTBUS8_CODUSUARIO_"+sGXsfl_23_idx ;
         edtTTBUS8_DesUsuario_Internalname = "TTBUS8_DESUSUARIO_"+sGXsfl_23_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
            edtTTBUS8_CodUsuario_Internalname = "TTBUS8_CODUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS8_DesUsuario_Internalname = "TTBUS8_DESUSUARIO_"+sGXsfl_23_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV9fTTBUS8_DesUsuario ,
                                                 A200TTBUS8_DesUsuario ,
                                                 AV12TTBUS8_DesUsuario },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                                 }
            });
            /* Using cursor H001J2 */
            pr_default.execute(0, new Object[] {AV12TTBUS8_DesUsuario});
            nGXsfl_23_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A200TTBUS8_DesUsuario = H001J2_A200TTBUS8_DesUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
               n200TTBUS8_DesUsuario = H001J2_n200TTBUS8_DesUsuario[0] ;
               A40TTBUS8_CodUsuario = H001J2_A40TTBUS8_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               A200TTBUS8_DesUsuario = H001J2_A200TTBUS8_DesUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200TTBUS8_DesUsuario", A200TTBUS8_DesUsuario);
               n200TTBUS8_DesUsuario = H001J2_n200TTBUS8_DesUsuario[0] ;
               /* Execute user event: E151J2 */
               E151J2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 23 ;
            WB1J0( ) ;
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
                                              AV9fTTBUS8_DesUsuario ,
                                              A200TTBUS8_DesUsuario ,
                                              AV12TTBUS8_DesUsuario },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         });
         /* Using cursor H001J3 */
         pr_default.execute(1, new Object[] {AV12TTBUS8_DesUsuario});
         GRID1_nRecordCount = H001J3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP1J0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E141J2 */
         E141J2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV9fTTBUS8_DesUsuario = StringUtil.Upper( cgiGet( edtavFttbus8_desusuario_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9fTTBUS8_DesUsuario", AV9fTTBUS8_DesUsuario);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV10SISTEMA = cgiGet( "vSISTEMA") ;
            AV11USUARIO = cgiGet( "vUSUARIO") ;
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
         /* Execute user event: E141J2 */
         E141J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E141J2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV13Context) ;
         AV11USUARIO = AV13Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
         new pseg102(context ).execute( ref  AV11USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
      }

      private void E151J2( )
      {
         /* Grid1_Load Routine */
         AV5baja = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
         AV6edicion = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV6edicion));
         AV7visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV7visualizacion));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 23 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_232( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E121J2( )
      {
         /* 'Alta' Routine */
         context.wjLoc = formatLink("ttbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO)) ;
      }

      protected void E161J2( )
      {
         /* 'Baja' Routine */
         context.wjLoc = formatLink("ttbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim(A40TTBUS8_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO)) ;
      }

      protected void E171J2( )
      {
         /* 'Edicion' Routine */
         context.wjLoc = formatLink("ttbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim(A40TTBUS8_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO)) ;
      }

      protected void E181J2( )
      {
         /* 'Visualizacion' Routine */
         context.wjLoc = formatLink("ttbus008.aspx") + "?" + UrlEncode(StringUtil.RTrim(A40TTBUS8_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO)) ;
      }

      protected void E111J2( )
      {
         /* 'Buscar' Routine */
         AV12TTBUS8_DesUsuario = "%" + StringUtil.Trim( AV9fTTBUS8_DesUsuario) + "%" ;
      }

      protected void E131J2( )
      {
         /* 'Atrás' Routine */
         context.wjLoc = formatLink("htbus000_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV11USUARIO)) ;
      }

      protected void wb_table1_2_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(104), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(639), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
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
            wb_table2_8_1J2( true) ;
         }
         else
         {
            wb_table2_8_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Alta", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgImage1_Jsonclick, "E\\'ALTA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS008.htm");
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cód. Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Desc. Usuario") ;
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
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV7visualizacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A40TTBUS8_CodUsuario));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A200TTBUS8_DesUsuario));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 23 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_23_idx-1) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Atrás", "Atrás", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "E\\'ATRáS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(23), 3, 0)+","+"null"+");", "", "HLP_HTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1J2e( true) ;
         }
         else
         {
            wb_table1_2_1J2e( false) ;
         }
      }

      protected void wb_table2_8_1J2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Apellido:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_23_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus8_desusuario_Internalname, StringUtil.RTrim( AV9fTTBUS8_DesUsuario), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9fTTBUS8_DesUsuario, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtavFttbus8_desusuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'BUSCAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(23), 3, 0)+","+"null"+");", "", "HLP_HTBUS008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_1J2e( true) ;
         }
         else
         {
            wb_table2_8_1J2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISTEMA", AV10SISTEMA);
         AV11USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
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
         PA1J2( ) ;
         WS1J2( ) ;
         WE1J2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13224215");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus008.js", "?13224215");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_232( )
      {
         WB1J0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_23_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_23_idx) % (2)) == 0 )
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
            TempTags = " " + ((edtavBaja_Enabled!=0)&&(edtavBaja_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 24,'',false,'',23)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavBaja_Internalname,(String)"",(String)AV5baja,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Baja",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavBaja_Jsonclick,"E\\'BAJA\\'."+sGXsfl_23_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavEdicion_Enabled!=0)&&(edtavEdicion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 25,'',false,'',23)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavEdicion_Internalname,(String)"",(String)AV6edicion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Edición",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavEdicion_Jsonclick,"E\\'EDICION\\'."+sGXsfl_23_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavVisualizacion_Enabled!=0)&&(edtavVisualizacion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'',false,'',23)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV7visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Visualización",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACION\\'."+sGXsfl_23_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS8_CodUsuario_Internalname,StringUtil.RTrim( A40TTBUS8_CodUsuario),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A40TTBUS8_CodUsuario, "@!")),(String)"",(short)0,(String)edtTTBUS8_CodUsuario_Jsonclick,(String)"",(short)23,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS8_DesUsuario_Internalname,StringUtil.RTrim( A200TTBUS8_DesUsuario),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A200TTBUS8_DesUsuario, "@!")),(String)"",(short)0,(String)edtTTBUS8_DesUsuario_Jsonclick,(String)"",(short)23,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_23_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_23_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_23_idx+1)) ;
            sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
            edtTTBUS8_CodUsuario_Internalname = "TTBUS8_CODUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS8_DesUsuario_Internalname = "TTBUS8_DESUSUARIO_"+sGXsfl_23_idx ;
         }
         /* End function sendrow_232 */
      }

      protected void init_default_properties( )
      {
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavFttbus8_desusuario_Internalname = "vFTTBUS8_DESUSUARIO" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable2_Internalname = "TABLE2" ;
         imgImage1_Internalname = "IMAGE1" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable3_Internalname = "TABLE3" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS8_DesUsuario_Jsonclick = "" ;
         edtTTBUS8_CodUsuario_Jsonclick = "" ;
         edtavVisualizacion_Jsonclick = "" ;
         edtavVisualizacion_Visible = -1 ;
         edtavVisualizacion_Enabled = 1 ;
         edtavEdicion_Jsonclick = "" ;
         edtavEdicion_Visible = -1 ;
         edtavEdicion_Enabled = 1 ;
         edtavBaja_Jsonclick = "" ;
         edtavBaja_Visible = -1 ;
         edtavBaja_Enabled = 1 ;
         edtavFttbus8_desusuario_Jsonclick = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Actualización de Administradores de Trazabilidad de Bienes de Uso" ;
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
         wcpOAV10SISTEMA = "" ;
         wcpOAV11USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV9fTTBUS8_DesUsuario = "" ;
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
         edtTTBUS8_CodUsuario_Internalname = "" ;
         edtTTBUS8_DesUsuario_Internalname = "" ;
         AV5baja = "" ;
         AV6edicion = "" ;
         AV7visualizacion = "" ;
         A40TTBUS8_CodUsuario = "" ;
         A200TTBUS8_DesUsuario = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         AV12TTBUS8_DesUsuario = "" ;
         H001J2_A200TTBUS8_DesUsuario = new String[] {""} ;
         H001J2_n200TTBUS8_DesUsuario = new bool[] {false} ;
         H001J2_A40TTBUS8_CodUsuario = new String[] {""} ;
         H001J3_AGRID1_nRecordCount = new int[1] ;
         AV13Context = new SdtContext(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         imgImage1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         bttButton2_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char5 = "" ;
         ROClassString = "" ;
         GXt_char6 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus008__default(),
            new Object[][] {
                new Object[] {
               H001J2_A200TTBUS8_DesUsuario, H001J2_n200TTBUS8_DesUsuario, H001J2_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H001J3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_23_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize23 ;
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
      private String AV10SISTEMA ;
      private String AV11USUARIO ;
      private String wcpOAV10SISTEMA ;
      private String wcpOAV11USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_23_idx="0001" ;
      private String AV9fTTBUS8_DesUsuario ;
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
      private String edtTTBUS8_CodUsuario_Internalname ;
      private String edtTTBUS8_DesUsuario_Internalname ;
      private String A40TTBUS8_CodUsuario ;
      private String A200TTBUS8_DesUsuario ;
      private String edtavFttbus8_desusuario_Internalname ;
      private String scmdbuf ;
      private String AV12TTBUS8_DesUsuario ;
      private String sStyleString ;
      private String tblTable3_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String TempTags ;
      private String imgImage1_Internalname ;
      private String imgImage1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavFttbus8_desusuario_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavBaja_Jsonclick ;
      private String edtavEdicion_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String GXt_char5 ;
      private String ROClassString ;
      private String edtTTBUS8_CodUsuario_Jsonclick ;
      private String edtTTBUS8_DesUsuario_Jsonclick ;
      private String GXt_char6 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n200TTBUS8_DesUsuario ;
      private bool returnInSub ;
      private String AV5baja ;
      private String AV6edicion ;
      private String AV7visualizacion ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] H001J2_A200TTBUS8_DesUsuario ;
      private bool[] H001J2_n200TTBUS8_DesUsuario ;
      private String[] H001J2_A40TTBUS8_CodUsuario ;
      private int[] H001J3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtContext AV13Context ;
   }

   public class htbus008__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001J2( String AV9fTTBUS8_DesUsuario ,
                                             String A200TTBUS8_DesUsuario ,
                                             String AV12TTBUS8_DesUsuario )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int7 ;
         GXv_int7 = new short [1] ;
         Object[] GXv_Object8 ;
         GXv_Object8 = new Object [2] ;
         scmdbuf = "SELECT T2.[USU_DES] AS TTBUS8_DesUsuario, T1.[TTBUS8_CodUsuario] AS TTBUS8_CodUsuario FROM ([TTBUS008] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS8_CodUsuario])" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV9fTTBUS8_DesUsuario), "") != 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER(T2.[USU_DES]) = UPPER(@AV12TTBUS8_DesUsuario))" ;
            }
            else
            {
               sWhereString = sWhereString + " (UPPER(T2.[USU_DES]) = UPPER(@AV12TTBUS8_DesUsuario))" ;
            }
         }
         else
         {
            GXv_int7[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS8_CodUsuario]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object8[0] = scmdbuf ;
         GXv_Object8[1] = (Object)(GXv_int7) ;
         return GXv_Object8 ;
      }

      protected Object[] conditional_H001J3( String AV9fTTBUS8_DesUsuario ,
                                             String A200TTBUS8_DesUsuario ,
                                             String AV12TTBUS8_DesUsuario )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int9 ;
         GXv_int9 = new short [1] ;
         Object[] GXv_Object10 ;
         GXv_Object10 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([TTBUS008] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS8_CodUsuario])" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV9fTTBUS8_DesUsuario), "") != 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER(T2.[USU_DES]) = UPPER(@AV12TTBUS8_DesUsuario))" ;
            }
            else
            {
               sWhereString = sWhereString + " (UPPER(T2.[USU_DES]) = UPPER(@AV12TTBUS8_DesUsuario))" ;
            }
         }
         else
         {
            GXv_int9[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
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
                     return conditional_H001J2( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
               case 1 :
                     return conditional_H001J3( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
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
          Object[] prmH001J2 ;
          prmH001J2 = new Object[] {
          new Object[] {"@AV12TTBUS8_DesUsuario",SqlDbType.Char,50,0}
          } ;
          Object[] prmH001J3 ;
          prmH001J3 = new Object[] {
          new Object[] {"@AV12TTBUS8_DesUsuario",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001J2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001J2,11,0,true,false )
             ,new CursorDef("H001J3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001J3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (String)parms[1]);
                }
                break;
             case 1 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[1]);
                }
                break;
       }
    }

 }

}
