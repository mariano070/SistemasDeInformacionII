/*
               File: HSEG000_P
        Description: MUESTRA CODIGOS DISPONIBLES
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:25.61
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
   public class hseg000_p : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg000_p( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg000_p( IGxContext context )
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
         this.AV10SISTEMA = aP0_SISTEMA;
         this.AV9USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV10SISTEMA;
         aP1_USUARIO=this.AV9USUARIO;
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
               nGXsfl_5_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_5_idx = GetNextPar( ) ;
               edtavSeleccionar_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeleccionar_Internalname, "Tooltiptext", edtavSeleccionar_Tooltiptext);
               AV8Seleccionar = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeleccionar_Internalname, "Bitmap", context.convertURL( AV8Seleccionar));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_5_idx, sGXsfl_5_idx, AV8Seleccionar) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavDis_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDis_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDis_Enabled), 5, 0)));
               Grid1_PageSize5 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               edtavSeleccionar_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeleccionar_Internalname, "Tooltiptext", edtavSeleccionar_Tooltiptext);
               AV8Seleccionar = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeleccionar_Internalname, "Bitmap", context.convertURL( AV8Seleccionar));
               AV6DISPONIBLE = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize5, AV8Seleccionar, AV6DISPONIBLE, A116SIS_COD) ;
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
                  AV9USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUARIO", AV9USUARIO);
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
         PA372( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START372( ) ;
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg000_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV10SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV9USUARIO));
         GxWebStd.gx_hidden_field( context, "vDISPONIBLE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6DISPONIBLE), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")));
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
            WE372( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT372( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG000_P" ;
      }

      public override String GetPgmdesc( )
      {
         return "MUESTRA CODIGOS DISPONIBLES" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg000_p.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO)) ;
      }

      protected void WB370( )
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
            wb_table1_2_372( true) ;
         }
         else
         {
            wb_table1_2_372( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_372e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START372( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "MUESTRA CODIGOS DISPONIBLES", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP370( ) ;
      }

      protected void WS372( )
      {
         START372( ) ;
         EVT372( ) ;
      }

      protected void EVT372( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'ANTERIOR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11372 */
                              E11372 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PROXIMA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12372 */
                              E12372 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'SELECCIONAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'PRIMERA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'PROXIMA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'ANTERIOR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'ULTIMA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'SELECCIONAR'") == 0 ) )
                           {
                              nGXsfl_5_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
                              edtavDis_Internalname = "vDIS_"+sGXsfl_5_idx ;
                              edtavSeleccionar_Internalname = "vSELECCIONAR_"+sGXsfl_5_idx ;
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavDis_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavDis_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavDis_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vDIS");
                                 GX_FocusControl = edtavDis_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV5DIS = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5DIS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5DIS), 3, 0)));
                              }
                              else
                              {
                                 AV5DIS = (short)(context.localUtil.CToN( cgiGet( edtavDis_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5DIS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5DIS), 3, 0)));
                              }
                              AV8Seleccionar = cgiGet( "GXimg"+edtavSeleccionar_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeleccionar_Internalname, "Bitmap", context.convertURL( AV8Seleccionar));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13372 */
                                    E13372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14372 */
                                    E14372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'SELECCIONAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15372 */
                                    E15372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'PRIMERA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E16372 */
                                    E16372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'PROXIMA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12372 */
                                    E12372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ANTERIOR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11372 */
                                    E11372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ULTIMA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E17372 */
                                    E17372 ();
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

      protected void WE372( )
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

      protected void PA372( )
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
                                       short nGXsfl_5_idx ,
                                       String sGXsfl_5_idx ,
                                       String AV8Seleccionar )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavDis_Internalname = "vDIS_"+sGXsfl_5_idx ;
         edtavSeleccionar_Internalname = "vSELECCIONAR_"+sGXsfl_5_idx ;
         while ( nGXsfl_5_idx <= nRC_Grid1 )
         {
            sendrow_52( ) ;
            nGXsfl_5_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_5_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_5_idx+1)) ;
            sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
            edtavDis_Internalname = "vDIS_"+sGXsfl_5_idx ;
            edtavSeleccionar_Internalname = "vSELECCIONAR_"+sGXsfl_5_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize5 ,
                                        String AV8Seleccionar ,
                                        short AV6DISPONIBLE ,
                                        short A116SIS_COD )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize5) ;
         RF372( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF372( ) ;
         /* End function Refresh */
      }

      protected void RF372( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 5 ;
         nGXsfl_5_idx = 1 ;
         sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
         edtavDis_Internalname = "vDIS_"+sGXsfl_5_idx ;
         edtavSeleccionar_Internalname = "vSELECCIONAR_"+sGXsfl_5_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavDis_Internalname = "vDIS_"+sGXsfl_5_idx ;
            edtavSeleccionar_Internalname = "vSELECCIONAR_"+sGXsfl_5_idx ;
            /* Execute user event: E13372 */
            E13372 ();
            wbEnd = 5 ;
            WB370( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 6 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(6*1) ;
            }
            else
            {
               return (int)(6) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         if ( GRID1_nEOF == 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
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
         subGrid1_Islastpage = 1 ;
         return 3 ;
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

      protected void STRUP370( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavDis_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDis_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDis_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E14372 */
         E14372 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV10SISTEMA = cgiGet( "vSISTEMA") ;
            AV9USUARIO = cgiGet( "vUSUARIO") ;
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

      private void E13372( )
      {
         /* Load Routine */
         AV7BANDERA = 0 ;
         /* Using cursor H00372 */
         pr_default.execute(0, new Object[] {AV7BANDERA});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A116SIS_COD = H00372_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            AV6DISPONIBLE = (short)(AV6DISPONIBLE+1) ;
            if ( A116SIS_COD == AV6DISPONIBLE )
            {
               AV7BANDERA = 0 ;
            }
            else
            {
               while ( A116SIS_COD != AV6DISPONIBLE )
               {
                  AV5DIS = AV6DISPONIBLE ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5DIS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5DIS), 3, 0)));
                  if ( ( subGrid1_Islastpage == 1 ) || ( 6 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
                  {
                     sendrow_52( ) ;
                     GRID1_nEOF = 1 ;
                     if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
                     {
                        GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
                     }
                  }
                  if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
                  {
                     GRID1_nEOF = 0 ;
                  }
                  GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
                  AV6DISPONIBLE = (short)(AV6DISPONIBLE+1) ;
               }
               AV7BANDERA = 1 ;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXStart( )
      {
         /* Execute user event: E14372 */
         E14372 ();
         if (returnInSub) return;
      }

      protected void E14372( )
      {
         /* Start Routine */
         AV8Seleccionar = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeleccionar_Internalname, "Bitmap", context.convertURL( AV8Seleccionar));
         edtavSeleccionar_Tooltiptext = "GXM_Select" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeleccionar_Internalname, "Tooltiptext", edtavSeleccionar_Tooltiptext);
      }

      protected void E15372( )
      {
         /* 'Seleccionar' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +AV5DIS) ;
         context.wjLoc = formatLink("tseg000.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E16372( )
      {
         /* 'primera' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E12372( )
      {
         /* 'proxima' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E11372( )
      {
         /* 'anterior' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E17372( )
      {
         /* 'ultima' Routine */
         subgrid1_lastpage( ) ;
      }

      protected void wb_table1_2_372( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Numeros Disponibles") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Seleccionar") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5DIS), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDis_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV8Seleccionar));
               Grid1Column.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSeleccionar_Tooltiptext));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 5 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_5_idx-1) ;
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
            wb_table2_8_372( true) ;
         }
         else
         {
            wb_table2_8_372( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_372e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttButton1_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(5), 3, 0)+","+"null"+");", "", "HLP_HSEG000_P.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_372e( true) ;
         }
         else
         {
            wb_table1_2_372e( false) ;
         }
      }

      protected void wb_table2_8_372( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(26), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(54), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"width:22px\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage2_Internalname, "", context.GetImagePath( "cdf36de9-aae4-40c2-928b-5dd2f7589dc9", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgImage2_Jsonclick, "E\\'ANTERIOR\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HSEG000_P.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage3_Internalname, "", context.GetImagePath( "ffebe689-f176-4a2f-914b-2ea1a59db803", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgImage3_Jsonclick, "E\\'PROXIMA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HSEG000_P.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_372e( true) ;
         }
         else
         {
            wb_table2_8_372e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISTEMA", AV10SISTEMA);
         AV9USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUARIO", AV9USUARIO);
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
         PA372( ) ;
         WS372( ) ;
         WE372( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11182589");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg000_p.js", "?11182589");
         /* End function include_jscripts */
      }

      protected void sendrow_52( )
      {
         WB370( ) ;
         if ( ( 6 * 1 == 0 ) || ( nGXsfl_5_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_5_idx) % (2)) == 0 )
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
            TempTags = " " + ((edtavDis_Enabled!=0)&&(edtavDis_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 6,'',false,'"+sGXsfl_5_idx+"',5)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDis_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5DIS), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(int)edtavDis_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV5DIS), "ZZ9"),TempTags+((edtavDis_Enabled!=0)&&(edtavDis_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavDis_Enabled!=0)&&(edtavDis_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(6);\"" : " "),(short)0,(String)edtavDis_Jsonclick,(String)"",(short)5,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSeleccionar_Enabled!=0)&&(edtavSeleccionar_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 7,'',false,'',5)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavSeleccionar_Internalname,(String)"",(String)AV8Seleccionar,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavSeleccionar_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavSeleccionar_Jsonclick,"E\\'SELECCIONAR\\'."+sGXsfl_5_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_5_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_5_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_5_idx+1)) ;
            sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
            edtavDis_Internalname = "vDIS_"+sGXsfl_5_idx ;
            edtavSeleccionar_Internalname = "vSELECCIONAR_"+sGXsfl_5_idx ;
         }
         /* End function sendrow_52 */
      }

      protected void init_default_properties( )
      {
         imgImage2_Internalname = "IMAGE2" ;
         imgImage3_Internalname = "IMAGE3" ;
         tblTable5_Internalname = "TABLE5" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavSeleccionar_Jsonclick = "" ;
         edtavSeleccionar_Visible = -1 ;
         edtavSeleccionar_Enabled = 1 ;
         edtavDis_Jsonclick = "" ;
         edtavDis_Visible = -1 ;
         edtavDis_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "MUESTRA CODIGOS DISPONIBLES" ;
         edtavSeleccionar_Tooltiptext = "" ;
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
         wcpOAV9USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         edtavSeleccionar_Internalname = "" ;
         AV8Seleccionar = "" ;
         edtavDis_Internalname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H00372_A116SIS_COD = new short[1] ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         sStyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttButton1_Jsonclick = "" ;
         imgImage2_Jsonclick = "" ;
         imgImage3_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg000_p__default(),
            new Object[][] {
                new Object[] {
               H00372_A116SIS_COD
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavDis_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_5_idx=1 ;
      private short AV6DISPONIBLE ;
      private short A116SIS_COD ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short AV5DIS ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV7BANDERA ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize5 ;
      private int edtavDis_Enabled ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavDis_Visible ;
      private int edtavSeleccionar_Enabled ;
      private int edtavSeleccionar_Visible ;
      private String AV10SISTEMA ;
      private String AV9USUARIO ;
      private String wcpOAV10SISTEMA ;
      private String wcpOAV9USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_5_idx="0001" ;
      private String edtavSeleccionar_Tooltiptext ;
      private String edtavSeleccionar_Internalname ;
      private String edtavDis_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char1 ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable5_Internalname ;
      private String imgImage2_Internalname ;
      private String imgImage2_Jsonclick ;
      private String imgImage3_Internalname ;
      private String imgImage3_Jsonclick ;
      private String ROClassString ;
      private String edtavDis_Jsonclick ;
      private String edtavSeleccionar_Jsonclick ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV8Seleccionar ;
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
      private short[] H00372_A116SIS_COD ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hseg000_p__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00372 ;
          prmH00372 = new Object[] {
          new Object[] {"@AV7BANDERA",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00372", "SELECT [SIS_COD] FROM [SEG000] WITH (NOLOCK) WHERE ([SIS_COD] <> 0) AND (@AV7BANDERA = 0) ORDER BY [SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00372,100,1,false,false )
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
       }
    }

 }

}
