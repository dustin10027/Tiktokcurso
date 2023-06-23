using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Tiktokcurso.Modelo;

namespace Tiktokcurso.Datos
{
    public class Dvideos
    {
        public ObservableCollection<Mvideos> Mostrarvideos()
        {
            return new ObservableCollection<Mvideos>()
            {
                new Mvideos()
                {
                    video="https://firebasestorage.googleapis.com/v0/b/tiktok-2ebf7.appspot.com/o/v1.mp4?alt=media&token=728faa76-2ee8-4000-8965-0c834bf31023"
                },
                new Mvideos()
                {
                    video="https://firebasestorage.googleapis.com/v0/b/tiktok-2ebf7.appspot.com/o/v2.mp4?alt=media&token=64d65d03-751f-49ab-be9c-1b8616f002d9"
                },
                new Mvideos()
                {
                    video="https://firebasestorage.googleapis.com/v0/b/tiktok-2ebf7.appspot.com/o/v3.mp4?alt=media&token=b72f8c6e-976b-4934-833e-1686e8719c08"
                }
            };
        }
    }
}
