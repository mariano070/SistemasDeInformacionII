/*
               File: HTBUS001_I
        Description: Visualizador de Identificadores de un Bien de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:15.99
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
   public class htbus001_i : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus001_i( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus001_i( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_SISTEMA ,
                           ref String aP2_USUARIO )
      {
         this.AV5TTBUS_Id = aP0_TTBUS_Id;
         this.AV6SISTEMA = aP1_SISTEMA;
         this.AV7USUARIO = aP2_USUARIO;
         executePrivate();
         aP0_TTBUS_Id=this.AV5TTBUS_Id;
         aP1_SISTEMA=this.AV6SISTEMA;
         aP2_USUARIO=this.AV7USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynIdIdentificador = new GXCombobox();
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
               nGXsfl_8_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_8_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_8_idx, sGXsfl_8_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               GXCCtl = "IDIDENTIFICADOR_" + sGXsfl_8_idx ;
               dynIdIdentificador.Name = GXCCtl ;
               dynIdIdentificador.WebTags = "" ;
               dynIdIdentificador.removeAllItems();
               /* Using cursor H001T2 */
               pr_default.execute(0);
               while ( (pr_default.getStatus(0) != 101) )
               {
                  dynIdIdentificador.addItem(StringUtil.Str( (decimal)(H001T2_A20TTBUS5_IdIdentificador[0]), 8, 0), H001T2_A21TTBUS5_DescIdentificador[0], 0);
                  pr_default.readNext(0);
               }
               pr_default.close(0);
               if ( ( dynIdIdentificador.ItemCount > 0 ) && (0==A14IdIdentificador) )
               {
                  A14IdIdentificador = (int)(NumberUtil.Val( dynIdIdentificador.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               }
               Grid1_PageSize8 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV5TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5TTBUS_Id), 8, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize8, AV5TTBUS_Id) ;
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
               AV5TTBUS_Id = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5TTBUS_Id), 8, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6SISTEMA", AV6SISTEMA);
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA1T2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1T2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus001_i.aspx") + "?" + UrlEncode("" +AV5TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(AV6SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV6SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV7USUARIO));
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
            WE1T2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1T2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS001_I" ;
      }

      public override String GetPgmdesc( )
      {
         return "Visualizador de Identificadores de un Bien de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus001_i.aspx") + "?" + UrlEncode("" +AV5TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(AV6SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV7USUARIO)) ;
      }

      protected void WB1T0( )
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
            wb_table1_2_1T2( true) ;
         }
         else
         {
            wb_table1_2_1T2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1T2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1T2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Visualizador de Identificadores de un Bien de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1T0( ) ;
      }

      protected void WS1T2( )
      {
         START1T2( ) ;
         EVT1T2( ) ;
      }

      protected void EVT1T2( )
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
                              nGXsfl_8_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
                              edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
                              dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
                              edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              dynIdIdentificador.Name = dynIdIdentificador_Internalname ;
                              dynIdIdentificador.CurrentValue = cgiGet( dynIdIdentificador_Internalname) ;
                              A14IdIdentificador = (int)(NumberUtil.Val( cgiGet( dynIdIdentificador_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
                              A15NumeroIdentificador = cgiGet( edtNumeroIdentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111T2 */
                                    E111T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121T2 */
                                    E121T2 ();
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

      protected void WE1T2( )
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

      protected void PA1T2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "IDIDENTIFICADOR_" + sGXsfl_8_idx ;
            dynIdIdentificador.Name = GXCCtl ;
            dynIdIdentificador.WebTags = "" ;
            dynIdIdentificador.removeAllItems();
            /* Using cursor H001T3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               dynIdIdentificador.addItem(StringUtil.Str( (decimal)(H001T3_A20TTBUS5_IdIdentificador[0]), 8, 0), H001T3_A21TTBUS5_DescIdentificador[0], 0);
               pr_default.readNext(1);
            }
            pr_default.close(1);
            if ( ( dynIdIdentificador.ItemCount > 0 ) && (0==A14IdIdentificador) )
            {
               A14IdIdentificador = (int)(NumberUtil.Val( dynIdIdentificador.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_8_idx ,
                                       String sGXsfl_8_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
         dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         while ( nGXsfl_8_idx <= nRC_Grid1 )
         {
            sendrow_82( ) ;
            nGXsfl_8_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1)) ;
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
            dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize8 ,
                                        int AV5TTBUS_Id )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize8) ;
         RF1T2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1T2( ) ;
         /* End function Refresh */
      }

      protected void RF1T2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 8 ;
         nGXsfl_8_idx = 1 ;
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
         dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
            dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            /* Using cursor H001T4 */
            pr_default.execute(2, new Object[] {AV5TTBUS_Id});
            nGXsfl_8_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A15NumeroIdentificador = H001T4_A15NumeroIdentificador[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
               A14IdIdentificador = H001T4_A14IdIdentificador[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               A11TTBUS_Id = H001T4_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               /* Execute user event: E121T2 */
               E121T2 ();
               pr_default.readNext(2);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0)) ;
            pr_default.close(2);
            wbEnd = 8 ;
            WB1T0( ) ;
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
         /* Using cursor H001T5 */
         pr_default.execute(3, new Object[] {AV5TTBUS_Id});
         GRID1_nRecordCount = H001T5_AGRID1_nRecordCount[0] ;
         pr_default.close(3);
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

      protected void STRUP1T0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111T2 */
         E111T2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV5TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vTTBUS_ID"), ",", ".")) ;
            AV6SISTEMA = cgiGet( "vSISTEMA") ;
            AV7USUARIO = cgiGet( "vUSUARIO") ;
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
         /* Execute user event: E111T2 */
         E111T2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111T2( )
      {
         /* Start Routine */
         /* Using cursor H001T6 */
         pr_default.execute(4, new Object[] {AV5TTBUS_Id});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A11TTBUS_Id = H001T6_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A12TTBUS_Descripcion = H001T6_A12TTBUS_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            lblTbx_titulo_Caption = "IDENTIFICADORES DEL BIEN \""+StringUtil.Trim( A12TTBUS_Descripcion)+"\"." ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTbx_titulo_Internalname, "Caption", lblTbx_titulo_Caption);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
      }

      private void E121T2( )
      {
         /* Load Routine */
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_82( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_2_1T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(36), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(463), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTbx_titulo_Internalname, 1, 1, 0, lblTbx_titulo_Caption, "", "", "", 0, lblTbx_titulo_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001_I.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id del bien de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Tipo de Identificador") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A15NumeroIdentificador));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 8 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_8_idx-1) ;
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
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1T2e( true) ;
         }
         else
         {
            wb_table1_2_1T2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5TTBUS_Id = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5TTBUS_Id), 8, 0)));
         AV6SISTEMA = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6SISTEMA", AV6SISTEMA);
         AV7USUARIO = (String)getParm(obj,2) ;
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
         PA1T2( ) ;
         WS1T2( ) ;
         WE1T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13221621");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus001_i.js", "?13221621");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_82( )
      {
         WB1T0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_8_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_8_idx) % (2)) == 0 )
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_Id_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)false,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_8_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "IDIDENTIFICADOR_" + sGXsfl_8_idx ;
               dynIdIdentificador.Name = GXCCtl ;
               dynIdIdentificador.WebTags = "" ;
               dynIdIdentificador.removeAllItems();
               /* Using cursor H001T7 */
               pr_default.execute(5);
               while ( (pr_default.getStatus(5) != 101) )
               {
                  dynIdIdentificador.addItem(StringUtil.Str( (decimal)(H001T7_A20TTBUS5_IdIdentificador[0]), 8, 0), H001T7_A21TTBUS5_DescIdentificador[0], 0);
                  pr_default.readNext(5);
               }
               pr_default.close(5);
               if ( ( dynIdIdentificador.ItemCount > 0 ) && (0==A14IdIdentificador) )
               {
                  A14IdIdentificador = (int)(NumberUtil.Val( dynIdIdentificador.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynIdIdentificador,(String)dynIdIdentificador_Internalname,StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)dynIdIdentificador_Jsonclick,(String)"",(String)"",(bool)false});
            dynIdIdentificador.CurrentValue = StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynIdIdentificador_Internalname, "Values", (String)(dynIdIdentificador.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNumeroIdentificador_Internalname,StringUtil.RTrim( A15NumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")),(String)"",(short)0,(String)edtNumeroIdentificador_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)false,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_8_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1)) ;
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
            dynIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         }
         /* End function sendrow_82 */
      }

      protected void init_default_properties( )
      {
         lblTbx_titulo_Internalname = "TBX_TITULO" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtNumeroIdentificador_Jsonclick = "" ;
         dynIdIdentificador_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         lblTbx_titulo_Caption = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Visualizador de Identificadores de un Bien de Uso" ;
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
         wcpOAV6SISTEMA = "" ;
         wcpOAV7USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXCCtl = "" ;
         scmdbuf = "" ;
         H001T2_A20TTBUS5_IdIdentificador = new int[1] ;
         H001T2_A21TTBUS5_DescIdentificador = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtTTBUS_Id_Internalname = "" ;
         dynIdIdentificador_Internalname = "" ;
         edtNumeroIdentificador_Internalname = "" ;
         A15NumeroIdentificador = "" ;
         H001T3_A20TTBUS5_IdIdentificador = new int[1] ;
         H001T3_A21TTBUS5_DescIdentificador = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         H001T4_A15NumeroIdentificador = new String[] {""} ;
         H001T4_A14IdIdentificador = new int[1] ;
         H001T4_A11TTBUS_Id = new int[1] ;
         H001T5_AGRID1_nRecordCount = new int[1] ;
         H001T6_A11TTBUS_Id = new int[1] ;
         H001T6_A12TTBUS_Descripcion = new String[] {""} ;
         A12TTBUS_Descripcion = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTbx_titulo_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char3 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         H001T7_A20TTBUS5_IdIdentificador = new int[1] ;
         H001T7_A21TTBUS5_DescIdentificador = new String[] {""} ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus001_i__default(),
            new Object[][] {
                new Object[] {
               H001T2_A20TTBUS5_IdIdentificador, H001T2_A21TTBUS5_DescIdentificador
               }
               , new Object[] {
               H001T3_A20TTBUS5_IdIdentificador, H001T3_A21TTBUS5_DescIdentificador
               }
               , new Object[] {
               H001T4_A15NumeroIdentificador, H001T4_A14IdIdentificador, H001T4_A11TTBUS_Id
               }
               , new Object[] {
               H001T5_AGRID1_nRecordCount
               }
               , new Object[] {
               H001T6_A11TTBUS_Id, H001T6_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001T7_A20TTBUS5_IdIdentificador, H001T7_A21TTBUS5_DescIdentificador
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_8_idx=1 ;
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
      private int AV5TTBUS_Id ;
      private int wcpOAV5TTBUS_Id ;
      private int Grid1_PageSize8 ;
      private int A14IdIdentificador ;
      private int GRID1_nFirstRecordOnPage ;
      private int A11TTBUS_Id ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String AV6SISTEMA ;
      private String AV7USUARIO ;
      private String wcpOAV6SISTEMA ;
      private String wcpOAV7USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_8_idx="0001" ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtTTBUS_Id_Internalname ;
      private String dynIdIdentificador_Internalname ;
      private String edtNumeroIdentificador_Internalname ;
      private String lblTbx_titulo_Caption ;
      private String lblTbx_titulo_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTbx_titulo_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String ROClassString ;
      private String edtTTBUS_Id_Jsonclick ;
      private String dynIdIdentificador_Jsonclick ;
      private String edtNumeroIdentificador_Jsonclick ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String A15NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_SISTEMA ;
      private String aP2_USUARIO ;
      private GXCombobox dynIdIdentificador ;
      private IDataStoreProvider pr_default ;
      private int[] H001T2_A20TTBUS5_IdIdentificador ;
      private String[] H001T2_A21TTBUS5_DescIdentificador ;
      private int[] H001T3_A20TTBUS5_IdIdentificador ;
      private String[] H001T3_A21TTBUS5_DescIdentificador ;
      private String[] H001T4_A15NumeroIdentificador ;
      private int[] H001T4_A14IdIdentificador ;
      private int[] H001T4_A11TTBUS_Id ;
      private int[] H001T5_AGRID1_nRecordCount ;
      private int[] H001T6_A11TTBUS_Id ;
      private String[] H001T6_A12TTBUS_Descripcion ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int[] H001T7_A20TTBUS5_IdIdentificador ;
      private String[] H001T7_A21TTBUS5_DescIdentificador ;
      private GXWebForm Form ;
   }

   public class htbus001_i__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001T2 ;
          prmH001T2 = new Object[] {
          } ;
          Object[] prmH001T3 ;
          prmH001T3 = new Object[] {
          } ;
          Object[] prmH001T4 ;
          prmH001T4 = new Object[] {
          new Object[] {"@AV5TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001T5 ;
          prmH001T5 = new Object[] {
          new Object[] {"@AV5TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001T6 ;
          prmH001T6 = new Object[] {
          new Object[] {"@AV5TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001T7 ;
          prmH001T7 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H001T2", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001T2,0,0,true,false )
             ,new CursorDef("H001T3", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001T3,0,0,true,false )
             ,new CursorDef("H001T4", "SELECT [NumeroIdentificador], [IdIdentificador], [TTBUS_Id] FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV5TTBUS_Id ORDER BY [TTBUS_Id], [IdIdentificador]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001T4,11,0,true,false )
             ,new CursorDef("H001T5", "SELECT COUNT(*) FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV5TTBUS_Id ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001T5,1,0,true,false )
             ,new CursorDef("H001T6", "SELECT TOP 1 [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV5TTBUS_Id ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001T6,1,0,false,true )
             ,new CursorDef("H001T7", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001T7,0,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
