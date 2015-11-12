/*
               File: HTBUS007_p
        Description: Administración de Permisos
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:41.24
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
   public class htbus007_p : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus007_p( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus007_p( IGxContext context )
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
         this.AV7SISTEMA = aP0_SISTEMA;
         this.AV8USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV7SISTEMA;
         aP1_USUARIO=this.AV8USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkTTBUS7_RespAux = new GXCheckbox();
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
               GXCCtl = "TTBUS7_RESPAUX_" + sGXsfl_23_idx ;
               chkTTBUS7_RespAux.Name = GXCCtl ;
               chkTTBUS7_RespAux.WebTags = "" ;
               chkTTBUS7_RespAux.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Caption", chkTTBUS7_RespAux.Caption);
               chkTTBUS7_RespAux.CheckedValue = "0" ;
               Grid1_PageSize23 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV10fTTBUS7_DesUsuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10fTTBUS7_DesUsuario", AV10fTTBUS7_DesUsuario);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize23, AV10fTTBUS7_DesUsuario) ;
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
               AV7SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
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
         PA1K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1K2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus007_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vFTTBUS7_DESUSUARIO", StringUtil.RTrim( AV10fTTBUS7_DesUsuario));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
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
            WE1K2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1K2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS007_p" ;
      }

      public override String GetPgmdesc( )
      {
         return "Administración de Permisos" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus007_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void WB1K0( )
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
            wb_table1_2_1K2( true) ;
         }
         else
         {
            wb_table1_2_1K2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1K2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1K2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Administración de Permisos", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1K0( ) ;
      }

      protected void WS1K2( )
      {
         START1K2( ) ;
         EVT1K2( ) ;
      }

      protected void EVT1K2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DESUSUARIO"), AV10fTTBUS7_DesUsuario) != 0 )
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
                              /* Execute user event: E111K2 */
                              E111K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121K2 */
                              E121K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ATRAS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131K2 */
                              E131K2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'ATRAS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BUSCAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'EDICION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) )
                           {
                              nGXsfl_23_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
                              edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
                              edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
                              edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_23_idx ;
                              edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_23_idx ;
                              edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_23_idx ;
                              edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_23_idx ;
                              chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_23_idx ;
                              AV5baja = cgiGet( "GXimg"+edtavBaja_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
                              AV6edicion = cgiGet( "GXimg"+edtavEdicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV6edicion));
                              AV9visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV9visualizacion));
                              A33TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                              A39TTBUS7_CodUsuario = StringUtil.Upper( cgiGet( edtTTBUS7_CodUsuario_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                              A199TTBUS7_DesUsuario = StringUtil.Upper( cgiGet( edtTTBUS7_DesUsuario_Internalname)) ;
                              n199TTBUS7_DesUsuario = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
                              A34TTBUS7_Des = cgiGet( edtTTBUS7_Des_Internalname) ;
                              n34TTBUS7_Des = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                              A51TTBUS7_RespAux = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS7_RespAux_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141K2 */
                                    E141K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E151K2 */
                                    E151K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121K2 */
                                    E121K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E161K2 */
                                    E161K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'EDICION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E171K2 */
                                    E171K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E181K2 */
                                    E181K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ATRAS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131K2 */
                                    E131K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111K2 */
                                    E111K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Fttbus7_desusuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS7_DESUSUARIO"), AV10fTTBUS7_DesUsuario) != 0 )
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

      protected void WE1K2( )
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

      protected void PA1K2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "TTBUS7_RESPAUX_" + sGXsfl_23_idx ;
            chkTTBUS7_RespAux.Name = GXCCtl ;
            chkTTBUS7_RespAux.WebTags = "" ;
            chkTTBUS7_RespAux.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Caption", chkTTBUS7_RespAux.Caption);
            chkTTBUS7_RespAux.CheckedValue = "0" ;
            GX_FocusControl = edtavFttbus7_desusuario_Internalname ;
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
         edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_23_idx ;
         edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_23_idx ;
         edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_23_idx ;
         edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_23_idx ;
         chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_23_idx ;
         while ( nGXsfl_23_idx <= nRC_Grid1 )
         {
            sendrow_232( ) ;
            nGXsfl_23_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_23_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_23_idx+1)) ;
            sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
            edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_23_idx ;
            edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_23_idx ;
            chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_23_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize23 ,
                                        String AV10fTTBUS7_DesUsuario )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize23) ;
         RF1K2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1K2( ) ;
         /* End function Refresh */
      }

      protected void RF1K2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 23 ;
         nGXsfl_23_idx = 1 ;
         sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
         edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_23_idx ;
         edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_23_idx ;
         edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_23_idx ;
         edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_23_idx ;
         chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_23_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
            edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_23_idx ;
            edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_23_idx ;
            chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_23_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV10fTTBUS7_DesUsuario ,
                                                 A199TTBUS7_DesUsuario ,
                                                 AV11TTBUS7_DesUsuario ,
                                                 A33TTBUS7_Pos },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT
                                                 }
            });
            lV11TTBUS7_DesUsuario = StringUtil.PadR( StringUtil.RTrim( AV11TTBUS7_DesUsuario), 50, "%") ;
            /* Using cursor H001K2 */
            pr_default.execute(0, new Object[] {lV11TTBUS7_DesUsuario});
            nGXsfl_23_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A51TTBUS7_RespAux = H001K2_A51TTBUS7_RespAux[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
               A34TTBUS7_Des = H001K2_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001K2_n34TTBUS7_Des[0] ;
               A199TTBUS7_DesUsuario = H001K2_A199TTBUS7_DesUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
               n199TTBUS7_DesUsuario = H001K2_n199TTBUS7_DesUsuario[0] ;
               A39TTBUS7_CodUsuario = H001K2_A39TTBUS7_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               A33TTBUS7_Pos = H001K2_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A199TTBUS7_DesUsuario = H001K2_A199TTBUS7_DesUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
               n199TTBUS7_DesUsuario = H001K2_n199TTBUS7_DesUsuario[0] ;
               A34TTBUS7_Des = H001K2_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001K2_n34TTBUS7_Des[0] ;
               /* Execute user event: E151K2 */
               E151K2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 23 ;
            WB1K0( ) ;
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
                                              AV10fTTBUS7_DesUsuario ,
                                              A199TTBUS7_DesUsuario ,
                                              AV11TTBUS7_DesUsuario ,
                                              A33TTBUS7_Pos },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT
                                              }
         });
         lV11TTBUS7_DesUsuario = StringUtil.PadR( StringUtil.RTrim( AV11TTBUS7_DesUsuario), 50, "%") ;
         /* Using cursor H001K3 */
         pr_default.execute(1, new Object[] {lV11TTBUS7_DesUsuario});
         GRID1_nRecordCount = H001K3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP1K0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E141K2 */
         E141K2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV10fTTBUS7_DesUsuario = StringUtil.Upper( cgiGet( edtavFttbus7_desusuario_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10fTTBUS7_DesUsuario", AV10fTTBUS7_DesUsuario);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV7SISTEMA = cgiGet( "vSISTEMA") ;
            AV8USUARIO = cgiGet( "vUSUARIO") ;
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
         /* Execute user event: E141K2 */
         E141K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E141K2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV12Context) ;
         AV8USUARIO = AV12Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
         new pseg102(context ).execute( ref  AV8USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
      }

      private void E151K2( )
      {
         /* Grid1_Load Routine */
         AV5baja = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
         AV9visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV9visualizacion));
         AV6edicion = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV6edicion));
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

      protected void E121K2( )
      {
         /* 'Alta' Routine */
         context.wjLoc = formatLink("ttbus007_p.aspx") + "?" + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void E161K2( )
      {
         /* 'Baja' Routine */
         context.wjLoc = formatLink("ttbus007_p.aspx") + "?" + UrlEncode("" +A33TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(A39TTBUS7_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void E171K2( )
      {
         /* 'Edicion' Routine */
         context.wjLoc = formatLink("ttbus007_p.aspx") + "?" + UrlEncode("" +A33TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(A39TTBUS7_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void E181K2( )
      {
         /* 'Visualizacion' Routine */
         context.wjLoc = formatLink("ttbus007_p.aspx") + "?" + UrlEncode("" +A33TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(A39TTBUS7_CodUsuario)) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void E111K2( )
      {
         /* 'Buscar' Routine */
         AV11TTBUS7_DesUsuario = "%" + StringUtil.Trim( AV10fTTBUS7_DesUsuario) + "%" ;
      }

      protected void E131K2( )
      {
         /* 'Atras' Routine */
         context.wjLoc = formatLink("htbus000_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void wb_table1_2_1K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(104), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(800), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:36px\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            wb_table2_8_1K2( true) ;
         }
         else
         {
            wb_table2_8_1K2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_1K2e( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Alta", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgImage1_Jsonclick, "E\\'ALTA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS007_p.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id. de Posición") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cód. Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Apellido y Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Resp. Aux") ;
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
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV9visualizacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A39TTBUS7_CodUsuario));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A199TTBUS7_DesUsuario));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A34TTBUS7_Des));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A51TTBUS7_RespAux), 1, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Atrás", "Atrás", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "E\\'ATRAS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(23), 3, 0)+","+"null"+");", "", "HLP_HTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1K2e( true) ;
         }
         else
         {
            wb_table1_2_1K2e( false) ;
         }
      }

      protected void wb_table2_8_1K2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Apellido y Nombre:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_23_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus7_desusuario_Internalname, StringUtil.RTrim( AV10fTTBUS7_DesUsuario), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10fTTBUS7_DesUsuario, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtavFttbus7_desusuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'BUSCAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(23), 3, 0)+","+"null"+");", "", "HLP_HTBUS007_p.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_1K2e( true) ;
         }
         else
         {
            wb_table2_8_1K2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
         AV8USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
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
         PA1K2( ) ;
         WS1K2( ) ;
         WE1K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13224158");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus007_p.js", "?13224158");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_232( )
      {
         WB1K0( ) ;
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
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV9visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Visualización",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACION\\'."+sGXsfl_23_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_Pos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A33TTBUS7_Pos), "ZZ9"),(String)"",(short)0,(String)edtTTBUS7_Pos_Jsonclick,(String)"",(short)23,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_CodUsuario_Internalname,StringUtil.RTrim( A39TTBUS7_CodUsuario),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A39TTBUS7_CodUsuario, "@!")),(String)"",(short)0,(String)edtTTBUS7_CodUsuario_Jsonclick,(String)"",(short)23,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_DesUsuario_Internalname,StringUtil.RTrim( A199TTBUS7_DesUsuario),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A199TTBUS7_DesUsuario, "@!")),(String)"",(short)0,(String)edtTTBUS7_DesUsuario_Jsonclick,(String)"",(short)23,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_Des_Internalname,StringUtil.RTrim( A34TTBUS7_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A34TTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS7_Des_Jsonclick,(String)"",(short)23,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkTTBUS7_RespAux_Internalname,StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0),(String)"",(short)-1,(short)0,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)""});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_23_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_23_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_23_idx+1)) ;
            sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_23_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_23_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_23_idx ;
            edtTTBUS7_Pos_Internalname = "TTBUS7_POS_"+sGXsfl_23_idx ;
            edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_23_idx ;
            edtTTBUS7_Des_Internalname = "TTBUS7_DES_"+sGXsfl_23_idx ;
            chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_23_idx ;
         }
         /* End function sendrow_232 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavFttbus7_desusuario_Internalname = "vFTTBUS7_DESUSUARIO" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable2_Internalname = "TABLE2" ;
         imgImage1_Internalname = "IMAGE1" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS7_Des_Jsonclick = "" ;
         edtTTBUS7_DesUsuario_Jsonclick = "" ;
         edtTTBUS7_CodUsuario_Jsonclick = "" ;
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
         edtavFttbus7_desusuario_Jsonclick = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Administración de Permisos" ;
         chkTTBUS7_RespAux.Caption = "" ;
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
         wcpOAV7SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXCCtl = "" ;
         chkTTBUS7_RespAux_Internalname = "" ;
         AV10fTTBUS7_DesUsuario = "" ;
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
         edtTTBUS7_CodUsuario_Internalname = "" ;
         edtTTBUS7_DesUsuario_Internalname = "" ;
         edtTTBUS7_Des_Internalname = "" ;
         AV5baja = "" ;
         AV6edicion = "" ;
         AV9visualizacion = "" ;
         A39TTBUS7_CodUsuario = "" ;
         A199TTBUS7_DesUsuario = "" ;
         A34TTBUS7_Des = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         AV11TTBUS7_DesUsuario = "" ;
         lV11TTBUS7_DesUsuario = "" ;
         H001K2_A51TTBUS7_RespAux = new short[1] ;
         H001K2_A34TTBUS7_Des = new String[] {""} ;
         H001K2_n34TTBUS7_Des = new bool[] {false} ;
         H001K2_A199TTBUS7_DesUsuario = new String[] {""} ;
         H001K2_n199TTBUS7_DesUsuario = new bool[] {false} ;
         H001K2_A39TTBUS7_CodUsuario = new String[] {""} ;
         H001K2_A33TTBUS7_Pos = new short[1] ;
         H001K3_AGRID1_nRecordCount = new int[1] ;
         AV12Context = new SdtContext(context);
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
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         Grid1Column = new GXWebColumn();
         bttButton2_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus007_p__default(),
            new Object[][] {
                new Object[] {
               H001K2_A51TTBUS7_RespAux, H001K2_A34TTBUS7_Des, H001K2_n34TTBUS7_Des, H001K2_A199TTBUS7_DesUsuario, H001K2_n199TTBUS7_DesUsuario, H001K2_A39TTBUS7_CodUsuario, H001K2_A33TTBUS7_Pos
               }
               , new Object[] {
               H001K3_AGRID1_nRecordCount
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
      private short A33TTBUS7_Pos ;
      private short A51TTBUS7_RespAux ;
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
      private String AV7SISTEMA ;
      private String AV8USUARIO ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_23_idx="0001" ;
      private String GXCCtl ;
      private String chkTTBUS7_RespAux_Internalname ;
      private String AV10fTTBUS7_DesUsuario ;
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
      private String edtTTBUS7_CodUsuario_Internalname ;
      private String edtTTBUS7_DesUsuario_Internalname ;
      private String edtTTBUS7_Des_Internalname ;
      private String A39TTBUS7_CodUsuario ;
      private String A199TTBUS7_DesUsuario ;
      private String A34TTBUS7_Des ;
      private String edtavFttbus7_desusuario_Internalname ;
      private String scmdbuf ;
      private String AV11TTBUS7_DesUsuario ;
      private String lV11TTBUS7_DesUsuario ;
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
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavFttbus7_desusuario_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavBaja_Jsonclick ;
      private String edtavEdicion_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtTTBUS7_Pos_Jsonclick ;
      private String edtTTBUS7_CodUsuario_Jsonclick ;
      private String edtTTBUS7_DesUsuario_Jsonclick ;
      private String edtTTBUS7_Des_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n199TTBUS7_DesUsuario ;
      private bool n34TTBUS7_Des ;
      private bool returnInSub ;
      private String AV5baja ;
      private String AV6edicion ;
      private String AV9visualizacion ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private GXCheckbox chkTTBUS7_RespAux ;
      private IDataStoreProvider pr_default ;
      private short[] H001K2_A51TTBUS7_RespAux ;
      private String[] H001K2_A34TTBUS7_Des ;
      private bool[] H001K2_n34TTBUS7_Des ;
      private String[] H001K2_A199TTBUS7_DesUsuario ;
      private bool[] H001K2_n199TTBUS7_DesUsuario ;
      private String[] H001K2_A39TTBUS7_CodUsuario ;
      private short[] H001K2_A33TTBUS7_Pos ;
      private int[] H001K3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtContext AV12Context ;
   }

   public class htbus007_p__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001K2( String AV10fTTBUS7_DesUsuario ,
                                             String A199TTBUS7_DesUsuario ,
                                             String AV11TTBUS7_DesUsuario ,
                                             short A33TTBUS7_Pos )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int10 ;
         GXv_int10 = new short [1] ;
         Object[] GXv_Object11 ;
         GXv_Object11 = new Object [2] ;
         scmdbuf = "SELECT T1.[TTBUS7_RespAux], T3.[W53DES] AS TTBUS7_Des, T2.[USU_DES] AS TTBUS7_DesUsuario, T1.[TTBUS7_CodUsuario] AS TTBUS7_CodUsuario, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM (([TTBUS007Permisos] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodUsuario]) INNER JOIN [T53FPOS] T3 WITH (NOLOCK) ON T3.[W53POS] = T1.[TTBUS7_Pos])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS7_Pos] <> 998)" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS7_Pos] <> 999)" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV10fTTBUS7_DesUsuario), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T2.[USU_DES]) like UPPER(@AV11TTBUS7_DesUsuario))" ;
         }
         else
         {
            GXv_int10[0] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS7_CodUsuario]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object11[0] = scmdbuf ;
         GXv_Object11[1] = (Object)(GXv_int10) ;
         return GXv_Object11 ;
      }

      protected Object[] conditional_H001K3( String AV10fTTBUS7_DesUsuario ,
                                             String A199TTBUS7_DesUsuario ,
                                             String AV11TTBUS7_DesUsuario ,
                                             short A33TTBUS7_Pos )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int12 ;
         GXv_int12 = new short [1] ;
         Object[] GXv_Object13 ;
         GXv_Object13 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([TTBUS007Permisos] T1 WITH (NOLOCK) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T1.[TTBUS7_CodUsuario]) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS7_Pos] <> 998)" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS7_Pos] <> 999)" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV10fTTBUS7_DesUsuario), "") != 0 )
         {
            sWhereString = sWhereString + " and (UPPER(T3.[USU_DES]) like UPPER(@AV11TTBUS7_DesUsuario))" ;
         }
         else
         {
            GXv_int12[0] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + "" ;
         GXv_Object13[0] = scmdbuf ;
         GXv_Object13[1] = (Object)(GXv_int12) ;
         return GXv_Object13 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H001K2( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] );
               case 1 :
                     return conditional_H001K3( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] );
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
          Object[] prmH001K2 ;
          prmH001K2 = new Object[] {
          new Object[] {"@AV11TTBUS7_DesUsuario",SqlDbType.Char,50,0}
          } ;
          Object[] prmH001K3 ;
          prmH001K3 = new Object[] {
          new Object[] {"@AV11TTBUS7_DesUsuario",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001K2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K2,11,0,true,false )
             ,new CursorDef("H001K3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K3,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 16) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
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
